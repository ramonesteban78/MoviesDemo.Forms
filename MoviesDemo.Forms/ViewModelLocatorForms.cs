using System;
using MoviesDemo.ViewModels;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;

namespace MoviesDemo.Forms
{
	// TODO: 3. Create the ViewModelLocatorForms
	public class ViewModelLocatorForms : ViewModelLocator
	{
		public ViewModelLocatorForms() : base()
		{

		}

		protected override INavigationService CreateNavigationService()
		{
			var navigationService = new NavigationService();

			navigationService.Configure(Const.MOVIES_VIEW, typeof(MoviesView));
			navigationService.Configure(Const.MOVIESDATAIL_VIEW, typeof(MovieDetailView));

			return navigationService;
		}
	}
}

