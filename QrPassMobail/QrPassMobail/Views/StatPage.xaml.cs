﻿using QrPassMobail.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QrPassMobail.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StatPage : ContentPage
    {
        private StatPageViewModel vm;
        public StatPage()
        {
            InitializeComponent();
            vm = (StatPageViewModel)BindingContext;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            vm.OnApperring();
            
        }
    }
}