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
    public partial class Hacks1 : ContentPage
    {

        public Hacks1()
        {
            InitializeComponent();
        }
        void OnPanUpdated(object sender, PanUpdatedEventArgs e)
        {
            this.Navigation.PopAsync();
        }

        private async void game11(object sender, EventArgs e)
        {
            var page = new game101();
            await Navigation.PushAsync(page);
        }
        private async void game12(object sender, EventArgs e)
        {
            var page = new game201();
            await Navigation.PushAsync(page);
        }
        private async void game13(object sender, EventArgs e)
        {
            var page = new game301();
            await Navigation.PushAsync(page);
        }
        private async void game14(object sender, EventArgs e)
        {
            var page = new game401();
            await Navigation.PushAsync(page);
        }
        private async void game15(object sender, EventArgs e)
        {
            var page = new game501();
            await Navigation.PushAsync(page);
        }
        private async void game16(object sender, EventArgs e)
        {
            var page = new game601();
            await Navigation.PushAsync(page);
        }
        private async void game17(object sender, EventArgs e)
        {
            var page = new game701();
            await Navigation.PushAsync(page);
        }
        private async void game18(object sender, EventArgs e)
        {
            var page = new game018();
            await Navigation.PushAsync(page);
        }
        private async void game19(object sender, EventArgs e)
        {
            var page = new game019();
            await Navigation.PushAsync(page);
        }
        private async void game110(object sender, EventArgs e)
        {
            var page = new game0110();
            await Navigation.PushAsync(page);
        }
        private async void game111(object sender, EventArgs e)
        {
            var page = new game0111();
            await Navigation.PushAsync(page);
        }
        private async void game112(object sender, EventArgs e)
        {
            var page = new game0112();
            await Navigation.PushAsync(page);
        }
        private async void game113(object sender, EventArgs e)
        {
            var page = new game0113();
            await Navigation.PushAsync(page);
        }
        private async void game114(object sender, EventArgs e)
        {
            var page = new game0114();
            await Navigation.PushAsync(page);
        }
        private async void game115(object sender, EventArgs e)
        {
            var page = new game0115();
            await Navigation.PushAsync(page);
        }
        private async void game116(object sender, EventArgs e)
        {
            var page = new game0116();
            await Navigation.PushAsync(page);
        }
        private async void game117(object sender, EventArgs e)
        {
            var page = new game0117();
            await Navigation.PushAsync(page);
        }
        private async void game118(object sender, EventArgs e)
        {
            var page = new game0118();
            await Navigation.PushAsync(page);
        }
        private async void game119(object sender, EventArgs e)
        {
            var page = new game0119();
            await Navigation.PushAsync(page);
        }
        private async void game120(object sender, EventArgs e)
        {
            var page = new game0120();
            await Navigation.PushAsync(page);
        }
        private async void game121(object sender, EventArgs e)
        {
            var page = new game0121();
            await Navigation.PushAsync(page);
        }
        private async void game122(object sender, EventArgs e)
        {
            var page = new game0122();
            await Navigation.PushAsync(page);
        }
    }
}