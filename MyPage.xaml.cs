using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class QuotesPage : ContentPage
	{

		string[] quotes = { "Meme1", "Meme2", "Meme3" };
		int index = 0;

		public QuotesPage()
		{
			InitializeComponent();
			slider.Value = 16;
			quoteLabel.Text = quotes[index];
		}

		void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
		{
			quoteLabel.FontSize = e.NewValue;
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			if (index == 2)
			{
				index = 0;
				quoteLabel.Text = quotes[0];
			}

			else 
			{
				index++;
				quoteLabel.Text = quotes[index];
			}
		}
	}
}
