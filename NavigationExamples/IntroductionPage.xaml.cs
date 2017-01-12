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
			NavigationPage.SetHasBackButton(this, false); // explicitly disable back button
		}

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PopAsync(); // async and await go hand in hand
			//await Navigation.PopAsync(); // if we set this up as a modal page instead
		}

		protected override bool OnBackButtonPressed() // if we want to disable android/windows back button for this page
		{
			return true;
		}
	}
}
