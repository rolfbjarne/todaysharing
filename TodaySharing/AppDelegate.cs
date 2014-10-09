using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace TodaySharing
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		UIWindow window;

		UIViewController vc;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			window = new UIWindow (UIScreen.MainScreen.Bounds);

			vc = new UIViewController ();
			vc.View.BackgroundColor = UIColor.Blue;
			window.RootViewController = vc;

			UIColor lastColor = UIColor.Green;
			NSTimer.CreateRepeatingScheduledTimer (1, () => {
				var defs = new NSUserDefaults ("group.com.xamarin.todaysharing", NSUserDefaultsType.SuiteName);
				var value = defs.ValueForKey (new NSString ("key"));
				if (value == null) {
					if (lastColor == UIColor.Yellow)
						lastColor = UIColor.Orange;
					else 
						lastColor = UIColor.Yellow;
					vc.View.BackgroundColor = lastColor;
				} else {
					vc.View.BackgroundColor = UIColor.Green;
				}
			});

			window.MakeKeyAndVisible ();
			
			return true;
		}
	}
}

