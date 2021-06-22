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
    public partial class boxgames4 : ContentPage
    {
        public boxgames4()
        {
            InitializeComponent();
        }
        private async void game41(object sender, EventArgs e)
        {
            var page = new box41();
            await Navigation.PushAsync(page);
        }
        private async void game42(object sender, EventArgs e)
        {
            var page = new box42();
            await Navigation.PushAsync(page);
        }
        private async void game43(object sender, EventArgs e)
        {
            var page = new box43();
            await Navigation.PushAsync(page);
        }
        private async void game44(object sender, EventArgs e)
        {
            var page = new box44();
            await Navigation.PushAsync(page);
        }
        private async void game45(object sender, EventArgs e)
        {
            var page = new box45();
            await Navigation.PushAsync(page);
        }
        private async void game46(object sender, EventArgs e)
        {
            var page = new box46();
            await Navigation.PushAsync(page);
        }
        private async void game47(object sender, EventArgs e)
        {
            var page = new box47();
            await Navigation.PushAsync(page);
        }
        private async void game48(object sender, EventArgs e)
        {
            var page = new box48();
            await Navigation.PushAsync(page);
        }
        private async void game49(object sender, EventArgs e)
        {
            var page = new box49();
            await Navigation.PushAsync(page);
        }
        private async void game410(object sender, EventArgs e)
        {
            var page = new box410();
            await Navigation.PushAsync(page);
        }
        private async void game411(object sender, EventArgs e)
        {
            var page = new box411();
            await Navigation.PushAsync(page);
        }
        private async void game412(object sender, EventArgs e)
        {
            var page = new box412();
            await Navigation.PushAsync(page);
        }
        private async void game413(object sender, EventArgs e)
        {
            var page = new box413();
            await Navigation.PushAsync(page);
        }
        private async void game414(object sender, EventArgs e)
        {
            var page = new box414();
            await Navigation.PushAsync(page);
        }
        private async void game415(object sender, EventArgs e)
        {
            var page = new box415();
            await Navigation.PushAsync(page);
        }
        void OnPanUpdated(object sender, PanUpdatedEventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}