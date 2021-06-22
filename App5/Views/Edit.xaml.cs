using App5.Models;
using App5.ViewModels;
using App5.Views;
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
    public partial class Edit : ContentPage
    { 

        public static int UserId;
        public Edit()
        {
            InitializeComponent();
            UserId = LoginPage.UserId;
            var user = App.Database.GetItem(UserId);
            Surname.Text = user.Fio.Split()[0];
            Name.Text = user.Fio.Split()[1];
            Name3.Text = user.Fio.Split()[2];
            if (user.Sex == 1)
            {
                Male.IsChecked = true;
            }
            else Female.IsChecked = true;
        }
        public bool CheckExistence()
        {
            foreach (var elem in App.Database.GetItems())
            {
                if (elem.Email == Mail.Text) return true;
            }
            return false;
        }
        public bool PassMatched()
        {
            return OldPass.Text == App.Database.GetItem(UserId).Password;
        }

        private async  void Apply(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            User user = App.Database.GetItem(UserId);
            var sb = new StringBuilder();
            var flag = true;
            if (Surname.Text != null)
            {
                if (Surname.Text.Length <= 50)
                {
                    sb.Append(Surname.Text);
                    sb.Append(" ");
                }
                else
                {
                    flag = false;
                    await DisplayAlert("Alert", "Текст полей не должен превышать 50 символов", "OK");

                }
            }
            else
            {
                sb.Append(App.Database.GetItem(UserId).Fio.Split()[0]);
                sb.Append(" ");
            }
            if (Name.Text != null)
            {
                if (Name.Text.Length <= 50)
                {
                    sb.Append(Name.Text);
                    sb.Append(" ");
                }
                else
                {
                    flag = false;
                    await DisplayAlert("Alert", "Текст полей не должен превышать 50 символов", "OK");
                }
            }
            else
            {
                sb.Append(App.Database.GetItem(UserId).Fio.Split()[1]);
                sb.Append(" ");
            }
            if (Name3.Text != null)
            {
                if (Name3.Text.Length <= 50)
                {
                    sb.Append(Name3.Text);

                }
                else
                {
                    flag = false;
                    await DisplayAlert("Alert", "Текст полей не должен превышать 50 символов", "OK");
                }
            }
            else
            {
                sb.Append(App.Database.GetItem(UserId).Fio.Split()[2]);

            }
            user.Fio = sb.ToString();

           
            if (Mail.Text != null)
            {
                if (Mail.Text.Length <= 50)
                {
                    if (regex.Match(Mail.Text).Success)
                    {
                        if (!CheckExistence())
                        {
                            user.Email = Mail.Text;
                        }
                        else
                        {
                            flag = false;
                            await DisplayAlert("Alert", "Пользователь с такой почтой уже зарегистрирован", "OK");
                        }
                    }
                    else
                    {
                        flag = false;
                        await DisplayAlert("Alert", "Неправильный формат почты", "OK");
                    }
                }
                else
                {
                    flag = false;
                    await DisplayAlert("Alert", "Текст полей не должен превышать 50 символов", "OK");
                }
            }

            if (Pass.Text != null)
            {
                if (Pass.Text.Length <= 50)
                {
                    if (Pass.Text.Length >= 8)
                    {
                        if (PassMatched())
                        {
                            user.Password = Pass.Text;
                        }
                        else
                        {
                            flag = false;
                            await DisplayAlert("Alert", "Чтобы изменить пароль, нужно указать правильный пердыдущий вариант", "OK");
                        }
                    }
                    else
                    {
                        flag = false;
                        await DisplayAlert("Alert", "Пароль должен состоять минимум из 8 символов", "OK");
                    }
                }
                else
                {
                    flag = false;
                    await DisplayAlert("Alert", "Текст полей не должен превышать 50 символов", "OK");
                }
            }
            if (flag)
            {
                user.Sex = Male.IsChecked ? 1 : 0;
                App.Database.SaveItem(user);
                await this.Navigation.PushAsync(new ProfilePage());
            }
            
        }
        void OnPanUpdated(object sender, PanUpdatedEventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}