using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class PopupExample : ContentPage
	{
		Random rnd = new Random();

		public PopupExample()
		{
			InitializeComponent();
		}

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			var response = await DisplayAlert("CHOOSE CAREFULLY", "Don't mess up", "Red wire", "Blue wire");
			int randNum = rnd.Next(1, 3);

			if (response) // red wire
			{
				if (randNum == 1)
				{
					DisplayAlert("WORLD BLEW UP", "You blew it", "Shame");
				}

				else
				{
					DisplayAlert("SAVED THE WORLD", "Great job", "Nice");
				}
			}

			else // blue wire
			{

				if (randNum == 1)
				{
					DisplayAlert("WORLD BLEW UP", "You blew it", "Shame");
				}

				else
				{
					DisplayAlert("SAVED THE WORLD", "Great job", "Nice");
				}
			}
		}
	}
}
