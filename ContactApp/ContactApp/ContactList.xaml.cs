using ContactApp.Model;
using ContactApp.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ContactApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactList : ContentPage
    {
        public ContactList(Dane danelok)
        {
            InitializeComponent();
            BindingContext = danelok;
            /*list.ItemsSource = new ObservableCollection<Contact>() {
                new Contact()
                {
                    ContactId=1,
                    Name= "Marcin Wołkowicz",
                    AditionalInfo="asdasd",
                    PhoneNr = "606499884",
                    Email = "biuro@tuttoarts.pl"

                },
                 new Contact()
                {
                    ContactId=2,
                    Name= "Iwona Wołkowicz",
                    AditionalInfo="afsdasd",
                     PhoneNr = "606499884",
                    Email = "biuro@tuttoarts.pl"

                },
                  new Contact()
                {
                    ContactId=3,
                    Name= "Łucja Wołkowicz",
                    AditionalInfo="asdafvfvsd",
                     PhoneNr = "606499884",
                    Email = "biuro@tuttoarts.pl"

                },
                   new Contact()
                {
                    ContactId=4,
                    Name= "Franek Wołkowicz",
                    AditionalInfo="avfvfvsdasd",
                     PhoneNr = "606499884",
                    Email = "biuro@tuttoarts.pl"

                }
            };
            */
            //Dane dane = new Dane();
            list.ItemsSource = danelok.contacts;
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new EntryForm());
        }

        async private void list_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var contactselected = e.SelectedItem as Contact;
            await Navigation.PushAsync(new ContactDetail(contactselected));
            list.SelectedItem = null;
        }

       
    }
}