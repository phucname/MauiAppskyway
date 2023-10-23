using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoSink']"
	[Register ("org/webrtc/VideoSink", "", "Org.Webrtc.IVideoSinkInvoker")]
	public partial interface IVideoSink : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoSink']/method[@name='onFrame' and count(parameter)=1 and parameter[1][@type='org.webrtc.VideoFrame']]"
		[Register ("onFrame", "(Lorg/webrtc/VideoFrame;)V", "GetOnFrame_Lorg_webrtc_VideoFrame_Handler:Org.Webrtc.IVideoSinkInvoker, webrtc")]
		void OnFrame (global::Org.Webrtc.VideoFrame? p0);

	}

	[global::Android.Runtime.Register ("org/webrtc/VideoSink", DoNotGenerateAcw=true)]
	internal partial class IVideoSinkInvoker : global::Java.Lang.Object, IVideoSink {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoSink", typeof (IVideoSinkInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IVideoSink? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoSink> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.webrtc.VideoSink'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoSinkInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onFrame_Lorg_webrtc_VideoFrame_;
#pragma warning disable 0169
		static Delegate GetOnFrame_Lorg_webrtc_VideoFrame_Handler ()
		{
			if (cb_onFrame_Lorg_webrtc_VideoFrame_ == null)
				cb_onFrame_Lorg_webrtc_VideoFrame_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnFrame_Lorg_webrtc_VideoFrame_);
			return cb_onFrame_Lorg_webrtc_VideoFrame_;
		}

		static void n_OnFrame_Lorg_webrtc_VideoFrame_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFrame (p0);
		}
#pragma warning restore 0169

		IntPtr id_onFrame_Lorg_webrtc_VideoFrame_;
		public unsafe void OnFrame (global::Org.Webrtc.VideoFrame? p0)
		{
			if (id_onFrame_Lorg_webrtc_VideoFrame_ == IntPtr.Zero)
				id_onFrame_Lorg_webrtc_VideoFrame_ = JNIEnv.GetMethodID (class_ref, "onFrame", "(Lorg/webrtc/VideoFrame;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFrame_Lorg_webrtc_VideoFrame_, __args);
		}

	}
}
