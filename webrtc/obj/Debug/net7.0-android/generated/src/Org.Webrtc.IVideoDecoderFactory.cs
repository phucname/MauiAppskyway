using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoDecoderFactory']"
	[Register ("org/webrtc/VideoDecoderFactory", "", "Org.Webrtc.IVideoDecoderFactoryInvoker")]
	public partial interface IVideoDecoderFactory : IJavaObject, IJavaPeerable {
		private static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoDecoderFactory", typeof (IVideoDecoderFactory), isInterface: true);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoDecoderFactory']/method[@name='createDecoder' and count(parameter)=1 and parameter[1][@type='org.webrtc.VideoCodecInfo']]"
		[Register ("createDecoder", "(Lorg/webrtc/VideoCodecInfo;)Lorg/webrtc/VideoDecoder;", "GetCreateDecoder_Lorg_webrtc_VideoCodecInfo_Handler:Org.Webrtc.IVideoDecoderFactoryInvoker, webrtc")]
		global::Org.Webrtc.IVideoDecoder? CreateDecoder (global::Org.Webrtc.VideoCodecInfo? p0);

		private static Delegate? cb_getSupportedCodecs;
#pragma warning disable 0169
		private static Delegate GetGetSupportedCodecsHandler ()
		{
			if (cb_getSupportedCodecs == null)
				cb_getSupportedCodecs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSupportedCodecs);
			return cb_getSupportedCodecs;
		}

		private static IntPtr n_GetSupportedCodecs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoDecoderFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.GetSupportedCodecs ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoDecoderFactory']/method[@name='getSupportedCodecs' and count(parameter)=0]"
		[Register ("getSupportedCodecs", "()[Lorg/webrtc/VideoCodecInfo;", "GetGetSupportedCodecsHandler:Org.Webrtc.IVideoDecoderFactory, webrtc")]
		virtual unsafe global::Org.Webrtc.VideoCodecInfo[]? GetSupportedCodecs ()
		{
			const string __id = "getSupportedCodecs.()[Lorg/webrtc/VideoCodecInfo;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Org.Webrtc.VideoCodecInfo[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.VideoCodecInfo));
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/webrtc/VideoDecoderFactory", DoNotGenerateAcw=true)]
	internal partial class IVideoDecoderFactoryInvoker : global::Java.Lang.Object, IVideoDecoderFactory {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoDecoderFactory", typeof (IVideoDecoderFactoryInvoker));

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

		public static IVideoDecoderFactory? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoDecoderFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.webrtc.VideoDecoderFactory'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoDecoderFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_createDecoder_Lorg_webrtc_VideoCodecInfo_;
#pragma warning disable 0169
		static Delegate GetCreateDecoder_Lorg_webrtc_VideoCodecInfo_Handler ()
		{
			if (cb_createDecoder_Lorg_webrtc_VideoCodecInfo_ == null)
				cb_createDecoder_Lorg_webrtc_VideoCodecInfo_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CreateDecoder_Lorg_webrtc_VideoCodecInfo_);
			return cb_createDecoder_Lorg_webrtc_VideoCodecInfo_;
		}

		static IntPtr n_CreateDecoder_Lorg_webrtc_VideoCodecInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoDecoderFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCodecInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateDecoder (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createDecoder_Lorg_webrtc_VideoCodecInfo_;
		public unsafe global::Org.Webrtc.IVideoDecoder? CreateDecoder (global::Org.Webrtc.VideoCodecInfo? p0)
		{
			if (id_createDecoder_Lorg_webrtc_VideoCodecInfo_ == IntPtr.Zero)
				id_createDecoder_Lorg_webrtc_VideoCodecInfo_ = JNIEnv.GetMethodID (class_ref, "createDecoder", "(Lorg/webrtc/VideoCodecInfo;)Lorg/webrtc/VideoDecoder;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoDecoder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createDecoder_Lorg_webrtc_VideoCodecInfo_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
