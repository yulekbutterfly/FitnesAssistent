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

namespace FitnesAssistent.Windows
{
    /// <summary>
    /// Логика взаимодействия для Assistent.xaml
    /// </summary>
    public partial class Assistent : Window
    {
        public Assistent()
        {
            InitializeComponent();
        }

        private void izm(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
        }
    }
}
