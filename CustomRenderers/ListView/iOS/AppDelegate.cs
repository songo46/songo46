using Foundation;
using UIKit;

namespace CustomRenderer.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();

			App.Description = "Custom UITableView + UICell";
			LoadApplication (new App ());

			return base.FinishedLaunching (app, options);
		}
	}
}

