using Android.Content;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.ControlGallery.Android;
using Xamarin.Forms.Controls;
using Xamarin.Forms.Platform.Android;

[assembly: Dependency(typeof(PlatformTestSuite))]
namespace Xamarin.Forms.ControlGallery.Android
{
	public class PlatformTestSuite : IPlatformTestSuite
	{
		global::Android.Content.Context _context;

		public PlatformTestSuite(Context context) => _context = context;

		public void Run()
		{
			var x = new Label { Text = "foo" };
			var renderer = Platform.Android.Platform.CreateRendererWithContext(x, _context);
			var tv = renderer.View as ViewRenderer<Label, TextView>;
			var ftv = tv.Control;

			NUnit.Framework.Assert.That(ftv.Text == x.Text);
		}
	}
}