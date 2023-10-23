using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='FrameDecryptor']"
	[Register ("org/webrtc/FrameDecryptor", "", "Org.Webrtc.IFrameDecryptorInvoker")]
	public partial interface IFrameDecryptor : IJavaObject, IJavaPeerable {
		long NativeFrameDecryptor {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='FrameDecryptor']/method[@name='getNativeFrameDecryptor' and count(parameter)=0]"
			[Register ("getNativeFrameDecryptor", "()J", "GetGetNativeFrameDecryptorHandler:Org.Webrtc.IFrameDecryptorInvoker, webrtc")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("org/webrtc/FrameDecryptor", DoNotGenerateAcw=true)]
	internal partial class IFrameDecryptorInvoker : global::Java.Lang.Object, IFrameDecryptor {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/FrameDecryptor", typeof (IFrameDecryptorInvoker));

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

		public static IFrameDecryptor? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFrameDecryptor> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.webrtc.FrameDecryptor'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFrameDecryptorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getNativeFrameDecryptor;
#pragma warning disable 0169
		static Delegate GetGetNativeFrameDecryptorHandler ()
		{
			if (cb_getNativeFrameDecryptor == null)
				cb_getNativeFrameDecryptor = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetNativeFrameDecryptor);
			return cb_getNativeFrameDecryptor;
		}

		static long n_GetNativeFrameDecryptor (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IFrameDecryptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.NativeFrameDecryptor;
		}
#pragma warning restore 0169

		IntPtr id_getNativeFrameDecryptor;
		public unsafe long NativeFrameDecryptor {
			get {
				if (id_getNativeFrameDecryptor == IntPtr.Zero)
					id_getNativeFrameDecryptor = JNIEnv.GetMethodID (class_ref, "getNativeFrameDecryptor", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getNativeFrameDecryptor);
			}
		}

	}
}
