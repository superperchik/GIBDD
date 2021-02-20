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
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        
        public MenuPage()
        {
            InitializeComponent();
        }

        

        private void AddDriverPage_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddDriverPage(null));
         
        }

        private void ChangeDrivePage_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new ChangeDrivePage());
        }

        private void RegistrateCar_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new RegistrateCarPage(null));
        }

        private void LookatLicense_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new LookatLicensePage());
        }
    }
}
