using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Core.Content.Local.Source {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='CameraSource']"
	[global::Android.Runtime.Register ("com/ntt/skyway/core/content/local/source/CameraSource", DoNotGenerateAcw=true)]
	public sealed partial class CameraSource : global::Com.Ntt.Skyway.Core.Content.Local.Source.VideoSource {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='CameraSource']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.Ntt.Skyway.Core.Content.Local.Source.CameraSource Instance {
			get {
				const string __id = "INSTANCE.Lcom/ntt/skyway/core/content/local/source/CameraSource;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Local.Source.CameraSource> (__v.Handle, JniHandleOwnership.TransferLocalRef)!;
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='CameraSource.CapturingOptions']"
		[global::Android.Runtime.Register ("com/ntt/skyway/core/content/local/source/CameraSource$CapturingOptions", DoNotGenerateAcw=true)]
		public sealed partial class CapturingOptions : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/content/local/source/CameraSource$CapturingOptions", typeof (CapturingOptions));

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

			internal CapturingOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='CameraSource.CapturingOptions']/constructor[@name='CameraSource.CapturingOptions' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register (".ctor", "(III)V", "")]
			public unsafe CapturingOptions (int width, int height, int frameRate) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(III)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (width);
					__args [1] = new JniArgumentValue (height);
					__args [2] = new JniArgumentValue (frameRate);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			public unsafe int FrameRate {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='CameraSource.CapturingOptions']/method[@name='getFrameRate' and count(parameter)=0]"
				[Register ("getFrameRate", "()I", "")]
				get {
					const string __id = "getFrameRate.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe int Height {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='CameraSource.CapturingOptions']/method[@name='getHeight' and count(parameter)=0]"
				[Register ("getHeight", "()I", "")]
				get {
					const string __id = "getHeight.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe int Width {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='CameraSource.CapturingOptions']/method[@name='getWidth' and count(parameter)=0]"
				[Register ("getWidth", "()I", "")]
				get {
					const string __id = "getWidth.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='CameraSource.CapturingOptions']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()I", "")]
			public unsafe int Component1 ()
			{
				const string __id = "component1.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='CameraSource.CapturingOptions']/method[@name='component2' and count(parameter)=0]"
			[Register ("component2", "()I", "")]
			public unsafe int Component2 ()
			{
				const string __id = "component2.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='CameraSource.CapturingOptions']/method[@name='component3' and count(parameter)=0]"
			[Register ("component3", "()I", "")]
			public unsafe int Component3 ()
			{
				const string __id = "component3.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='CameraSource.CapturingOptions']/method[@name='copy' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("copy", "(III)Lcom/ntt/skyway/core/content/local/source/CameraSource$CapturingOptions;", "")]
			public unsafe global::Com.Ntt.Skyway.Core.Content.Local.Source.CameraSource.CapturingOptions Copy (int width, int height, int frameRate)
			{
				const string __id = "copy.(III)Lcom/ntt/skyway/core/content/local/source/CameraSource$CapturingOptions;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (width);
					__args [1] = new JniArgumentValue (height);
					__args [2] = new JniArgumentValue (frameRate);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Local.Source.CameraSource.CapturingOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/content/local/source/CameraSource", typeof (CameraSource));

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

		internal CameraSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe global::Kotlin.Jvm.Functions.IFunction1? OnCameraChangeErrorHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='CameraSource']/method[@name='getOnCameraChangeErrorHandler' and count(parameter)=0]"
			[Register ("getOnCameraChangeErrorHandler", "()Lkotlin/jvm/functions/Function1;", "")]
			get {
				const string __id = "getOnCameraChangeErrorHandler.()Lkotlin/jvm/functions/Function1;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='CameraSource']/method[@name='setOnCameraChangeErrorHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super java.lang.String, kotlin.Unit&gt;']]"
			[Register ("setOnCameraChangeErrorHandler", "(Lkotlin/jvm/functions/Function1;)V", "")]
			set {
				const string __id = "setOnCameraChangeErrorHandler.(Lkotlin/jvm/functions/Function1;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Kotlin.Jvm.Functions.IFunction1? OnCameraChangedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='CameraSource']/method[@name='getOnCameraChangedHandler' and count(parameter)=0]"
			[Register ("getOnCameraChangedHandler", "()Lkotlin/jvm/functions/Function1;", "")]
			get {
				const string __id = "getOnCameraChangedHandler.()Lkotlin/jvm/functions/Function1;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='CameraSource']/method[@name='setOnCameraChangedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super java.lang.Boolean, kotlin.Unit&gt;']]"
			[Register ("setOnCameraChangedHandler", "(Lkotlin/jvm/functions/Function1;)V", "")]
			set {
				const string __id = "setOnCameraChangedHandler.(Lkotlin/jvm/functions/Function1;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='CameraSource']/method[@name='changeCamera' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("changeCamera", "(Ljava/lang/String;)V", "")]
		public static unsafe void ChangeCamera (string deviceName)
		{
			const string __id = "changeCamera.(Ljava/lang/String;)V";
			IntPtr native_deviceName = JNIEnv.NewString ((string?)deviceName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_deviceName);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_deviceName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='CameraSource']/method[@name='getBackCameras' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getBackCameras", "(Landroid/content/Context;)Ljava/util/Set;", "")]
		public static unsafe global::System.Collections.Generic.ICollection<string> GetBackCameras (global::Android.Content.Context context)
		{
			const string __id = "getBackCameras.(Landroid/content/Context;)Ljava/util/Set;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='CameraSource']/method[@name='getCameras' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getCameras", "(Landroid/content/Context;)Ljava/util/Set;", "")]
		public static unsafe global::System.Collections.Generic.ICollection<string> GetCameras (global::Android.Content.Context context)
		{
			const string __id = "getCameras.(Landroid/content/Context;)Ljava/util/Set;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='CameraSource']/method[@name='getFrontCameras' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getFrontCameras", "(Landroid/content/Context;)Ljava/util/Set;", "")]
		public static unsafe global::System.Collections.Generic.ICollection<string> GetFrontCameras (global::Android.Content.Context context)
		{
			const string __id = "getFrontCameras.(Landroid/content/Context;)Ljava/util/Set;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='CameraSource']/method[@name='startCapturing' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.ntt.skyway.core.content.local.source.CameraSource.CapturingOptions']]"
		[Register ("startCapturing", "(Landroid/content/Context;Ljava/lang/String;Lcom/ntt/skyway/core/content/local/source/CameraSource$CapturingOptions;)V", "")]
		public static unsafe void StartCapturing (global::Android.Content.Context context, string deviceName, global::Com.Ntt.Skyway.Core.Content.Local.Source.CameraSource.CapturingOptions options)
		{
			const string __id = "startCapturing.(Landroid/content/Context;Ljava/lang/String;Lcom/ntt/skyway/core/content/local/source/CameraSource$CapturingOptions;)V";
			IntPtr native_deviceName = JNIEnv.NewString ((string?)deviceName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_deviceName);
				__args [2] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_deviceName);
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (options);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='CameraSource']/method[@name='stopCapturing' and count(parameter)=0]"
		[Register ("stopCapturing", "()V", "")]
		public static unsafe void StopCapturing ()
		{
			const string __id = "stopCapturing.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

	}
}
