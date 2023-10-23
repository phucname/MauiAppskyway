using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Core.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.util']/class[@name='Logger']"
	[global::Android.Runtime.Register ("com/ntt/skyway/core/util/Logger", DoNotGenerateAcw=true)]
	public sealed partial class Logger : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.util']/class[@name='Logger']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.Ntt.Skyway.Core.Util.Logger Instance {
			get {
				const string __id = "INSTANCE.Lcom/ntt/skyway/core/util/Logger;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Util.Logger> (__v.Handle, JniHandleOwnership.TransferLocalRef)!;
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.util']/class[@name='Logger.LogLevel']"
		[global::Android.Runtime.Register ("com/ntt/skyway/core/util/Logger$LogLevel", DoNotGenerateAcw=true)]
		public sealed partial class LogLevel : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.util']/class[@name='Logger.LogLevel']/field[@name='DEBUG']"
			[Register ("DEBUG")]
			public static global::Com.Ntt.Skyway.Core.Util.Logger.LogLevel? Debug {
				get {
					const string __id = "DEBUG.Lcom/ntt/skyway/core/util/Logger$LogLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Util.Logger.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.util']/class[@name='Logger.LogLevel']/field[@name='ERROR']"
			[Register ("ERROR")]
			public static global::Com.Ntt.Skyway.Core.Util.Logger.LogLevel? Error {
				get {
					const string __id = "ERROR.Lcom/ntt/skyway/core/util/Logger$LogLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Util.Logger.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.util']/class[@name='Logger.LogLevel']/field[@name='INFO']"
			[Register ("INFO")]
			public static global::Com.Ntt.Skyway.Core.Util.Logger.LogLevel? Info {
				get {
					const string __id = "INFO.Lcom/ntt/skyway/core/util/Logger$LogLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Util.Logger.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.util']/class[@name='Logger.LogLevel']/field[@name='NONE']"
			[Register ("NONE")]
			public static global::Com.Ntt.Skyway.Core.Util.Logger.LogLevel? None {
				get {
					const string __id = "NONE.Lcom/ntt/skyway/core/util/Logger$LogLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Util.Logger.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.util']/class[@name='Logger.LogLevel']/field[@name='VERBOSE']"
			[Register ("VERBOSE")]
			public static global::Com.Ntt.Skyway.Core.Util.Logger.LogLevel? Verbose {
				get {
					const string __id = "VERBOSE.Lcom/ntt/skyway/core/util/Logger$LogLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Util.Logger.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.util']/class[@name='Logger.LogLevel']/field[@name='WARN']"
			[Register ("WARN")]
			public static global::Com.Ntt.Skyway.Core.Util.Logger.LogLevel? Warn {
				get {
					const string __id = "WARN.Lcom/ntt/skyway/core/util/Logger$LogLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Util.Logger.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/util/Logger$LogLevel", typeof (LogLevel));

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

			internal LogLevel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.util']/class[@name='Logger.LogLevel']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/ntt/skyway/core/util/Logger$LogLevel;", "")]
			public static unsafe global::Com.Ntt.Skyway.Core.Util.Logger.LogLevel? ValueOf (string? value)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/ntt/skyway/core/util/Logger$LogLevel;";
				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Util.Logger.LogLevel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.util']/class[@name='Logger.LogLevel']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/ntt/skyway/core/util/Logger$LogLevel;", "")]
			public static unsafe global::Com.Ntt.Skyway.Core.Util.Logger.LogLevel[]? Values ()
			{
				const string __id = "values.()[Lcom/ntt/skyway/core/util/Logger$LogLevel;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Ntt.Skyway.Core.Util.Logger.LogLevel[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Ntt.Skyway.Core.Util.Logger.LogLevel));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.util']/class[@name='Logger.WhenMappings']"
		[global::Android.Runtime.Register ("com/ntt/skyway/core/util/Logger$WhenMappings", DoNotGenerateAcw=true)]
		public sealed partial class WhenMappings : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/util/Logger$WhenMappings", typeof (WhenMappings));

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

			internal WhenMappings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/util/Logger", typeof (Logger));

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

		internal Logger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe bool WebRTCLog {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.util']/class[@name='Logger']/method[@name='getWebRTCLog' and count(parameter)=0]"
			[Register ("getWebRTCLog", "()Z", "")]
			get {
				const string __id = "getWebRTCLog.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.util']/class[@name='Logger']/method[@name='setWebRTCLog' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setWebRTCLog", "(Z)V", "")]
			set {
				const string __id = "setWebRTCLog.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.util']/class[@name='Logger']/method[@name='getLogLevel' and count(parameter)=0]"
		[Register ("getLogLevel", "()Lcom/ntt/skyway/core/util/Logger$LogLevel;", "")]
		public unsafe global::Com.Ntt.Skyway.Core.Util.Logger.LogLevel GetLogLevel ()
		{
			const string __id = "getLogLevel.()Lcom/ntt/skyway/core/util/Logger$LogLevel;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Util.Logger.LogLevel> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.util']/class[@name='Logger']/method[@name='log' and count(parameter)=2 and parameter[1][@type='com.ntt.skyway.core.util.Logger.LogLevel'] and parameter[2][@type='java.lang.String']]"
		[Register ("log", "(Lcom/ntt/skyway/core/util/Logger$LogLevel;Ljava/lang/String;)V", "")]
		public unsafe void Log (global::Com.Ntt.Skyway.Core.Util.Logger.LogLevel level, string message)
		{
			const string __id = "log.(Lcom/ntt/skyway/core/util/Logger$LogLevel;Ljava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString ((string?)message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((level == null) ? IntPtr.Zero : ((global::Java.Lang.Object) level).Handle);
				__args [1] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				global::System.GC.KeepAlive (level);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.util']/class[@name='Logger']/method[@name='log' and count(parameter)=3 and parameter[1][@type='com.ntt.skyway.core.util.Logger.LogLevel'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("log", "(Lcom/ntt/skyway/core/util/Logger$LogLevel;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void Log (global::Com.Ntt.Skyway.Core.Util.Logger.LogLevel level, string message, string tag)
		{
			const string __id = "log.(Lcom/ntt/skyway/core/util/Logger$LogLevel;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString ((string?)message);
			IntPtr native_tag = JNIEnv.NewString ((string?)tag);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((level == null) ? IntPtr.Zero : ((global::Java.Lang.Object) level).Handle);
				__args [1] = new JniArgumentValue (native_message);
				__args [2] = new JniArgumentValue (native_tag);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				JNIEnv.DeleteLocalRef (native_tag);
				global::System.GC.KeepAlive (level);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.util']/class[@name='Logger']/method[@name='log' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='int']]"
		[Register ("log", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V", "")]
		public unsafe void Log (int level, string message, string fileName, string methodName, int lineNumber)
		{
			const string __id = "log.(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V";
			IntPtr native_message = JNIEnv.NewString ((string?)message);
			IntPtr native_fileName = JNIEnv.NewString ((string?)fileName);
			IntPtr native_methodName = JNIEnv.NewString ((string?)methodName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (level);
				__args [1] = new JniArgumentValue (native_message);
				__args [2] = new JniArgumentValue (native_fileName);
				__args [3] = new JniArgumentValue (native_methodName);
				__args [4] = new JniArgumentValue (lineNumber);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				JNIEnv.DeleteLocalRef (native_fileName);
				JNIEnv.DeleteLocalRef (native_methodName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.util']/class[@name='Logger']/method[@name='logD' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("logD", "(Ljava/lang/String;)V", "")]
		public unsafe void LogD (string message)
		{
			const string __id = "logD.(Ljava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString ((string?)message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.util']/class[@name='Logger']/method[@name='logE' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("logE", "(Ljava/lang/String;)V", "")]
		public unsafe void LogE (string message)
		{
			const string __id = "logE.(Ljava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString ((string?)message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.util']/class[@name='Logger']/method[@name='logI' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("logI", "(Ljava/lang/String;)V", "")]
		public unsafe void LogI (string message)
		{
			const string __id = "logI.(Ljava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString ((string?)message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.util']/class[@name='Logger']/method[@name='logV' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("logV", "(Ljava/lang/String;)V", "")]
		public unsafe void LogV (string message)
		{
			const string __id = "logV.(Ljava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString ((string?)message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.util']/class[@name='Logger']/method[@name='logW' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("logW", "(Ljava/lang/String;)V", "")]
		public unsafe void LogW (string message)
		{
			const string __id = "logW.(Ljava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString ((string?)message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.util']/class[@name='Logger']/method[@name='setLogLevel' and count(parameter)=1 and parameter[1][@type='com.ntt.skyway.core.util.Logger.LogLevel']]"
		[Register ("setLogLevel", "(Lcom/ntt/skyway/core/util/Logger$LogLevel;)V", "")]
		public unsafe void SetLogLevel (global::Com.Ntt.Skyway.Core.Util.Logger.LogLevel value)
		{
			const string __id = "setLogLevel.(Lcom/ntt/skyway/core/util/Logger$LogLevel;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (value);
			}
		}

	}
}
