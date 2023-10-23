using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='AddIceObserver']"
	[Register ("org/webrtc/AddIceObserver", "", "Org.Webrtc.IAddIceObserverInvoker")]
	public partial interface IAddIceObserver : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='AddIceObserver']/method[@name='onAddFailure' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onAddFailure", "(Ljava/lang/String;)V", "GetOnAddFailure_Ljava_lang_String_Handler:Org.Webrtc.IAddIceObserverInvoker, webrtc")]
		void OnAddFailure (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='AddIceObserver']/method[@name='onAddSuccess' and count(parameter)=0]"
		[Register ("onAddSuccess", "()V", "GetOnAddSuccessHandler:Org.Webrtc.IAddIceObserverInvoker, webrtc")]
		void OnAddSuccess ();

	}

	[global::Android.Runtime.Register ("org/webrtc/AddIceObserver", DoNotGenerateAcw=true)]
	internal partial class IAddIceObserverInvoker : global::Java.Lang.Object, IAddIceObserver {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/AddIceObserver", typeof (IAddIceObserverInvoker));

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

		public static IAddIceObserver? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAddIceObserver> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.webrtc.AddIceObserver'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAddIceObserverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onAddFailure_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnAddFailure_Ljava_lang_String_Handler ()
		{
			if (cb_onAddFailure_Ljava_lang_String_ == null)
				cb_onAddFailure_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnAddFailure_Ljava_lang_String_);
			return cb_onAddFailure_Ljava_lang_String_;
		}

		static void n_OnAddFailure_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IAddIceObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAddFailure (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAddFailure_Ljava_lang_String_;
		public unsafe void OnAddFailure (string? p0)
		{
			if (id_onAddFailure_Ljava_lang_String_ == IntPtr.Zero)
				id_onAddFailure_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onAddFailure", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAddFailure_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate? cb_onAddSuccess;
#pragma warning disable 0169
		static Delegate GetOnAddSuccessHandler ()
		{
			if (cb_onAddSuccess == null)
				cb_onAddSuccess = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnAddSuccess);
			return cb_onAddSuccess;
		}

		static void n_OnAddSuccess (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IAddIceObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnAddSuccess ();
		}
#pragma warning restore 0169

		IntPtr id_onAddSuccess;
		public unsafe void OnAddSuccess ()
		{
			if (id_onAddSuccess == IntPtr.Zero)
				id_onAddSuccess = JNIEnv.GetMethodID (class_ref, "onAddSuccess", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAddSuccess);
		}

	}
}
