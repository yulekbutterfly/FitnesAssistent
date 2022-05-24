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
            Assistent assistent = new Assistent();
            assistent.Show();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();

        }
    }
}
