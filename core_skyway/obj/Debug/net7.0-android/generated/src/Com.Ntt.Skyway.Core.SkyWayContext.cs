using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext']"
	[global::Android.Runtime.Register ("com/ntt/skyway/core/SkyWayContext", DoNotGenerateAcw=true)]
	public sealed partial class SkyWayContext : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.Ntt.Skyway.Core.SkyWayContext Instance {
			get {
				const string __id = "INSTANCE.Lcom/ntt/skyway/core/SkyWayContext;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.SkyWayContext> (__v.Handle, JniHandleOwnership.TransferLocalRef)!;
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext']/field[@name='version']"
		[Register ("version")]
		public const string Version = (string) "1.4.2";

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Error']"
		[global::Android.Runtime.Register ("com/ntt/skyway/core/SkyWayContext$Error", DoNotGenerateAcw=true)]
		public sealed partial class Error : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/SkyWayContext$Error", typeof (Error));

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

			internal Error (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Error']/constructor[@name='SkyWayContext.Error' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe Error (string message) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_message = JNIEnv.NewString ((string?)message);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_message);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_message);
				}
			}

			public unsafe string Message {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Error']/method[@name='getMessage' and count(parameter)=0]"
				[Register ("getMessage", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getMessage.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Error']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()Ljava/lang/String;", "")]
			public unsafe string Component1 ()
			{
				const string __id = "component1.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Error']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("copy", "(Ljava/lang/String;)Lcom/ntt/skyway/core/SkyWayContext$Error;", "")]
			public unsafe global::Com.Ntt.Skyway.Core.SkyWayContext.Error Copy (string message)
			{
				const string __id = "copy.(Ljava/lang/String;)Lcom/ntt/skyway/core/SkyWayContext$Error;";
				IntPtr native_message = JNIEnv.NewString ((string?)message);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_message);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.SkyWayContext.Error> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
					JNIEnv.DeleteLocalRef (native_message);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.IceParams']"
		[global::Android.Runtime.Register ("com/ntt/skyway/core/SkyWayContext$IceParams", DoNotGenerateAcw=true)]
		public sealed partial class IceParams : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/SkyWayContext$IceParams", typeof (IceParams));

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

			internal IceParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.IceParams']/constructor[@name='SkyWayContext.IceParams' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe IceParams () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.IceParams']/constructor[@name='SkyWayContext.IceParams' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Integer'] and parameter[3][@type='java.lang.Boolean']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/Boolean;)V", "")]
			public unsafe IceParams (string? domain, global::Java.Lang.Integer? version, global::Java.Lang.Boolean? secure) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/Boolean;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_domain = JNIEnv.NewString ((string?)domain);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_domain);
					__args [1] = new JniArgumentValue ((version == null) ? IntPtr.Zero : ((global::Java.Lang.Object) version).Handle);
					__args [2] = new JniArgumentValue ((secure == null) ? IntPtr.Zero : ((global::Java.Lang.Object) secure).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_domain);
					global::System.GC.KeepAlive (version);
					global::System.GC.KeepAlive (secure);
				}
			}

			public unsafe string? Domain {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.IceParams']/method[@name='getDomain' and count(parameter)=0]"
				[Register ("getDomain", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getDomain.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Java.Lang.Boolean? Secure {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.IceParams']/method[@name='getSecure' and count(parameter)=0]"
				[Register ("getSecure", "()Ljava/lang/Boolean;", "")]
				get {
					const string __id = "getSecure.()Ljava/lang/Boolean;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Java.Lang.Integer? Version {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.IceParams']/method[@name='getVersion' and count(parameter)=0]"
				[Register ("getVersion", "()Ljava/lang/Integer;", "")]
				get {
					const string __id = "getVersion.()Ljava/lang/Integer;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.IceParams']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()Ljava/lang/String;", "")]
			public unsafe string? Component1 ()
			{
				const string __id = "component1.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.IceParams']/method[@name='component2' and count(parameter)=0]"
			[Register ("component2", "()Ljava/lang/Integer;", "")]
			public unsafe global::Java.Lang.Integer? Component2 ()
			{
				const string __id = "component2.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.IceParams']/method[@name='component3' and count(parameter)=0]"
			[Register ("component3", "()Ljava/lang/Boolean;", "")]
			public unsafe global::Java.Lang.Boolean? Component3 ()
			{
				const string __id = "component3.()Ljava/lang/Boolean;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.IceParams']/method[@name='copy' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Integer'] and parameter[3][@type='java.lang.Boolean']]"
			[Register ("copy", "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/Boolean;)Lcom/ntt/skyway/core/SkyWayContext$IceParams;", "")]
			public unsafe global::Com.Ntt.Skyway.Core.SkyWayContext.IceParams Copy (string? domain, global::Java.Lang.Integer? version, global::Java.Lang.Boolean? secure)
			{
				const string __id = "copy.(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/Boolean;)Lcom/ntt/skyway/core/SkyWayContext$IceParams;";
				IntPtr native_domain = JNIEnv.NewString ((string?)domain);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_domain);
					__args [1] = new JniArgumentValue ((version == null) ? IntPtr.Zero : ((global::Java.Lang.Object) version).Handle);
					__args [2] = new JniArgumentValue ((secure == null) ? IntPtr.Zero : ((global::Java.Lang.Object) secure).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.SkyWayContext.IceParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
					JNIEnv.DeleteLocalRef (native_domain);
					global::System.GC.KeepAlive (version);
					global::System.GC.KeepAlive (secure);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Options']"
		[global::Android.Runtime.Register ("com/ntt/skyway/core/SkyWayContext$Options", DoNotGenerateAcw=true)]
		public sealed partial class Options : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/SkyWayContext$Options", typeof (Options));

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

			internal Options (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Options']/constructor[@name='SkyWayContext.Options' and count(parameter)=10 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.ntt.skyway.core.util.Logger.LogLevel'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean'] and parameter[5][@type='com.ntt.skyway.core.SkyWayContext.RtcApi'] and parameter[6][@type='com.ntt.skyway.core.SkyWayContext.IceParams'] and parameter[7][@type='com.ntt.skyway.core.SkyWayContext.Signaling'] and parameter[8][@type='com.ntt.skyway.core.SkyWayContext.RtcConfig'] and parameter[9][@type='com.ntt.skyway.core.SkyWayContext.Sfu'] and parameter[10][@type='com.ntt.skyway.core.SkyWayContext.Token']]"
			[Register (".ctor", "(Ljava/lang/String;Lcom/ntt/skyway/core/util/Logger$LogLevel;ZZLcom/ntt/skyway/core/SkyWayContext$RtcApi;Lcom/ntt/skyway/core/SkyWayContext$IceParams;Lcom/ntt/skyway/core/SkyWayContext$Signaling;Lcom/ntt/skyway/core/SkyWayContext$RtcConfig;Lcom/ntt/skyway/core/SkyWayContext$Sfu;Lcom/ntt/skyway/core/SkyWayContext$Token;)V", "")]
			public unsafe Options (string authToken, global::Com.Ntt.Skyway.Core.Util.Logger.LogLevel logLevel, bool webRTCLog, bool enableHardwareCodec, global::Com.Ntt.Skyway.Core.SkyWayContext.RtcApi? rtcApi, global::Com.Ntt.Skyway.Core.SkyWayContext.IceParams? iceParams, global::Com.Ntt.Skyway.Core.SkyWayContext.Signaling? signaling, global::Com.Ntt.Skyway.Core.SkyWayContext.RtcConfig? rtcConfig, global::Com.Ntt.Skyway.Core.SkyWayContext.Sfu? sfu, global::Com.Ntt.Skyway.Core.SkyWayContext.Token? token) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Lcom/ntt/skyway/core/util/Logger$LogLevel;ZZLcom/ntt/skyway/core/SkyWayContext$RtcApi;Lcom/ntt/skyway/core/SkyWayContext$IceParams;Lcom/ntt/skyway/core/SkyWayContext$Signaling;Lcom/ntt/skyway/core/SkyWayContext$RtcConfig;Lcom/ntt/skyway/core/SkyWayContext$Sfu;Lcom/ntt/skyway/core/SkyWayContext$Token;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_authToken = JNIEnv.NewString ((string?)authToken);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [10];
					__args [0] = new JniArgumentValue (native_authToken);
					__args [1] = new JniArgumentValue ((logLevel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logLevel).Handle);
					__args [2] = new JniArgumentValue (webRTCLog);
					__args [3] = new JniArgumentValue (enableHardwareCodec);
					__args [4] = new JniArgumentValue ((rtcApi == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rtcApi).Handle);
					__args [5] = new JniArgumentValue ((iceParams == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iceParams).Handle);
					__args [6] = new JniArgumentValue ((signaling == null) ? IntPtr.Zero : ((global::Java.Lang.Object) signaling).Handle);
					__args [7] = new JniArgumentValue ((rtcConfig == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rtcConfig).Handle);
					__args [8] = new JniArgumentValue ((sfu == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sfu).Handle);
					__args [9] = new JniArgumentValue ((token == null) ? IntPtr.Zero : ((global::Java.Lang.Object) token).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_authToken);
					global::System.GC.KeepAlive (logLevel);
					global::System.GC.KeepAlive (rtcApi);
					global::System.GC.KeepAlive (iceParams);
					global::System.GC.KeepAlive (signaling);
					global::System.GC.KeepAlive (rtcConfig);
					global::System.GC.KeepAlive (sfu);
					global::System.GC.KeepAlive (token);
				}
			}

			public unsafe string AuthToken {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Options']/method[@name='getAuthToken' and count(parameter)=0]"
				[Register ("getAuthToken", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getAuthToken.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
					} finally {
					}
				}
			}

			public unsafe bool EnableHardwareCodec {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Options']/method[@name='getEnableHardwareCodec' and count(parameter)=0]"
				[Register ("getEnableHardwareCodec", "()Z", "")]
				get {
					const string __id = "getEnableHardwareCodec.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe global::Com.Ntt.Skyway.Core.SkyWayContext.IceParams? IceParams {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Options']/method[@name='getIceParams' and count(parameter)=0]"
				[Register ("getIceParams", "()Lcom/ntt/skyway/core/SkyWayContext$IceParams;", "")]
				get {
					const string __id = "getIceParams.()Lcom/ntt/skyway/core/SkyWayContext$IceParams;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.SkyWayContext.IceParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Com.Ntt.Skyway.Core.Util.Logger.LogLevel LogLevel {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Options']/method[@name='getLogLevel' and count(parameter)=0]"
				[Register ("getLogLevel", "()Lcom/ntt/skyway/core/util/Logger$LogLevel;", "")]
				get {
					const string __id = "getLogLevel.()Lcom/ntt/skyway/core/util/Logger$LogLevel;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Util.Logger.LogLevel> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
					} finally {
					}
				}
			}

			public unsafe global::Com.Ntt.Skyway.Core.SkyWayContext.RtcApi? RtcApi {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Options']/method[@name='getRtcApi' and count(parameter)=0]"
				[Register ("getRtcApi", "()Lcom/ntt/skyway/core/SkyWayContext$RtcApi;", "")]
				get {
					const string __id = "getRtcApi.()Lcom/ntt/skyway/core/SkyWayContext$RtcApi;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.SkyWayContext.RtcApi> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Com.Ntt.Skyway.Core.SkyWayContext.RtcConfig? RtcConfig {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Options']/method[@name='getRtcConfig' and count(parameter)=0]"
				[Register ("getRtcConfig", "()Lcom/ntt/skyway/core/SkyWayContext$RtcConfig;", "")]
				get {
					const string __id = "getRtcConfig.()Lcom/ntt/skyway/core/SkyWayContext$RtcConfig;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.SkyWayContext.RtcConfig> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Com.Ntt.Skyway.Core.SkyWayContext.Sfu? Sfu {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Options']/method[@name='getSfu' and count(parameter)=0]"
				[Register ("getSfu", "()Lcom/ntt/skyway/core/SkyWayContext$Sfu;", "")]
				get {
					const string __id = "getSfu.()Lcom/ntt/skyway/core/SkyWayContext$Sfu;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.SkyWayContext.Sfu> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Com.Ntt.Skyway.Core.SkyWayContext.Signaling? Signaling {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Options']/method[@name='getSignaling' and count(parameter)=0]"
				[Register ("getSignaling", "()Lcom/ntt/skyway/core/SkyWayContext$Signaling;", "")]
				get {
					const string __id = "getSignaling.()Lcom/ntt/skyway/core/SkyWayContext$Signaling;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.SkyWayContext.Signaling> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Com.Ntt.Skyway.Core.SkyWayContext.Token? Token {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Options']/method[@name='getToken' and count(parameter)=0]"
				[Register ("getToken", "()Lcom/ntt/skyway/core/SkyWayContext$Token;", "")]
				get {
					const string __id = "getToken.()Lcom/ntt/skyway/core/SkyWayContext$Token;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.SkyWayContext.Token> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe bool WebRTCLog {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Options']/method[@name='getWebRTCLog' and count(parameter)=0]"
				[Register ("getWebRTCLog", "()Z", "")]
				get {
					const string __id = "getWebRTCLog.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Options']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()Ljava/lang/String;", "")]
			public unsafe string Component1 ()
			{
				const string __id = "component1.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Options']/method[@name='component10' and count(parameter)=0]"
			[Register ("component10", "()Lcom/ntt/skyway/core/SkyWayContext$Token;", "")]
			public unsafe global::Com.Ntt.Skyway.Core.SkyWayContext.Token? Component10 ()
			{
				const string __id = "component10.()Lcom/ntt/skyway/core/SkyWayContext$Token;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.SkyWayContext.Token> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Options']/method[@name='component2' and count(parameter)=0]"
			[Register ("component2", "()Lcom/ntt/skyway/core/util/Logger$LogLevel;", "")]
			public unsafe global::Com.Ntt.Skyway.Core.Util.Logger.LogLevel Component2 ()
			{
				const string __id = "component2.()Lcom/ntt/skyway/core/util/Logger$LogLevel;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Util.Logger.LogLevel> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Options']/method[@name='component3' and count(parameter)=0]"
			[Register ("component3", "()Z", "")]
			public unsafe bool Component3 ()
			{
				const string __id = "component3.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Options']/method[@name='component4' and count(parameter)=0]"
			[Register ("component4", "()Z", "")]
			public unsafe bool Component4 ()
			{
				const string __id = "component4.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Options']/method[@name='component5' and count(parameter)=0]"
			[Register ("component5", "()Lcom/ntt/skyway/core/SkyWayContext$RtcApi;", "")]
			public unsafe global::Com.Ntt.Skyway.Core.SkyWayContext.RtcApi? Component5 ()
			{
				const string __id = "component5.()Lcom/ntt/skyway/core/SkyWayContext$RtcApi;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.SkyWayContext.RtcApi> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Options']/method[@name='component6' and count(parameter)=0]"
			[Register ("component6", "()Lcom/ntt/skyway/core/SkyWayContext$IceParams;", "")]
			public unsafe global::Com.Ntt.Skyway.Core.SkyWayContext.IceParams? Component6 ()
			{
				const string __id = "component6.()Lcom/ntt/skyway/core/SkyWayContext$IceParams;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.SkyWayContext.IceParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Options']/method[@name='component7' and count(parameter)=0]"
			[Register ("component7", "()Lcom/ntt/skyway/core/SkyWayContext$Signaling;", "")]
			public unsafe global::Com.Ntt.Skyway.Core.SkyWayContext.Signaling? Component7 ()
			{
				const string __id = "component7.()Lcom/ntt/skyway/core/SkyWayContext$Signaling;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.SkyWayContext.Signaling> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Options']/method[@name='component8' and count(parameter)=0]"
			[Register ("component8", "()Lcom/ntt/skyway/core/SkyWayContext$RtcConfig;", "")]
			public unsafe global::Com.Ntt.Skyway.Core.SkyWayContext.RtcConfig? Component8 ()
			{
				const string __id = "component8.()Lcom/ntt/skyway/core/SkyWayContext$RtcConfig;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.SkyWayContext.RtcConfig> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Options']/method[@name='component9' and count(parameter)=0]"
			[Register ("component9", "()Lcom/ntt/skyway/core/SkyWayContext$Sfu;", "")]
			public unsafe global::Com.Ntt.Skyway.Core.SkyWayContext.Sfu? Component9 ()
			{
				const string __id = "component9.()Lcom/ntt/skyway/core/SkyWayContext$Sfu;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.SkyWayContext.Sfu> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Options']/method[@name='copy' and count(parameter)=10 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.ntt.skyway.core.util.Logger.LogLevel'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean'] and parameter[5][@type='com.ntt.skyway.core.SkyWayContext.RtcApi'] and parameter[6][@type='com.ntt.skyway.core.SkyWayContext.IceParams'] and parameter[7][@type='com.ntt.skyway.core.SkyWayContext.Signaling'] and parameter[8][@type='com.ntt.skyway.core.SkyWayContext.RtcConfig'] and parameter[9][@type='com.ntt.skyway.core.SkyWayContext.Sfu'] and parameter[10][@type='com.ntt.skyway.core.SkyWayContext.Token']]"
			[Register ("copy", "(Ljava/lang/String;Lcom/ntt/skyway/core/util/Logger$LogLevel;ZZLcom/ntt/skyway/core/SkyWayContext$RtcApi;Lcom/ntt/skyway/core/SkyWayContext$IceParams;Lcom/ntt/skyway/core/SkyWayContext$Signaling;Lcom/ntt/skyway/core/SkyWayContext$RtcConfig;Lcom/ntt/skyway/core/SkyWayContext$Sfu;Lcom/ntt/skyway/core/SkyWayContext$Token;)Lcom/ntt/skyway/core/SkyWayContext$Options;", "")]
			public unsafe global::Com.Ntt.Skyway.Core.SkyWayContext.Options Copy (string authToken, global::Com.Ntt.Skyway.Core.Util.Logger.LogLevel logLevel, bool webRTCLog, bool enableHardwareCodec, global::Com.Ntt.Skyway.Core.SkyWayContext.RtcApi? rtcApi, global::Com.Ntt.Skyway.Core.SkyWayContext.IceParams? iceParams, global::Com.Ntt.Skyway.Core.SkyWayContext.Signaling? signaling, global::Com.Ntt.Skyway.Core.SkyWayContext.RtcConfig? rtcConfig, global::Com.Ntt.Skyway.Core.SkyWayContext.Sfu? sfu, global::Com.Ntt.Skyway.Core.SkyWayContext.Token? token)
			{
				const string __id = "copy.(Ljava/lang/String;Lcom/ntt/skyway/core/util/Logger$LogLevel;ZZLcom/ntt/skyway/core/SkyWayContext$RtcApi;Lcom/ntt/skyway/core/SkyWayContext$IceParams;Lcom/ntt/skyway/core/SkyWayContext$Signaling;Lcom/ntt/skyway/core/SkyWayContext$RtcConfig;Lcom/ntt/skyway/core/SkyWayContext$Sfu;Lcom/ntt/skyway/core/SkyWayContext$Token;)Lcom/ntt/skyway/core/SkyWayContext$Options;";
				IntPtr native_authToken = JNIEnv.NewString ((string?)authToken);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [10];
					__args [0] = new JniArgumentValue (native_authToken);
					__args [1] = new JniArgumentValue ((logLevel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logLevel).Handle);
					__args [2] = new JniArgumentValue (webRTCLog);
					__args [3] = new JniArgumentValue (enableHardwareCodec);
					__args [4] = new JniArgumentValue ((rtcApi == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rtcApi).Handle);
					__args [5] = new JniArgumentValue ((iceParams == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iceParams).Handle);
					__args [6] = new JniArgumentValue ((signaling == null) ? IntPtr.Zero : ((global::Java.Lang.Object) signaling).Handle);
					__args [7] = new JniArgumentValue ((rtcConfig == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rtcConfig).Handle);
					__args [8] = new JniArgumentValue ((sfu == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sfu).Handle);
					__args [9] = new JniArgumentValue ((token == null) ? IntPtr.Zero : ((global::Java.Lang.Object) token).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.SkyWayContext.Options> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
					JNIEnv.DeleteLocalRef (native_authToken);
					global::System.GC.KeepAlive (logLevel);
					global::System.GC.KeepAlive (rtcApi);
					global::System.GC.KeepAlive (iceParams);
					global::System.GC.KeepAlive (signaling);
					global::System.GC.KeepAlive (rtcConfig);
					global::System.GC.KeepAlive (sfu);
					global::System.GC.KeepAlive (token);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.RtcApi']"
		[global::Android.Runtime.Register ("com/ntt/skyway/core/SkyWayContext$RtcApi", DoNotGenerateAcw=true)]
		public sealed partial class RtcApi : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/SkyWayContext$RtcApi", typeof (RtcApi));

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

			internal RtcApi (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.RtcApi']/constructor[@name='SkyWayContext.RtcApi' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe RtcApi () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.RtcApi']/constructor[@name='SkyWayContext.RtcApi' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Boolean']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Boolean;)V", "")]
			public unsafe RtcApi (string? domain, global::Java.Lang.Boolean? secure) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Ljava/lang/Boolean;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_domain = JNIEnv.NewString ((string?)domain);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_domain);
					__args [1] = new JniArgumentValue ((secure == null) ? IntPtr.Zero : ((global::Java.Lang.Object) secure).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_domain);
					global::System.GC.KeepAlive (secure);
				}
			}

			public unsafe string? Domain {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.RtcApi']/method[@name='getDomain' and count(parameter)=0]"
				[Register ("getDomain", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getDomain.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Java.Lang.Boolean? Secure {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.RtcApi']/method[@name='getSecure' and count(parameter)=0]"
				[Register ("getSecure", "()Ljava/lang/Boolean;", "")]
				get {
					const string __id = "getSecure.()Ljava/lang/Boolean;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.RtcApi']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()Ljava/lang/String;", "")]
			public unsafe string? Component1 ()
			{
				const string __id = "component1.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.RtcApi']/method[@name='component2' and count(parameter)=0]"
			[Register ("component2", "()Ljava/lang/Boolean;", "")]
			public unsafe global::Java.Lang.Boolean? Component2 ()
			{
				const string __id = "component2.()Ljava/lang/Boolean;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.RtcApi']/method[@name='copy' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Boolean']]"
			[Register ("copy", "(Ljava/lang/String;Ljava/lang/Boolean;)Lcom/ntt/skyway/core/SkyWayContext$RtcApi;", "")]
			public unsafe global::Com.Ntt.Skyway.Core.SkyWayContext.RtcApi Copy (string? domain, global::Java.Lang.Boolean? secure)
			{
				const string __id = "copy.(Ljava/lang/String;Ljava/lang/Boolean;)Lcom/ntt/skyway/core/SkyWayContext$RtcApi;";
				IntPtr native_domain = JNIEnv.NewString ((string?)domain);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_domain);
					__args [1] = new JniArgumentValue ((secure == null) ? IntPtr.Zero : ((global::Java.Lang.Object) secure).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.SkyWayContext.RtcApi> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
					JNIEnv.DeleteLocalRef (native_domain);
					global::System.GC.KeepAlive (secure);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.RtcConfig']"
		[global::Android.Runtime.Register ("com/ntt/skyway/core/SkyWayContext$RtcConfig", DoNotGenerateAcw=true)]
		public sealed partial class RtcConfig : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/SkyWayContext$RtcConfig", typeof (RtcConfig));

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

			internal RtcConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.RtcConfig']/constructor[@name='SkyWayContext.RtcConfig' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe RtcConfig () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.RtcConfig']/constructor[@name='SkyWayContext.RtcConfig' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='com.ntt.skyway.core.SkyWayContext.TurnPolicy']]"
			[Register (".ctor", "(Ljava/lang/Integer;Lcom/ntt/skyway/core/SkyWayContext$TurnPolicy;)V", "")]
			public unsafe RtcConfig (global::Java.Lang.Integer? timeout, global::Com.Ntt.Skyway.Core.SkyWayContext.TurnPolicy? policy) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/Integer;Lcom/ntt/skyway/core/SkyWayContext$TurnPolicy;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((timeout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeout).Handle);
					__args [1] = new JniArgumentValue ((policy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) policy).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (timeout);
					global::System.GC.KeepAlive (policy);
				}
			}

			public unsafe global::Com.Ntt.Skyway.Core.SkyWayContext.TurnPolicy? Policy {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.RtcConfig']/method[@name='getPolicy' and count(parameter)=0]"
				[Register ("getPolicy", "()Lcom/ntt/skyway/core/SkyWayContext$TurnPolicy;", "")]
				get {
					const string __id = "getPolicy.()Lcom/ntt/skyway/core/SkyWayContext$TurnPolicy;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.SkyWayContext.TurnPolicy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Java.Lang.Integer? Timeout {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.RtcConfig']/method[@name='getTimeout' and count(parameter)=0]"
				[Register ("getTimeout", "()Ljava/lang/Integer;", "")]
				get {
					const string __id = "getTimeout.()Ljava/lang/Integer;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.RtcConfig']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()Ljava/lang/Integer;", "")]
			public unsafe global::Java.Lang.Integer? Component1 ()
			{
				const string __id = "component1.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.RtcConfig']/method[@name='component2' and count(parameter)=0]"
			[Register ("component2", "()Lcom/ntt/skyway/core/SkyWayContext$TurnPolicy;", "")]
			public unsafe global::Com.Ntt.Skyway.Core.SkyWayContext.TurnPolicy? Component2 ()
			{
				const string __id = "component2.()Lcom/ntt/skyway/core/SkyWayContext$TurnPolicy;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.SkyWayContext.TurnPolicy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.RtcConfig']/method[@name='copy' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='com.ntt.skyway.core.SkyWayContext.TurnPolicy']]"
			[Register ("copy", "(Ljava/lang/Integer;Lcom/ntt/skyway/core/SkyWayContext$TurnPolicy;)Lcom/ntt/skyway/core/SkyWayContext$RtcConfig;", "")]
			public unsafe global::Com.Ntt.Skyway.Core.SkyWayContext.RtcConfig Copy (global::Java.Lang.Integer? timeout, global::Com.Ntt.Skyway.Core.SkyWayContext.TurnPolicy? policy)
			{
				const string __id = "copy.(Ljava/lang/Integer;Lcom/ntt/skyway/core/SkyWayContext$TurnPolicy;)Lcom/ntt/skyway/core/SkyWayContext$RtcConfig;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((timeout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeout).Handle);
					__args [1] = new JniArgumentValue ((policy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) policy).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.SkyWayContext.RtcConfig> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
					global::System.GC.KeepAlive (timeout);
					global::System.GC.KeepAlive (policy);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Sfu']"
		[global::Android.Runtime.Register ("com/ntt/skyway/core/SkyWayContext$Sfu", DoNotGenerateAcw=true)]
		public sealed partial class Sfu : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/SkyWayContext$Sfu", typeof (Sfu));

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

			internal Sfu (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Sfu']/constructor[@name='SkyWayContext.Sfu' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Sfu () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Sfu']/constructor[@name='SkyWayContext.Sfu' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Integer'] and parameter[3][@type='java.lang.Boolean']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/Boolean;)V", "")]
			public unsafe Sfu (string? domain, global::Java.Lang.Integer? version, global::Java.Lang.Boolean? secure) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/Boolean;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_domain = JNIEnv.NewString ((string?)domain);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_domain);
					__args [1] = new JniArgumentValue ((version == null) ? IntPtr.Zero : ((global::Java.Lang.Object) version).Handle);
					__args [2] = new JniArgumentValue ((secure == null) ? IntPtr.Zero : ((global::Java.Lang.Object) secure).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_domain);
					global::System.GC.KeepAlive (version);
					global::System.GC.KeepAlive (secure);
				}
			}

			public unsafe string? Domain {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Sfu']/method[@name='getDomain' and count(parameter)=0]"
				[Register ("getDomain", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getDomain.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Java.Lang.Boolean? Secure {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Sfu']/method[@name='getSecure' and count(parameter)=0]"
				[Register ("getSecure", "()Ljava/lang/Boolean;", "")]
				get {
					const string __id = "getSecure.()Ljava/lang/Boolean;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Java.Lang.Integer? Version {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Sfu']/method[@name='getVersion' and count(parameter)=0]"
				[Register ("getVersion", "()Ljava/lang/Integer;", "")]
				get {
					const string __id = "getVersion.()Ljava/lang/Integer;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Sfu']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()Ljava/lang/String;", "")]
			public unsafe string? Component1 ()
			{
				const string __id = "component1.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Sfu']/method[@name='component2' and count(parameter)=0]"
			[Register ("component2", "()Ljava/lang/Integer;", "")]
			public unsafe global::Java.Lang.Integer? Component2 ()
			{
				const string __id = "component2.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Sfu']/method[@name='component3' and count(parameter)=0]"
			[Register ("component3", "()Ljava/lang/Boolean;", "")]
			public unsafe global::Java.Lang.Boolean? Component3 ()
			{
				const string __id = "component3.()Ljava/lang/Boolean;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Sfu']/method[@name='copy' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Integer'] and parameter[3][@type='java.lang.Boolean']]"
			[Register ("copy", "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/Boolean;)Lcom/ntt/skyway/core/SkyWayContext$Sfu;", "")]
			public unsafe global::Com.Ntt.Skyway.Core.SkyWayContext.Sfu Copy (string? domain, global::Java.Lang.Integer? version, global::Java.Lang.Boolean? secure)
			{
				const string __id = "copy.(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/Boolean;)Lcom/ntt/skyway/core/SkyWayContext$Sfu;";
				IntPtr native_domain = JNIEnv.NewString ((string?)domain);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_domain);
					__args [1] = new JniArgumentValue ((version == null) ? IntPtr.Zero : ((global::Java.Lang.Object) version).Handle);
					__args [2] = new JniArgumentValue ((secure == null) ? IntPtr.Zero : ((global::Java.Lang.Object) secure).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.SkyWayContext.Sfu> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
					JNIEnv.DeleteLocalRef (native_domain);
					global::System.GC.KeepAlive (version);
					global::System.GC.KeepAlive (secure);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Signaling']"
		[global::Android.Runtime.Register ("com/ntt/skyway/core/SkyWayContext$Signaling", DoNotGenerateAcw=true)]
		public sealed partial class Signaling : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/SkyWayContext$Signaling", typeof (Signaling));

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

			internal Signaling (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Signaling']/constructor[@name='SkyWayContext.Signaling' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Signaling () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Signaling']/constructor[@name='SkyWayContext.Signaling' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Boolean']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Boolean;)V", "")]
			public unsafe Signaling (string? domain, global::Java.Lang.Boolean? secure) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Ljava/lang/Boolean;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_domain = JNIEnv.NewString ((string?)domain);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_domain);
					__args [1] = new JniArgumentValue ((secure == null) ? IntPtr.Zero : ((global::Java.Lang.Object) secure).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_domain);
					global::System.GC.KeepAlive (secure);
				}
			}

			public unsafe string? Domain {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Signaling']/method[@name='getDomain' and count(parameter)=0]"
				[Register ("getDomain", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getDomain.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Java.Lang.Boolean? Secure {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Signaling']/method[@name='getSecure' and count(parameter)=0]"
				[Register ("getSecure", "()Ljava/lang/Boolean;", "")]
				get {
					const string __id = "getSecure.()Ljava/lang/Boolean;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Signaling']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()Ljava/lang/String;", "")]
			public unsafe string? Component1 ()
			{
				const string __id = "component1.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Signaling']/method[@name='component2' and count(parameter)=0]"
			[Register ("component2", "()Ljava/lang/Boolean;", "")]
			public unsafe global::Java.Lang.Boolean? Component2 ()
			{
				const string __id = "component2.()Ljava/lang/Boolean;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Signaling']/method[@name='copy' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Boolean']]"
			[Register ("copy", "(Ljava/lang/String;Ljava/lang/Boolean;)Lcom/ntt/skyway/core/SkyWayContext$Signaling;", "")]
			public unsafe global::Com.Ntt.Skyway.Core.SkyWayContext.Signaling Copy (string? domain, global::Java.Lang.Boolean? secure)
			{
				const string __id = "copy.(Ljava/lang/String;Ljava/lang/Boolean;)Lcom/ntt/skyway/core/SkyWayContext$Signaling;";
				IntPtr native_domain = JNIEnv.NewString ((string?)domain);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_domain);
					__args [1] = new JniArgumentValue ((secure == null) ? IntPtr.Zero : ((global::Java.Lang.Object) secure).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.SkyWayContext.Signaling> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
					JNIEnv.DeleteLocalRef (native_domain);
					global::System.GC.KeepAlive (secure);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Token']"
		[global::Android.Runtime.Register ("com/ntt/skyway/core/SkyWayContext$Token", DoNotGenerateAcw=true)]
		public sealed partial class Token : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/SkyWayContext$Token", typeof (Token));

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

			internal Token (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Token']/constructor[@name='SkyWayContext.Token' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Token () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Token']/constructor[@name='SkyWayContext.Token' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register (".ctor", "(Ljava/lang/Integer;)V", "")]
			public unsafe Token (global::Java.Lang.Integer? tokenReminderTimeSec) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/Integer;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((tokenReminderTimeSec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tokenReminderTimeSec).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (tokenReminderTimeSec);
				}
			}

			public unsafe global::Java.Lang.Integer? TokenReminderTimeSec {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Token']/method[@name='getTokenReminderTimeSec' and count(parameter)=0]"
				[Register ("getTokenReminderTimeSec", "()Ljava/lang/Integer;", "")]
				get {
					const string __id = "getTokenReminderTimeSec.()Ljava/lang/Integer;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Token']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()Ljava/lang/Integer;", "")]
			public unsafe global::Java.Lang.Integer? Component1 ()
			{
				const string __id = "component1.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.Token']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("copy", "(Ljava/lang/Integer;)Lcom/ntt/skyway/core/SkyWayContext$Token;", "")]
			public unsafe global::Com.Ntt.Skyway.Core.SkyWayContext.Token Copy (global::Java.Lang.Integer? tokenReminderTimeSec)
			{
				const string __id = "copy.(Ljava/lang/Integer;)Lcom/ntt/skyway/core/SkyWayContext$Token;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((tokenReminderTimeSec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tokenReminderTimeSec).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.SkyWayContext.Token> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
					global::System.GC.KeepAlive (tokenReminderTimeSec);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.TurnPolicy']"
		[global::Android.Runtime.Register ("com/ntt/skyway/core/SkyWayContext$TurnPolicy", DoNotGenerateAcw=true)]
		public sealed partial class TurnPolicy : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.TurnPolicy']/field[@name='DISABLE']"
			[Register ("DISABLE")]
			public static global::Com.Ntt.Skyway.Core.SkyWayContext.TurnPolicy? Disable {
				get {
					const string __id = "DISABLE.Lcom/ntt/skyway/core/SkyWayContext$TurnPolicy;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.SkyWayContext.TurnPolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.TurnPolicy']/field[@name='ENABLE']"
			[Register ("ENABLE")]
			public static global::Com.Ntt.Skyway.Core.SkyWayContext.TurnPolicy? Enable {
				get {
					const string __id = "ENABLE.Lcom/ntt/skyway/core/SkyWayContext$TurnPolicy;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.SkyWayContext.TurnPolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.TurnPolicy']/field[@name='TURN_ONLY']"
			[Register ("TURN_ONLY")]
			public static global::Com.Ntt.Skyway.Core.SkyWayContext.TurnPolicy? TurnOnly {
				get {
					const string __id = "TURN_ONLY.Lcom/ntt/skyway/core/SkyWayContext$TurnPolicy;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.SkyWayContext.TurnPolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/SkyWayContext$TurnPolicy", typeof (TurnPolicy));

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

			internal TurnPolicy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.TurnPolicy']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/ntt/skyway/core/SkyWayContext$TurnPolicy;", "")]
			public static unsafe global::Com.Ntt.Skyway.Core.SkyWayContext.TurnPolicy? ValueOf (string? value)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/ntt/skyway/core/SkyWayContext$TurnPolicy;";
				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.SkyWayContext.TurnPolicy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext.TurnPolicy']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/ntt/skyway/core/SkyWayContext$TurnPolicy;", "")]
			public static unsafe global::Com.Ntt.Skyway.Core.SkyWayContext.TurnPolicy[]? Values ()
			{
				const string __id = "values.()[Lcom/ntt/skyway/core/SkyWayContext$TurnPolicy;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Ntt.Skyway.Core.SkyWayContext.TurnPolicy[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Ntt.Skyway.Core.SkyWayContext.TurnPolicy));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/SkyWayContext", typeof (SkyWayContext));

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

		internal SkyWayContext (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe bool IsSetup {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext']/method[@name='isSetup' and count(parameter)=0]"
			[Register ("isSetup", "()Z", "")]
			get {
				const string __id = "isSetup.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Kotlin.Jvm.Functions.IFunction1? OnErrorHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext']/method[@name='getOnErrorHandler' and count(parameter)=0]"
			[Register ("getOnErrorHandler", "()Lkotlin/jvm/functions/Function1;", "")]
			get {
				const string __id = "getOnErrorHandler.()Lkotlin/jvm/functions/Function1;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext']/method[@name='setOnErrorHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super com.ntt.skyway.core.SkyWayContext.Error, kotlin.Unit&gt;']]"
			[Register ("setOnErrorHandler", "(Lkotlin/jvm/functions/Function1;)V", "")]
			set {
				const string __id = "setOnErrorHandler.(Lkotlin/jvm/functions/Function1;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Kotlin.Jvm.Functions.IFunction0? OnReconnectStartHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext']/method[@name='getOnReconnectStartHandler' and count(parameter)=0]"
			[Register ("getOnReconnectStartHandler", "()Lkotlin/jvm/functions/Function0;", "")]
			get {
				const string __id = "getOnReconnectStartHandler.()Lkotlin/jvm/functions/Function0;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction0> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext']/method[@name='setOnReconnectStartHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function0&lt;kotlin.Unit&gt;']]"
			[Register ("setOnReconnectStartHandler", "(Lkotlin/jvm/functions/Function0;)V", "")]
			set {
				const string __id = "setOnReconnectStartHandler.(Lkotlin/jvm/functions/Function0;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Kotlin.Jvm.Functions.IFunction0? OnReconnectSuccessHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext']/method[@name='getOnReconnectSuccessHandler' and count(parameter)=0]"
			[Register ("getOnReconnectSuccessHandler", "()Lkotlin/jvm/functions/Function0;", "")]
			get {
				const string __id = "getOnReconnectSuccessHandler.()Lkotlin/jvm/functions/Function0;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction0> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext']/method[@name='setOnReconnectSuccessHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function0&lt;kotlin.Unit&gt;']]"
			[Register ("setOnReconnectSuccessHandler", "(Lkotlin/jvm/functions/Function0;)V", "")]
			set {
				const string __id = "setOnReconnectSuccessHandler.(Lkotlin/jvm/functions/Function0;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Kotlin.Jvm.Functions.IFunction0? OnTokenExpiredHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext']/method[@name='getOnTokenExpiredHandler' and count(parameter)=0]"
			[Register ("getOnTokenExpiredHandler", "()Lkotlin/jvm/functions/Function0;", "")]
			get {
				const string __id = "getOnTokenExpiredHandler.()Lkotlin/jvm/functions/Function0;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction0> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext']/method[@name='setOnTokenExpiredHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function0&lt;kotlin.Unit&gt;']]"
			[Register ("setOnTokenExpiredHandler", "(Lkotlin/jvm/functions/Function0;)V", "")]
			set {
				const string __id = "setOnTokenExpiredHandler.(Lkotlin/jvm/functions/Function0;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Kotlin.Jvm.Functions.IFunction0? OnTokenRefreshingNeededHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext']/method[@name='getOnTokenRefreshingNeededHandler' and count(parameter)=0]"
			[Register ("getOnTokenRefreshingNeededHandler", "()Lkotlin/jvm/functions/Function0;", "")]
			get {
				const string __id = "getOnTokenRefreshingNeededHandler.()Lkotlin/jvm/functions/Function0;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction0> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext']/method[@name='setOnTokenRefreshingNeededHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function0&lt;kotlin.Unit&gt;']]"
			[Register ("setOnTokenRefreshingNeededHandler", "(Lkotlin/jvm/functions/Function0;)V", "")]
			set {
				const string __id = "setOnTokenRefreshingNeededHandler.(Lkotlin/jvm/functions/Function0;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Plugin.IPlugin> Plugins {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext']/method[@name='getPlugins' and count(parameter)=0]"
			[Register ("getPlugins", "()Ljava/util/List;", "")]
			get {
				const string __id = "getPlugins.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Plugin.IPlugin>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext']/method[@name='_updateRtcConfig' and count(parameter)=1 and parameter[1][@type='com.ntt.skyway.core.SkyWayContext.RtcConfig']]"
		[Register ("_updateRtcConfig", "(Lcom/ntt/skyway/core/SkyWayContext$RtcConfig;)V", "")]
		public static unsafe void _updateRtcConfig (global::Com.Ntt.Skyway.Core.SkyWayContext.RtcConfig rtcConfig)
		{
			const string __id = "_updateRtcConfig.(Lcom/ntt/skyway/core/SkyWayContext$RtcConfig;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((rtcConfig == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rtcConfig).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (rtcConfig);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "")]
		public static unsafe void Dispose ()
		{
			const string __id = "dispose.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext']/method[@name='findPlugin' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("findPlugin", "(Ljava/lang/String;)Lcom/ntt/skyway/plugin/Plugin;", "")]
		public static unsafe global::Com.Ntt.Skyway.Plugin.IPlugin? FindPlugin (string name)
		{
			const string __id = "findPlugin.(Ljava/lang/String;)Lcom/ntt/skyway/plugin/Plugin;";
			IntPtr native_name = JNIEnv.NewString ((string?)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Plugin.IPlugin> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext']/method[@name='onFatalError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onFatalError", "(Ljava/lang/String;)V", "")]
		public static unsafe void OnFatalError (string message)
		{
			const string __id = "onFatalError.(Ljava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString ((string?)message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext']/method[@name='onReconnectStart' and count(parameter)=0]"
		[Register ("onReconnectStart", "()V", "")]
		public static unsafe void OnReconnectStart ()
		{
			const string __id = "onReconnectStart.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext']/method[@name='onReconnectSuccess' and count(parameter)=0]"
		[Register ("onReconnectSuccess", "()V", "")]
		public static unsafe void OnReconnectSuccess ()
		{
			const string __id = "onReconnectSuccess.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext']/method[@name='onTokenExpired' and count(parameter)=0]"
		[Register ("onTokenExpired", "()V", "")]
		public static unsafe void OnTokenExpired ()
		{
			const string __id = "onTokenExpired.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext']/method[@name='onTokenRefreshingNeeded' and count(parameter)=0]"
		[Register ("onTokenRefreshingNeeded", "()V", "")]
		public static unsafe void OnTokenRefreshingNeeded ()
		{
			const string __id = "onTokenRefreshingNeeded.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext']/method[@name='registerPlugin' and count(parameter)=1 and parameter[1][@type='com.ntt.skyway.plugin.Plugin']]"
		[Register ("registerPlugin", "(Lcom/ntt/skyway/plugin/Plugin;)V", "")]
		public static unsafe void RegisterPlugin (global::Com.Ntt.Skyway.Plugin.IPlugin plugin)
		{
			const string __id = "registerPlugin.(Lcom/ntt/skyway/plugin/Plugin;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((plugin == null) ? IntPtr.Zero : ((global::Java.Lang.Object) plugin).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (plugin);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext']/method[@name='
		//setup' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.ntt.skyway.core.SkyWayContext.Options'] and parameter[3][@type='kotlin.jvm.functions.Function1&lt;? super com.ntt.skyway.core.SkyWayContext.Error, kotlin.Unit&gt;'] and parameter[4][@type='kotlin.coroutines.Continuation&lt;? super java.lang.Boolean&gt;']]"
		[Register ("setup", "(Landroid/content/Context;Lcom/ntt/skyway/core/SkyWayContext$Options;Lkotlin/jvm/functions/Function1;" +
			"Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object? Setup (global::Android.Content.Context context, global::Com.Ntt.Skyway.Core.SkyWayContext.Options option
			, global::Kotlin.Jvm.Functions.IFunction1? onErrorHandler, global::Kotlin.Coroutines.IContinuation _completion)
		{
			const string __id = "setup.(Landroid/content/Context;Lcom/ntt/skyway/core/SkyWayContext$Options;Lkotlin/jvm/functions/Function1;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((option == null) ? IntPtr.Zero : ((global::Java.Lang.Object) option).Handle);
				__args [2] = new JniArgumentValue ((onErrorHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onErrorHandler).Handle);
				__args [3] = new JniArgumentValue ((_completion == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _completion).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (option);
				global::System.GC.KeepAlive (onErrorHandler);
				global::System.GC.KeepAlive (_completion);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core']/class[@name='SkyWayContext']/method[@name='updateAuthToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("updateAuthToken", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool UpdateAuthToken (string authToken)
		{
			const string __id = "updateAuthToken.(Ljava/lang/String;)Z";
			IntPtr native_authToken = JNIEnv.NewString ((string?)authToken);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_authToken);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_authToken);
			}
		}

	}
}
