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
    /// Логика взаимодействия для AddEditCustomerWindow.xaml
    /// </summary>
    public partial class AddEditCustomerWindow : Window
    {
        // Флажок отслеживает что нужно делать
        bool isEdit = false;
        public AddEditCustomerWindow()
        {
            InitializeComponent();

            isEdit = false;
        }

        public AddEditCustomerWindow(Customers selectedCustomers)
        {
            InitializeComponent();

            DataContext = selectedCustomers;

            isEdit = true;
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if(isEdit == true)
            {
                App.contexnt.SaveChanges();


                MessageBox.Show("Читатель успешно изменен!");

                DialogResult = true;

            }
            else
            {
                Customers newCustomers = new Customers
                {
                    Name = NameTb.Text,
                    Address = AddressTb.Text,
                    Zip = ZipTb.Text,
                    City = CityTb.Text,
                    Phone = PhoneTb.Text,
                    Email = EmailTb.Text
                };
                App.contexnt.Customers.Add(newCustomers);
                App.contexnt.SaveChanges();

                MessageBox.Show("Читатель успешно добавлен!");

                DialogResult = true;

            }

        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
