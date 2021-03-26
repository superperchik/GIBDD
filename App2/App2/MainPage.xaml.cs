using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            image1.Source = ImageSource.FromResource("App2.gibddlogo.jpg");
        }

       

        private void Button_Clicked(object sender, EventArgs e)
        {
            if ((LoginBox.Text == "admin") & (PasBox.Text == "password"))
            {
                DisplayAlert("Уведомление", "Вы успешно вошли в систему", "ОК");
                this.Navigation.PushModalAsync(new Page1());
            }
            else
                DisplayAlert("Внимание", "Неудачная попытка входа. Проверьте правильность данных и повторите попытку", "OK");
        }
    }
}
