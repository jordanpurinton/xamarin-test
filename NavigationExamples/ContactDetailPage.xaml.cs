using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class ContactDetailPage : ContentPage
	{
		public ContactDetailPage(Contact contact)
		{
			if (contact == null) {
				throw new ArgumentNullException();
			}

			BindingContext = contact;

			InitializeComponent();
		}
	}
}
