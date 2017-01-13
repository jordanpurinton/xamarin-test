using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class ActionSheetExample : ContentPage
	{
		public ActionSheetExample()
		{
			InitializeComponent();
		}

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			var response = await DisplayActionSheet("Pick one", "CLICK MEE", "ALERT", "Plz click", "Don't press me", "Hello");
			DisplayAlert("You chose", response, "Dismiss");
		}
	}
}
