using Librurari.AppData;
using Librurari.Forms;
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
            List <Gender> genders = context.Gender.ToList(); //создаём лист гендер и присваеваем ему все значения 
            genders.Insert(0, new Gender() { NameGender = "все" });// добовляем значения все
            CmbGender.DisplayMemberPath = "NameGender"; // добавляем именно имя
            CmbGender.ItemsSource = genders; // присваеваем лист гендер 
            CmbGender.SelectedIndex = 0;
            Cmbfilter.ItemsSource = new List<string>()
            {
                "По умолчанию", "По адресу ", "По фамилии"
            };
        }
        public void Filter()
        {
            var list = context.ReaderList.Where(i => i.FirstName.Contains(TxtSearch.Text)
            || i.LastName.Contains(TxtSearch.Text)
            || i.Patronumic.Contains(TxtSearch.Text))
                .ToList();


            switch (Cmbfilter.SelectedIndex)
            {

                case 1:
                    list = list.OrderByDescending(i => i.Addres).ToList();
                    break;
                case 2:
                    list = list.OrderByDescending(i => i.LastName).ToList();
                    break;
            }
            if (CmbGender.SelectedIndex == 0)
            {
                ListViewFW.ItemsSource = list;
            }
            else
            {
                var Gendre = CmbGender.SelectedItem as Gender;
                list = list.Where(i => i.NameGender == Gendre.NameGender).ToList();
            }
            ListViewFW.ItemsSource = list;
        }

        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filter();
        }

        private void Cmbfilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }

        private void CmbGender_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }

        private void BtnAddReader_Click(object sender, RoutedEventArgs e)
        {
            AddReader addReader = new AddReader();
            this.Opacity = 0.3;
            Filter();
            addReader.ShowDialog();
            Filter();
            this.Opacity = 1;
            
        }

        private void BtnDeleteCharacteristics_Click(object sender, RoutedEventArgs e)
        {
            if (ListViewFW.SelectedItem is ReaderList reader)
            {
                var result = MessageBox.Show("вы действительно хотите удалить клиента? ", "dellclientt",
                    MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
     
                        context.Reader.Remove(context.Reader.Where(i => i.Phone == reader.Phone).FirstOrDefault());
                        context.SaveChanges();
                        MessageBox.Show("запись удалена", "Уведоимление", MessageBoxButton.OK, MessageBoxImage.Information);
                        Filter();

                }
            }
            else
            {
                MessageBox.Show("выбирите клиента которого хотите удалить ");
            }
        }
    }
}
