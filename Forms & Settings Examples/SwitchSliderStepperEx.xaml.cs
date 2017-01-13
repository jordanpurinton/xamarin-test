using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class SwitchSliderStepperEx : ContentPage
	{
		public SwitchSliderStepperEx()
		{
			InitializeComponent();
		}

		void Handle_Toggled(object sender, Xamarin.Forms.ToggledEventArgs e)
		{
			label.IsVisible = e.Value;
		}

	}
}
