using Xamarin.Forms;
using System;

namespace HelloWorld
{
	public partial class App : Application
	{
		private const string TitleKey = "Name";
		private const string NotificationsEnabledKey = "NotificationsEnabled";

		public App()
		{
			InitializeComponent();

			MainPage = new ApplicationProperties(); 	// switch this to a new instance of any
            									   // of the other examples to view that page
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}

		public string Title
		{
			get{
				if (Properties.ContainsKey(TitleKey))
					return Properties[TitleKey].ToString();

				return "";

				}

			set
			{
				Properties[TitleKey] = value;
			}
		}

		public string NotificationsEnabled
		{
			get
			{
				if (Properties.ContainsKey(NotificationsEnabledKey))
					return (bool) Properties[NotificationsEnabledKey];
			}			
			set
			{
				Properties[NotificationsEnabledKey] = value;
			}
		}
	}
}
