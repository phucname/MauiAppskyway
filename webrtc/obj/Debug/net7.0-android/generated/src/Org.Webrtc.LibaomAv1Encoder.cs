using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='LibaomAv1Encoder']"
	[global::Android.Runtime.Register ("org/webrtc/LibaomAv1Encoder", DoNotGenerateAcw=true)]
	public partial class LibaomAv1Encoder : global::Org.Webrtc.WrappedNativeVideoEncoder {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/LibaomAv1Encoder", typeof (LibaomAv1Encoder));

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

		protected LibaomAv1Encoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='LibaomAv1Encoder']/constructor[@name='LibaomAv1Encoder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LibaomAv1Encoder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_isHardwareEncoder;
#pragma warning disable 0169
		static Delegate GetIsHardwareEncoderHandler ()
		{
			if (cb_isHardwareEncoder == null)
				cb_isHardwareEncoder = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsHardwareEncoder);
			return cb_isHardwareEncoder;
		}

		static bool n_IsHardwareEncoder (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.LibaomAv1Encoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsHardwareEncoder;
		}
#pragma warning restore 0169

		public override unsafe bool IsHardwareEncoder {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='LibaomAv1Encoder']/method[@name='isHardwareEncoder' and count(parameter)=0]"
			[Register ("isHardwareEncoder", "()Z", "GetIsHardwareEncoderHandler")]
			get {
				const string __id = "isHardwareEncoder.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_createNativeVideoEncoder;
#pragma warning disable 0169
		static Delegate GetCreateNativeVideoEncoderHandler ()
		{
			if (cb_createNativeVideoEncoder == null)
				cb_createNativeVideoEncoder = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_CreateNativeVideoEncoder);
			return cb_createNativeVideoEncoder;
		}

		static long n_CreateNativeVideoEncoder (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.LibaomAv1Encoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.CreateNativeVideoEncoder ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='LibaomAv1Encoder']/method[@name='createNativeVideoEncoder' and count(parameter)=0]"
		[Register ("createNativeVideoEncoder", "()J", "GetCreateNativeVideoEncoderHandler")]
		public virtual unsafe long CreateNativeVideoEncoder ()
		{
			const string __id = "createNativeVideoEncoder.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
