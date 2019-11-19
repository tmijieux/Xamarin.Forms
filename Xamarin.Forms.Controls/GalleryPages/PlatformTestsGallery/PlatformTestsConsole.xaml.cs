using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.Forms.Controls.GalleryPages.PlatformTestsGallery
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PlatformTestsConsole : ContentPage
	{
		public PlatformTestsConsole()
		{
			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			var tests = DependencyService.Resolve<IPlatformTestSuite>();
			if (tests != null)
			{
				tests.Run();
			}
			else
			{
				Done();
			}
		}

		void Done() 
		{
			Results.Children.Add(new Label { Text = "Done" });
		}
	}
}