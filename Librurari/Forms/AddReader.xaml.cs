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
using System.Windows.Shapes;
using static Librurari.AppData.AppDataClass;

namespace Librurari.Forms
{
    /// <summary>
    /// Логика взаимодействия для AddReader.xaml
    /// </summary>
    public partial class AddReader : Window
    {
        public AddReader()
        {
            InitializeComponent();
            cbgender.ItemsSource = context.Gender.ToList();
            cbgender.DisplayMemberPath = "NameGender";
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Reader reader = new Reader();
                reader.LastName = tblastname.Text;
                reader.FirstName = tbname.Text;
                reader.Patronumic = tbpatronumic.Text;
                reader.Phone = tbphone.Text;
                reader.Addres = Tbaddres.Text;
                reader.Gender = cbgender.SelectedIndex + 1;
                reader.BirthDate = (DateTime)dpbirthdate.SelectedDate;
                reader.Pasport = 8;
                reader.Teg = 3;


                context.Reader.Add(reader);
                context.SaveChanges();
                MessageBox.Show("Читатель добавлен", "Success", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                Close();

            }
             catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
