using ContactApp.Model;
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
        public ContactList()
        {
            InitializeComponent();
            list.ItemsSource = new ObservableCollection<Contact>() {
                new Contact()
                {
                    ContactId=1,
                    Name= "Marcin Wołkowicz",
                    AditionalInfo="asdasd"

                },
                 new Contact()
                {
                    ContactId=2,
                    Name= "Iwona Wołkowicz",
                    AditionalInfo="afsdasd"

                },
                  new Contact()
                {
                    ContactId=3,
                    Name= "Łucja Wołkowicz",
                    AditionalInfo="asdafvfvsd"

                },
                   new Contact()
                {
                    ContactId=4,
                    Name= "Franek Wołkowicz",
                    AditionalInfo="avfvfvsdasd"

                }
            };
            
        }
    }
}