﻿using System;
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
        public EntryForm()
        {
            InitializeComponent();
        }
    }
}