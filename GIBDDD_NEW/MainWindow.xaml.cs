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

namespace GIBDDD_NEW
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public MainWindow()
    {
        InitializeComponent();

        MainFrame.Navigate(new MainFrame());
        Manager.MainFrame = MainFrame;
    }

    private void MainFrame_ContentRendered(object sender, EventArgs e)
    {
        if (MainFrame.CanGoBack)
        {
            BtnBack.Visibility = Visibility.Visible;
        }
        else
        {
            BtnBack.Visibility = Visibility.Hidden;
        }
    }

    private void BtnBack_Click(object sender, RoutedEventArgs e)
    {
        MainFrame.GoBack();
    }


}
}
