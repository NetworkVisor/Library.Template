using System;
using AppKit;
using Foundation;

namespace NetworkVisor.Core.Test.MacOS.IntegrationTests
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
	{
	}

        public override void ViewDidLoad()
	{
            base.ViewDidLoad();

		// Do any additional setup after loading the view.
	}

        public override NSObject RepresentedObject
        {
	    get => base.RepresentedObject;
            set
            {
			base.RepresentedObject = value;

			// Update the view, if already loaded.
		}
	}
    }
}
