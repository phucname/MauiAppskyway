using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Core.Content.Remote {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.content.remote']/class[@name='RemoteStream']"
	[global::Android.Runtime.Register ("com/ntt/skyway/core/content/remote/RemoteStream", DoNotGenerateAcw=true)]
	public abstract partial class RemoteStream : global::Com.Ntt.Skyway.Core.Content.Stream {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/content/remote/RemoteStream", typeof (RemoteStream));

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

		protected RemoteStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate? cb_getSide;
#pragma warning disable 0169
		static Delegate GetGetSideHandler ()
		{
			if (cb_getSide == null)
				cb_getSide = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSide);
			return cb_getSide;
		}

		static IntPtr n_GetSide (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Remote.RemoteStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.GetSide ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.remote']/class[@name='RemoteStream']/method[@name='getSide' and count(parameter)=0]"
		[Register ("getSide", "()Lcom/ntt/skyway/core/content/Stream$Side;", "GetGetSideHandler")]
		public override unsafe global::Com.Ntt.Skyway.Core.Content.Stream.Side GetSide ()
		{
			const string __id = "getSide.()Lcom/ntt/skyway/core/content/Stream$Side;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Stream.Side> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/ntt/skyway/core/content/remote/RemoteStream", DoNotGenerateAcw=true)]
	internal partial class RemoteStreamInvoker : RemoteStream {
		public RemoteStreamInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/content/remote/RemoteStream", typeof (RemoteStreamInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content']/class[@name='Stream']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public override unsafe void Dispose ()
		{
			const string __id = "dispose.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content']/class[@name='Stream']/method[@name='getContentType' and count(parameter)=0]"
		[Register ("getContentType", "()Lcom/ntt/skyway/core/content/Stream$ContentType;", "GetGetContentTypeHandler")]
		public override unsafe global::Com.Ntt.Skyway.Core.Content.Stream.ContentType GetContentType ()
		{
			const string __id = "getContentType.()Lcom/ntt/skyway/core/content/Stream$ContentType;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Stream.ContentType> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
			}
		}

	}
}
