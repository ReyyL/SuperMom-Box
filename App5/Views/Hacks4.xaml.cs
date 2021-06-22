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
    public partial class Hacks4 : ContentPage
    {

        public Hacks4()
        {
            InitializeComponent();
        }

        private async void game41(object sender, EventArgs e)
        {
            var page = new game41();
            await Navigation.PushAsync(page);
        }
        private async void game42(object sender, EventArgs e)
        {
            var page = new game42();
            await Navigation.PushAsync(page);
        }
        void OnPanUpdated(object sender, PanUpdatedEventArgs e)
        {
            this.Navigation.PopAsync();
        }
        private async void game43(object sender, EventArgs e)
        {
            var page = new game43();
            await Navigation.PushAsync(page);
        }
        private async void game44(object sender, EventArgs e)
        {
            var page = new game44();
            await Navigation.PushAsync(page);
        }
        private async void game45(object sender, EventArgs e)
        {
            var page = new game45();
            await Navigation.PushAsync(page);
        }
        private async void game46(object sender, EventArgs e)
        {
            var page = new game46();
            await Navigation.PushAsync(page);
        }
        private async void game47(object sender, EventArgs e)
        {
            var page = new game47();
            await Navigation.PushAsync(page);
        }
        private async void game48(object sender, EventArgs e)
        {
            var page = new game48();
            await Navigation.PushAsync(page);
        }
        private async void game49(object sender, EventArgs e)
        {
            var page = new game49();
            await Navigation.PushAsync(page);
        }
        private async void game410(object sender, EventArgs e)
        {
            var page = new game410();
            await Navigation.PushAsync(page);
        }
        private async void game411(object sender, EventArgs e)
        {
            var page = new game411();
            await Navigation.PushAsync(page);
        }
        private async void game412(object sender, EventArgs e)
        {
            var page = new game412();
            await Navigation.PushAsync(page);
        }
    }
}