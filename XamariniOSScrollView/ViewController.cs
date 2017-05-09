using System;
using CoreGraphics;
using UIKit;
using Foundation;

namespace XamariniOSScrollView
{
	public partial class ViewController : UIViewController
	{
		UIScrollView scrollView;
		UIImageView imageView;
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			scrollView = new UIScrollView(new CGRect(0, 0, View.Frame.Width, View.Frame.Height));
			View.AddSubview(scrollView);

			imageView = new UIImageView(UIImage.FromFile("Xamarin.jpg"));
			scrollView.ContentSize = imageView.Image.Size;
			scrollView.AddSubview(imageView);
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
