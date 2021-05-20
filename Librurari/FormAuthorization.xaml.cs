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

namespace Librurari
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class FormAuthorization : Window
    {
        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void btnAuthorigarion_Click(object sender, RoutedEventArgs e)
        {
            txtlogin.Clear();
            txtpasword.Clear();
        }

        private void btncleer_Click(object sender, RoutedEventArgs e)
        {
            var accountLibrian = context.LIbrarian.ToList().Where(i => i.Login == txtlogin.Text && i.Password == txtpasword.Text).FirstOrDefault();
            if (accountLibrian == null)
            {
                MessageBox.Show("Неправильный логин или пароль", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                WorkpPlase workpPlase = new WorkpPlase();
                this.Hide();
                workpPlase.Show();
                this.Close();
            }
        }
    }
}
