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
    public partial class tasks : ContentPage
    {
        public tasks()
        {
            InitializeComponent();
        }
        void OnPanUpdated(object sender, PanUpdatedEventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}