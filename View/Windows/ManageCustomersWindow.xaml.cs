using BookMaster.Model;
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
using System.Windows.Shapes;


namespace BookMaster.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для ManageCustomersWindow.xaml
    /// </summary>
    public partial class ManageCustomersWindow : Window
    {
        public ManageCustomersWindow()
        {
            InitializeComponent();

            CustomersInfoLsV.ItemsSource = App.contexnt.Customers.ToList();
        }

        private void ReportsMi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CirculationMi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ManageCustomersMi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CloseMi_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void LogoutMi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LoginMi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            if (CustomerIdTb.Text != string.Empty)
            {
                CustomersInfoLsV.ItemsSource = App.contexnt.Customers.Where(c => c.Name.Contains(NameTb.Text)).ToList();
            }
        }

        private void CustomerIdTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            //if (CustomerIdTb.Text != string.Empty)
            //{

            //}
        }

        private void NameTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (NameTb.Text == string.Empty)
            {
                CustomersInfoLsV.ItemsSource = App.contexnt.Customers.Where(c => c.Name.Contains(NameTb.Text)).ToList();
            }
        }

        private void CustomerIdTb_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if (CustomerIdTb.Text != string.Empty)
            {
                CustomersInfoLsV.ItemsSource = App.contexnt.Customers.Where(c => c.Name.Contains(NameTb.Text)).ToList();
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            AddEditCustomerWindow addEditCustomerWindow = new AddEditCustomerWindow();
            if (addEditCustomerWindow.ShowDialog() == true)
            {
                CustomersInfoLsV.ItemsSource = App.contexnt.Customers.ToList();
            }
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            if (CustomersInfoLsV.SelectedItem == null)
            {
                MessageBox.Show("Пользователь не выбран");
            }
            else
            {
                AddEditCustomerWindow addEditCustomerWindow = new AddEditCustomerWindow(CustomersInfoLsV.SelectedItem as Customers);
                if (addEditCustomerWindow.ShowDialog() == true)
                {

                }
            }
        }
    }
}
