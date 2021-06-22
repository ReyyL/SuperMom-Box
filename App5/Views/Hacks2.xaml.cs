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
    public partial class Hacks2 : ContentPage
    {

        public Hacks2()
        {
            InitializeComponent();
        }
        void OnPanUpdated(object sender, PanUpdatedEventArgs e)
        {
            this.Navigation.PopAsync();
        }

        private async void game21(object sender, EventArgs e)
        {
            var page = new game21();
            await Navigation.PushAsync(page);
        }
        private async void game22(object sender, EventArgs e)
        {
            var page = new game22();
            await Navigation.PushAsync(page);
        }
        private async void game23(object sender, EventArgs e)
        {
            var page = new game23();
            await Navigation.PushAsync(page);
        }
        private async void game24(object sender, EventArgs e)
        {
            var page = new game24();
            await Navigation.PushAsync(page);
        }
        private async void game25(object sender, EventArgs e)
        {
            var page = new game25();
            await Navigation.PushAsync(page);
        }
        private async void game26(object sender, EventArgs e)
        {
            var page = new game26();
            await Navigation.PushAsync(page);
        }
        private async void game27(object sender, EventArgs e)
        {
            var page = new game27();
            await Navigation.PushAsync(page);
        }
        private async void game28(object sender, EventArgs e)
        {
            var page = new game28();
            await Navigation.PushAsync(page);
        }
        private async void game29(object sender, EventArgs e)
        {
            var page = new game29();
            await Navigation.PushAsync(page);
        }
        private async void game210(object sender, EventArgs e)
        {
            var page = new game210();
            await Navigation.PushAsync(page);
        }
        private async void game211(object sender, EventArgs e)
        {
            var page = new game211();
            await Navigation.PushAsync(page);
        }
        private async void game212(object sender, EventArgs e)
        {
            var page = new game212();
            await Navigation.PushAsync(page);
        }
        private async void game213(object sender, EventArgs e)
        {
            var page = new game213();
            await Navigation.PushAsync(page);
        }
        private async void game214(object sender, EventArgs e)
        {
            var page = new game214();
            await Navigation.PushAsync(page);
        }
        private async void game215(object sender, EventArgs e)
        {
            var page = new game215();
            await Navigation.PushAsync(page);
        }
        private async void game216(object sender, EventArgs e)
        {
            var page = new game216();
            await Navigation.PushAsync(page);
        }
        private async void game217(object sender, EventArgs e)
        {
            var page = new game217();
            await Navigation.PushAsync(page);
        }
        private async void game218(object sender, EventArgs e)
        {
            var page = new game218();
            await Navigation.PushAsync(page);
        }
    }
}