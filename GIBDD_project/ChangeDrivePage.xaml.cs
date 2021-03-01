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
    /// Логика взаимодействия для ChangeDrivePage.xaml
    /// </summary>
    public partial class ChangeDrivePage : Page
    {
        public ChangeDrivePage()
        {
            InitializeComponent();
            //DGridChangeDrivers.ItemsSource = GIBDDEntities.GetContext().Drivers.ToList();
            DGridChangeDrivers.ItemsSource = GIBDDEntities.GetContext().Drivers.ToList();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            // Manager.MainFrame.Navigate(new AddDriverPage(null));
            //Manager.MainFrame.Navigate(new AddDriverPage((sender as Button).DataContext as Driver));
            Manager.MainFrame.Navigate(new AddDriverPage((sender as Button).DataContext as Driver));
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddDriverPage(null));
        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            var DriverForRemoving = DGridChangeDrivers.SelectedItems.Cast<Driver>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {DriverForRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    GIBDDEntities.GetContext().Drivers.RemoveRange(DriverForRemoving);
                    GIBDDEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    DGridChangeDrivers.ItemsSource = GIBDDEntities.GetContext().Drivers.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
