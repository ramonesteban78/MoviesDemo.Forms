using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace MoviesDemo.Forms.UITests
{
	[TestFixture (Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests (Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest ()
		{
			app = AppInitializer.StartApp (platform);
		}

		[Test]
		public void TestMoviesDemo ()
		{
			app.ScrollDown();
			app.Tap(x => x.Class("Xamarin_Forms_Platform_iOS_LabelRenderer").Index(3));
			app.Screenshot("Tapped on view Xamarin_Forms_Platform_iOS_LabelRenderer");
			app.Tap(x => x.Text("Movies Demo"));
			app.Screenshot("Tapped on view UILabel with Text: 'Movies Demo'");
			Assert.IsTrue (true);
		}

		[Test]
		public void TestEnMicrosoft ()
		{
			app.ScrollDown();
			app.Tap(x => x.Class("Xamarin_Forms_Platform_iOS_LabelRenderer").Index(6));
			app.Screenshot("Tapped on view Xamarin_Forms_Platform_iOS_LabelRenderer");
			app.Tap(x => x.Marked("Movies Demo"));
			app.Screenshot("Tapped on view UINavigationItemButtonView");
			app.ScrollDown();
			app.Tap(x => x.Class("UIImageView").Index(20));
			app.Screenshot("Tapped on view UIImageView");
			app.Tap(x => x.Marked("Movies Demo"));
			app.Screenshot("Tapped on view UINavigationItemButtonView");
		}
	}
}

