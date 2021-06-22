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
    public partial class boxgames3 : ContentPage
    {
        public boxgames3()
        {
            InitializeComponent();
        }
        private async void game31(object sender, EventArgs e)
        {
            var page = new box31();
            await Navigation.PushAsync(page);
        }
        private async void game32(object sender, EventArgs e)
        {
            var page = new box32();
            await Navigation.PushAsync(page);
        }
        private async void game33(object sender, EventArgs e)
        {
            var page = new box33();
            await Navigation.PushAsync(page);
        }
        private async void game34(object sender, EventArgs e)
        {
            var page = new box34();
            await Navigation.PushAsync(page);
        }
        private async void game35(object sender, EventArgs e)
        {
            var page = new box35();
            await Navigation.PushAsync(page);
        }
        private async void game36(object sender, EventArgs e)
        {
            var page = new box36();
            await Navigation.PushAsync(page);
        }
        private async void game37(object sender, EventArgs e)
        {
            var page = new box37();
            await Navigation.PushAsync(page);
        }
        private async void game38(object sender, EventArgs e)
        {
            var page = new box38();
            await Navigation.PushAsync(page);
        }
        private async void game39(object sender, EventArgs e)
        {
            var page = new box39();
            await Navigation.PushAsync(page);
        }
        private async void game310(object sender, EventArgs e)
        { 
            var page = new box310();
            await Navigation.PushAsync(page);
        }
        private async void game311(object sender, EventArgs e)
        {
            var page = new box311();
            await Navigation.PushAsync(page);
        }
        private async void game312(object sender, EventArgs e)
        {
            var page = new box312();
            await Navigation.PushAsync(page);
        }
        private async void game313(object sender, EventArgs e)
        {
            var page = new box313();
            await Navigation.PushAsync(page);
        }
        private async void game314(object sender, EventArgs e)
        {
            var page = new box314();
            await Navigation.PushAsync(page);
        }
        private async void game315(object sender, EventArgs e)
        {
            var page = new box315();
            await Navigation.PushAsync(page);
        }
        private async void game316(object sender, EventArgs e)
        {
            var page = new box316();
            await Navigation.PushAsync(page);
        }
        private async void game317(object sender, EventArgs e)
        {
            var page = new box317();
            await Navigation.PushAsync(page);
        }
        private async void game318(object sender, EventArgs e)
        {
            var page = new box318();
            await Navigation.PushAsync(page);
        }
        private async void game319(object sender, EventArgs e)
        {
            var page = new box319();
            await Navigation.PushAsync(page);
        }
        private async void game320(object sender, EventArgs e)
        {
            var page = new box320();
            await Navigation.PushAsync(page);
        }
        void OnPanUpdated(object sender, PanUpdatedEventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}