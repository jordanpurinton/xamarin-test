﻿using Xamarin.Forms;

namespace HelloWorld
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new FormEntryExample(); 	// switch this to a new instance of any
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
	}
}
