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
using static FitnesAssistent.Validation.Calculation;

namespace FitnesAssistent.Windows
{
    /// <summary>
    /// Логика взаимодействия для Assistent.xaml
    /// </summary>
    public partial class Assistent : Window
    {

        DB.User globalUser;
        public Assistent(DB.User user)
        {
            InitializeComponent();

            double bmi = BMI(user.Weight,user.Height);
            double bmr = BMR(user.Weight,user.Height,Convert.ToDouble(user.Age),user.Gender.Gender1);

            txtWeight.Text = user.Weight.ToString();
            txtHeight.Text = user.Height.ToString();
            txtAge.Text=user.Age.ToString();

            txtUserMetrics.Text = GradeBMI(bmi);
            txtUserCalories.Text = bmr.ToString();

            txtName.Text = "Добро пожаловать, " + user.FName;

            globalUser = user;
        }

        private void izm(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration(globalUser);
            registration.ShowDialog();

            double bmi = BMI(globalUser.Weight, globalUser.Height);
            double bmr = BMR(globalUser.Weight, globalUser.Height, Convert.ToDouble(globalUser.Age), globalUser.Gender.Gender1);

            txtWeight.Text = globalUser.Weight.ToString();
            txtHeight.Text = globalUser.Height.ToString();
            txtAge.Text = globalUser.Age.ToString();

            txtUserMetrics.Text = GradeBMI(bmi);
            txtUserCalories.Text = bmr.ToString();

            txtName.Text = "Добро пожаловать, " + globalUser.FName;
        }

        public string GradeBMI(double bmi)
        {
            if (bmi < 16)
            {
                return "Выраженный дефицит массы тела";
            }
            else if (bmi >= 16 && bmi < 18.5)
            {
                return "Недостаточная (дефицит) масса тела";
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                return "Норма";
            }
            else if (bmi >= 25 && bmi < 30)
            {
                return "Избыточная масса тела (предожирение)";
            }
            else if (bmi >= 30 && bmi < 35)
            {
                return "Ожирение 1 степени";
            }
            else if (bmi >= 35 && bmi > 40)
            {
                return "Ожирение 2 степени";
            }
            else if (bmi > 40)
            {
                return "Ожирение 3 степени";
            }
            return "Невообразимо!";
        }

        private void btn_vyhod_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
