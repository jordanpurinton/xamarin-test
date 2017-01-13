using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class AbsoluteLayoutPage : ContentPage
	{
		public AbsoluteLayoutPage()
		{
			InitializeComponent();

			//var layout = new AbsoluteLayout();
			//Content = layout;

			//var box = new BoxView { Color = Color.Aqua };
			//layout.Children.Add(box
			//                    , new Rectangle(0, 0, 1, 1)
			//                    , AbsoluteLayoutFlags.All);
			//AbsoluteLayout.SetLayoutBounds(box, new Rectangle(0, 0, 1, 1));
			//AbsoluteLayout.SetLayoutFlags(box, AbsoluteLayoutFlags.HeightProportional);
		}
	}
}
