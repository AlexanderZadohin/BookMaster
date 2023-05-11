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
using BookMaster.Model;
using BookMaster.View.Pages;

namespace BookMaster.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для BrowseCatalogWindow.xaml
    /// </summary>
    public partial class BrowseCatalogWindow : Window
    {
        public BrowseCatalogWindow()
        {
            InitializeComponent();


            SearchResultslv.ItemsSource = App.contexnt.BookAuthor.ToList();
        }
        #region Menu
        private void LoginMi_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow login = new LoginWindow();
            if(login.ShowDialog() == true)
            {
                LoginMi.Visibility = Visibility.Collapsed;
                LogoutMi.Visibility = Visibility.Visible;
                LibraryMi.Visibility = Visibility.Visible;
            }
        }

        private void LogoutMi_Click(object sender, RoutedEventArgs e)
        {
            LoginMi.Visibility = Visibility.Visible;
            LogoutMi.Visibility = Visibility.Collapsed;
            LibraryMi.Visibility = Visibility.Collapsed;
        }

        private void CloseMi_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ManageCustomersMi_Click(object sender, RoutedEventArgs e)
        {
            ManageCustomersWindow manageCustomers = new ManageCustomersWindow();
            manageCustomers.ShowDialog();
        }

        private void CirculationMi_Click(object sender, RoutedEventArgs e)
        {
            CirculationWindow circulationWindow = new CirculationWindow();
            circulationWindow.ShowDialog();
        }

        private void ReportsMi_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion

        private void SearchResultsFrm_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            if(TitleSearchTb.Text != string.Empty)
            {
                SearchResultslv.ItemsSource = App.contexnt.BookAuthor.Where(ba => ba.Book.Title.Contains(TitleSearchTb.Text)).ToList();
            }
            //else if(AuthorSearchTb.Text != string.Empty)
            //{
            //    SearchResultslv.ItemsSource = App.contexnt.BookAuthor.Where(ba => ba.Book.BookAuthor.Contains(AuthorSearchTb.Text)).ToList();
            //}
        }

        private void SearchResultslv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            BookDetailsGrid.DataContext = SearchResultslv.SelectedItem as BookAuthor;

        }

        private void TitleSearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TitleSearchTb.Text == string.Empty)
            {
                SearchResultslv.ItemsSource = App.contexnt.BookAuthor.ToList();
            }
        }

        private void AuthorsDetailsHl_Click(object sender, RoutedEventArgs e)
        {
            BookAuthorDetailsWindow detailsWindow = new BookAuthorDetailsWindow(SearchResultslv.SelectedItem as BookAuthor);
            detailsWindow.ShowDialog();
        }
    }
}
