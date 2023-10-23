using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Core.Content {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.content']/class[@name='Encoding']"
	[global::Android.Runtime.Register ("com/ntt/skyway/core/content/Encoding", DoNotGenerateAcw=true)]
	public sealed partial class Encoding : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.content']/class[@name='Encoding.Companion']"
		[global::Android.Runtime.Register ("com/ntt/skyway/core/content/Encoding$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/content/Encoding$Companion", typeof (Companion));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core.content']/class[@name='Encoding.Companion']/constructor[@name='Encoding.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/content/Encoding", typeof (Encoding));

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

		internal Encoding (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core.content']/class[@name='Encoding']/constructor[@name='Encoding' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Integer'] and parameter[3][@type='java.lang.Double'] and parameter[4][@type='java.lang.Double']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/Double;Ljava/lang/Double;)V", "")]
		public unsafe Encoding (string? id, global::Java.Lang.Integer? maxBitrate, global::Java.Lang.Double? scaleResolutionDownBy, global::Java.Lang.Double? maxFramerate) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/Double;Ljava/lang/Double;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_id = JNIEnv.NewString ((string?)id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue ((maxBitrate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) maxBitrate).Handle);
				__args [2] = new JniArgumentValue ((scaleResolutionDownBy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scaleResolutionDownBy).Handle);
				__args [3] = new JniArgumentValue ((maxFramerate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) maxFramerate).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				global::System.GC.KeepAlive (maxBitrate);
				global::System.GC.KeepAlive (scaleResolutionDownBy);
				global::System.GC.KeepAlive (maxFramerate);
			}
		}

		public unsafe string? Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content']/class[@name='Encoding']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Java.Lang.Integer? MaxBitrate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content']/class[@name='Encoding']/method[@name='getMaxBitrate' and count(parameter)=0]"
			[Register ("getMaxBitrate", "()Ljava/lang/Integer;", "")]
			get {
				const string __id = "getMaxBitrate.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Java.Lang.Double? MaxFramerate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content']/class[@name='Encoding']/method[@name='getMaxFramerate' and count(parameter)=0]"
			[Register ("getMaxFramerate", "()Ljava/lang/Double;", "")]
			get {
				const string __id = "getMaxFramerate.()Ljava/lang/Double;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Java.Lang.Double? ScaleResolutionDownBy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content']/class[@name='Encoding']/method[@name='getScaleResolutionDownBy' and count(parameter)=0]"
			[Register ("getScaleResolutionDownBy", "()Ljava/lang/Double;", "")]
			get {
				const string __id = "getScaleResolutionDownBy.()Ljava/lang/Double;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content']/class[@name='Encoding']/method[@name='component1' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content']/class[@name='Encoding']/method[@name='component2' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content']/class[@name='Encoding']/method[@name='component3' and count(parameter)=0]"
		[Register ("component3", "()Ljava/lang/Double;", "")]
		public unsafe global::Java.Lang.Double? Component3 ()
		{
			const string __id = "component3.()Ljava/lang/Double;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content']/class[@name='Encoding']/method[@name='component4' and count(parameter)=0]"
		[Register ("component4", "()Ljava/lang/Double;", "")]
		public unsafe global::Java.Lang.Double? Component4 ()
		{
			const string __id = "component4.()Ljava/lang/Double;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content']/class[@name='Encoding']/method[@name='copy' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Integer'] and parameter[3][@type='java.lang.Double'] and parameter[4][@type='java.lang.Double']]"
		[Register ("copy", "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/Double;Ljava/lang/Double;)Lcom/ntt/skyway/core/content/Encoding;", "")]
		public unsafe global::Com.Ntt.Skyway.Core.Content.Encoding Copy (string? id, global::Java.Lang.Integer? maxBitrate, global::Java.Lang.Double? scaleResolutionDownBy, global::Java.Lang.Double? maxFramerate)
		{
			const string __id = "copy.(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/Double;Ljava/lang/Double;)Lcom/ntt/skyway/core/content/Encoding;";
			IntPtr native_id = JNIEnv.NewString ((string?)id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue ((maxBitrate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) maxBitrate).Handle);
				__args [2] = new JniArgumentValue ((scaleResolutionDownBy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scaleResolutionDownBy).Handle);
				__args [3] = new JniArgumentValue ((maxFramerate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) maxFramerate).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Encoding> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				global::System.GC.KeepAlive (maxBitrate);
				global::System.GC.KeepAlive (scaleResolutionDownBy);
				global::System.GC.KeepAlive (maxFramerate);
			}
		}

	}
}
