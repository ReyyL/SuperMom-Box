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
    public partial class EditChild : ContentPage
    {
        public static int UserId;
        public string child;
        public int childId;
        public EditChild(int id)
        {
            InitializeComponent();
            childId = id;
            UserId = LoginPage.UserId;
            var user = App.Database.GetItem(UserId);
            if(id == 1)
            {
                child = user.Child1;
            }
            else if (id == 2)
            {
                child = user.Child2;
            }
            else if (id == 3)
            {
                child = user.Child3;
            }
            else if (id == 4)
            {
                child = user.Child4;
            }
            else if (id == 5)
            {
                child = user.Child5;
            }
            Name.Text = child.Split()[1];
            Surname.Text = child.Split()[0];
            Name3.Text = child.Split()[2];
            if (child.Split()[4] == "1")
            {
                Male.IsChecked = true;
            }
            else Female.IsChecked = true;
        }
       
       
        private async void Apply(object sender, EventArgs e)
        {
            
            User user = App.Database.GetItem(UserId);
            var curChild = child.Split();
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
                sb.Append(curChild[0]);
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
                sb.Append(curChild[1]);
                sb.Append(" ");
            }
            if (Name3.Text != null)
            {
                if (Name3.Text.Length <= 50)
                {
                    sb.Append(Name3.Text);
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
                sb.Append(curChild[2]);
                sb.Append(" ");

            }

            sb.Append(curChild[3]);
            sb.Append(" ");

            if (flag)
            {
                sb.Append(Male.IsChecked ? "1" : "0");
                if (childId == 1)
                {
                    user.Child1 = sb.ToString();
                }
                else if (childId == 2)
                {
                    user.Child2 = sb.ToString();
                }
                else if (childId == 3)
                {
                    user.Child3 = sb.ToString();
                }
                else if (childId == 4)
                {
                    user.Child4 = sb.ToString();
                }
                else if (childId == 5)
                {
                   user.Child5 = sb.ToString();
                }
                App.Database.SaveItem(user);
                await this.Navigation.PopAsync();
            }

        }
        void OnPanUpdated(object sender, PanUpdatedEventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}
