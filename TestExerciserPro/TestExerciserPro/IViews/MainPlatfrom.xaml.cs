﻿using System.Windows.Controls;
using System.Windows;
using TestExerciserPro.IViews.AutoTesting;
namespace TestExerciserPro.IViews
{
    /// <summary>
    /// Interaction logic for TilesExample.xaml
    /// </summary>
    public partial class MainPlatfrom : UserControl
    {
        public MainPlatfrom()
        {
            InitializeComponent();
        }

        private void AutoTesting_OnClick(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Hide();
            MainAutoTesting main = new MainAutoTesting();
            main.Show();
        }
    }
}
