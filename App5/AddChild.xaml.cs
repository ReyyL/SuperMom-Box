using App5.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddChild : ContentPage
    {
        public AddChild()
        {
            InitializeComponent();
        }
        public async void ApplyButton_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (Name3.Text == null) Name3.Text = "Не_Указано";
            if (Name.Text == null || Surname.Text == null)
            {
                await DisplayAlert("Alert", "Не все обязательные поля заполнены", "OK");
            }
            else if (Name.Text.Length >= 50 || Surname.Text.Length >= 50 || Name3.Text.Length >=50)
                {
                    await DisplayAlert("Alert", "Текст полей не должен превышать 50 символов", "OK");
                }
            else
            {
                var sb = new StringBuilder();
                sb.Append(Surname.Text);
                sb.Append(" ");
                sb.Append(Name.Text);
                
                sb.Append(" ");
                sb.Append(Name3.Text);
                sb.Append(" ");
                sb.Append(Birth.Date.ToString().Split()[0].ToString());
                sb.Append(" ");
                sb.Append(Male.IsChecked ? "1" : "0");
                var user = App.Database.GetItem(LoginPage.UserId);
                if (user.Child1 is null) user.Child1 = sb.ToString();
                else
                {
                    if (user.Child2 is null) user.Child2 = sb.ToString();
                    else
                    {
                        if (user.Child3 is null) user.Child3 = sb.ToString();
                        else
                        {
                            if (user.Child4 is null) user.Child4 = sb.ToString();
                            else
                            {
                                if (user.Child5 is null) user.Child5 = sb.ToString();
                                else await DisplayAlert("Alert", "Нельзя добавить более 5 детей", "OK");
                            }
                        }
                    }
                }
                App.Database.SaveItem(user);                
                await Navigation.PopAsync();
            }
        }
        public async  void BackButton_Click(object sender, EventArgs e)
        {
            await Navigation.PopAsync();

        }
        void OnPanUpdated(object sender, PanUpdatedEventArgs e)
        {
            this.Navigation.PopAsync();
        }

    }
}