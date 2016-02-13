using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoviesDemo.Forms
{
	[XamlCompilation (XamlCompilationOptions.Compile)]
	public partial class MovieTemplate : ContentView
	{
		public MovieTemplate ()
		{
			InitializeComponent ();
//			Label lbl = new Label ();
//			lbl.LineBreakMode = LineBreakMode.CharacterWrap;
			Image img = new Image();
			img.Aspect = Aspect.Fill;
		}
	}
}

