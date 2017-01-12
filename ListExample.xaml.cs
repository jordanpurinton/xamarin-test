using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace HelloWorld
{
	public partial class ListExample : ContentPage
	{
		private ObservableCollection<Contact> _contacts;

		public ListExample()
		{
			InitializeComponent();

			// FIRST/THIRD EXAMPLE

			//listView.ItemsSource = new List<Contact>{ // by default this calls toString() which returns fully qualified name
			//	new Contact {
			//		Name = "Han Solo",
			//		ImageUrl="http://lorempixel.com/100/100/people/1",
			//		Status ="Never tell me the odds"},

			//	new Contact {
			//		Name = "Luke Skywalker",
			//		ImageUrl="http://lorempixel.com/100/100/people/2",
			//		Status ="I have a bad feeling about this"}


			// CONTACT GROUP EXAMPLE

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

			// FOURTH EXAMPLE
			_contacts = new ObservableCollection<Contact>{ // by default this calls toString() which returns fully qualified name
				new Contact {
					Name = "Han Solo",
					ImageUrl="http://lorempixel.com/100/100/people/1",
					Status ="Never tell me the odds"},

				new Contact {
					Name = "Luke Skywalker",
					ImageUrl="http://lorempixel.com/100/100/people/2",
					Status ="I have a bad feeling about this"}
			};

			listView.ItemsSource = _contacts;
		}

		// TAPPED/SELECTED EXAMPLE
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

		// CONTEXT ACTION EXAMPLE
		void Call_Clicked(object sender, System.EventArgs e)
		{
			var menuItem = sender as MenuItem;
			var contact = menuItem.CommandParameter as Contact; // we set up a binding expression w/ '.' in the XAML 
																// which refers to the entire context object
			DisplayAlert("Calling", contact.Name, "Dismiss");
		}

		void Delete_Clicked(object sender, System.EventArgs e)
		{
			var contact = (sender as MenuItem).CommandParameter as Contact; // same thing as above, just cleaner
			_contacts.Remove(contact);
		}
	}
}