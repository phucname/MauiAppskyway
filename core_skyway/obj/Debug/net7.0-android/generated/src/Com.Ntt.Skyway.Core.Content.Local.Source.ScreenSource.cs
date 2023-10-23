using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Core.Content.Local.Source {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='ScreenSource']"
	[global::Android.Runtime.Register ("com/ntt/skyway/core/content/local/source/ScreenSource", DoNotGenerateAcw=true)]
	public sealed partial class ScreenSource : global::Com.Ntt.Skyway.Core.Content.Local.Source.VideoSource {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='ScreenSource']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.Ntt.Skyway.Core.Content.Local.Source.ScreenSource Instance {
			get {
				const string __id = "INSTANCE.Lcom/ntt/skyway/core/content/local/source/ScreenSource;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Local.Source.ScreenSource> (__v.Handle, JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/content/local/source/ScreenSource", typeof (ScreenSource));

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

		internal ScreenSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='ScreenSource']/method[@name='setup' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("setup", "(Landroid/content/Context;Landroid/content/Intent;)V", "")]
		public static unsafe void Setup (global::Android.Content.Context context, global::Android.Content.Intent mediaProjectionPermissionResultData)
		{
			const string __id = "setup.(Landroid/content/Context;Landroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((mediaProjectionPermissionResultData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaProjectionPermissionResultData).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (mediaProjectionPermissionResultData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='ScreenSource']/method[@name='startCapturing' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("startCapturing", "(III)V", "")]
		public static unsafe void StartCapturing (int width, int height, int frameRate)
		{
			const string __id = "startCapturing.(III)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (width);
				__args [1] = new JniArgumentValue (height);
				__args [2] = new JniArgumentValue (frameRate);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='ScreenSource']/method[@name='stopCapturing' and count(parameter)=0]"
		[Register ("stopCapturing", "()V", "")]
		public static unsafe void StopCapturing ()
		{
			const string __id = "stopCapturing.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

	}
}
