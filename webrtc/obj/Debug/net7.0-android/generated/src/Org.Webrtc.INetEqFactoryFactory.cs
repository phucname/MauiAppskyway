using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='NetEqFactoryFactory']"
	[Register ("org/webrtc/NetEqFactoryFactory", "", "Org.Webrtc.INetEqFactoryFactoryInvoker")]
	public partial interface INetEqFactoryFactory : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='NetEqFactoryFactory']/method[@name='createNativeNetEqFactory' and count(parameter)=0]"
		[Register ("createNativeNetEqFactory", "()J", "GetCreateNativeNetEqFactoryHandler:Org.Webrtc.INetEqFactoryFactoryInvoker, webrtc")]
		long CreateNativeNetEqFactory ();

	}

	[global::Android.Runtime.Register ("org/webrtc/NetEqFactoryFactory", DoNotGenerateAcw=true)]
	internal partial class INetEqFactoryFactoryInvoker : global::Java.Lang.Object, INetEqFactoryFactory {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/NetEqFactoryFactory", typeof (INetEqFactoryFactoryInvoker));

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

		public static INetEqFactoryFactory? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INetEqFactoryFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.webrtc.NetEqFactoryFactory'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INetEqFactoryFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_createNativeNetEqFactory;
#pragma warning disable 0169
		static Delegate GetCreateNativeNetEqFactoryHandler ()
		{
			if (cb_createNativeNetEqFactory == null)
				cb_createNativeNetEqFactory = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_CreateNativeNetEqFactory);
			return cb_createNativeNetEqFactory;
		}

		static long n_CreateNativeNetEqFactory (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.INetEqFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.CreateNativeNetEqFactory ();
		}
#pragma warning restore 0169

		IntPtr id_createNativeNetEqFactory;
		public unsafe long CreateNativeNetEqFactory ()
		{
			if (id_createNativeNetEqFactory == IntPtr.Zero)
				id_createNativeNetEqFactory = JNIEnv.GetMethodID (class_ref, "createNativeNetEqFactory", "()J");
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_createNativeNetEqFactory);
		}

	}
}
