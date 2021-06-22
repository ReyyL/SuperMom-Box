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
    public partial class boxgames5 : ContentPage
    {
        public boxgames5()
        {
            InitializeComponent();
        }
        private async void game51(object sender, EventArgs e)
        {
            var page = new box51();
            await Navigation.PushAsync(page);
        }
        private async void game52(object sender, EventArgs e)
        {
            var page = new box52();
            await Navigation.PushAsync(page);
        }
        private async void game53(object sender, EventArgs e)
        {
            var page = new box53();
            await Navigation.PushAsync(page);
        }
        private async void game54(object sender, EventArgs e)
        {
            var page = new box54();
            await Navigation.PushAsync(page);
        }
        private async void game55(object sender, EventArgs e)
        {
            var page = new box55();
            await Navigation.PushAsync(page);
        }
        private async void game56(object sender, EventArgs e)
        {
            var page = new box56();
            await Navigation.PushAsync(page);
        }
        private async void game57(object sender, EventArgs e)
        {
            var page = new box57();
            await Navigation.PushAsync(page);
        }
        private async void game58(object sender, EventArgs e)
        {
            var page = new box58();
            await Navigation.PushAsync(page);
        }
        private async void game59(object sender, EventArgs e)
        {
            var page = new box59();
            await Navigation.PushAsync(page);
        }
        private async void game510(object sender, EventArgs e)
        {
            var page = new box510();
            await Navigation.PushAsync(page);
        }
        private async void game511(object sender, EventArgs e)
        {
            var page = new box511();
            await Navigation.PushAsync(page);
        }
        private async void game512(object sender, EventArgs e)
        {
            var page = new box512();
            await Navigation.PushAsync(page);
        }
        private async void game513(object sender, EventArgs e)
        {
            var page = new box513();
            await Navigation.PushAsync(page);
        }
        private async void game514(object sender, EventArgs e)
        {
            var page = new box514();
            await Navigation.PushAsync(page);
        }
        private async void game515(object sender, EventArgs e)
        {
            var page = new box515();
            await Navigation.PushAsync(page);
        }
        private async void game516(object sender, EventArgs e)
        {
            var page = new box516();
            await Navigation.PushAsync(page);
        }
        private async void game517(object sender, EventArgs e)
        {
            var page = new box517();
            await Navigation.PushAsync(page);
        }
        void OnPanUpdated(object sender, PanUpdatedEventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}