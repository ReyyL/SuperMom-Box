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
    public partial class Hacks5 : ContentPage
    {

        public Hacks5()
        {
            InitializeComponent();
        }

        private async void game51(object sender, EventArgs e)
        {
            var page = new game51();
            await Navigation.PushAsync(page);
        }
        private async void game52(object sender, EventArgs e)
        {
            var page = new game52();
            await Navigation.PushAsync(page);
        }
        void OnPanUpdated(object sender, PanUpdatedEventArgs e)
        {
            this.Navigation.PopAsync();
        }
        private async void game53(object sender, EventArgs e)
        {
            var page = new game53();
            await Navigation.PushAsync(page);
        }
        private async void game54(object sender, EventArgs e)
        {
            var page = new game54();
            await Navigation.PushAsync(page);
        }
        private async void game55(object sender, EventArgs e)
        {
            var page = new game55();
            await Navigation.PushAsync(page);
        }
        private async void game56(object sender, EventArgs e)
        {
            var page = new game56();
            await Navigation.PushAsync(page);
        }
        private async void game57(object sender, EventArgs e)
        {
            var page = new game57();
            await Navigation.PushAsync(page);
        }
        private async void game58(object sender, EventArgs e)
        {
            var page = new game58();
            await Navigation.PushAsync(page);
        }
        private async void game59(object sender, EventArgs e)
        {
            var page = new game59();
            await Navigation.PushAsync(page);
        }
        private async void game510(object sender, EventArgs e)
        {
            var page = new game510();
            await Navigation.PushAsync(page);
        }
        private async void game511(object sender, EventArgs e)
        {
            var page = new game511();
            await Navigation.PushAsync(page);
        }
    }
}