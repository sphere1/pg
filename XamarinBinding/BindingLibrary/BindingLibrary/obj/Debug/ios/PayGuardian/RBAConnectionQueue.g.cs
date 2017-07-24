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
	[Register("RBAConnectionQueue", true)]
	public unsafe partial class RBAConnectionQueue : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("RBAConnectionQueue");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public RBAConnectionQueue () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected RBAConnectionQueue (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal RBAConnectionQueue (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("resume")]
		[CompilerGenerated]
		public virtual void Resume ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("resume"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("resume"));
			}
		}
		
		[Export ("run:")]
		[CompilerGenerated]
		public unsafe virtual void Run ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action block)
		{
			if (block == null)
				throw new ArgumentNullException ("block");
			BlockLiteral *block_ptr_block;
			BlockLiteral block_block;
			block_block = new BlockLiteral ();
			block_ptr_block = &block_block;
			block_block.SetupBlock (Trampolines.SDAction.Handler, block);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("run:"), (IntPtr) block_ptr_block);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("run:"), (IntPtr) block_ptr_block);
			}
			block_ptr_block->CleanupBlock ();
			
		}
		
		[Export ("run:afterBlockProcessed:")]
		[CompilerGenerated]
		public unsafe virtual void Run ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action block, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action afterProcessed)
		{
			if (block == null)
				throw new ArgumentNullException ("block");
			if (afterProcessed == null)
				throw new ArgumentNullException ("afterProcessed");
			BlockLiteral *block_ptr_block;
			BlockLiteral block_block;
			block_block = new BlockLiteral ();
			block_ptr_block = &block_block;
			block_block.SetupBlock (Trampolines.SDAction.Handler, block);
			BlockLiteral *block_ptr_afterProcessed;
			BlockLiteral block_afterProcessed;
			block_afterProcessed = new BlockLiteral ();
			block_ptr_afterProcessed = &block_afterProcessed;
			block_afterProcessed.SetupBlock (Trampolines.SDAction.Handler, afterProcessed);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("run:afterBlockProcessed:"), (IntPtr) block_ptr_block, (IntPtr) block_ptr_afterProcessed);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("run:afterBlockProcessed:"), (IntPtr) block_ptr_block, (IntPtr) block_ptr_afterProcessed);
			}
			block_ptr_block->CleanupBlock ();
			block_ptr_afterProcessed->CleanupBlock ();
			
		}
		
		[Export ("run:processingDelay:afterBlockProcessed:")]
		[CompilerGenerated]
		public unsafe virtual void Run ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action block, global::System.Double processingDelay, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action afterProcessed)
		{
			if (block == null)
				throw new ArgumentNullException ("block");
			if (afterProcessed == null)
				throw new ArgumentNullException ("afterProcessed");
			BlockLiteral *block_ptr_block;
			BlockLiteral block_block;
			block_block = new BlockLiteral ();
			block_ptr_block = &block_block;
			block_block.SetupBlock (Trampolines.SDAction.Handler, block);
			BlockLiteral *block_ptr_afterProcessed;
			BlockLiteral block_afterProcessed;
			block_afterProcessed = new BlockLiteral ();
			block_ptr_afterProcessed = &block_afterProcessed;
			block_afterProcessed.SetupBlock (Trampolines.SDAction.Handler, afterProcessed);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_Double_IntPtr (this.Handle, Selector.GetHandle ("run:processingDelay:afterBlockProcessed:"), (IntPtr) block_ptr_block, processingDelay, (IntPtr) block_ptr_afterProcessed);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_Double_IntPtr (this.SuperHandle, Selector.GetHandle ("run:processingDelay:afterBlockProcessed:"), (IntPtr) block_ptr_block, processingDelay, (IntPtr) block_ptr_afterProcessed);
			}
			block_ptr_block->CleanupBlock ();
			block_ptr_afterProcessed->CleanupBlock ();
			
		}
		
		[Export ("suspend")]
		[CompilerGenerated]
		public virtual void Suspend ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("suspend"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("suspend"));
			}
		}
		
	} /* class RBAConnectionQueue */
}
