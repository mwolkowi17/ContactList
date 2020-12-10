using ContactApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ContactApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryForm : ContentPage
    {
        public Contact contact_new;
        public EntryForm()
        {
            InitializeComponent();
            contact_new = new Contact();

        }

        private void EntryCell_Completed(object sender, EventArgs e)
        {
            contact_new.Name = namecell.Text;
            
        }

        private void EntryCell_Completed_1(object sender, EventArgs e)
        {
            contact_new.AditionalInfo = additionlcell.Text;
        }

         private void Button_Clicked(object sender, EventArgs e)
        {
            contact_new.Name = namecell.Text;
            DisplayAlert("Contact Added", contact_new.Name, "Ok");
            Navigation.PopAsync();
        }
    }
}