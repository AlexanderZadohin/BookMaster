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
    /// Логика взаимодействия для CirculationWindow.xaml
    /// </summary>
    public partial class CirculationWindow : Window
    {
        public CirculationWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (FindCustomers() != null)
                {
                    DataContext = FindCustomers();

                    EditBtn.IsEnabled = true;
                }
                else
                {
                    MessageBox.Show("Клиент с таким идентификатором не найден!");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Введите корректно id!\nИcключение: {ex.Message}");
            }
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            if (FindCustomers() != null) 
            {
                AddEditCustomerWindow addEditCustomerWindow = new AddEditCustomerWindow(FindCustomers());
                addEditCustomerWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите пользователя");
            }
        }

        private Customers FindCustomers()
        {
            int customerId = int.Parse(CustomerIDTB.Text.Trim('C'));

            Customers selectedCustomers = App.contexnt.Customers.FirstOrDefault(c => customerId == c.id);

            return selectedCustomers != null ? selectedCustomers : null;
        }
        private void BookIDTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                MessageBox.Show(FindBook().Title);
            }
            catch (NullReferenceException exp)
            {
                MessageBox.Show(exp.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("некорректный вод");
            }
        }
        private Book FindBook() 
        {
            int bookId = int.Parse(BookIDTB.Text);
            Book selectedBook = App.contexnt.Book.FirstOrDefault(b => bookId == b.Bookid);
            return selectedBook != null ? selectedBook : null;
        }
    }
}
