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
    public partial class ContentPage1 : ContentPage
    {
        public ContentPage1()
        {
            InitializeComponent();
        }

        private async void Content(object sender, EventArgs e)
        {
            Content page = new Content();
            await Navigation.PushAsync(page);
        }

        void OnPanUpdated(object sender, PanUpdatedEventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}