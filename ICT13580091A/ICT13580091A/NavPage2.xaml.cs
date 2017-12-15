﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ICT13580091A
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NavPage2 : ContentPage
	{
		public NavPage2 ()
		{
			InitializeComponent ();

            NextButton.Clicked += NextButton_Clicked;
            backButton.Clicked += BackButton_Clicked;
		}

        private void BackButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void NextButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavPage3());
        }
    }
}