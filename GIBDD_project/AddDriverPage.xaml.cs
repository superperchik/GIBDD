using System;
using System.Collections.Generic;
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

namespace GIBDD_project
{
    /// <summary>
    /// Логика взаимодействия для AddDriverPage.xaml
    /// </summary>
    public partial class AddDriverPage : Page
    {

        private Driver _currentDrivers = new Driver();
        
        public AddDriverPage(Driver selectedDriver)
        {
            InitializeComponent();
            if (selectedDriver != null)
                _currentDrivers = selectedDriver;
            DataContext = _currentDrivers;
            
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentDrivers.middlename))
                errors.AppendLine("Введите Фамилию");

            if (string.IsNullOrWhiteSpace(_currentDrivers.name))
                errors.AppendLine("Введите Имя");

            if (string.IsNullOrWhiteSpace(_currentDrivers.middlename))
                errors.AppendLine("Введите Фамилию");

            if (string.IsNullOrWhiteSpace(_currentDrivers.fathersname))
                errors.AppendLine("Введите Отчество");

            if (string.IsNullOrWhiteSpace(_currentDrivers.passportnumber))
                errors.AppendLine("Введите Номер Паспорта");

            if (string.IsNullOrWhiteSpace(_currentDrivers.passportserial))
                errors.AppendLine("Введите Серию Паспорта");

            if (string.IsNullOrWhiteSpace(_currentDrivers.address))
                errors.AppendLine("Введите Адрес");

            if (string.IsNullOrWhiteSpace(_currentDrivers.email))
                errors.AppendLine("Введите Почту");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            
            if (_currentDrivers.id == 0)
                GIBDDEntities.GetContext().Drivers.Add(_currentDrivers);
            try
            {
               GIBDDEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                Manager.MainFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            

                if (sender is TextBox textBox)
            {

                textBox.Text = new string
                    (
                         textBox
                         .Text
                         .Where
                         (ch =>
                            (ch >= 'а' && ch <= 'я')
                            || (ch >= 'А' && ch <= 'Я')
                            || ch == 'ё' || ch == 'Ё'
                         )
                         .ToArray()
                    );
            }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if (sender is TextBox textBox)
            {

                textBox.Text = new string
                    (
                         textBox
                         .Text
                         .Where
                         (ch =>
                            (ch >= 'а' && ch <= 'я')
                            || (ch >= 'А' && ch <= 'Я')
                            || ch == 'ё' || ch == 'Ё'
                         )
                         .ToArray()
                    );
            }
        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {
            if (sender is TextBox textBox)
            {

                textBox.Text = new string
                    (
                         textBox
                         .Text
                         .Where
                         (ch =>
                            (ch >= 'а' && ch <= 'я')
                            || (ch >= 'А' && ch <= 'Я')
                            || ch == 'ё' || ch == 'Ё'
                         )
                         .ToArray()
                    );
            }
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void TextBox_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }
    }
}
