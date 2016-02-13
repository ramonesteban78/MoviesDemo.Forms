using System;
using System.Collections.Generic;

using Xamarin.Forms;
using MoviesDemo.Core.ViewModels;
using MoviesDemo.Core.Models;
using Xamarin.Forms.Xaml;

namespace MoviesDemo.Forms
{
	[XamlCompilation (XamlCompilationOptions.Compile)]
	public partial class MoviesView : ContentPage
	{
		private readonly MoviesViewModel _vm;

		// TODO: 6. Assign the Binding Context in the xaml page MoviesView
		// TODO: 9. Apply design to the MoviewsView.xaml using Gorilla Player
		public MoviesView ()
		{
			InitializeComponent ();
			// TODO: 10. Set the Binding Context accessing the ViewModelLocatorForms
			_vm = App.Locator.Movies;
			this.BindingContext = _vm;

			listMovies.ItemSelected += (object sender, SelectedItemChangedEventArgs e) => {
				_vm.SelectMovieCommand.Execute(e.SelectedItem);
			};
		}

		protected override void OnAppearing ()
		{
			// TODO: 11. Call the Start method on the OnAppearing event
			base.OnAppearing ();
			_vm.Start ();
		}
	}
}

