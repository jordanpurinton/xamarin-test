﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class HomePage : ContentPage
	{
		public HomePage()
		{
			InitializeComponent();
		}

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new IntroductionPage());
			//await Navigation.PushModalAsync(new IntroductionPage()); if we want to display modal page instead
		}

	}
}
