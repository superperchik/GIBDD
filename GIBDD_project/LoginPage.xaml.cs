using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace GIBDD_project
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        //Объявлем таймер
        DispatcherTimer timer = new DispatcherTimer();

        
        public LoginPage()
        {
            InitializeComponent();
            //Тут объявлем обработчик событий для таймер и время (час, минута, секунда)
            timer.Tick += new EventHandler(timerTick);
            timer.Interval = new TimeSpan(0, 0, 10);

        }
        //Что-то на татарском
        enum Role { Failed, User1 }
         static Role GetRole(string login, string password)
         {
             Role role = Role.Failed;
             using (var connection = new SqlConnection("server=localhost\\SQLEXPRESS;Trusted_Connection=Yes;Database=GIBDD;"))
             {
                 connection.Open();
                 var command = new SqlCommand("Select [Password] From [User] WHERE Login=@Login AND Password=@Password", connection);
                 command.Parameters.AddWithValue("@Login", login);
                 command.Parameters.AddWithValue("@Password", password);
                 using (var dataReader = command.ExecuteReader())
                 {
                     if (dataReader.Read())
                     {
                         switch ((string)dataReader["password"])
                         {
                             case "test": role = Role.User1; break;
                         }
                     }
                 }
             }
             return role;
         }
       


        //число попыток входа
        int count_of_popitok = 3;

        //обработчик события таймера: по истечении времени возобновляем попытки входа
        private void timerTick(object sender, EventArgs e)
        {
           // if (count_of_popitok == 0)
           // {
                MessageBox.Show("Время истекло, можете попробовать войти еще раз");
                count_of_popitok = 3;
            timer.Stop();
            //}
            // else
            // {
            //    Manager.MainFrame.Navigate(new LoginPage());
            // }

        }

        //кнопка войти
        private void BtnEnter_Click(object sender, RoutedEventArgs e)
        {
            //сверяем логин и пароль из БД
            Role role = GetRole(LoginBox.Text, PassBox.Password);
            //Если неправильно
            if (role == Role.Failed)
            {
                //Уменьшаем кол-во попыток, выдаем сообщение о неверных данных и запускаем таймер, если попытки закончились
                count_of_popitok--;
                if (count_of_popitok<0)
                {
                    MessageBox.Show("Лимит попыток превышен, подождите 10 секунд и введите заново");
                    timer.Start();
                    
                }
                //Просто сообщение о неверных данных, если попытки еще остались
                else
                MessageBox.Show("Неверный логин или пароль");
            }
            //Авторизуемся, если всё верно и попытки в, выводим сообщение и переходим на страницу
            else
            {
                if (count_of_popitok < 0)
                {
                    MessageBox.Show("Данные верны, но лимит попыток превышен");
                    

                }
                if (count_of_popitok > 0)
                {
                    MessageBox.Show("Добро пожаловать");
                   // timer.Start();
                    Manager.MainFrame.Navigate(new MenuPage());
                }
            }
        }      
    }   
}






