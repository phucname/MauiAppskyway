using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Core.Content.Sink {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='SurfaceViewRenderer']"
	[global::Android.Runtime.Register ("com/ntt/skyway/core/content/sink/SurfaceViewRenderer", DoNotGenerateAcw=true)]
	public sealed partial class SurfaceViewRenderer : global::Android.Widget.FrameLayout, global::Com.Ntt.Skyway.Core.Content.Sink.IRenderer {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='SurfaceViewRenderer.LayoutParam']"
		[global::Android.Runtime.Register ("com/ntt/skyway/core/content/sink/SurfaceViewRenderer$LayoutParam", DoNotGenerateAcw=true)]
		public sealed partial class LayoutParam : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='SurfaceViewRenderer.LayoutParam']/field[@name='FILL_PARENT']"
			[Register ("FILL_PARENT")]
			public static global::Com.Ntt.Skyway.Core.Content.Sink.SurfaceViewRenderer.LayoutParam? FillParent {
				get {
					const string __id = "FILL_PARENT.Lcom/ntt/skyway/core/content/sink/SurfaceViewRenderer$LayoutParam;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Sink.SurfaceViewRenderer.LayoutParam> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='SurfaceViewRenderer.LayoutParam']/field[@name='MATCH_PARENT']"
			[Register ("MATCH_PARENT")]
			public static global::Com.Ntt.Skyway.Core.Content.Sink.SurfaceViewRenderer.LayoutParam? MatchParent {
				get {
					const string __id = "MATCH_PARENT.Lcom/ntt/skyway/core/content/sink/SurfaceViewRenderer$LayoutParam;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Sink.SurfaceViewRenderer.LayoutParam> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='SurfaceViewRenderer.LayoutParam']/field[@name='WRAP_CONTENT']"
			[Register ("WRAP_CONTENT")]
			public static global::Com.Ntt.Skyway.Core.Content.Sink.SurfaceViewRenderer.LayoutParam? WrapContent {
				get {
					const string __id = "WRAP_CONTENT.Lcom/ntt/skyway/core/content/sink/SurfaceViewRenderer$LayoutParam;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Sink.SurfaceViewRenderer.LayoutParam> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/content/sink/SurfaceViewRenderer$LayoutParam", typeof (LayoutParam));

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

			internal LayoutParam (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			public unsafe int Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='SurfaceViewRenderer.LayoutParam']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()I", "")]
				get {
					const string __id = "getValue.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='SurfaceViewRenderer.LayoutParam']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/ntt/skyway/core/content/sink/SurfaceViewRenderer$LayoutParam;", "")]
			public static unsafe global::Com.Ntt.Skyway.Core.Content.Sink.SurfaceViewRenderer.LayoutParam? ValueOf (string? value)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/ntt/skyway/core/content/sink/SurfaceViewRenderer$LayoutParam;";
				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Sink.SurfaceViewRenderer.LayoutParam> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='SurfaceViewRenderer.LayoutParam']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/ntt/skyway/core/content/sink/SurfaceViewRenderer$LayoutParam;", "")]
			public static unsafe global::Com.Ntt.Skyway.Core.Content.Sink.SurfaceViewRenderer.LayoutParam[]? Values ()
			{
				const string __id = "values.()[Lcom/ntt/skyway/core/content/sink/SurfaceViewRenderer$LayoutParam;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Ntt.Skyway.Core.Content.Sink.SurfaceViewRenderer.LayoutParam[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Ntt.Skyway.Core.Content.Sink.SurfaceViewRenderer.LayoutParam));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='SurfaceViewRenderer.ScalingType']"
		[global::Android.Runtime.Register ("com/ntt/skyway/core/content/sink/SurfaceViewRenderer$ScalingType", DoNotGenerateAcw=true)]
		public sealed partial class ScalingType : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='SurfaceViewRenderer.ScalingType']/field[@name='SCALE_ASPECT_BALANCED']"
			[Register ("SCALE_ASPECT_BALANCED")]
			public static global::Com.Ntt.Skyway.Core.Content.Sink.SurfaceViewRenderer.ScalingType? ScaleAspectBalanced {
				get {
					const string __id = "SCALE_ASPECT_BALANCED.Lcom/ntt/skyway/core/content/sink/SurfaceViewRenderer$ScalingType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Sink.SurfaceViewRenderer.ScalingType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='SurfaceViewRenderer.ScalingType']/field[@name='SCALE_ASPECT_FILL']"
			[Register ("SCALE_ASPECT_FILL")]
			public static global::Com.Ntt.Skyway.Core.Content.Sink.SurfaceViewRenderer.ScalingType? ScaleAspectFill {
				get {
					const string __id = "SCALE_ASPECT_FILL.Lcom/ntt/skyway/core/content/sink/SurfaceViewRenderer$ScalingType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Sink.SurfaceViewRenderer.ScalingType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='SurfaceViewRenderer.ScalingType']/field[@name='SCALE_ASPECT_FIT']"
			[Register ("SCALE_ASPECT_FIT")]
			public static global::Com.Ntt.Skyway.Core.Content.Sink.SurfaceViewRenderer.ScalingType? ScaleAspectFit {
				get {
					const string __id = "SCALE_ASPECT_FIT.Lcom/ntt/skyway/core/content/sink/SurfaceViewRenderer$ScalingType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Sink.SurfaceViewRenderer.ScalingType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='SurfaceViewRenderer.ScalingType.Companion']"
			[global::Android.Runtime.Register ("com/ntt/skyway/core/content/sink/SurfaceViewRenderer$ScalingType$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='SurfaceViewRenderer.ScalingType.Companion.WhenMappings']"
				[global::Android.Runtime.Register ("com/ntt/skyway/core/content/sink/SurfaceViewRenderer$ScalingType$Companion$WhenMappings", DoNotGenerateAcw=true)]
				public sealed partial class WhenMappings : global::Java.Lang.Object {
					static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/content/sink/SurfaceViewRenderer$ScalingType$Companion$WhenMappings", typeof (WhenMappings));

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

				static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/content/sink/SurfaceViewRenderer$ScalingType$Companion", typeof (Companion));

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

				internal Companion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
				{
				}

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='SurfaceViewRenderer.ScalingType.Companion']/constructor[@name='SurfaceViewRenderer.ScalingType.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
				[Register (".ctor", "(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", "")]
				public unsafe Companion (global::Kotlin.Jvm.Internal.DefaultConstructorMarker? _constructor_marker) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
				{
					const string __id = "(Lkotlin/jvm/internal/DefaultConstructorMarker;)V";

					if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
						return;

					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue ((_constructor_marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _constructor_marker).Handle);
						var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
						SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
						_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
					} finally {
						global::System.GC.KeepAlive (_constructor_marker);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/content/sink/SurfaceViewRenderer$ScalingType", typeof (ScalingType));

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

			internal ScalingType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='SurfaceViewRenderer.ScalingType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/ntt/skyway/core/content/sink/SurfaceViewRenderer$ScalingType;", "")]
			public static unsafe global::Com.Ntt.Skyway.Core.Content.Sink.SurfaceViewRenderer.ScalingType? ValueOf (string? value)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/ntt/skyway/core/content/sink/SurfaceViewRenderer$ScalingType;";
				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Sink.SurfaceViewRenderer.ScalingType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='SurfaceViewRenderer.ScalingType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/ntt/skyway/core/content/sink/SurfaceViewRenderer$ScalingType;", "")]
			public static unsafe global::Com.Ntt.Skyway.Core.Content.Sink.SurfaceViewRenderer.ScalingType[]? Values ()
			{
				const string __id = "values.()[Lcom/ntt/skyway/core/content/sink/SurfaceViewRenderer$ScalingType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Ntt.Skyway.Core.Content.Sink.SurfaceViewRenderer.ScalingType[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Ntt.Skyway.Core.Content.Sink.SurfaceViewRenderer.ScalingType));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/content/sink/SurfaceViewRenderer", typeof (SurfaceViewRenderer));

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

		internal SurfaceViewRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='SurfaceViewRenderer']/constructor[@name='SurfaceViewRenderer' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe SurfaceViewRenderer (global::Android.Content.Context context) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='SurfaceViewRenderer']/constructor[@name='SurfaceViewRenderer' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe SurfaceViewRenderer (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (attrs);
			}
		}

		public unsafe bool Setup {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='SurfaceViewRenderer']/method[@name='isSetup' and count(parameter)=0]"
			[Register ("isSetup", "()Z", "")]
			get {
				const string __id = "isSetup.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='SurfaceViewRenderer']/method[@name='setSetup' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSetup", "(Z)V", "")]
			set {
				const string __id = "setSetup.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='SurfaceViewRenderer']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "")]
		public unsafe void Dispose ()
		{
			const string __id = "dispose.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='SurfaceViewRenderer']/method[@name='setScalingType' and count(parameter)=1 and parameter[1][@type='com.ntt.skyway.core.content.sink.SurfaceViewRenderer.ScalingType']]"
		[Register ("setScalingType", "(Lcom/ntt/skyway/core/content/sink/SurfaceViewRenderer$ScalingType;)V", "")]
		public unsafe void SetScalingType (global::Com.Ntt.Skyway.Core.Content.Sink.SurfaceViewRenderer.ScalingType scalingType)
		{
			const string __id = "setScalingType.(Lcom/ntt/skyway/core/content/sink/SurfaceViewRenderer$ScalingType;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((scalingType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scalingType).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (scalingType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='SurfaceViewRenderer']/method[@name='setup' and count(parameter)=2 and parameter[1][@type='com.ntt.skyway.core.content.sink.SurfaceViewRenderer.LayoutParam'] and parameter[2][@type='com.ntt.skyway.core.content.sink.SurfaceViewRenderer.LayoutParam']]"
		[Register ("setup", "(Lcom/ntt/skyway/core/content/sink/SurfaceViewRenderer$LayoutParam;Lcom/ntt/skyway/core/content/sink/SurfaceViewRenderer$LayoutParam;)V", "")]
		public unsafe void InvokeSetup (global::Com.Ntt.Skyway.Core.Content.Sink.SurfaceViewRenderer.LayoutParam width, global::Com.Ntt.Skyway.Core.Content.Sink.SurfaceViewRenderer.LayoutParam height)
		{
			const string __id = "setup.(Lcom/ntt/skyway/core/content/sink/SurfaceViewRenderer$LayoutParam;Lcom/ntt/skyway/core/content/sink/SurfaceViewRenderer$LayoutParam;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((width == null) ? IntPtr.Zero : ((global::Java.Lang.Object) width).Handle);
				__args [1] = new JniArgumentValue ((height == null) ? IntPtr.Zero : ((global::Java.Lang.Object) height).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (width);
				global::System.GC.KeepAlive (height);
			}
		}

	}
}
