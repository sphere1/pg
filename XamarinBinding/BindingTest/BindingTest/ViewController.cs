using System;
using System.Diagnostics;
using UIKit;
using Foundation;
using PayGuardian;

namespace BindingTest
{
    public partial class ViewController : UIViewController
    {
		// If these 2 variables were commented no error would occur, else MT5216 occurs
		BPNPaymentRequest request;
		PayGuardianTransaction transaction;

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			// Just to see if ViewDidLoad is called
			View.BackgroundColor = UIColor.Blue;

			// FIXME: If the code below is uncommented,
			// an MT0000 error occurs along with a null reference exception description

			//request = new BPNPaymentRequest("1234", null, new NSDecimalNumber("5.00"),
			//                                new NSDecimalNumber("1.00"), null,
			//                               "TENDER_TYPE_CREDIT", "TRANSACTION_TYPE_SALE",
			//                               "paulpgtest", "57!sE@3Fm", @"682000",
			//                               "682001", null, null, null, "TERMINAL_TYPE_INGENICO_BLUETOOTH",
			//                                "TRANSACTION_INDUSTRY_TYPE_RESTAURANT", false, true);
			//transaction = new PayGuardianTransaction(request);
			//transaction.RunOnCompletion((payment, error) =>
			//{

			//}, (state) => 
			//{

			//});
		}

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
