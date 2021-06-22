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
    public partial class Hacks6 : ContentPage
    {

        public Hacks6()
        {
            InitializeComponent();
        }

        private async void game61(object sender, EventArgs e)
        {
            var page = new game61();
            await Navigation.PushAsync(page);
        }
        private async void game62(object sender, EventArgs e)
        {
            var page = new game62();
            await Navigation.PushAsync(page);
        }
        private async void game63(object sender, EventArgs e)
        {
            var page = new game63();
            await Navigation.PushAsync(page);
        }
        void OnPanUpdated(object sender, PanUpdatedEventArgs e)
        {
            this.Navigation.PopAsync();
        }
        private async void game64(object sender, EventArgs e)
        {
            var page = new game64();
            await Navigation.PushAsync(page);
        }
        private async void game65(object sender, EventArgs e)
        {
            var page = new game65();
            await Navigation.PushAsync(page);
        }
        private async void game66(object sender, EventArgs e)
        {
            var page = new game66();
            await Navigation.PushAsync(page);
        }
        private async void game67(object sender, EventArgs e)
        {
            var page = new game67();
            await Navigation.PushAsync(page);
        }
        private async void game68(object sender, EventArgs e)
        {
            var page = new game68();
            await Navigation.PushAsync(page);
        }
        private async void game69(object sender, EventArgs e)
        {
            var page = new game69();
            await Navigation.PushAsync(page);
        }
        private async void game610(object sender, EventArgs e)
        {
            var page = new game610();
            await Navigation.PushAsync(page);
        }
        private async void game611(object sender, EventArgs e)
        {
            var page = new game611();
            await Navigation.PushAsync(page);
        }
        private async void game612(object sender, EventArgs e)
        {
            var page = new game612();
            await Navigation.PushAsync(page);
        }
    }
}