using App5.Models;
using App5.ViewModels;
using App5.Views;
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
    public partial class CatalogPage : ContentPage
    {
  
        public CatalogPage()
        {
            InitializeComponent();
        }

        private async void zeroone(object sender, EventArgs e)
        {
            more1 page = new more1();
            await Navigation.PushAsync(page);
        }

        void OnPanUpdated(object sender, PanUpdatedEventArgs e)
        {
            this.Navigation.PopAsync();
        }
        private async void onetwo(object sender, EventArgs e)
        {
            more2 page = new more2();
            await Navigation.PushAsync(page);
        }
        private async void twothree(object sender, EventArgs e)
        {
            more3 page = new more3();
            await Navigation.PushAsync(page);
        }
        private async void threefour(object sender, EventArgs e)
        {
            more4 page = new more4();
            await Navigation.PushAsync(page);
        }

        private async void fourfive(object sender, EventArgs e)
        {
            more5 page = new more5();
            await Navigation.PushAsync(page);
        }

        private async void fivesix(object sender, EventArgs e)
        {
            more6 page = new more6();
            await Navigation.PushAsync(page);
        }

    }
}