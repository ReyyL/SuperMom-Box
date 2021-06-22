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
    public partial class Hacks : ContentPage
    {

        public Hacks()
        {
            InitializeComponent();
        }

        public async void one(object sender, EventArgs e)
        {
            var page = new Hacks1();
            await Navigation.PushAsync(page);
        }
        void OnPanUpdated(object sender, PanUpdatedEventArgs e)
        {
            this.Navigation.PopAsync();
        }
        public async void two(object sender, EventArgs e)
        {
            var page = new Hacks2();
            await Navigation.PushAsync(page);
        }

        public async void three(object sender, EventArgs e)
        {
            var page = new Hacks3();
            await Navigation.PushAsync(page);
        }

        public async void four(object sender, EventArgs e)
        {
            var page = new Hacks4();
            await Navigation.PushAsync(page);
        }
        public async void five(object sender, EventArgs e)
        {
            var page = new Hacks5();
            await Navigation.PushAsync(page);
        }

        public async void six(object sender, EventArgs e)
        {
            var page = new Hacks6();
            await Navigation.PushAsync(page);
        }


    }
}