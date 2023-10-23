using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Core.Content {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.content']/class[@name='Codec']"
	[global::Android.Runtime.Register ("com/ntt/skyway/core/content/Codec", DoNotGenerateAcw=true)]
	public sealed partial class Codec : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.content']/class[@name='Codec.Companion']"
		[global::Android.Runtime.Register ("com/ntt/skyway/core/content/Codec$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/content/Codec$Companion", typeof (Companion));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core.content']/class[@name='Codec.Companion']/constructor[@name='Codec.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.content']/class[@name='Codec.MimeType']"
		[global::Android.Runtime.Register ("com/ntt/skyway/core/content/Codec$MimeType", DoNotGenerateAcw=true)]
		public sealed partial class MimeType : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.content']/class[@name='Codec.MimeType']/field[@name='AV1']"
			[Register ("AV1")]
			public static global::Com.Ntt.Skyway.Core.Content.Codec.MimeType? Av1 {
				get {
					const string __id = "AV1.Lcom/ntt/skyway/core/content/Codec$MimeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Codec.MimeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.content']/class[@name='Codec.MimeType']/field[@name='H264']"
			[Register ("H264")]
			public static global::Com.Ntt.Skyway.Core.Content.Codec.MimeType? H264 {
				get {
					const string __id = "H264.Lcom/ntt/skyway/core/content/Codec$MimeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Codec.MimeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.content']/class[@name='Codec.MimeType']/field[@name='OPUS']"
			[Register ("OPUS")]
			public static global::Com.Ntt.Skyway.Core.Content.Codec.MimeType? Opus {
				get {
					const string __id = "OPUS.Lcom/ntt/skyway/core/content/Codec$MimeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Codec.MimeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.content']/class[@name='Codec.MimeType']/field[@name='RED']"
			[Register ("RED")]
			public static global::Com.Ntt.Skyway.Core.Content.Codec.MimeType? Red {
				get {
					const string __id = "RED.Lcom/ntt/skyway/core/content/Codec$MimeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Codec.MimeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.content']/class[@name='Codec.MimeType']/field[@name='VP8']"
			[Register ("VP8")]
			public static global::Com.Ntt.Skyway.Core.Content.Codec.MimeType? Vp8 {
				get {
					const string __id = "VP8.Lcom/ntt/skyway/core/content/Codec$MimeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Codec.MimeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.content']/class[@name='Codec.MimeType']/field[@name='VP9']"
			[Register ("VP9")]
			public static global::Com.Ntt.Skyway.Core.Content.Codec.MimeType? Vp9 {
				get {
					const string __id = "VP9.Lcom/ntt/skyway/core/content/Codec$MimeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Codec.MimeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.content']/class[@name='Codec.MimeType.Companion']"
			[global::Android.Runtime.Register ("com/ntt/skyway/core/content/Codec$MimeType$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/content/Codec$MimeType$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core.content']/class[@name='Codec.MimeType.Companion']/constructor[@name='Codec.MimeType.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/content/Codec$MimeType", typeof (MimeType));

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

			internal MimeType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			public unsafe string Literal {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content']/class[@name='Codec.MimeType']/method[@name='getLiteral' and count(parameter)=0]"
				[Register ("getLiteral", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getLiteral.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content']/class[@name='Codec.MimeType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/ntt/skyway/core/content/Codec$MimeType;", "")]
			public static unsafe global::Com.Ntt.Skyway.Core.Content.Codec.MimeType? ValueOf (string? value)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/ntt/skyway/core/content/Codec$MimeType;";
				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Codec.MimeType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content']/class[@name='Codec.MimeType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/ntt/skyway/core/content/Codec$MimeType;", "")]
			public static unsafe global::Com.Ntt.Skyway.Core.Content.Codec.MimeType[]? Values ()
			{
				const string __id = "values.()[Lcom/ntt/skyway/core/content/Codec$MimeType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Ntt.Skyway.Core.Content.Codec.MimeType[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Ntt.Skyway.Core.Content.Codec.MimeType));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/content/Codec", typeof (Codec));

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

		internal Codec (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core.content']/class[@name='Codec']/constructor[@name='Codec' and count(parameter)=1 and parameter[1][@type='com.ntt.skyway.core.content.Codec.MimeType']]"
		[Register (".ctor", "(Lcom/ntt/skyway/core/content/Codec$MimeType;)V", "")]
		public unsafe Codec (global::Com.Ntt.Skyway.Core.Content.Codec.MimeType mimeType) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/ntt/skyway/core/content/Codec$MimeType;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mimeType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mimeType).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (mimeType);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core.content']/class[@name='Codec']/constructor[@name='Codec' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe Codec (string mimeType) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_mimeType = JNIEnv.NewString ((string?)mimeType);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_mimeType);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mimeType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content']/class[@name='Codec']/method[@name='component1' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content']/class[@name='Codec']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("copy", "(Ljava/lang/String;)Lcom/ntt/skyway/core/content/Codec;", "")]
		public unsafe global::Com.Ntt.Skyway.Core.Content.Codec Copy (string mimeType)
		{
			const string __id = "copy.(Ljava/lang/String;)Lcom/ntt/skyway/core/content/Codec;";
			IntPtr native_mimeType = JNIEnv.NewString ((string?)mimeType);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_mimeType);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Codec> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
				JNIEnv.DeleteLocalRef (native_mimeType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content']/class[@name='Codec']/method[@name='getMimeType' and count(parameter)=0]"
		[Register ("getMimeType", "()Ljava/lang/String;", "")]
		public unsafe string GetMimeType ()
		{
			const string __id = "getMimeType.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
			}
		}

	}
}
