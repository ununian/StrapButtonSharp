using System;
using System.Drawing;

using Foundation;
using StrapButtonSharp;
using UIKit;

namespace StrapButtonSample
{
    public partial class RootViewController : UIViewController
    {
        public RootViewController(IntPtr handle)
            : base(handle)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        #region View lifecycle

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.Btn1.DefaultStyle();
            this.Btn1.SetTitle("Default", UIControlState.Normal);
            Btn1.AddAwesomeIcon(AwesomeIcon.Bookmark, true);

            this.Btn2.PrimaryStyle();
            this.Btn2.SetTitle("Primary", UIControlState.Normal);
            Btn2.AddAwesomeIcon(AwesomeIcon.Check, true);

            this.Btn3.SuccessStyle();
            this.Btn3.SetTitle("Success", UIControlState.Normal);
            Btn3.AddAwesomeIcon(AwesomeIcon.DownloadAlt, false);

            this.Btn4.InfoStyle();
            this.Btn4.SetTitle("Info", UIControlState.Normal);


            this.Btn5.WarningStyle();
            this.Btn5.SetTitle("Warning", UIControlState.Normal);
            Btn5.AddAwesomeIcon(AwesomeIcon.Cloud, true);

            this.Btn6.DangerStyle();
            this.Btn6.SetTitle("Danger", UIControlState.Normal);
            Btn6.AddAwesomeIcon(AwesomeIcon.Star, false);

            this.Btn7.SuccessStyle();
            this.Btn7.SetTitle(" ", UIControlState.Normal);
            Btn7.AddAwesomeIcon(AwesomeIcon.Calendar, true);

            this.Btn8.SuccessStyle();
            this.Btn8.SetTitle(" ", UIControlState.Normal);
            Btn8.AddAwesomeIcon(AwesomeIcon.Dashboard, false);

            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }

        #endregion
    }
}