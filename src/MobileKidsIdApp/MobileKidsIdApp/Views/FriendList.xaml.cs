﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MobileKidsIdApp.Views
{
    public partial class FriendList : ContentPage
    {
        public FriendList()
        {
            InitializeComponent();
        }

        protected override async void OnDisappearing()
        {
            base.OnDisappearing();
            await ((ViewModels.FriendList)BindingContext).SaveDataAsync();
        }
    }
}
