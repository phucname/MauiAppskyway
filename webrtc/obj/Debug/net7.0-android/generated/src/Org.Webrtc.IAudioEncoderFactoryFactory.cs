using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='AudioEncoderFactoryFactory']"
	[Register ("org/webrtc/AudioEncoderFactoryFactory", "", "Org.Webrtc.IAudioEncoderFactoryFactoryInvoker")]
	public partial interface IAudioEncoderFactoryFactory : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='AudioEncoderFactoryFactory']/method[@name='createNativeAudioEncoderFactory' and count(parameter)=0]"
		[Register ("createNativeAudioEncoderFactory", "()J", "GetCreateNativeAudioEncoderFactoryHandler:Org.Webrtc.IAudioEncoderFactoryFactoryInvoker, webrtc")]
		long CreateNativeAudioEncoderFactory ();

	}

	[global::Android.Runtime.Register ("org/webrtc/AudioEncoderFactoryFactory", DoNotGenerateAcw=true)]
	internal partial class IAudioEncoderFactoryFactoryInvoker : global::Java.Lang.Object, IAudioEncoderFactoryFactory {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/AudioEncoderFactoryFactory", typeof (IAudioEncoderFactoryFactoryInvoker));

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

		public static IAudioEncoderFactoryFactory? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAudioEncoderFactoryFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.webrtc.AudioEncoderFactoryFactory'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAudioEncoderFactoryFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_createNativeAudioEncoderFactory;
#pragma warning disable 0169
		static Delegate GetCreateNativeAudioEncoderFactoryHandler ()
		{
			if (cb_createNativeAudioEncoderFactory == null)
				cb_createNativeAudioEncoderFactory = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_CreateNativeAudioEncoderFactory);
			return cb_createNativeAudioEncoderFactory;
		}

		static long n_CreateNativeAudioEncoderFactory (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IAudioEncoderFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.CreateNativeAudioEncoderFactory ();
		}
#pragma warning restore 0169

		IntPtr id_createNativeAudioEncoderFactory;
		public unsafe long CreateNativeAudioEncoderFactory ()
		{
			if (id_createNativeAudioEncoderFactory == IntPtr.Zero)
				id_createNativeAudioEncoderFactory = JNIEnv.GetMethodID (class_ref, "createNativeAudioEncoderFactory", "()J");
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_createNativeAudioEncoderFactory);
		}

	}
}
