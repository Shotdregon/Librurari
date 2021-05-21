using Librurari.AppData;
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
    /// Логика взаимодействия для ReaderPage.xaml
    /// </summary>
    public partial class ReaderPage : Page
    {
        public ReaderPage()
        {
            InitializeComponent();
            ListViewFW.ItemsSource = context.vivReader.ToList();
            Cmbfilter.SelectedItem = 0;
            Cmbfilter.ItemsSource = new List<string>
            {
                "По умолчанию","По аренде книг","по полу"
            };
        }
        public void Filter() 
        {
            var list = context.vivReader.AsNoTracking()
                .Where(i => i.FirstName.Contains(TxtSearch.Text) 
            || i.LastName.Contains(TxtSearch.Text) 
            || i.Patronumic.Contains(TxtSearch.Text))
                .ToList();
            ListViewFW.ItemsSource = list;

            switch (Cmbfilter.SelectedIndex)
            {

                case 1:
                    list = list.OrderByDescending(i => i.QuantityBp).ToList();
                    break;
                case 2:
                    list = list.OrderByDescending(i => i.NameGender).ToList();
                    break;
            }
            ListViewFW.ItemsSource = list;
        }
            
        

        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filter();
        }

        private void BtnResetFilters_Click(object sender, RoutedEventArgs e)
        {
            TxtSearch.Clear();
            Cmbfilter.SelectedIndex = 0;
        }

        private void Cmbfilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }
    }
}
