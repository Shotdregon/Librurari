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
using static Librurari.AppData.AppDataClass;

namespace Librurari.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageBook.xaml
    /// </summary>
    public partial class PageBook : Page
    {
        public PageBook()
        {
            InitializeComponent();
            ListViewBook.ItemsSource = context.infbook.ToList();
        }

        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
