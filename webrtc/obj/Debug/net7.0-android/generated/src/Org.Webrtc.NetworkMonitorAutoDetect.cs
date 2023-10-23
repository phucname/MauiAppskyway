using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitorAutoDetect']"
	[global::Android.Runtime.Register ("org/webrtc/NetworkMonitorAutoDetect", DoNotGenerateAcw=true)]
	public partial class NetworkMonitorAutoDetect : global::Android.Content.BroadcastReceiver, global::Org.Webrtc.INetworkChangeDetector {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/NetworkMonitorAutoDetect", typeof (NetworkMonitorAutoDetect));

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

		protected NetworkMonitorAutoDetect (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitorAutoDetect']/constructor[@name='NetworkMonitorAutoDetect' and count(parameter)=2 and parameter[1][@type='org.webrtc.NetworkChangeDetector.Observer'] and parameter[2][@type='android.content.Context']]"
		[Register (".ctor", "(Lorg/webrtc/NetworkChangeDetector$Observer;Landroid/content/Context;)V", "")]
		public unsafe NetworkMonitorAutoDetect (global::Org.Webrtc.INetworkChangeDetector.Observer? observer, global::Android.Content.Context? context) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/webrtc/NetworkChangeDetector$Observer;Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((observer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) observer).Handle);
				__args [1] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (observer);
				global::System.GC.KeepAlive (context);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.NetworkMonitorAutoDetect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaList<global::Org.Webrtc.INetworkChangeDetector.NetworkInformation>.ToLocalJniHandle (__this.ActiveNetworkList);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Webrtc.INetworkChangeDetector.NetworkInformation>? ActiveNetworkList {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitorAutoDetect']/method[@name='getActiveNetworkList' and count(parameter)=0]"
			[Register ("getActiveNetworkList", "()Ljava/util/List;", "GetGetActiveNetworkListHandler")]
			get {
				const string __id = "getActiveNetworkList.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Org.Webrtc.INetworkChangeDetector.NetworkInformation>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.NetworkMonitorAutoDetect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.CurrentConnectionType);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Webrtc.INetworkChangeDetector.ConnectionType? CurrentConnectionType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitorAutoDetect']/method[@name='getCurrentConnectionType' and count(parameter)=0]"
			[Register ("getCurrentConnectionType", "()Lorg/webrtc/NetworkChangeDetector$ConnectionType;", "GetGetCurrentConnectionTypeHandler")]
			get {
				const string __id = "getCurrentConnectionType.()Lorg/webrtc/NetworkChangeDetector$ConnectionType;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.INetworkChangeDetector.ConnectionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getCurrentNetworkState;
#pragma warning disable 0169
		static Delegate GetGetCurrentNetworkStateHandler ()
		{
			if (cb_getCurrentNetworkState == null)
				cb_getCurrentNetworkState = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCurrentNetworkState);
			return cb_getCurrentNetworkState;
		}

		static IntPtr n_GetCurrentNetworkState (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.NetworkMonitorAutoDetect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.CurrentNetworkState);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object? CurrentNetworkState {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitorAutoDetect']/method[@name='getCurrentNetworkState' and count(parameter)=0]"
			[Register ("getCurrentNetworkState", "()Ljava/lang/Object;", "GetGetCurrentNetworkStateHandler")]
			get {
				const string __id = "getCurrentNetworkState.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getDefaultNetId;
#pragma warning disable 0169
		static Delegate GetGetDefaultNetIdHandler ()
		{
			if (cb_getDefaultNetId == null)
				cb_getDefaultNetId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetDefaultNetId);
			return cb_getDefaultNetId;
		}

		static long n_GetDefaultNetId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.NetworkMonitorAutoDetect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.DefaultNetId;
		}
#pragma warning restore 0169

		public virtual unsafe long DefaultNetId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitorAutoDetect']/method[@name='getDefaultNetId' and count(parameter)=0]"
			[Register ("getDefaultNetId", "()J", "GetGetDefaultNetIdHandler")]
			get {
				const string __id = "getDefaultNetId.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.NetworkMonitorAutoDetect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Destroy ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitorAutoDetect']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public virtual unsafe void Destroy ()
		{
			const string __id = "destroy.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler ()
		{
			if (cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ == null)
				cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnReceive_Landroid_content_Context_Landroid_content_Intent_);
			return cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
		}

		static void n_OnReceive_Landroid_content_Context_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_intent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.NetworkMonitorAutoDetect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			var intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			__this.OnReceive (context, intent);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitorAutoDetect']/method[@name='onReceive' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler")]
		public override unsafe void OnReceive (global::Android.Content.Context? context, global::Android.Content.Intent? intent)
		{
			const string __id = "onReceive.(Landroid/content/Context;Landroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (intent);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitorAutoDetect']/method[@name='setIncludeWifiDirect' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setIncludeWifiDirect", "(Z)V", "")]
		public static unsafe void SetIncludeWifiDirect (bool enable)
		{
			const string __id = "setIncludeWifiDirect.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enable);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.NetworkMonitorAutoDetect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.SupportNetworkCallback ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitorAutoDetect']/method[@name='supportNetworkCallback' and count(parameter)=0]"
		[Register ("supportNetworkCallback", "()Z", "GetSupportNetworkCallbackHandler")]
		public virtual unsafe bool SupportNetworkCallback ()
		{
			const string __id = "supportNetworkCallback.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
