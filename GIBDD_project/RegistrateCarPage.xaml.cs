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
    /// Логика взаимодействия для RegistrateCarPage.xaml
    /// </summary>
    public partial class RegistrateCarPage : Page
    {
        private Car _currentCars = new Car();
        public RegistrateCarPage(Car selectedCar)
        {
            InitializeComponent();
            if (selectedCar != null)
                _currentCars = selectedCar;
            DataContext = _currentCars;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void BtnSaveCar_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentCars.VIN))
                errors.AppendLine("Введите VIN");

            // if (_currentCars.year)


            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentCars.VIN == null)
                GIBDDEntities.GetContext().Cars.Add(_currentCars);

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
    }
}
