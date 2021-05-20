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
    /// Логика взаимодействия для ListReaderPage.xaml
    /// </summary>
    public partial class ListReaderPage : Page
    {
        public ListReaderPage()
        {
            InitializeComponent();
            ListViewFW.ItemsSource = context.ReaderList.ToList();
        }
        public void Filter()
        {
            var list = context.ReaderList.Where(i => i.FirstName.Contains(TxtSearch.Text)
            || i.LastName.Contains(TxtSearch.Text)
            || i.Patronumic.Contains(TxtSearch.Text))
                .ToList();
            ListViewFW.ItemsSource = list;

            switch (Cmbfilter.SelectedIndex)
            {

                case 1:
                    list = list.OrderByDescending(i => i.Addres).ToList();
                    break;
                case 2:
                    list = list.OrderByDescending(i => i.NameGender).ToList();
                    break;
            }
        }

        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filter();
        }
    }
}
