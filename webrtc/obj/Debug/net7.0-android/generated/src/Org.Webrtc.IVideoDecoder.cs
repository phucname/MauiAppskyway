using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoDecoder']"
	[Register ("org/webrtc/VideoDecoder", "", "Org.Webrtc.IVideoDecoderInvoker")]
	public partial interface IVideoDecoder : IJavaObject, IJavaPeerable {
		private static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoDecoder", typeof (IVideoDecoder), isInterface: true);

		string? ImplementationName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoDecoder']/method[@name='getImplementationName' and count(parameter)=0]"
			[Register ("getImplementationName", "()Ljava/lang/String;", "GetGetImplementationNameHandler:Org.Webrtc.IVideoDecoderInvoker, webrtc")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoDecoder']/method[@name='decode' and count(parameter)=2 and parameter[1][@type='org.webrtc.EncodedImage'] and parameter[2][@type='org.webrtc.VideoDecoder.DecodeInfo']]"
		[Register ("decode", "(Lorg/webrtc/EncodedImage;Lorg/webrtc/VideoDecoder$DecodeInfo;)Lorg/webrtc/VideoCodecStatus;", "GetDecode_Lorg_webrtc_EncodedImage_Lorg_webrtc_VideoDecoder_DecodeInfo_Handler:Org.Webrtc.IVideoDecoderInvoker, webrtc")]
		global::Org.Webrtc.VideoCodecStatus? Decode (global::Org.Webrtc.EncodedImage? p0, global::Org.Webrtc.IVideoDecoder.DecodeInfo? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoDecoder']/method[@name='initDecode' and count(parameter)=2 and parameter[1][@type='org.webrtc.VideoDecoder.Settings'] and parameter[2][@type='org.webrtc.VideoDecoder.Callback']]"
		[Register ("initDecode", "(Lorg/webrtc/VideoDecoder$Settings;Lorg/webrtc/VideoDecoder$Callback;)Lorg/webrtc/VideoCodecStatus;", "GetInitDecode_Lorg_webrtc_VideoDecoder_Settings_Lorg_webrtc_VideoDecoder_Callback_Handler:Org.Webrtc.IVideoDecoderInvoker, webrtc")]
		global::Org.Webrtc.VideoCodecStatus? InitDecode (global::Org.Webrtc.IVideoDecoder.Settings? p0, global::Org.Webrtc.IVideoDecoder.ICallback? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoDecoder']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()Lorg/webrtc/VideoCodecStatus;", "GetReleaseHandler:Org.Webrtc.IVideoDecoderInvoker, webrtc")]
		global::Org.Webrtc.VideoCodecStatus? Release ();

		private static Delegate? cb_createNativeVideoDecoder;
#pragma warning disable 0169
		private static Delegate GetCreateNativeVideoDecoderHandler ()
		{
			if (cb_createNativeVideoDecoder == null)
				cb_createNativeVideoDecoder = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_CreateNativeVideoDecoder);
			return cb_createNativeVideoDecoder;
		}

		private static long n_CreateNativeVideoDecoder (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.CreateNativeVideoDecoder ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoDecoder']/method[@name='createNativeVideoDecoder' and count(parameter)=0]"
		[Register ("createNativeVideoDecoder", "()J", "GetCreateNativeVideoDecoderHandler:Org.Webrtc.IVideoDecoder, webrtc")]
		virtual unsafe long CreateNativeVideoDecoder ()
		{
			const string __id = "createNativeVideoDecoder.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoDecoder.Callback']"
		[Register ("org/webrtc/VideoDecoder$Callback", "", "Org.Webrtc.IVideoDecoder/ICallbackInvoker")]
		public partial interface ICallback : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoDecoder.Callback']/method[@name='onDecodedFrame' and count(parameter)=3 and parameter[1][@type='org.webrtc.VideoFrame'] and parameter[2][@type='java.lang.Integer'] and parameter[3][@type='java.lang.Integer']]"
			[Register ("onDecodedFrame", "(Lorg/webrtc/VideoFrame;Ljava/lang/Integer;Ljava/lang/Integer;)V", "GetOnDecodedFrame_Lorg_webrtc_VideoFrame_Ljava_lang_Integer_Ljava_lang_Integer_Handler:Org.Webrtc.IVideoDecoder/ICallbackInvoker, webrtc")]
			void OnDecodedFrame (global::Org.Webrtc.VideoFrame? p0, global::Java.Lang.Integer? p1, global::Java.Lang.Integer? p2);

		}

		[global::Android.Runtime.Register ("org/webrtc/VideoDecoder$Callback", DoNotGenerateAcw=true)]
		internal partial class ICallbackInvoker : global::Java.Lang.Object, ICallback {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoDecoder$Callback", typeof (ICallbackInvoker));

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

			public static ICallback? GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.webrtc.VideoDecoder.Callback'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate? cb_onDecodedFrame_Lorg_webrtc_VideoFrame_Ljava_lang_Integer_Ljava_lang_Integer_;
#pragma warning disable 0169
			static Delegate GetOnDecodedFrame_Lorg_webrtc_VideoFrame_Ljava_lang_Integer_Ljava_lang_Integer_Handler ()
			{
				if (cb_onDecodedFrame_Lorg_webrtc_VideoFrame_Ljava_lang_Integer_Ljava_lang_Integer_ == null)
					cb_onDecodedFrame_Lorg_webrtc_VideoFrame_Ljava_lang_Integer_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_OnDecodedFrame_Lorg_webrtc_VideoFrame_Ljava_lang_Integer_Ljava_lang_Integer_);
				return cb_onDecodedFrame_Lorg_webrtc_VideoFrame_Ljava_lang_Integer_Ljava_lang_Integer_;
			}

			static void n_OnDecodedFrame_Lorg_webrtc_VideoFrame_Ljava_lang_Integer_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoDecoder.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p1, JniHandleOwnership.DoNotTransfer);
				var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnDecodedFrame (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onDecodedFrame_Lorg_webrtc_VideoFrame_Ljava_lang_Integer_Ljava_lang_Integer_;
			public unsafe void OnDecodedFrame (global::Org.Webrtc.VideoFrame? p0, global::Java.Lang.Integer? p1, global::Java.Lang.Integer? p2)
			{
				if (id_onDecodedFrame_Lorg_webrtc_VideoFrame_Ljava_lang_Integer_Ljava_lang_Integer_ == IntPtr.Zero)
					id_onDecodedFrame_Lorg_webrtc_VideoFrame_Ljava_lang_Integer_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "onDecodedFrame", "(Lorg/webrtc/VideoFrame;Ljava/lang/Integer;Ljava/lang/Integer;)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDecodedFrame_Lorg_webrtc_VideoFrame_Ljava_lang_Integer_Ljava_lang_Integer_, __args);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoDecoder.DecodeInfo']"
		[global::Android.Runtime.Register ("org/webrtc/VideoDecoder$DecodeInfo", DoNotGenerateAcw=true)]
		public partial class DecodeInfo : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoDecoder.DecodeInfo']/field[@name='isMissingFrames']"
			[Register ("isMissingFrames")]
			public bool IsMissingFrames {
				get {
					const string __id = "isMissingFrames.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "isMissingFrames.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoDecoder.DecodeInfo']/field[@name='renderTimeMs']"
			[Register ("renderTimeMs")]
			public long RenderTimeMs {
				get {
					const string __id = "renderTimeMs.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "renderTimeMs.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoDecoder$DecodeInfo", typeof (DecodeInfo));

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

			protected DecodeInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='VideoDecoder.DecodeInfo']/constructor[@name='VideoDecoder.DecodeInfo' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='long']]"
			[Register (".ctor", "(ZJ)V", "")]
			public unsafe DecodeInfo (bool isMissingFrames, long renderTimeMs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(ZJ)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (isMissingFrames);
					__args [1] = new JniArgumentValue (renderTimeMs);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoDecoder.Settings']"
		[global::Android.Runtime.Register ("org/webrtc/VideoDecoder$Settings", DoNotGenerateAcw=true)]
		public partial class Settings : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoDecoder.Settings']/field[@name='height']"
			[Register ("height")]
			public int Height {
				get {
					const string __id = "height.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "height.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoDecoder.Settings']/field[@name='numberOfCores']"
			[Register ("numberOfCores")]
			public int NumberOfCores {
				get {
					const string __id = "numberOfCores.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "numberOfCores.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoDecoder.Settings']/field[@name='width']"
			[Register ("width")]
			public int Width {
				get {
					const string __id = "width.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "width.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoDecoder$Settings", typeof (Settings));

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

			protected Settings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='VideoDecoder.Settings']/constructor[@name='VideoDecoder.Settings' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register (".ctor", "(III)V", "")]
			public unsafe Settings (int numberOfCores, int width, int height) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(III)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (numberOfCores);
					__args [1] = new JniArgumentValue (width);
					__args [2] = new JniArgumentValue (height);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

		}

	}

	[global::Android.Runtime.Register ("org/webrtc/VideoDecoder", DoNotGenerateAcw=true)]
	internal partial class IVideoDecoderInvoker : global::Java.Lang.Object, IVideoDecoder {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoDecoder", typeof (IVideoDecoderInvoker));

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

		public static IVideoDecoder? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoDecoder> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.webrtc.VideoDecoder'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoDecoderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getImplementationName;
#pragma warning disable 0169
		static Delegate GetGetImplementationNameHandler ()
		{
			if (cb_getImplementationName == null)
				cb_getImplementationName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetImplementationName);
			return cb_getImplementationName;
		}

		static IntPtr n_GetImplementationName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.ImplementationName);
		}
#pragma warning restore 0169

		IntPtr id_getImplementationName;
		public unsafe string? ImplementationName {
			get {
				if (id_getImplementationName == IntPtr.Zero)
					id_getImplementationName = JNIEnv.GetMethodID (class_ref, "getImplementationName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImplementationName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_decode_Lorg_webrtc_EncodedImage_Lorg_webrtc_VideoDecoder_DecodeInfo_;
#pragma warning disable 0169
		static Delegate GetDecode_Lorg_webrtc_EncodedImage_Lorg_webrtc_VideoDecoder_DecodeInfo_Handler ()
		{
			if (cb_decode_Lorg_webrtc_EncodedImage_Lorg_webrtc_VideoDecoder_DecodeInfo_ == null)
				cb_decode_Lorg_webrtc_EncodedImage_Lorg_webrtc_VideoDecoder_DecodeInfo_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Decode_Lorg_webrtc_EncodedImage_Lorg_webrtc_VideoDecoder_DecodeInfo_);
			return cb_decode_Lorg_webrtc_EncodedImage_Lorg_webrtc_VideoDecoder_DecodeInfo_;
		}

		static IntPtr n_Decode_Lorg_webrtc_EncodedImage_Lorg_webrtc_VideoDecoder_DecodeInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EncodedImage> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoDecoder.DecodeInfo> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Decode (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_decode_Lorg_webrtc_EncodedImage_Lorg_webrtc_VideoDecoder_DecodeInfo_;
		public unsafe global::Org.Webrtc.VideoCodecStatus? Decode (global::Org.Webrtc.EncodedImage? p0, global::Org.Webrtc.IVideoDecoder.DecodeInfo? p1)
		{
			if (id_decode_Lorg_webrtc_EncodedImage_Lorg_webrtc_VideoDecoder_DecodeInfo_ == IntPtr.Zero)
				id_decode_Lorg_webrtc_EncodedImage_Lorg_webrtc_VideoDecoder_DecodeInfo_ = JNIEnv.GetMethodID (class_ref, "decode", "(Lorg/webrtc/EncodedImage;Lorg/webrtc/VideoDecoder$DecodeInfo;)Lorg/webrtc/VideoCodecStatus;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCodecStatus> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decode_Lorg_webrtc_EncodedImage_Lorg_webrtc_VideoDecoder_DecodeInfo_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate? cb_initDecode_Lorg_webrtc_VideoDecoder_Settings_Lorg_webrtc_VideoDecoder_Callback_;
#pragma warning disable 0169
		static Delegate GetInitDecode_Lorg_webrtc_VideoDecoder_Settings_Lorg_webrtc_VideoDecoder_Callback_Handler ()
		{
			if (cb_initDecode_Lorg_webrtc_VideoDecoder_Settings_Lorg_webrtc_VideoDecoder_Callback_ == null)
				cb_initDecode_Lorg_webrtc_VideoDecoder_Settings_Lorg_webrtc_VideoDecoder_Callback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_InitDecode_Lorg_webrtc_VideoDecoder_Settings_Lorg_webrtc_VideoDecoder_Callback_);
			return cb_initDecode_Lorg_webrtc_VideoDecoder_Settings_Lorg_webrtc_VideoDecoder_Callback_;
		}

		static IntPtr n_InitDecode_Lorg_webrtc_VideoDecoder_Settings_Lorg_webrtc_VideoDecoder_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoDecoder.Settings> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Org.Webrtc.IVideoDecoder.ICallback?)global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoDecoder.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InitDecode (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_initDecode_Lorg_webrtc_VideoDecoder_Settings_Lorg_webrtc_VideoDecoder_Callback_;
		public unsafe global::Org.Webrtc.VideoCodecStatus? InitDecode (global::Org.Webrtc.IVideoDecoder.Settings? p0, global::Org.Webrtc.IVideoDecoder.ICallback? p1)
		{
			if (id_initDecode_Lorg_webrtc_VideoDecoder_Settings_Lorg_webrtc_VideoDecoder_Callback_ == IntPtr.Zero)
				id_initDecode_Lorg_webrtc_VideoDecoder_Settings_Lorg_webrtc_VideoDecoder_Callback_ = JNIEnv.GetMethodID (class_ref, "initDecode", "(Lorg/webrtc/VideoDecoder$Settings;Lorg/webrtc/VideoDecoder$Callback;)Lorg/webrtc/VideoCodecStatus;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCodecStatus> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_initDecode_Lorg_webrtc_VideoDecoder_Settings_Lorg_webrtc_VideoDecoder_Callback_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate? cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Release);
			return cb_release;
		}

		static IntPtr n_Release (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Release ());
		}
#pragma warning restore 0169

		IntPtr id_release;
		public unsafe global::Org.Webrtc.VideoCodecStatus? Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()Lorg/webrtc/VideoCodecStatus;");
			return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCodecStatus> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_release), JniHandleOwnership.TransferLocalRef);
		}

	}
}
