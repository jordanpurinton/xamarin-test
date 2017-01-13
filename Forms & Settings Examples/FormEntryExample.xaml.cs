using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class FormEntryExample : ContentPage
	{
		public FormEntryExample()
		{
			InitializeComponent();
		}

		//void Handle_Completed(object sender, System.EventArgs e)
		//{
		//	label.Text = "Finished!";
		//}

		void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
		{
			label2.Text = e.NewTextValue;
		}
	}
}
