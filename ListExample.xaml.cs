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

			//FIRST/THIRD EXAMPLE

			listView.ItemsSource = new List<Contact>{ // by default this calls toString() which returns fully qualified name
				new Contact {
					Name = "Han Solo",
					ImageUrl="http://lorempixel.com/100/100/people/1",
					Status ="Never tell me the odds"},

				new Contact {
					Name = "Luke Skywalker",
					ImageUrl="http://lorempixel.com/100/100/people/2",
					Status ="I have a bad feeling about this"}


			// SECOND EXAMPLE

			//listView.ItemsSource = new List<ContactGroup> {
			//	new ContactGroup("H", "H") {
			//		new Contact {
			//			Name = "Han Solo",
			//			ImageUrl="http://lorempixel.com/100/100/people/1",
			//			Status ="Never tell me the odds"
			//		}
			//	},

			//	new ContactGroup("L", "L") {
			//		new Contact {
			//			Name = "Luke Skywalker",
			//			ImageUrl="http://lorempixel.com/100/100/people/2",
			//			Status ="I have a bad feeling about this"
			//		}

			//	}

			//};
			};
		}

		void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
		{
			var contact = e.Item as Contact;
			DisplayAlert("Tapped", contact.Name, "Dismiss");
		}

		void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			var contact = e.SelectedItem as Contact;
			DisplayAlert("Selected", contact.Name, "Dismiss");
		}
	}
}