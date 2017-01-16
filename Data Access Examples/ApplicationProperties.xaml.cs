using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class ApplicationProperties : ContentPage
	{

		private const string TitleKey = "Name";
		private const string NotificationsEnabledKey = "NotificationsEnabled";

		void Handle_OnChanged(object sender, Xamarin.Forms.ToggledEventArgs e)
		{

			Application.Current.Properties[TitleKey] = title.Text;

		}

		public ApplicationProperties()
		{


			InitializeComponent();
	

			// For storage
			if(Application.Current.Properties.ContainsKey(TitleKey)) 
				title.Text = Application.Current.Properties["Name"].ToString();

			if (Application.Current.Properties.ContainsKey("NotificationsEnabled"))
				notificationsEnabled.On = (bool) Application.Current.Properties["NotificationsEnabled"];
		}

		void Handle_Completed(object sender, System.EventArgs e)
		{
			throw new NotImplementedException();
		}


		protected override void OnDisappearing()
		{
			base.OnDisappearing(); // needed for apps w/ multiple pages
		}
	}
}
