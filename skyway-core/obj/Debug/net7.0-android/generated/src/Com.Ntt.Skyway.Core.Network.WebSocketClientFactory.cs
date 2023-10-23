using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Core.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.network']/class[@name='WebSocketClientFactory']"
	[global::Android.Runtime.Register ("com/ntt/skyway/core/network/WebSocketClientFactory", DoNotGenerateAcw=true)]
	public sealed partial class WebSocketClientFactory : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.network']/class[@name='WebSocketClientFactory']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.Ntt.Skyway.Core.Network.WebSocketClientFactory Instance {
			get {
				const string __id = "INSTANCE.Lcom/ntt/skyway/core/network/WebSocketClientFactory;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Network.WebSocketClientFactory> (__v.Handle, JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/network/WebSocketClientFactory", typeof (WebSocketClientFactory));

		internal static IntPtr class_ref {
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

		internal WebSocketClientFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.network']/class[@name='WebSocketClientFactory']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lcom/ntt/skyway/core/network/WebSocketClient;", "")]
		public static unsafe global::Com.Ntt.Skyway.Core.Network.WebSocketClient Create ()
		{
			const string __id = "create.()Lcom/ntt/skyway/core/network/WebSocketClient;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Network.WebSocketClient> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
			}
		}

	}
}
