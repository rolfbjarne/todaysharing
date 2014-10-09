using System;
using System.Drawing;

using NotificationCenter;
using Foundation;
using Social;
using UIKit;

namespace TapCounter
{
	public partial class TodayViewController : SLComposeServiceViewController, INCWidgetProviding
	{
		public TodayViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();

			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Do any additional setup after loading the view.
			View.BackgroundColor = UIColor.LightGray;
		}

		public override void TouchesEnded (NSSet touches, UIEvent evt)
		{
			base.TouchesEnded (touches, evt);

			var defs = new NSUserDefaults ("group.com.xamarin.todaysharing", NSUserDefaultsType.SuiteName);
			if (defs.ValueForKey (new NSString ("key")) != null) {
				defs.RemoveObject ("key");
				View.BackgroundColor = UIColor.DarkGray;
			} else {
				defs.SetValueForKey (new NSString ("value"), new NSString ("key"));
				View.BackgroundColor = UIColor.Green;
			}
			defs.Synchronize ();
		}

		public void WidgetPerformUpdate (Action<NCUpdateResult> completionHandler)
		{
			// Perform any setup necessary in order to update the view.

			// If an error is encoutered, use NCUpdateResultFailed
			// If there's no update required, use NCUpdateResultNoData
			// If there's an update, use NCUpdateResultNewData

			completionHandler (NCUpdateResult.NewData);
		}
	}
}

