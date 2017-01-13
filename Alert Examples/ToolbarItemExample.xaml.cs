using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class ToolbarItemExample : ContentPage
	{
		public ToolbarItemExample()
		{
			InitializeComponent();
		}

		void Handle_Activated(object sender, System.EventArgs e)
		{
			DisplayAlert("ACTIVATE", "You activated me!", "Dismiss");
		}
	}
}
