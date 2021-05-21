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
using Librurari.Forms;
using Librurari.Pages;

namespace Librurari
{
    /// <summary>
    /// Логика взаимодействия для WorkpPlase.xaml
    /// </summary>
    public partial class WorkpPlase : Window
    {
        public WorkpPlase()
        {
            InitializeComponent();
            MainFrame.Content = new ReaderPage();
        }

        private void btnlistRider_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new ReaderPage();
        }

        private void btnToprider_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new ListReaderPage();
        }



        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            FormAuthorization formav = new FormAuthorization();
            formav.Show();
            this.Close();
        }

        private void btnlistbook_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new PageBook();
        }
    }
}
