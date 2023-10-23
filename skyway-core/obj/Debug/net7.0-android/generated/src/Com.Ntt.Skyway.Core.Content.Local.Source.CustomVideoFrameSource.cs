using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Core.Content.Local.Source {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='CustomVideoFrameSource']"
	[global::Android.Runtime.Register ("com/ntt/skyway/core/content/local/source/CustomVideoFrameSource", DoNotGenerateAcw=true)]
	public sealed partial class CustomVideoFrameSource : global::Com.Ntt.Skyway.Core.Content.Local.Source.VideoSource {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/content/local/source/CustomVideoFrameSource", typeof (CustomVideoFrameSource));

		internal static new IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal CustomVideoFrameSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='CustomVideoFrameSource']/constructor[@name='CustomVideoFrameSource' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe CustomVideoFrameSource (int width, int height) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(II)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (width);
				__args [1] = new JniArgumentValue (height);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='CustomVideoFrameSource']/method[@name='updateFrame' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int']]"
		[Register ("updateFrame", "(Landroid/graphics/Bitmap;I)V", "")]
		public unsafe void UpdateFrame (global::Android.Graphics.Bitmap bitmap, int rotation)
		{
			const string __id = "updateFrame.(Landroid/graphics/Bitmap;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((bitmap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmap).Handle);
				__args [1] = new JniArgumentValue (rotation);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (bitmap);
			}
		}

	}
}
