using App5.ViewModels;
using App5.Services;
using App5.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace App5.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            GetUserId();
            if (UserId != 0 && UserId != -2) {
                Mail.Text = App.Database.GetItem(UserId).Email;
                Pass.Text = App.Database.GetItem(UserId).Password; 
            }
        }

        public static int UserId;

        public void GetUserId()
        {
            var last_user = "LastUser.txt";
            var writePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),last_user);

            try
            {
                var sr0 = new StreamReader(writePath);
                sr0.Close();
               
            }
            catch (Exception e)
            {
                var sr = new StreamWriter(writePath);
                sr.Write("-2");
                sr.Close();
            }
           
            var sr1 = new StreamReader(writePath);
            UserId = Convert.ToInt32(sr1.ReadToEnd());
            sr1.Close();
        }

        public void SetUserId(int text)
        {
            var last_user = "LastUser.txt";
            var writePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), last_user);
            File.Create(writePath).Close();
            var sr1 = new StreamWriter(writePath);
            sr1.WriteLine(text.ToString());
            sr1.Close();
        }

        public bool CheckMail()
        {
            foreach (var elem in App.Database.GetItems())
            {
                if (elem.Email == Mail.Text)
                {
                    UserId = elem.Id;
                    return true;
                }
            }
            return false;
        }
        public bool CheckPassword()
        {
            if (App.Database.GetItem(UserId).Password == Pass.Text) return true;
            return false;
        }

        public void BackButton(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Welcome();

        }

        public async void LoginClick(object sender, EventArgs e)
        {
            if (CheckMail())
            {
                if (CheckPassword())
                {
                    SetUserId(UserId);
                    Application.Current.MainPage = new AppShell();
                }
                else
                    await DisplayAlert("Alert", "Неверный пароль", "OK");
            }
            else
            {
                await DisplayAlert("Alert", "Нет пользователя с такой почтой", "OK");
            }
        }
    }
}