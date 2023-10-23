using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='NetworkChangeDetector']"
	[Register ("org/webrtc/NetworkChangeDetector", "", "Org.Webrtc.INetworkChangeDetectorInvoker")]
	public partial interface INetworkChangeDetector : IJavaObject, IJavaPeerable {
		global::System.Collections.Generic.IList<global::Org.Webrtc.INetworkChangeDetector.NetworkInformation>? ActiveNetworkList {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='NetworkChangeDetector']/method[@name='getActiveNetworkList' and count(parameter)=0]"
			[Register ("getActiveNetworkList", "()Ljava/util/List;", "GetGetActiveNetworkListHandler:Org.Webrtc.INetworkChangeDetectorInvoker, webrtc")]
			get; 
		}

		global::Org.Webrtc.INetworkChangeDetector.ConnectionType? CurrentConnectionType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='NetworkChangeDetector']/method[@name='getCurrentConnectionType' and count(parameter)=0]"
			[Register ("getCurrentConnectionType", "()Lorg/webrtc/NetworkChangeDetector$ConnectionType;", "GetGetCurrentConnectionTypeHandler:Org.Webrtc.INetworkChangeDetectorInvoker, webrtc")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='NetworkChangeDetector']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler:Org.Webrtc.INetworkChangeDetectorInvoker, webrtc")]
		void Destroy ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='NetworkChangeDetector']/method[@name='supportNetworkCallback' and count(parameter)=0]"
		[Register ("supportNetworkCallback", "()Z", "GetSupportNetworkCallbackHandler:Org.Webrtc.INetworkChangeDetectorInvoker, webrtc")]
		bool SupportNetworkCallback ();

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkChangeDetector.ConnectionType']"
		[global::Android.Runtime.Register ("org/webrtc/NetworkChangeDetector$ConnectionType", DoNotGenerateAcw=true)]
		public sealed partial class ConnectionType : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkChangeDetector.ConnectionType']/field[@name='CONNECTION_2G']"
			[Register ("CONNECTION_2G")]
			public static global::Org.Webrtc.INetworkChangeDetector.ConnectionType? Connection2g {
				get {
					const string __id = "CONNECTION_2G.Lorg/webrtc/NetworkChangeDetector$ConnectionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.INetworkChangeDetector.ConnectionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkChangeDetector.ConnectionType']/field[@name='CONNECTION_3G']"
			[Register ("CONNECTION_3G")]
			public static global::Org.Webrtc.INetworkChangeDetector.ConnectionType? Connection3g {
				get {
					const string __id = "CONNECTION_3G.Lorg/webrtc/NetworkChangeDetector$ConnectionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.INetworkChangeDetector.ConnectionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkChangeDetector.ConnectionType']/field[@name='CONNECTION_4G']"
			[Register ("CONNECTION_4G")]
			public static global::Org.Webrtc.INetworkChangeDetector.ConnectionType? Connection4g {
				get {
					const string __id = "CONNECTION_4G.Lorg/webrtc/NetworkChangeDetector$ConnectionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.INetworkChangeDetector.ConnectionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkChangeDetector.ConnectionType']/field[@name='CONNECTION_5G']"
			[Register ("CONNECTION_5G")]
			public static global::Org.Webrtc.INetworkChangeDetector.ConnectionType? Connection5g {
				get {
					const string __id = "CONNECTION_5G.Lorg/webrtc/NetworkChangeDetector$ConnectionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.INetworkChangeDetector.ConnectionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkChangeDetector.ConnectionType']/field[@name='CONNECTION_BLUETOOTH']"
			[Register ("CONNECTION_BLUETOOTH")]
			public static global::Org.Webrtc.INetworkChangeDetector.ConnectionType? ConnectionBluetooth {
				get {
					const string __id = "CONNECTION_BLUETOOTH.Lorg/webrtc/NetworkChangeDetector$ConnectionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.INetworkChangeDetector.ConnectionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkChangeDetector.ConnectionType']/field[@name='CONNECTION_ETHERNET']"
			[Register ("CONNECTION_ETHERNET")]
			public static global::Org.Webrtc.INetworkChangeDetector.ConnectionType? ConnectionEthernet {
				get {
					const string __id = "CONNECTION_ETHERNET.Lorg/webrtc/NetworkChangeDetector$ConnectionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.INetworkChangeDetector.ConnectionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkChangeDetector.ConnectionType']/field[@name='CONNECTION_NONE']"
			[Register ("CONNECTION_NONE")]
			public static global::Org.Webrtc.INetworkChangeDetector.ConnectionType? ConnectionNone {
				get {
					const string __id = "CONNECTION_NONE.Lorg/webrtc/NetworkChangeDetector$ConnectionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.INetworkChangeDetector.ConnectionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkChangeDetector.ConnectionType']/field[@name='CONNECTION_UNKNOWN']"
			[Register ("CONNECTION_UNKNOWN")]
			public static global::Org.Webrtc.INetworkChangeDetector.ConnectionType? ConnectionUnknown {
				get {
					const string __id = "CONNECTION_UNKNOWN.Lorg/webrtc/NetworkChangeDetector$ConnectionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.INetworkChangeDetector.ConnectionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkChangeDetector.ConnectionType']/field[@name='CONNECTION_UNKNOWN_CELLULAR']"
			[Register ("CONNECTION_UNKNOWN_CELLULAR")]
			public static global::Org.Webrtc.INetworkChangeDetector.ConnectionType? ConnectionUnknownCellular {
				get {
					const string __id = "CONNECTION_UNKNOWN_CELLULAR.Lorg/webrtc/NetworkChangeDetector$ConnectionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.INetworkChangeDetector.ConnectionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkChangeDetector.ConnectionType']/field[@name='CONNECTION_VPN']"
			[Register ("CONNECTION_VPN")]
			public static global::Org.Webrtc.INetworkChangeDetector.ConnectionType? ConnectionVpn {
				get {
					const string __id = "CONNECTION_VPN.Lorg/webrtc/NetworkChangeDetector$ConnectionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.INetworkChangeDetector.ConnectionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkChangeDetector.ConnectionType']/field[@name='CONNECTION_WIFI']"
			[Register ("CONNECTION_WIFI")]
			public static global::Org.Webrtc.INetworkChangeDetector.ConnectionType? ConnectionWifi {
				get {
					const string __id = "CONNECTION_WIFI.Lorg/webrtc/NetworkChangeDetector$ConnectionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.INetworkChangeDetector.ConnectionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/NetworkChangeDetector$ConnectionType", typeof (ConnectionType));

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

			internal ConnectionType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkChangeDetector.ConnectionType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/NetworkChangeDetector$ConnectionType;", "")]
			public static unsafe global::Org.Webrtc.INetworkChangeDetector.ConnectionType? ValueOf (string? name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/webrtc/NetworkChangeDetector$ConnectionType;";
				IntPtr native_name = JNIEnv.NewString ((string?)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.INetworkChangeDetector.ConnectionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkChangeDetector.ConnectionType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/NetworkChangeDetector$ConnectionType;", "")]
			public static unsafe global::Org.Webrtc.INetworkChangeDetector.ConnectionType[]? Values ()
			{
				const string __id = "values.()[Lorg/webrtc/NetworkChangeDetector$ConnectionType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Webrtc.INetworkChangeDetector.ConnectionType[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.INetworkChangeDetector.ConnectionType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkChangeDetector.IPAddress']"
		[global::Android.Runtime.Register ("org/webrtc/NetworkChangeDetector$IPAddress", DoNotGenerateAcw=true)]
		public partial class IPAddress : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkChangeDetector.IPAddress']/field[@name='address']"
			[Register ("address")]
			public IList<byte>? Address {
				get {
					const string __id = "address.[B";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "address.[B";

					IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/NetworkChangeDetector$IPAddress", typeof (IPAddress));

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

			protected IPAddress (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkChangeDetector.IPAddress']/constructor[@name='NetworkChangeDetector.IPAddress' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register (".ctor", "([B)V", "")]
			public unsafe IPAddress (byte[]? address) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "([B)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_address = JNIEnv.NewArray (address);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_address);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					if (address != null) {
						JNIEnv.CopyArray (native_address, address);
						JNIEnv.DeleteLocalRef (native_address);
					}
					global::System.GC.KeepAlive (address);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkChangeDetector.NetworkInformation']"
		[global::Android.Runtime.Register ("org/webrtc/NetworkChangeDetector$NetworkInformation", DoNotGenerateAcw=true)]
		public partial class NetworkInformation : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkChangeDetector.NetworkInformation']/field[@name='handle']"
			[Register ("handle")]
			public long Handle {
				get {
					const string __id = "handle.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "handle.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkChangeDetector.NetworkInformation']/field[@name='ipAddresses']"
			[Register ("ipAddresses")]
			public IList<Org.Webrtc.INetworkChangeDetector.IPAddress>? IpAddresses {
				get {
					const string __id = "ipAddresses.[Lorg/webrtc/NetworkChangeDetector$IPAddress;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaArray<global::Org.Webrtc.INetworkChangeDetector.IPAddress>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "ipAddresses.[Lorg/webrtc/NetworkChangeDetector$IPAddress;";

					IntPtr native_value = global::Android.Runtime.JavaArray<global::Org.Webrtc.INetworkChangeDetector.IPAddress>.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkChangeDetector.NetworkInformation']/field[@name='name']"
			[Register ("name")]
			public string? Name {
				get {
					const string __id = "name.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "name.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString ((string?)value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkChangeDetector.NetworkInformation']/field[@name='type']"
			[Register ("type")]
			public global::Org.Webrtc.INetworkChangeDetector.ConnectionType? Type {
				get {
					const string __id = "type.Lorg/webrtc/NetworkChangeDetector$ConnectionType;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.INetworkChangeDetector.ConnectionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "type.Lorg/webrtc/NetworkChangeDetector$ConnectionType;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkChangeDetector.NetworkInformation']/field[@name='underlyingTypeForVpn']"
			[Register ("underlyingTypeForVpn")]
			public global::Org.Webrtc.INetworkChangeDetector.ConnectionType? UnderlyingTypeForVpn {
				get {
					const string __id = "underlyingTypeForVpn.Lorg/webrtc/NetworkChangeDetector$ConnectionType;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.INetworkChangeDetector.ConnectionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "underlyingTypeForVpn.Lorg/webrtc/NetworkChangeDetector$ConnectionType;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/NetworkChangeDetector$NetworkInformation", typeof (NetworkInformation));

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

			protected NetworkInformation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkChangeDetector.NetworkInformation']/constructor[@name='NetworkChangeDetector.NetworkInformation' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.webrtc.NetworkChangeDetector.ConnectionType'] and parameter[3][@type='org.webrtc.NetworkChangeDetector.ConnectionType'] and parameter[4][@type='long'] and parameter[5][@type='org.webrtc.NetworkChangeDetector.IPAddress[]']]"
			[Register (".ctor", "(Ljava/lang/String;Lorg/webrtc/NetworkChangeDetector$ConnectionType;Lorg/webrtc/NetworkChangeDetector$ConnectionType;J[Lorg/webrtc/NetworkChangeDetector$IPAddress;)V", "")]
			public unsafe NetworkInformation (string? name, global::Org.Webrtc.INetworkChangeDetector.ConnectionType? type, global::Org.Webrtc.INetworkChangeDetector.ConnectionType? underlyingTypeForVpn, long handle, global::Org.Webrtc.INetworkChangeDetector.IPAddress[]? addresses) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Lorg/webrtc/NetworkChangeDetector$ConnectionType;Lorg/webrtc/NetworkChangeDetector$ConnectionType;J[Lorg/webrtc/NetworkChangeDetector$IPAddress;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_name = JNIEnv.NewString ((string?)name);
				IntPtr native_addresses = JNIEnv.NewArray (addresses);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue (native_name);
					__args [1] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
					__args [2] = new JniArgumentValue ((underlyingTypeForVpn == null) ? IntPtr.Zero : ((global::Java.Lang.Object) underlyingTypeForVpn).Handle);
					__args [3] = new JniArgumentValue (handle);
					__args [4] = new JniArgumentValue (native_addresses);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
					if (addresses != null) {
						JNIEnv.CopyArray (native_addresses, addresses);
						JNIEnv.DeleteLocalRef (native_addresses);
					}
					global::System.GC.KeepAlive (type);
					global::System.GC.KeepAlive (underlyingTypeForVpn);
					global::System.GC.KeepAlive (addresses);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkChangeDetector.Observer']"
		[global::Android.Runtime.Register ("org/webrtc/NetworkChangeDetector$Observer", DoNotGenerateAcw=true)]
		public abstract partial class Observer : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/NetworkChangeDetector$Observer", typeof (Observer));

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

			protected Observer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkChangeDetector.Observer']/constructor[@name='NetworkChangeDetector.Observer' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Observer () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			static Delegate? cb_getFieldTrialsString;
#pragma warning disable 0169
			static Delegate GetGetFieldTrialsStringHandler ()
			{
				if (cb_getFieldTrialsString == null)
					cb_getFieldTrialsString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFieldTrialsString);
				return cb_getFieldTrialsString;
			}

			static IntPtr n_GetFieldTrialsString (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.INetworkChangeDetector.Observer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.FieldTrialsString);
			}
#pragma warning restore 0169

			public virtual unsafe string? FieldTrialsString {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkChangeDetector.Observer']/method[@name='getFieldTrialsString' and count(parameter)=0]"
				[Register ("getFieldTrialsString", "()Ljava/lang/String;", "GetGetFieldTrialsStringHandler")]
				get {
					const string __id = "getFieldTrialsString.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_onConnectionTypeChanged_Lorg_webrtc_NetworkChangeDetector_ConnectionType_;
#pragma warning disable 0169
			static Delegate GetOnConnectionTypeChanged_Lorg_webrtc_NetworkChangeDetector_ConnectionType_Handler ()
			{
				if (cb_onConnectionTypeChanged_Lorg_webrtc_NetworkChangeDetector_ConnectionType_ == null)
					cb_onConnectionTypeChanged_Lorg_webrtc_NetworkChangeDetector_ConnectionType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnConnectionTypeChanged_Lorg_webrtc_NetworkChangeDetector_ConnectionType_);
				return cb_onConnectionTypeChanged_Lorg_webrtc_NetworkChangeDetector_ConnectionType_;
			}

			static void n_OnConnectionTypeChanged_Lorg_webrtc_NetworkChangeDetector_ConnectionType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.INetworkChangeDetector.Observer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.INetworkChangeDetector.ConnectionType> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnConnectionTypeChanged (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkChangeDetector.Observer']/method[@name='onConnectionTypeChanged' and count(parameter)=1 and parameter[1][@type='org.webrtc.NetworkChangeDetector.ConnectionType']]"
			[Register ("onConnectionTypeChanged", "(Lorg/webrtc/NetworkChangeDetector$ConnectionType;)V", "GetOnConnectionTypeChanged_Lorg_webrtc_NetworkChangeDetector_ConnectionType_Handler")]
			public abstract void OnConnectionTypeChanged (global::Org.Webrtc.INetworkChangeDetector.ConnectionType? p0);

			static Delegate? cb_onNetworkConnect_Lorg_webrtc_NetworkChangeDetector_NetworkInformation_;
#pragma warning disable 0169
			static Delegate GetOnNetworkConnect_Lorg_webrtc_NetworkChangeDetector_NetworkInformation_Handler ()
			{
				if (cb_onNetworkConnect_Lorg_webrtc_NetworkChangeDetector_NetworkInformation_ == null)
					cb_onNetworkConnect_Lorg_webrtc_NetworkChangeDetector_NetworkInformation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnNetworkConnect_Lorg_webrtc_NetworkChangeDetector_NetworkInformation_);
				return cb_onNetworkConnect_Lorg_webrtc_NetworkChangeDetector_NetworkInformation_;
			}

			static void n_OnNetworkConnect_Lorg_webrtc_NetworkChangeDetector_NetworkInformation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.INetworkChangeDetector.Observer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.INetworkChangeDetector.NetworkInformation> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnNetworkConnect (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkChangeDetector.Observer']/method[@name='onNetworkConnect' and count(parameter)=1 and parameter[1][@type='org.webrtc.NetworkChangeDetector.NetworkInformation']]"
			[Register ("onNetworkConnect", "(Lorg/webrtc/NetworkChangeDetector$NetworkInformation;)V", "GetOnNetworkConnect_Lorg_webrtc_NetworkChangeDetector_NetworkInformation_Handler")]
			public abstract void OnNetworkConnect (global::Org.Webrtc.INetworkChangeDetector.NetworkInformation? p0);

			static Delegate? cb_onNetworkDisconnect_J;
#pragma warning disable 0169
			static Delegate GetOnNetworkDisconnect_JHandler ()
			{
				if (cb_onNetworkDisconnect_J == null)
					cb_onNetworkDisconnect_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_OnNetworkDisconnect_J);
				return cb_onNetworkDisconnect_J;
			}

			static void n_OnNetworkDisconnect_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.INetworkChangeDetector.Observer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.OnNetworkDisconnect (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkChangeDetector.Observer']/method[@name='onNetworkDisconnect' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("onNetworkDisconnect", "(J)V", "GetOnNetworkDisconnect_JHandler")]
			public abstract void OnNetworkDisconnect (long p0);

			static Delegate? cb_onNetworkPreference_Ljava_util_List_I;
#pragma warning disable 0169
			static Delegate GetOnNetworkPreference_Ljava_util_List_IHandler ()
			{
				if (cb_onNetworkPreference_Ljava_util_List_I == null)
					cb_onNetworkPreference_Ljava_util_List_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_OnNetworkPreference_Ljava_util_List_I);
				return cb_onNetworkPreference_Ljava_util_List_I;
			}

			static void n_OnNetworkPreference_Ljava_util_List_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.INetworkChangeDetector.Observer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Android.Runtime.JavaList<global::Org.Webrtc.INetworkChangeDetector.ConnectionType>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnNetworkPreference (p0, p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkChangeDetector.Observer']/method[@name='onNetworkPreference' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;org.webrtc.NetworkChangeDetector.ConnectionType&gt;'] and parameter[2][@type='int']]"
			[Register ("onNetworkPreference", "(Ljava/util/List;I)V", "GetOnNetworkPreference_Ljava_util_List_IHandler")]
			public abstract void OnNetworkPreference (global::System.Collections.Generic.IList<global::Org.Webrtc.INetworkChangeDetector.ConnectionType>? p0, int p1);

		}

		[global::Android.Runtime.Register ("org/webrtc/NetworkChangeDetector$Observer", DoNotGenerateAcw=true)]
		internal partial class ObserverInvoker : Observer {
			public ObserverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/NetworkChangeDetector$Observer", typeof (ObserverInvoker));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkChangeDetector.Observer']/method[@name='onConnectionTypeChanged' and count(parameter)=1 and parameter[1][@type='org.webrtc.NetworkChangeDetector.ConnectionType']]"
			[Register ("onConnectionTypeChanged", "(Lorg/webrtc/NetworkChangeDetector$ConnectionType;)V", "GetOnConnectionTypeChanged_Lorg_webrtc_NetworkChangeDetector_ConnectionType_Handler")]
			public override unsafe void OnConnectionTypeChanged (global::Org.Webrtc.INetworkChangeDetector.ConnectionType? p0)
			{
				const string __id = "onConnectionTypeChanged.(Lorg/webrtc/NetworkChangeDetector$ConnectionType;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkChangeDetector.Observer']/method[@name='onNetworkConnect' and count(parameter)=1 and parameter[1][@type='org.webrtc.NetworkChangeDetector.NetworkInformation']]"
			[Register ("onNetworkConnect", "(Lorg/webrtc/NetworkChangeDetector$NetworkInformation;)V", "GetOnNetworkConnect_Lorg_webrtc_NetworkChangeDetector_NetworkInformation_Handler")]
			public override unsafe void OnNetworkConnect (global::Org.Webrtc.INetworkChangeDetector.NetworkInformation? p0)
			{
				const string __id = "onNetworkConnect.(Lorg/webrtc/NetworkChangeDetector$NetworkInformation;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkChangeDetector.Observer']/method[@name='onNetworkDisconnect' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("onNetworkDisconnect", "(J)V", "GetOnNetworkDisconnect_JHandler")]
			public override unsafe void OnNetworkDisconnect (long p0)
			{
				const string __id = "onNetworkDisconnect.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkChangeDetector.Observer']/method[@name='onNetworkPreference' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;org.webrtc.NetworkChangeDetector.ConnectionType&gt;'] and parameter[2][@type='int']]"
			[Register ("onNetworkPreference", "(Ljava/util/List;I)V", "GetOnNetworkPreference_Ljava_util_List_IHandler")]
			public override unsafe void OnNetworkPreference (global::System.Collections.Generic.IList<global::Org.Webrtc.INetworkChangeDetector.ConnectionType>? p0, int p1)
			{
				const string __id = "onNetworkPreference.(Ljava/util/List;I)V";
				IntPtr native_p0 = global::Android.Runtime.JavaList<global::Org.Webrtc.INetworkChangeDetector.ConnectionType>.ToLocalJniHandle (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (p1);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					global::System.GC.KeepAlive (p0);
				}
			}

		}

	}

	[global::Android.Runtime.Register ("org/webrtc/NetworkChangeDetector", DoNotGenerateAcw=true)]
	internal partial class INetworkChangeDetectorInvoker : global::Java.Lang.Object, INetworkChangeDetector {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/NetworkChangeDetector", typeof (INetworkChangeDetectorInvoker));

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

		public static INetworkChangeDetector? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INetworkChangeDetector> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.webrtc.NetworkChangeDetector'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INetworkChangeDetectorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getActiveNetworkList;
#pragma warning disable 0169
		static Delegate GetGetActiveNetworkListHandler ()
		{
			if (cb_getActiveNetworkList == null)
				cb_getActiveNetworkList = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetActiveNetworkList);
			return cb_getActiveNetworkList;
		}

		static IntPtr n_GetActiveNetworkList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.INetworkChangeDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaList<global::Org.Webrtc.INetworkChangeDetector.NetworkInformation>.ToLocalJniHandle (__this.ActiveNetworkList);
		}
#pragma warning restore 0169

		IntPtr id_getActiveNetworkList;
		public unsafe global::System.Collections.Generic.IList<global::Org.Webrtc.INetworkChangeDetector.NetworkInformation>? ActiveNetworkList {
			get {
				if (id_getActiveNetworkList == IntPtr.Zero)
					id_getActiveNetworkList = JNIEnv.GetMethodID (class_ref, "getActiveNetworkList", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Org.Webrtc.INetworkChangeDetector.NetworkInformation>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getActiveNetworkList), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getCurrentConnectionType;
#pragma warning disable 0169
		static Delegate GetGetCurrentConnectionTypeHandler ()
		{
			if (cb_getCurrentConnectionType == null)
				cb_getCurrentConnectionType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCurrentConnectionType);
			return cb_getCurrentConnectionType;
		}

		static IntPtr n_GetCurrentConnectionType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.INetworkChangeDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.CurrentConnectionType);
		}
#pragma warning restore 0169

		IntPtr id_getCurrentConnectionType;
		public unsafe global::Org.Webrtc.INetworkChangeDetector.ConnectionType? CurrentConnectionType {
			get {
				if (id_getCurrentConnectionType == IntPtr.Zero)
					id_getCurrentConnectionType = JNIEnv.GetMethodID (class_ref, "getCurrentConnectionType", "()Lorg/webrtc/NetworkChangeDetector$ConnectionType;");
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.INetworkChangeDetector.ConnectionType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentConnectionType), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_destroy == null)
				cb_destroy = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Destroy);
			return cb_destroy;
		}

		static void n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.INetworkChangeDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Destroy ();
		}
#pragma warning restore 0169

		IntPtr id_destroy;
		public unsafe void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetMethodID (class_ref, "destroy", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_destroy);
		}

		static Delegate? cb_supportNetworkCallback;
#pragma warning disable 0169
		static Delegate GetSupportNetworkCallbackHandler ()
		{
			if (cb_supportNetworkCallback == null)
				cb_supportNetworkCallback = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_SupportNetworkCallback);
			return cb_supportNetworkCallback;
		}

		static bool n_SupportNetworkCallback (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.INetworkChangeDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.SupportNetworkCallback ();
		}
#pragma warning restore 0169

		IntPtr id_supportNetworkCallback;
		public unsafe bool SupportNetworkCallback ()
		{
			if (id_supportNetworkCallback == IntPtr.Zero)
				id_supportNetworkCallback = JNIEnv.GetMethodID (class_ref, "supportNetworkCallback", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_supportNetworkCallback);
		}

	}
}
