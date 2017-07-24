//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using SceneKit;
using Security;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace PayGuardian {
	[Register("BPNPaymentRequest", true)]
	public unsafe partial class BPNPaymentRequest : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("BPNPaymentRequest");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected BPNPaymentRequest (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal BPNPaymentRequest (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initInvoiceNumber:pnRefNum:amount:tipAmount:cashBackAmount:tenderType:transactionType:username:password:merchantCode:merchantAccountCode:paymentAccountNumber:token:expirationDate:terminalType:industryType:disableEmv:testMode:")]
		[CompilerGenerated]
		public BPNPaymentRequest (string invoiceNumber, string pnRefNum, NSDecimalNumber amount, NSDecimalNumber tipAmount, NSDecimalNumber cashBackAmount, string tenderType, string transactionType, string username, string password, string merchantCode, string merchantAccountCode, string paymentAccountNumber, string token, string expirationDate, string terminalType, string industryType, bool disableEmv, bool testMode)
			: base (NSObjectFlag.Empty)
		{
			if (invoiceNumber == null)
				throw new ArgumentNullException ("invoiceNumber");
			if (amount == null)
				throw new ArgumentNullException ("amount");
			if (tenderType == null)
				throw new ArgumentNullException ("tenderType");
			if (transactionType == null)
				throw new ArgumentNullException ("transactionType");
			if (username == null)
				throw new ArgumentNullException ("username");
			if (password == null)
				throw new ArgumentNullException ("password");
			if (merchantCode == null)
				throw new ArgumentNullException ("merchantCode");
			if (merchantAccountCode == null)
				throw new ArgumentNullException ("merchantAccountCode");
			if (industryType == null)
				throw new ArgumentNullException ("industryType");
			var nsinvoiceNumber = NSString.CreateNative (invoiceNumber);
			var nspnRefNum = NSString.CreateNative (pnRefNum);
			var nstenderType = NSString.CreateNative (tenderType);
			var nstransactionType = NSString.CreateNative (transactionType);
			var nsusername = NSString.CreateNative (username);
			var nspassword = NSString.CreateNative (password);
			var nsmerchantCode = NSString.CreateNative (merchantCode);
			var nsmerchantAccountCode = NSString.CreateNative (merchantAccountCode);
			var nspaymentAccountNumber = NSString.CreateNative (paymentAccountNumber);
			var nstoken = NSString.CreateNative (token);
			var nsexpirationDate = NSString.CreateNative (expirationDate);
			var nsterminalType = NSString.CreateNative (terminalType);
			var nsindustryType = NSString.CreateNative (industryType);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_bool_bool (this.Handle, Selector.GetHandle ("initInvoiceNumber:pnRefNum:amount:tipAmount:cashBackAmount:tenderType:transactionType:username:password:merchantCode:merchantAccountCode:paymentAccountNumber:token:expirationDate:terminalType:industryType:disableEmv:testMode:"), nsinvoiceNumber, nspnRefNum, amount.Handle, tipAmount == null ? IntPtr.Zero : tipAmount.Handle, cashBackAmount == null ? IntPtr.Zero : cashBackAmount.Handle, nstenderType, nstransactionType, nsusername, nspassword, nsmerchantCode, nsmerchantAccountCode, nspaymentAccountNumber, nstoken, nsexpirationDate, nsterminalType, nsindustryType, disableEmv, testMode), "initInvoiceNumber:pnRefNum:amount:tipAmount:cashBackAmount:tenderType:transactionType:username:password:merchantCode:merchantAccountCode:paymentAccountNumber:token:expirationDate:terminalType:industryType:disableEmv:testMode:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_bool_bool (this.SuperHandle, Selector.GetHandle ("initInvoiceNumber:pnRefNum:amount:tipAmount:cashBackAmount:tenderType:transactionType:username:password:merchantCode:merchantAccountCode:paymentAccountNumber:token:expirationDate:terminalType:industryType:disableEmv:testMode:"), nsinvoiceNumber, nspnRefNum, amount.Handle, tipAmount == null ? IntPtr.Zero : tipAmount.Handle, cashBackAmount == null ? IntPtr.Zero : cashBackAmount.Handle, nstenderType, nstransactionType, nsusername, nspassword, nsmerchantCode, nsmerchantAccountCode, nspaymentAccountNumber, nstoken, nsexpirationDate, nsterminalType, nsindustryType, disableEmv, testMode), "initInvoiceNumber:pnRefNum:amount:tipAmount:cashBackAmount:tenderType:transactionType:username:password:merchantCode:merchantAccountCode:paymentAccountNumber:token:expirationDate:terminalType:industryType:disableEmv:testMode:");
			}
			NSString.ReleaseNative (nsinvoiceNumber);
			NSString.ReleaseNative (nspnRefNum);
			NSString.ReleaseNative (nstenderType);
			NSString.ReleaseNative (nstransactionType);
			NSString.ReleaseNative (nsusername);
			NSString.ReleaseNative (nspassword);
			NSString.ReleaseNative (nsmerchantCode);
			NSString.ReleaseNative (nsmerchantAccountCode);
			NSString.ReleaseNative (nspaymentAccountNumber);
			NSString.ReleaseNative (nstoken);
			NSString.ReleaseNative (nsexpirationDate);
			NSString.ReleaseNative (nsterminalType);
			NSString.ReleaseNative (nsindustryType);
			
		}
		
		[CompilerGenerated]
		public virtual NSDecimalNumber Amount {
			[Export ("amount", ArgumentSemantic.Retain)]
			get {
				NSDecimalNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("amount")));
				} else {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("amount")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSDecimalNumber CashBackAmount {
			[Export ("cashBackAmount", ArgumentSemantic.Retain)]
			get {
				NSDecimalNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("cashBackAmount")));
				} else {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cashBackAmount")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool DisableEmv {
			[Export ("disableEmv")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("disableEmv"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("disableEmv"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string ExpirationDate {
			[Export ("expirationDate", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("expirationDate")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("expirationDate")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string IndustryType {
			[Export ("industryType", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("industryType")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("industryType")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string MerchantAccountCode {
			[Export ("merchantAccountCode", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("merchantAccountCode")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("merchantAccountCode")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string MerchantCode {
			[Export ("merchantCode", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("merchantCode")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("merchantCode")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Password {
			[Export ("password", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("password")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("password")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string PaymentAccountNumber {
			[Export ("paymentAccountNumber", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("paymentAccountNumber")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("paymentAccountNumber")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string PnRefNum {
			[Export ("pnRefNum", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("pnRefNum")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pnRefNum")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual BPNAddress ShippingAddress {
			[Export ("shippingAddress", ArgumentSemantic.Retain)]
			get {
				BPNAddress ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<BPNAddress> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("shippingAddress")));
				} else {
					ret =  Runtime.GetNSObject<BPNAddress> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shippingAddress")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string TenderType {
			[Export ("tenderType", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("tenderType")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("tenderType")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string TerminalType {
			[Export ("terminalType", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("terminalType")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("terminalType")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool TestMode {
			[Export ("testMode")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("testMode"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("testMode"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSDecimalNumber TipAmount {
			[Export ("tipAmount", ArgumentSemantic.Retain)]
			get {
				NSDecimalNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("tipAmount")));
				} else {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("tipAmount")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Token {
			[Export ("token", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("token")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("token")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string TransactionID {
			[Export ("transactionID", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("transactionID")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("transactionID")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string TransactionType {
			[Export ("transactionType", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("transactionType")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("transactionType")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Username {
			[Export ("username", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("username")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("username")));
				}
			}
			
		}
		
	} /* class BPNPaymentRequest */
}
