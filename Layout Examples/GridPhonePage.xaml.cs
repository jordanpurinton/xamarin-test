using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class GridPhonePage : ContentPage
	{
		public GridPhonePage()
		{
			InitializeComponent();
			dialedLabel.Text = "Enter number";
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			//
		}
	}
}
