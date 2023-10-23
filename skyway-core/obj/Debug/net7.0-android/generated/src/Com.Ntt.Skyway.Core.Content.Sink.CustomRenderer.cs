using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Core.Content.Sink {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='CustomRenderer']"
	[global::Android.Runtime.Register ("com/ntt/skyway/core/content/sink/CustomRenderer", DoNotGenerateAcw=true)]
	public sealed partial class CustomRenderer : global::Java.Lang.Object, global::Com.Ntt.Skyway.Core.Content.Sink.IRenderer {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='CustomRenderer.VideoFrameBuffer']"
		[global::Android.Runtime.Register ("com/ntt/skyway/core/content/sink/CustomRenderer$VideoFrameBuffer", DoNotGenerateAcw=true)]
		public sealed partial class VideoFrameBuffer : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/content/sink/CustomRenderer$VideoFrameBuffer", typeof (VideoFrameBuffer));

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

			internal VideoFrameBuffer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='CustomRenderer.VideoFrameBuffer']/constructor[@name='CustomRenderer.VideoFrameBuffer' and count(parameter)=8 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.nio.ByteBuffer'] and parameter[4][@type='java.nio.ByteBuffer'] and parameter[5][@type='java.nio.ByteBuffer'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int']]"
			[Register (".ctor", "(IILjava/nio/ByteBuffer;Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;III)V", "")]
			public unsafe VideoFrameBuffer (int width, int height, global::Java.Nio.ByteBuffer dataY, global::Java.Nio.ByteBuffer dataU, global::Java.Nio.ByteBuffer dataV, int strideY, int strideU, int strideV) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(IILjava/nio/ByteBuffer;Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;III)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [8];
					__args [0] = new JniArgumentValue (width);
					__args [1] = new JniArgumentValue (height);
					__args [2] = new JniArgumentValue ((dataY == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataY).Handle);
					__args [3] = new JniArgumentValue ((dataU == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataU).Handle);
					__args [4] = new JniArgumentValue ((dataV == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataV).Handle);
					__args [5] = new JniArgumentValue (strideY);
					__args [6] = new JniArgumentValue (strideU);
					__args [7] = new JniArgumentValue (strideV);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (dataY);
					global::System.GC.KeepAlive (dataU);
					global::System.GC.KeepAlive (dataV);
				}
			}

			public unsafe global::Java.Nio.ByteBuffer DataU {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='CustomRenderer.VideoFrameBuffer']/method[@name='getDataU' and count(parameter)=0]"
				[Register ("getDataU", "()Ljava/nio/ByteBuffer;", "")]
				get {
					const string __id = "getDataU.()Ljava/nio/ByteBuffer;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
					} finally {
					}
				}
			}

			public unsafe global::Java.Nio.ByteBuffer DataV {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='CustomRenderer.VideoFrameBuffer']/method[@name='getDataV' and count(parameter)=0]"
				[Register ("getDataV", "()Ljava/nio/ByteBuffer;", "")]
				get {
					const string __id = "getDataV.()Ljava/nio/ByteBuffer;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
					} finally {
					}
				}
			}

			public unsafe global::Java.Nio.ByteBuffer DataY {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='CustomRenderer.VideoFrameBuffer']/method[@name='getDataY' and count(parameter)=0]"
				[Register ("getDataY", "()Ljava/nio/ByteBuffer;", "")]
				get {
					const string __id = "getDataY.()Ljava/nio/ByteBuffer;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
					} finally {
					}
				}
			}

			public unsafe int Height {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='CustomRenderer.VideoFrameBuffer']/method[@name='getHeight' and count(parameter)=0]"
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

			public unsafe int StrideU {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='CustomRenderer.VideoFrameBuffer']/method[@name='getStrideU' and count(parameter)=0]"
				[Register ("getStrideU", "()I", "")]
				get {
					const string __id = "getStrideU.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe int StrideV {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='CustomRenderer.VideoFrameBuffer']/method[@name='getStrideV' and count(parameter)=0]"
				[Register ("getStrideV", "()I", "")]
				get {
					const string __id = "getStrideV.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe int StrideY {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='CustomRenderer.VideoFrameBuffer']/method[@name='getStrideY' and count(parameter)=0]"
				[Register ("getStrideY", "()I", "")]
				get {
					const string __id = "getStrideY.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe int Width {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='CustomRenderer.VideoFrameBuffer']/method[@name='getWidth' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='CustomRenderer.VideoFrameBuffer']/method[@name='component1' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='CustomRenderer.VideoFrameBuffer']/method[@name='component2' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='CustomRenderer.VideoFrameBuffer']/method[@name='component3' and count(parameter)=0]"
			[Register ("component3", "()Ljava/nio/ByteBuffer;", "")]
			public unsafe global::Java.Nio.ByteBuffer Component3 ()
			{
				const string __id = "component3.()Ljava/nio/ByteBuffer;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='CustomRenderer.VideoFrameBuffer']/method[@name='component4' and count(parameter)=0]"
			[Register ("component4", "()Ljava/nio/ByteBuffer;", "")]
			public unsafe global::Java.Nio.ByteBuffer Component4 ()
			{
				const string __id = "component4.()Ljava/nio/ByteBuffer;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='CustomRenderer.VideoFrameBuffer']/method[@name='component5' and count(parameter)=0]"
			[Register ("component5", "()Ljava/nio/ByteBuffer;", "")]
			public unsafe global::Java.Nio.ByteBuffer Component5 ()
			{
				const string __id = "component5.()Ljava/nio/ByteBuffer;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='CustomRenderer.VideoFrameBuffer']/method[@name='component6' and count(parameter)=0]"
			[Register ("component6", "()I", "")]
			public unsafe int Component6 ()
			{
				const string __id = "component6.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='CustomRenderer.VideoFrameBuffer']/method[@name='component7' and count(parameter)=0]"
			[Register ("component7", "()I", "")]
			public unsafe int Component7 ()
			{
				const string __id = "component7.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='CustomRenderer.VideoFrameBuffer']/method[@name='component8' and count(parameter)=0]"
			[Register ("component8", "()I", "")]
			public unsafe int Component8 ()
			{
				const string __id = "component8.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='CustomRenderer.VideoFrameBuffer']/method[@name='copy' and count(parameter)=8 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.nio.ByteBuffer'] and parameter[4][@type='java.nio.ByteBuffer'] and parameter[5][@type='java.nio.ByteBuffer'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int']]"
			[Register ("copy", "(IILjava/nio/ByteBuffer;Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;III)Lcom/ntt/skyway/core/content/sink/CustomRenderer$VideoFrameBuffer;", "")]
			public unsafe global::Com.Ntt.Skyway.Core.Content.Sink.CustomRenderer.VideoFrameBuffer Copy (int width, int height, global::Java.Nio.ByteBuffer dataY, global::Java.Nio.ByteBuffer dataU, global::Java.Nio.ByteBuffer dataV, int strideY, int strideU, int strideV)
			{
				const string __id = "copy.(IILjava/nio/ByteBuffer;Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;III)Lcom/ntt/skyway/core/content/sink/CustomRenderer$VideoFrameBuffer;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [8];
					__args [0] = new JniArgumentValue (width);
					__args [1] = new JniArgumentValue (height);
					__args [2] = new JniArgumentValue ((dataY == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataY).Handle);
					__args [3] = new JniArgumentValue ((dataU == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataU).Handle);
					__args [4] = new JniArgumentValue ((dataV == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataV).Handle);
					__args [5] = new JniArgumentValue (strideY);
					__args [6] = new JniArgumentValue (strideU);
					__args [7] = new JniArgumentValue (strideV);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Sink.CustomRenderer.VideoFrameBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
					global::System.GC.KeepAlive (dataY);
					global::System.GC.KeepAlive (dataU);
					global::System.GC.KeepAlive (dataV);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/content/sink/CustomRenderer", typeof (CustomRenderer));

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

		internal CustomRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='CustomRenderer']/constructor[@name='CustomRenderer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CustomRenderer () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public unsafe global::Kotlin.Jvm.Functions.IFunction1? OnFrameHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='CustomRenderer']/method[@name='getOnFrameHandler' and count(parameter)=0]"
			[Register ("getOnFrameHandler", "()Lkotlin/jvm/functions/Function1;", "")]
			get {
				const string __id = "getOnFrameHandler.()Lkotlin/jvm/functions/Function1;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='CustomRenderer']/method[@name='setOnFrameHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super com.ntt.skyway.core.content.sink.CustomRenderer.VideoFrameBuffer, kotlin.Unit&gt;']]"
			[Register ("setOnFrameHandler", "(Lkotlin/jvm/functions/Function1;)V", "")]
			set {
				const string __id = "setOnFrameHandler.(Lkotlin/jvm/functions/Function1;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe bool Setup {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='CustomRenderer']/method[@name='isSetup' and count(parameter)=0]"
			[Register ("isSetup", "()Z", "")]
			get {
				const string __id = "isSetup.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='CustomRenderer']/method[@name='setSetup' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='CustomRenderer']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "")]
		public unsafe void Dispose ()
		{
			const string __id = "dispose.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
