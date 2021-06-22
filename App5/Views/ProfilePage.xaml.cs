using System;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5.Views
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
            var user = App.Database.GetItem(LoginPage.UserId);
            var sb = new StringBuilder();
            sb.Append(user.Fio.Split()[0]);
            sb.Append(" ");
            sb.Append(user.Fio.Split()[1]);
            Surname_Name.Text = sb.ToString();
            Name3.Text = user.Fio.Split()[2]; //user.Id.ToString();
            
        }
        /*protected override void OnAppearing()
        {
            base.OnAppearing();
            var existingPages = Navigation.NavigationStack.ToList();
            if (existingPages != null && existingPages[0] != null)
            {
                foreach (var elem in existingPages)
                {
                    Navigation.RemovePage(elem);
                }
            }
        }*/

        private async void GoToHacks(object sender, EventArgs e)
        {
            Hacks page = new Hacks();
            await Navigation.PushAsync(page);
        }

        private async void Add_Child(object sender, EventArgs e)
        {
            var page = new AddChild();
            await Navigation.PushAsync(page);
        }
        private async void GoToChildList(object sender, EventArgs e)
        {
            var page = new ChildList();
            await Navigation.PushAsync(page);
        }

        private async void GoToContacts(object sender, EventArgs e)
        {
            Contacts page = new Contacts();
            await Navigation.PushAsync(page);
        }

        private async void EditPage(object sender, EventArgs e)
        {
            Edit page = new Edit();
            await Navigation.PushAsync(page);
        }
        private void Exit(object sender, EventArgs e)
        {
            Application.Current.MainPage = new LoginPage();
        }

        void OnPanUpdated(object sender, PanUpdatedEventArgs e)
        {
            this.Navigation.PopAsync();
        }

    }
}