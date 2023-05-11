using BookMaster.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Логика взаимодействия для BookAuthorDetailsWindow.xaml
    /// </summary>
    public partial class BookAuthorDetailsWindow : Window
    {
        private BookAuthor bookAuthor;

        public BookAuthorDetailsWindow()
        {
            InitializeComponent();
        }

        public BookAuthorDetailsWindow(BookAuthor bookAuthor)
        {
            InitializeComponent();

            this.bookAuthor = bookAuthor;

            DataContext = bookAuthor;

            AuthorsCmb.ItemsSource = App.contexnt.BookAuthor.Where(ba => ba.Bookid ==bookAuthor.Book.Bookid).ToList();
            
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void AuthorsCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void OpenWikipediaHl_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }
    }
}
