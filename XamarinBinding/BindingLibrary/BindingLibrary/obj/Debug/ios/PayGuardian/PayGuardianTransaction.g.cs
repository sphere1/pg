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
	[Register("PayGuardianTransaction", true)]
	public unsafe partial class PayGuardianTransaction : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PayGuardianTransaction");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PayGuardianTransaction (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PayGuardianTransaction (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithPaymentRequest:")]
		[CompilerGenerated]
		public PayGuardianTransaction (BPNPaymentRequest request)
			: base (NSObjectFlag.Empty)
		{
			if (request == null)
				throw new ArgumentNullException ("request");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithPaymentRequest:"), request.Handle), "initWithPaymentRequest:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithPaymentRequest:"), request.Handle), "initWithPaymentRequest:");
			}
		}
		
		[Export ("cancel")]
		[CompilerGenerated]
		public virtual void Cancel ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("cancel"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cancel"));
			}
		}
		
		[Export ("ingenicoPushConfig:")]
		[CompilerGenerated]
		public unsafe virtual void IngenicoPushConfig ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action configPushComplete)
		{
			if (configPushComplete == null)
				throw new ArgumentNullException ("configPushComplete");
			BlockLiteral *block_ptr_configPushComplete;
			BlockLiteral block_configPushComplete;
			block_configPushComplete = new BlockLiteral ();
			block_ptr_configPushComplete = &block_configPushComplete;
			block_configPushComplete.SetupBlock (Trampolines.SDAction.Handler, configPushComplete);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("ingenicoPushConfig:"), (IntPtr) block_ptr_configPushComplete);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("ingenicoPushConfig:"), (IntPtr) block_ptr_configPushComplete);
			}
			block_ptr_configPushComplete->CleanupBlock ();
			
		}
		
		[Export ("runOnCompletion:onStateChanged:")]
		[CompilerGenerated]
		public unsafe virtual void RunOnCompletion ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<BPNPayment, NSError> onCompletion, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<PayGuardianTransactionState> onStateChanged)
		{
			if (onCompletion == null)
				throw new ArgumentNullException ("onCompletion");
			if (onStateChanged == null)
				throw new ArgumentNullException ("onStateChanged");
			BlockLiteral *block_ptr_onCompletion;
			BlockLiteral block_onCompletion;
			block_onCompletion = new BlockLiteral ();
			block_ptr_onCompletion = &block_onCompletion;
			block_onCompletion.SetupBlock (Trampolines.SDActionArity2V0.Handler, onCompletion);
			BlockLiteral *block_ptr_onStateChanged;
			BlockLiteral block_onStateChanged;
			block_onStateChanged = new BlockLiteral ();
			block_ptr_onStateChanged = &block_onStateChanged;
			block_onStateChanged.SetupBlock (Trampolines.SDActionArity1V0.Handler, onStateChanged);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("runOnCompletion:onStateChanged:"), (IntPtr) block_ptr_onCompletion, (IntPtr) block_ptr_onStateChanged);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("runOnCompletion:onStateChanged:"), (IntPtr) block_ptr_onCompletion, (IntPtr) block_ptr_onStateChanged);
			}
			block_ptr_onCompletion->CleanupBlock ();
			block_ptr_onStateChanged->CleanupBlock ();
			
		}
		
		[Export ("testMagtek")]
		[CompilerGenerated]
		public virtual void TestMagtek ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("testMagtek"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("testMagtek"));
			}
		}
		
		[Export ("UNIPAY_startEmv")]
		[CompilerGenerated]
		public virtual void UNIPAY_startEmv ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("UNIPAY_startEmv"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("UNIPAY_startEmv"));
			}
		}
		
		[CompilerGenerated]
		public virtual bool RetryOnBadRead {
			[Export ("retryOnBadRead")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("retryOnBadRead"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("retryOnBadRead"));
				}
			}
			
			[Export ("setRetryOnBadRead:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setRetryOnBadRead:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setRetryOnBadRead:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PayGuardianTransactionState State {
			[Export ("state", ArgumentSemantic.UnsafeUnretained)]
			get {
				PayGuardianTransactionState ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PayGuardianTransactionState) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("state"));
					} else {
						ret = (PayGuardianTransactionState) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("state"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PayGuardianTransactionState) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("state"));
					} else {
						ret = (PayGuardianTransactionState) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("state"));
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.IntPtr UniMag {
			[Export ("uniMag", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("uniMag"));
				} else {
					return global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("uniMag"));
				}
			}
			
			[Export ("setUniMag:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUniMag:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUniMag:"), value);
				}
			}
		}
		
	} /* class PayGuardianTransaction */
}
