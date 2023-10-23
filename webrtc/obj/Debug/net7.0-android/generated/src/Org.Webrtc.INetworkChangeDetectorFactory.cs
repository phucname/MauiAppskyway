using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='NetworkChangeDetectorFactory']"
	[Register ("org/webrtc/NetworkChangeDetectorFactory", "", "Org.Webrtc.INetworkChangeDetectorFactoryInvoker")]
	public partial interface INetworkChangeDetectorFactory : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='NetworkChangeDetectorFactory']/method[@name='create' and count(parameter)=2 and parameter[1][@type='org.webrtc.NetworkChangeDetector.Observer'] and parameter[2][@type='android.content.Context']]"
		[Register ("create", "(Lorg/webrtc/NetworkChangeDetector$Observer;Landroid/content/Context;)Lorg/webrtc/NetworkChangeDetector;", "GetCreate_Lorg_webrtc_NetworkChangeDetector_Observer_Landroid_content_Context_Handler:Org.Webrtc.INetworkChangeDetectorFactoryInvoker, webrtc")]
		global::Org.Webrtc.INetworkChangeDetector? Create (global::Org.Webrtc.INetworkChangeDetector.Observer? p0, global::Android.Content.Context? p1);

	}

	[global::Android.Runtime.Register ("org/webrtc/NetworkChangeDetectorFactory", DoNotGenerateAcw=true)]
	internal partial class INetworkChangeDetectorFactoryInvoker : global::Java.Lang.Object, INetworkChangeDetectorFactory {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/NetworkChangeDetectorFactory", typeof (INetworkChangeDetectorFactoryInvoker));

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

		public static INetworkChangeDetectorFactory? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INetworkChangeDetectorFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.webrtc.NetworkChangeDetectorFactory'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INetworkChangeDetectorFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_create_Lorg_webrtc_NetworkChangeDetector_Observer_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetCreate_Lorg_webrtc_NetworkChangeDetector_Observer_Landroid_content_Context_Handler ()
		{
			if (cb_create_Lorg_webrtc_NetworkChangeDetector_Observer_Landroid_content_Context_ == null)
				cb_create_Lorg_webrtc_NetworkChangeDetector_Observer_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Create_Lorg_webrtc_NetworkChangeDetector_Observer_Landroid_content_Context_);
			return cb_create_Lorg_webrtc_NetworkChangeDetector_Observer_Landroid_content_Context_;
		}

		static IntPtr n_Create_Lorg_webrtc_NetworkChangeDetector_Observer_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.INetworkChangeDetectorFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.INetworkChangeDetector.Observer> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Create (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_create_Lorg_webrtc_NetworkChangeDetector_Observer_Landroid_content_Context_;
		public unsafe global::Org.Webrtc.INetworkChangeDetector? Create (global::Org.Webrtc.INetworkChangeDetector.Observer? p0, global::Android.Content.Context? p1)
		{
			if (id_create_Lorg_webrtc_NetworkChangeDetector_Observer_Landroid_content_Context_ == IntPtr.Zero)
				id_create_Lorg_webrtc_NetworkChangeDetector_Observer_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "create", "(Lorg/webrtc/NetworkChangeDetector$Observer;Landroid/content/Context;)Lorg/webrtc/NetworkChangeDetector;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.INetworkChangeDetector> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_create_Lorg_webrtc_NetworkChangeDetector_Observer_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
