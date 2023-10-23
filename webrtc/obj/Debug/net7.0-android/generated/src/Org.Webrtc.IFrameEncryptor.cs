using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='FrameEncryptor']"
	[Register ("org/webrtc/FrameEncryptor", "", "Org.Webrtc.IFrameEncryptorInvoker")]
	public partial interface IFrameEncryptor : IJavaObject, IJavaPeerable {
		long NativeFrameEncryptor {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='FrameEncryptor']/method[@name='getNativeFrameEncryptor' and count(parameter)=0]"
			[Register ("getNativeFrameEncryptor", "()J", "GetGetNativeFrameEncryptorHandler:Org.Webrtc.IFrameEncryptorInvoker, webrtc")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("org/webrtc/FrameEncryptor", DoNotGenerateAcw=true)]
	internal partial class IFrameEncryptorInvoker : global::Java.Lang.Object, IFrameEncryptor {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/FrameEncryptor", typeof (IFrameEncryptorInvoker));

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

		public static IFrameEncryptor? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFrameEncryptor> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.webrtc.FrameEncryptor'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFrameEncryptorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getNativeFrameEncryptor;
#pragma warning disable 0169
		static Delegate GetGetNativeFrameEncryptorHandler ()
		{
			if (cb_getNativeFrameEncryptor == null)
				cb_getNativeFrameEncryptor = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetNativeFrameEncryptor);
			return cb_getNativeFrameEncryptor;
		}

		static long n_GetNativeFrameEncryptor (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IFrameEncryptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.NativeFrameEncryptor;
		}
#pragma warning restore 0169

		IntPtr id_getNativeFrameEncryptor;
		public unsafe long NativeFrameEncryptor {
			get {
				if (id_getNativeFrameEncryptor == IntPtr.Zero)
					id_getNativeFrameEncryptor = JNIEnv.GetMethodID (class_ref, "getNativeFrameEncryptor", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getNativeFrameEncryptor);
			}
		}

	}
}
