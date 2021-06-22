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
    public partial class boxgames6 : ContentPage
    {
        public boxgames6()
        {
            InitializeComponent();
        }
        private async void game61(object sender, EventArgs e)
        {
            var page = new box61();
            await Navigation.PushAsync(page);
        }
        private async void game62(object sender, EventArgs e)
        {
            var page = new box62();
            await Navigation.PushAsync(page);
        }
        private async void game63(object sender, EventArgs e)
        {
            var page = new box63();
            await Navigation.PushAsync(page);
        }
        private async void game64(object sender, EventArgs e)
        {
            var page = new box64();
            await Navigation.PushAsync(page);
        }
        private async void game65(object sender, EventArgs e)
        {
            var page = new box65();
            await Navigation.PushAsync(page);
        }
        private async void game66(object sender, EventArgs e)
        {
            var page = new box66();
            await Navigation.PushAsync(page);
        }
        private async void game67(object sender, EventArgs e)
        {
            var page = new box67();
            await Navigation.PushAsync(page);
        }
        private async void game68(object sender, EventArgs e)
        {
            var page = new box68();
            await Navigation.PushAsync(page);
        }
        private async void game69(object sender, EventArgs e)
        {
            var page = new box69();
            await Navigation.PushAsync(page);
        }
        private async void game610(object sender, EventArgs e)
        {
            var page = new box610();
            await Navigation.PushAsync(page);
        }
        private async void game611(object sender, EventArgs e)
        {
            var page = new box611();
            await Navigation.PushAsync(page);
        }
        private async void game612(object sender, EventArgs e)
        {
            var page = new box612();
            await Navigation.PushAsync(page);
        }
        private async void game613(object sender, EventArgs e)
        {
            var page = new box613();
            await Navigation.PushAsync(page);
        }
        void OnPanUpdated(object sender, PanUpdatedEventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}