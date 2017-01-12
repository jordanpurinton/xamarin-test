using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class ListExample : ContentPage
	{
		public ListExample()
		{
			InitializeComponent();

			listView.ItemsSource = new List<Contact>{ // by default this calls toString() which returns fully qualified name
				new Contact {Name = "Han Solo", ImageUrl="http://lorempixel.com/100/100/people/1"},
				new Contact {Name = "Luke Skywalker", ImageUrl="http://lorempixel.com/100/100/people/2", 
					Status ="I have a bad feeling about this"}

			};
		}
	}
}
