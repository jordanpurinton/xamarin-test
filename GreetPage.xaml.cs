using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class GreetPage : ContentPage
	{

		public GreetPage()
		{
			InitializeComponent();
			valueSlider.Value = 0.5; // explicitly setting slider val
		}

		//void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
		//{
		//	sliderValLabel.Text = String.Format("Value is {0:F2}", e.NewValue); // when slider is moved
		//}

		// Instead of using this event handler, we used data binding in GreetPage.xaml


	}
}