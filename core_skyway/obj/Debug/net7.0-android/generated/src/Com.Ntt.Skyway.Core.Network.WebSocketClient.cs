using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Core.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.network']/class[@name='WebSocketClient']"
	[global::Android.Runtime.Register ("com/ntt/skyway/core/network/WebSocketClient", DoNotGenerateAcw=true)]
	public sealed partial class WebSocketClient : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.network']/class[@name='WebSocketClient.ConnectionState']"
		[global::Android.Runtime.Register ("com/ntt/skyway/core/network/WebSocketClient$ConnectionState", DoNotGenerateAcw=true)]
		public sealed partial class ConnectionState : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.network']/class[@name='WebSocketClient.ConnectionState']/field[@name='CLOSED']"
			[Register ("CLOSED")]
			public static global::Com.Ntt.Skyway.Core.Network.WebSocketClient.ConnectionState? Closed {
				get {
					const string __id = "CLOSED.Lcom/ntt/skyway/core/network/WebSocketClient$ConnectionState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Network.WebSocketClient.ConnectionState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.network']/class[@name='WebSocketClient.ConnectionState']/field[@name='CONNECTING']"
			[Register ("CONNECTING")]
			public static global::Com.Ntt.Skyway.Core.Network.WebSocketClient.ConnectionState? Connecting {
				get {
					const string __id = "CONNECTING.Lcom/ntt/skyway/core/network/WebSocketClient$ConnectionState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Network.WebSocketClient.ConnectionState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.network']/class[@name='WebSocketClient.ConnectionState']/field[@name='ESTABLISHING']"
			[Register ("ESTABLISHING")]
			public static global::Com.Ntt.Skyway.Core.Network.WebSocketClient.ConnectionState? Establishing {
				get {
					const string __id = "ESTABLISHING.Lcom/ntt/skyway/core/network/WebSocketClient$ConnectionState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Network.WebSocketClient.ConnectionState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.network']/class[@name='WebSocketClient.ConnectionState']/field[@name='OPEN']"
			[Register ("OPEN")]
			public static global::Com.Ntt.Skyway.Core.Network.WebSocketClient.ConnectionState? Open {
				get {
					const string __id = "OPEN.Lcom/ntt/skyway/core/network/WebSocketClient$ConnectionState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Network.WebSocketClient.ConnectionState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/network/WebSocketClient$ConnectionState", typeof (ConnectionState));

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

			internal ConnectionState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			public unsafe string String {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.network']/class[@name='WebSocketClient.ConnectionState']/method[@name='getString' and count(parameter)=0]"
				[Register ("getString", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getString.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.network']/class[@name='WebSocketClient.ConnectionState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/ntt/skyway/core/network/WebSocketClient$ConnectionState;", "")]
			public static unsafe global::Com.Ntt.Skyway.Core.Network.WebSocketClient.ConnectionState? ValueOf (string? value)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/ntt/skyway/core/network/WebSocketClient$ConnectionState;";
				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Network.WebSocketClient.ConnectionState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.network']/class[@name='WebSocketClient.ConnectionState']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/ntt/skyway/core/network/WebSocketClient$ConnectionState;", "")]
			public static unsafe global::Com.Ntt.Skyway.Core.Network.WebSocketClient.ConnectionState[]? Values ()
			{
				const string __id = "values.()[Lcom/ntt/skyway/core/network/WebSocketClient$ConnectionState;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Ntt.Skyway.Core.Network.WebSocketClient.ConnectionState[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Ntt.Skyway.Core.Network.WebSocketClient.ConnectionState));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/network/WebSocketClient", typeof (WebSocketClient));

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

		internal WebSocketClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core.network']/class[@name='WebSocketClient']/constructor[@name='WebSocketClient' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WebSocketClient () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

	}
}
