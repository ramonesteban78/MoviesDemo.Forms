using System;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using MoviesDemo.Core.ViewModels;
using MoviesDemo.Core;
using Xamarin.Forms;
using GalaSoft.MvvmLight.Ioc;

namespace MoviesDemo.Forms
{
	// TODO: 3. Create the ViewModelLocatorForms
	public class ViewModelLocatorForms : ViewModelLocator
	{

		protected override INavigationService CreateNavigationService()
		{
			var navigationService = new NavigationService();

			navigationService.Configure(Const.MOVIES_VIEW, typeof(MoviesView));
			navigationService.Configure(Const.MOVIESDATAIL_VIEW, typeof(MovieDetailView));


			return navigationService;
		}

		public void NavigationServiceInit(NavigationPage page)
		{
			var navigationService = (NavigationService)SimpleIoc.Default.GetInstance<INavigationService> ();
			navigationService.Initialize (page);
		}
	}
}

