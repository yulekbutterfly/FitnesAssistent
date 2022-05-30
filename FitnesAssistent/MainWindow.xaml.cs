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
using FitnesAssistent.Windows;

namespace FitnesAssistent
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_vxod_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbLogin.Text))
            {
                MessageBox.Show("Поле ЛОГИН не должно быть пустым", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (String.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Поле ЛОГИН не должно быть пустым", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var user = DB.AppData.context.User.ToList().Where(i=> i.Login==tbLogin.Text && i.Password==tbPassword.Text).FirstOrDefault();

            if (user != null)
            {
                Assistent assistent = new Assistent(user);
                this.Hide();
                assistent.ShowDialog();
                this.ShowDialog();
            }
            else
            {
                MessageBox.Show("Пользователь не найден", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            registration.ShowDialog();

        }
    }
}
