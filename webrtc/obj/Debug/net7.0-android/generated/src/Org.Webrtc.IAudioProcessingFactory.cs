using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='AudioProcessingFactory']"
	[Register ("org/webrtc/AudioProcessingFactory", "", "Org.Webrtc.IAudioProcessingFactoryInvoker")]
	public partial interface IAudioProcessingFactory : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='AudioProcessingFactory']/method[@name='createNative' and count(parameter)=0]"
		[Register ("createNative", "()J", "GetCreateNativeHandler:Org.Webrtc.IAudioProcessingFactoryInvoker, webrtc")]
		long CreateNative ();

	}

	[global::Android.Runtime.Register ("org/webrtc/AudioProcessingFactory", DoNotGenerateAcw=true)]
	internal partial class IAudioProcessingFactoryInvoker : global::Java.Lang.Object, IAudioProcessingFactory {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/AudioProcessingFactory", typeof (IAudioProcessingFactoryInvoker));

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

		public static IAudioProcessingFactory? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAudioProcessingFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.webrtc.AudioProcessingFactory'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAudioProcessingFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_createNative;
#pragma warning disable 0169
		static Delegate GetCreateNativeHandler ()
		{
			if (cb_createNative == null)
				cb_createNative = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_CreateNative);
			return cb_createNative;
		}

		static long n_CreateNative (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IAudioProcessingFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.CreateNative ();
		}
#pragma warning restore 0169

		IntPtr id_createNative;
		public unsafe long CreateNative ()
		{
			if (id_createNative == IntPtr.Zero)
				id_createNative = JNIEnv.GetMethodID (class_ref, "createNative", "()J");
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_createNative);
		}

	}
}
