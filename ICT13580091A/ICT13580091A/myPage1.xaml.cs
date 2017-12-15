using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ICT13580091A
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class myPage1 : ContentPage
	{
		public myPage1 ()
		{
			InitializeComponent ();

            NextButton.Clicked += NextButton_Clicked;
		}

        private void NextButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new myPage2());
        }
    }
}