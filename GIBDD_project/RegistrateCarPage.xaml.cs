﻿using System;
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

        private void BtnSaveCar_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

           
            if( string.IsNullOrWhiteSpace(_currentCars.VIN))
                errors.AppendLine("Введите все 17 символов VIN");
            
            if (string.IsNullOrWhiteSpace(_currentCars.Manufacturer))
                errors.AppendLine("Введите Марку машины");

            if (string.IsNullOrWhiteSpace(_currentCars.Model))
                 errors.AppendLine("Введите модель машины");
            
             if ((_currentCars.year)<1900 || (_currentCars.year)>2021)
                errors.AppendLine("Введите год машины цифрами");

             if (string.IsNullOrWhiteSpace(_currentCars.Number_of_color))
               errors.AppendLine("Введите цвет машины");

             if ((_currentCars.Engine_type)<1900 || (_currentCars.Engine_type)>2021)
               errors.AppendLine("Введите тип двигателя машины");

            if (string.IsNullOrWhiteSpace(_currentCars.category_of_car))
                errors.AppendLine("Введите категорию машины");

            if ((_currentCars.Engine_number) < 0)
                errors.AppendLine("Введите номер двигателя");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
                if ((_currentCars.VIN).Length == 17)
                    {
                        GIBDDEntities.GetContext().Cars.Add(_currentCars);
                    }
                
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

        private void BtnPalitra_Click(object sender, RoutedEventArgs e)
        {
            // Manager.MainFrame.Navigate(new ColorPage());
            // Hide();
           // colorbox.Text = D.ColorData;
            ColorForm form = new ColorForm();
            form.ShowDialog();
           // Close();
        }

        private void colorbox_MouseMove(object sender, MouseEventArgs e)
        {
            colorbox.Text = D.ColorData;
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

        private void TextBox_PreviewTextInput_2(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void TextBox_PreviewTextInput_3(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        //удалить

        private void colorbox_Initialized(object sender, EventArgs e)
        {
            colorbox.Text = D.ColorData;
        }

        
    }
}
