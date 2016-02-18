using System;
using System.Collections.Generic;

using Xamarin.Forms;
using MoviesDemo.Core.ViewModels;
using Xamarin.Forms.Xaml;

namespace MoviesDemo.Forms
{
	[XamlCompilation (XamlCompilationOptions.Compile)]
	public partial class MovieDetailView : ContentPage
	{
		private readonly INavigable _vm;


		// TODO: 11. Diseñar la vista de detalle con Gorilla Player
		// TODO: 12. Assign the Binding Context in the xaml page MovieDetailView
		public MovieDetailView (uint movieId)
		{
			InitializeComponent ();

			_vm = App.Locator.MovieDetail;
			_vm.Activate (movieId);
			_vm.Start ();

			this.BindingContext = _vm;

		}
	}
}

