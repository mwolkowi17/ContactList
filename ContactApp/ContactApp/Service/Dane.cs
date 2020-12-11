using ContactApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ContactApp.Service
{
    public class Dane
    {
        public ObservableCollection<Contact> contacts = new ObservableCollection<Contact>()
        {
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
        }

        
    }

