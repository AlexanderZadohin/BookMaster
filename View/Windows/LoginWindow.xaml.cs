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
using System.Windows.Shapes;

namespace BookMaster.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {

        string name = "1";
        string password = "1";
        public LoginWindow()
        {
            InitializeComponent();

        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            //if (userNameTb.Text == name && PasswordPb.Password == password)
            //{
            //    MessageBox.Show("Введенно все верно, вход разрешен");
            //    ManageCustomersWindow manageCustomers = new ManageCustomersWindow();
            //    manageCustomers.ShowDialog();
            //    this.Close();
            //}

            //else
            //{
            //    MessageBox.Show("Данные не действительны", "Ошибка");
            //}
            Login();

        }

        private void Login()
        {
            if (userNameTb.Text == name && PasswordPb.Password == password)
            {
                DialogResult = true;
            }

            else
            {
                DialogResult = false;
                MessageBox.Show("Данные не действительны", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
