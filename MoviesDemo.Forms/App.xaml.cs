using System;
using System.Collections.Generic;

using Xamarin.Forms;
using MoviesDemo.Core.ViewModels;

namespace MoviesDemo.Forms
{
	public partial class App : Application
	{
		// TODO: 4. Define the Locator as ViewModelLocator in the App class 
		// TODO: 5. Create a Resource dictionary for the Locator in the App.xaml file
		private static ViewModelLocatorForms _locator;

		public static ViewModelLocatorForms Locator
		{
			get
			{
				return _locator ?? (_locator = new ViewModelLocatorForms ());
			}
		}


		public App ()
		{
			InitializeComponent (); 


			// TODO: 8. Set the main page of the app as a NavigationPage of the MovieDetailView
			var movies = new NavigationPage(new MoviesView());
			_locator.NavigationServiceInit (movies);
			MainPage = movies;

		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

