using App5.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddVideoPage : ContentPage
    {
        public int videoType;
        public AddVideoPage(int id)
        {
            InitializeComponent();
            videoType = id;
        }
        public  void AddVideo(object sender,EventArgs e)
        {
            var user = App.Database.GetItem(LoginPage.UserId);
            var sb = new StringBuilder(user.Videos);
            sb.Append("ↂ");
            sb.Append(videoType);
            sb.Append("~");
            sb.Append(text.Text);
            sb.Append("~");
            sb.Append(source.Text);
            user.Videos = sb.ToString().Trim('ↂ');
            App.Database.SaveItem(user);
            this.Navigation.PopAsync();
        }
    }
}