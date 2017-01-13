using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class MasterDetailPage : ContentPage
	{
		public MasterDetailPage()
		{
			InitializeComponent();

			listView.ItemsSource = new List<Contact> {
				new Contact {
					Name = "Han Solo",
					ImageUrl="http://lorempixel.com/100/100/people/1",
					Status ="Never tell me the odds"},

				new Contact {
					Name = "Luke Skywalker",
					ImageUrl="http://lorempixel.com/100/100/people/2",
					Status ="I have a bad feeling about this"}
			};
		}

		void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			if(e.SelectedItem == null){
				return;
			}

			var contact = e.SelectedItem as Contact;
			Navigation.PushAsync(new ContactDetailPage(contact));
			listView.SelectedItem = null; // explicitly deselect the contact so it isn't highlighted
		}
	}
}
