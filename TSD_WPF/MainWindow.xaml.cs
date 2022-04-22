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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TSD_WPF;

namespace TSD_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private static List<Book> booksCache = Book.MyBookCollection.GetMyCollection();
        public MainWindow()
        {
            InitializeComponent();
            booksListBox.ItemsSource = booksCache;
        }

        private void deleteButtonClick(object sender, RoutedEventArgs e)
        {
            if(booksListBox.SelectedItem != null)
            {
                if (MessageBox.Show("Are you sure to delete?", "Delete", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
                {
                    Book book = booksListBox.SelectedItem as Book;
                    (booksListBox.ItemsSource as List<Book>).Remove(book);
                }
            }

        }
    }
}
