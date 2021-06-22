using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace App5.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Profile";
            //OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            ChangePhoto = new Command(ParentPhoto);
            EditPage = new Command(EditParent);
            OpenKids = new Command(Kids);
            OpenHacks = new Command(Hacks);
            OpenContacts = new Command(Contacts);
            Exit = new Command(OnExit);
        }

        public void ParentPhoto()
        {
            Application.Current.MainPage = new Page();
        }

        public void EditParent()
        {
            Application.Current.MainPage = new Page();
        }

        public void Kids()
        {
            Application.Current.MainPage = new Page();
        }

        public void Hacks()
        {
            Application.Current.MainPage = new Page();
        }
        
        public void Contacts()
        {
            Application.Current.MainPage = new Page();
        }
        
        public void OnExit()
        {
            Application.Current.MainPage = new Page();
        }

        public ICommand ChangePhoto { get; }
        public ICommand EditPage { get; }
        public ICommand OpenKids { get; }
        public ICommand OpenHacks { get; }
        public ICommand OpenContacts { get; }
        public ICommand Exit { get; }
    }
}