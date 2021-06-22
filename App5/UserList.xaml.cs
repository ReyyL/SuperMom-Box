using App5.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserList : ContentPage
    {
        public UserList()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            userList.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            User selectedFriend = (User)e.SelectedItem;
            App.Database.DeleteItem(selectedFriend.Id);

        }

        public void BackButton_Click(object sender, System.EventArgs e)
        {
            Application.Current.MainPage = new AppShell();
        }
    }
}