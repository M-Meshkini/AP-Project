using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _FinalProj
{
    public partial class UserLogin : Window
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            WPF.MainWindow newWindow = new WPF.MainWindow();
            newWindow.Show();
            Close();
        }

        private void SignUp_Button_Click(object sender, RoutedEventArgs e)
        {
            Login_Tabs.SelectedIndex = 1;
        }
    }
}
