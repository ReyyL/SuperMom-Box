using App5.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class more2 : ContentPage
    {

        public more2()
        {
            InitializeComponent();
        }
        public async void AddButton_Click(object sender, EventArgs e)
        {
            var user = App.Database.GetItem(LoginPage.UserId);
            var sb = new StringBuilder(user.Boxes);
            if (sb.ToString().Length == 0)
            {
                sb.Append("2");
            }
            else
            {
                sb.Append(" ");
                sb.Append("2");
            }
            user.Boxes = sb.ToString();
            
            App.Database.SaveItem(user);
            await DisplayAlert("Alert", "Бокс успешно добавлен в корзину", "OK");
            await Navigation.PopAsync();
        }
        void OnPanUpdated(object sender, PanUpdatedEventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}