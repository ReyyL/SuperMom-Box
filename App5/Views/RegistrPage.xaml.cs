using App5.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrPage : ContentPage
    {
        public RegistrPage()
        {
            InitializeComponent();
        }
        public bool CheckExistence()
        {
            foreach (var elem in App.Database.GetItems())
            {
                if (elem.Email == Mail.Text) return true;
            }
            return false;
        }

        public async void Login(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (Name3.Text == null) Name3.Text = "Не_Указано";
            if (Name.Text == null || Surname.Text == null || Mail.Text == null || Pass.Text == null)
            {
                await DisplayAlert("Alert", "Не все обязательные поля заполнены", "OK");
            }
            else if (Name.Text.Length >= 50 || Surname.Text.Length >= 50 || Name3.Text.Length >= 50
                || Mail.Text.Length >= 50 || Pass.Text.Length >= 50)
            {
                await DisplayAlert("Alert", "Текст полей не должен превышать 50 символов", "OK");
            }
            else if (Pass.Text.Length < 8)
            {
                await DisplayAlert("Alert", "Пароль должен содержать как минимум 8 символов", "OK");
            }
            /*else if (!(regex.Match(Mail.Text).Success))
            {
                await DisplayAlert("Alert", "Неправильный формат почты", "OK");
            }*/
            else if (CheckExistence())
            {
                await DisplayAlert("Alert", "Пользователь с такой почтой уже зарегистрирован", "OK");
            }
            else
            {
                User user = new User();
                var sb = new StringBuilder();
                sb.Append(Surname.Text);
                sb.Append(" ");
                sb.Append(Name.Text);
                if (Name3.Text.Length == 0) Name3.Text = "Не_Указано";
                sb.Append(" ");
                sb.Append(Name3.Text);
                user.Fio = sb.ToString();
                user.Email = Mail.Text;
                user.Password = Pass.Text;
                user.BirthDate = Birth.Date.ToString();
                user.Sex = Male.IsChecked ? 1 : 0;
                App.Database.SaveItem(user);
                Application.Current.MainPage = new LoginPage();
            }
        }

        public void BackButton(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Welcome();
        }
    }
}