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
		// TODO: 5. Assign the Binding Context in the xaml page MoviesView
		// TODO: 8. Preparar el archivo SampleData.json para la previsualización de datos con Gorilla
		// TODO: 10. Aplicar diseño a la vista MoviesView.xaml usando Gorilla Player
		public MoviesView ()
		{
			InitializeComponent ();
			_vm = App.Locator.Movies;
			this.BindingContext = _vm;

			listMovies.ItemSelected += (object sender, SelectedItemChangedEventArgs e) => {
				_vm.SelectMovieCommand.Execute(e.SelectedItem);
			};
		}

		protected override void OnAppearing ()
		{
			// TODO: 6. Call the Start method on the OnAppearing event
			base.OnAppearing ();
			_vm.Start ();
		}
	}
}

