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
using static FitnesAssistent.Validation.ValidationResult;

namespace FitnesAssistent.Windows
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        bool IsEdit;
        DB.User globalUser;
        public Registration()
        {
            InitializeComponent();
            cmb_gender.ItemsSource = DB.AppData.context.Gender.ToList();
            cmb_gender.DisplayMemberPath = "Gender1";
            cmb_gender.SelectedIndex = 0;
            
        }

        public Registration(DB.User user)
        {
            InitializeComponent();
            tbTitle.Text = "Изменение";
            btn_zareg.Content = "Изменить";

            cmb_gender.ItemsSource = DB.AppData.context.Gender.ToList();
            cmb_gender.DisplayMemberPath = "Gender1";
            txt_log.Text = user.Login;
            txt_pass.Text = user.Password;
            txt_Fam.Text = user.LName;
            txt_Name.Text = user.FName;
            txt_Rost.Text = Convert.ToString( user.Height);
            txt_Ves.Text = Convert.ToString( user.Weight);
            txt_BD.Text= Convert.ToString( user.DateBirst);
            cmb_gender.SelectedIndex = user.idGender - 1;

            globalUser = user;
            IsEdit = true;
        }
        private void btn_zareg_Click(object sender, RoutedEventArgs e)
        {
            if(ValidationLogin(txt_log.Text)==false)
            {
                MessageBox.Show("Поле ЛОГИН не соответствует требованиям!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (ValidationPassword(txt_pass.Text) == false)
            {
                MessageBox.Show("Поле ПАРОЛЬ не соответствует требованиям!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if(ValidationNameLName(txt_Name.Text) == false)
            {
                MessageBox.Show("Поле ИМЯ не соответствует требованиям!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if(ValidationNameLName(txt_Fam.Text) == false)
            {
                MessageBox.Show("Поле ФАМИЛИЯ не соответствует требованиям!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if(ValidationWeightHeight(txt_Rost.Text) == false)
            {
                MessageBox.Show("Поле РОСТ не соответствует требованиям!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (ValidationWeightHeight(txt_Ves.Text) == false)
            {
                MessageBox.Show("Поле ВЕС не соответствует требованиям!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (ValidationDateOfBirth(Convert.ToDateTime(txt_BD.Text)) == false)
            {
                MessageBox.Show("Поле ДАТА не соответствует требованиям!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if(IsEdit)
            {
                var resClick = MessageBox.Show("Изменить пользователя", "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (resClick == MessageBoxResult.No)
                {
                    return;
                }

                globalUser.FName = txt_Name.Text;
                globalUser.LName = txt_Fam.Text;
                globalUser.Login = txt_log.Text;
                globalUser.Password = txt_pass.Text;
                globalUser.Height = Convert.ToDouble(txt_Rost.Text);
                globalUser.Weight = Convert.ToDouble(txt_Ves.Text);
                globalUser.DateBirst = Convert.ToDateTime(txt_BD.Text);
                globalUser.idGender = cmb_gender.SelectedIndex + 1;

                DB.AppData.context.SaveChanges();
                MessageBox.Show("Пользователь изменен");
                this.Close();
            }
            else
            {
                var resClick = MessageBox.Show("Добавить пользователя", "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (resClick == MessageBoxResult.No)
                {
                    return;
                }

                DB.User user = new DB.User();
                user.FName = txt_Name.Text;
                user.LName = txt_Fam.Text;
                user.Login = txt_log.Text;
                user.Password = txt_pass.Text;
                user.Height = Convert.ToDouble(txt_Rost.Text);
                user.Weight = Convert.ToDouble(txt_Ves.Text);
                user.DateBirst = Convert.ToDateTime(txt_BD.Text);
                user.idGender = cmb_gender.SelectedIndex + 1;

                DB.AppData.context.User.Add(user);
                DB.AppData.context.SaveChanges();

                MessageBox.Show("Запись успешно добавлена");
                this.Close();
            }


        }

        private void btn_OTMENA_Click(object sender, RoutedEventArgs e)
        {
           this.Close();
        }
    }
}
