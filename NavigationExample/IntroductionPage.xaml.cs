using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class IntroductionPage : ContentPage
	{
		public IntroductionPage()
		{
			InitializeComponent();
			NavigationPage.SetHasBackButton(this, false);
		}

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PopAsync(); // async and await go hand in hand
		}
	}
}
