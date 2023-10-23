using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoEncoder']"
	[Register ("org/webrtc/VideoEncoder", "", "Org.Webrtc.IVideoEncoderInvoker")]
	public partial interface IVideoEncoder : IJavaObject, IJavaPeerable {
		private static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoEncoder", typeof (IVideoEncoder), isInterface: true);

		string? ImplementationName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoEncoder']/method[@name='getImplementationName' and count(parameter)=0]"
			[Register ("getImplementationName", "()Ljava/lang/String;", "GetGetImplementationNameHandler:Org.Webrtc.IVideoEncoderInvoker, webrtc")]
			get; 
		}

		private static Delegate? cb_isHardwareEncoder;
#pragma warning disable 0169
		private static Delegate GetIsHardwareEncoderHandler ()
		{
			if (cb_isHardwareEncoder == null)
				cb_isHardwareEncoder = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsHardwareEncoder);
			return cb_isHardwareEncoder;
		}

		private static bool n_IsHardwareEncoder (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsHardwareEncoder;
		}
#pragma warning restore 0169

		virtual unsafe bool IsHardwareEncoder {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoEncoder']/method[@name='isHardwareEncoder' and count(parameter)=0]"
			[Register ("isHardwareEncoder", "()Z", "GetIsHardwareEncoderHandler:Org.Webrtc.IVideoEncoder, webrtc")]
			get {
				const string __id = "isHardwareEncoder.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoEncoder']/method[@name='encode' and count(parameter)=2 and parameter[1][@type='org.webrtc.VideoFrame'] and parameter[2][@type='org.webrtc.VideoEncoder.EncodeInfo']]"
		[Register ("encode", "(Lorg/webrtc/VideoFrame;Lorg/webrtc/VideoEncoder$EncodeInfo;)Lorg/webrtc/VideoCodecStatus;", "GetEncode_Lorg_webrtc_VideoFrame_Lorg_webrtc_VideoEncoder_EncodeInfo_Handler:Org.Webrtc.IVideoEncoderInvoker, webrtc")]
		global::Org.Webrtc.VideoCodecStatus? Encode (global::Org.Webrtc.VideoFrame? p0, global::Org.Webrtc.IVideoEncoder.EncodeInfo? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoEncoder']/method[@name='getScalingSettings' and count(parameter)=0]"
		[Register ("getScalingSettings", "()Lorg/webrtc/VideoEncoder$ScalingSettings;", "GetGetScalingSettingsHandler:Org.Webrtc.IVideoEncoderInvoker, webrtc")]
		global::Org.Webrtc.IVideoEncoder.ScalingSettings? GetScalingSettings ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoEncoder']/method[@name='initEncode' and count(parameter)=2 and parameter[1][@type='org.webrtc.VideoEncoder.Settings'] and parameter[2][@type='org.webrtc.VideoEncoder.Callback']]"
		[Register ("initEncode", "(Lorg/webrtc/VideoEncoder$Settings;Lorg/webrtc/VideoEncoder$Callback;)Lorg/webrtc/VideoCodecStatus;", "GetInitEncode_Lorg_webrtc_VideoEncoder_Settings_Lorg_webrtc_VideoEncoder_Callback_Handler:Org.Webrtc.IVideoEncoderInvoker, webrtc")]
		global::Org.Webrtc.VideoCodecStatus? InitEncode (global::Org.Webrtc.IVideoEncoder.Settings? p0, global::Org.Webrtc.IVideoEncoder.ICallback? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoEncoder']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()Lorg/webrtc/VideoCodecStatus;", "GetReleaseHandler:Org.Webrtc.IVideoEncoderInvoker, webrtc")]
		global::Org.Webrtc.VideoCodecStatus? Release ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoEncoder']/method[@name='setRateAllocation' and count(parameter)=2 and parameter[1][@type='org.webrtc.VideoEncoder.BitrateAllocation'] and parameter[2][@type='int']]"
		[Register ("setRateAllocation", "(Lorg/webrtc/VideoEncoder$BitrateAllocation;I)Lorg/webrtc/VideoCodecStatus;", "GetSetRateAllocation_Lorg_webrtc_VideoEncoder_BitrateAllocation_IHandler:Org.Webrtc.IVideoEncoderInvoker, webrtc")]
		global::Org.Webrtc.VideoCodecStatus? SetRateAllocation (global::Org.Webrtc.IVideoEncoder.BitrateAllocation? p0, int p1);

		private static Delegate? cb_createNativeVideoEncoder;
#pragma warning disable 0169
		private static Delegate GetCreateNativeVideoEncoderHandler ()
		{
			if (cb_createNativeVideoEncoder == null)
				cb_createNativeVideoEncoder = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_CreateNativeVideoEncoder);
			return cb_createNativeVideoEncoder;
		}

		private static long n_CreateNativeVideoEncoder (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.CreateNativeVideoEncoder ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoEncoder']/method[@name='createNativeVideoEncoder' and count(parameter)=0]"
		[Register ("createNativeVideoEncoder", "()J", "GetCreateNativeVideoEncoderHandler:Org.Webrtc.IVideoEncoder, webrtc")]
		virtual unsafe long CreateNativeVideoEncoder ()
		{
			const string __id = "createNativeVideoEncoder.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		private static Delegate? cb_getEncoderInfo;
#pragma warning disable 0169
		private static Delegate GetGetEncoderInfoHandler ()
		{
			if (cb_getEncoderInfo == null)
				cb_getEncoderInfo = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetEncoderInfo);
			return cb_getEncoderInfo;
		}

		private static IntPtr n_GetEncoderInfo (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.GetEncoderInfo ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoEncoder']/method[@name='getEncoderInfo' and count(parameter)=0]"
		[Register ("getEncoderInfo", "()Lorg/webrtc/VideoEncoder$EncoderInfo;", "GetGetEncoderInfoHandler:Org.Webrtc.IVideoEncoder, webrtc")]
		virtual unsafe global::Org.Webrtc.IVideoEncoder.EncoderInfo? GetEncoderInfo ()
		{
			const string __id = "getEncoderInfo.()Lorg/webrtc/VideoEncoder$EncoderInfo;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoder.EncoderInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		private static Delegate? cb_getResolutionBitrateLimits;
#pragma warning disable 0169
		private static Delegate GetGetResolutionBitrateLimitsHandler ()
		{
			if (cb_getResolutionBitrateLimits == null)
				cb_getResolutionBitrateLimits = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetResolutionBitrateLimits);
			return cb_getResolutionBitrateLimits;
		}

		private static IntPtr n_GetResolutionBitrateLimits (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.GetResolutionBitrateLimits ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoEncoder']/method[@name='getResolutionBitrateLimits' and count(parameter)=0]"
		[Register ("getResolutionBitrateLimits", "()[Lorg/webrtc/VideoEncoder$ResolutionBitrateLimits;", "GetGetResolutionBitrateLimitsHandler:Org.Webrtc.IVideoEncoder, webrtc")]
		virtual unsafe global::Org.Webrtc.IVideoEncoder.ResolutionBitrateLimits[]? GetResolutionBitrateLimits ()
		{
			const string __id = "getResolutionBitrateLimits.()[Lorg/webrtc/VideoEncoder$ResolutionBitrateLimits;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Org.Webrtc.IVideoEncoder.ResolutionBitrateLimits[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.IVideoEncoder.ResolutionBitrateLimits));
			} finally {
			}
		}

		private static Delegate? cb_setRates_Lorg_webrtc_VideoEncoder_RateControlParameters_;
#pragma warning disable 0169
		private static Delegate GetSetRates_Lorg_webrtc_VideoEncoder_RateControlParameters_Handler ()
		{
			if (cb_setRates_Lorg_webrtc_VideoEncoder_RateControlParameters_ == null)
				cb_setRates_Lorg_webrtc_VideoEncoder_RateControlParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetRates_Lorg_webrtc_VideoEncoder_RateControlParameters_);
			return cb_setRates_Lorg_webrtc_VideoEncoder_RateControlParameters_;
		}

		private static IntPtr n_SetRates_Lorg_webrtc_VideoEncoder_RateControlParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rcParameters)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var rcParameters = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoder.RateControlParameters> (native_rcParameters, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRates (rcParameters));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoEncoder']/method[@name='setRates' and count(parameter)=1 and parameter[1][@type='org.webrtc.VideoEncoder.RateControlParameters']]"
		[Register ("setRates", "(Lorg/webrtc/VideoEncoder$RateControlParameters;)Lorg/webrtc/VideoCodecStatus;", "GetSetRates_Lorg_webrtc_VideoEncoder_RateControlParameters_Handler:Org.Webrtc.IVideoEncoder, webrtc")]
		virtual unsafe global::Org.Webrtc.VideoCodecStatus? SetRates (global::Org.Webrtc.IVideoEncoder.RateControlParameters? rcParameters)
		{
			const string __id = "setRates.(Lorg/webrtc/VideoEncoder$RateControlParameters;)Lorg/webrtc/VideoCodecStatus;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((rcParameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rcParameters).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCodecStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (rcParameters);
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.BitrateAllocation']"
		[global::Android.Runtime.Register ("org/webrtc/VideoEncoder$BitrateAllocation", DoNotGenerateAcw=true)]
		public partial class BitrateAllocation : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.BitrateAllocation']/field[@name='bitratesBbs']"
			[Register ("bitratesBbs")]
			public IList<int[]>? BitratesBbs {
				get {
					const string __id = "bitratesBbs.[[I";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaArray<int[]>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "bitratesBbs.[[I";

					IntPtr native_value = global::Android.Runtime.JavaArray<int[]>.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoEncoder$BitrateAllocation", typeof (BitrateAllocation));

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

			protected BitrateAllocation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.BitrateAllocation']/constructor[@name='VideoEncoder.BitrateAllocation' and count(parameter)=1 and parameter[1][@type='int[][]']]"
			[Register (".ctor", "([[I)V", "")]
			public unsafe BitrateAllocation (int[][]? bitratesBbs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "([[I)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_bitratesBbs = JNIEnv.NewArray (bitratesBbs);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_bitratesBbs);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					if (bitratesBbs != null) {
						JNIEnv.CopyArray (native_bitratesBbs, bitratesBbs);
						JNIEnv.DeleteLocalRef (native_bitratesBbs);
					}
					global::System.GC.KeepAlive (bitratesBbs);
				}
			}

			static Delegate? cb_getSum;
#pragma warning disable 0169
			static Delegate GetGetSumHandler ()
			{
				if (cb_getSum == null)
					cb_getSum = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSum);
				return cb_getSum;
			}

			static int n_GetSum (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoder.BitrateAllocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Sum;
			}
#pragma warning restore 0169

			public virtual unsafe int Sum {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.BitrateAllocation']/method[@name='getSum' and count(parameter)=0]"
				[Register ("getSum", "()I", "GetGetSumHandler")]
				get {
					const string __id = "getSum.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoEncoder.Callback']"
		[Register ("org/webrtc/VideoEncoder$Callback", "", "Org.Webrtc.IVideoEncoder/ICallbackInvoker")]
		public partial interface ICallback : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoEncoder.Callback']/method[@name='onEncodedFrame' and count(parameter)=2 and parameter[1][@type='org.webrtc.EncodedImage'] and parameter[2][@type='org.webrtc.VideoEncoder.CodecSpecificInfo']]"
			[Register ("onEncodedFrame", "(Lorg/webrtc/EncodedImage;Lorg/webrtc/VideoEncoder$CodecSpecificInfo;)V", "GetOnEncodedFrame_Lorg_webrtc_EncodedImage_Lorg_webrtc_VideoEncoder_CodecSpecificInfo_Handler:Org.Webrtc.IVideoEncoder/ICallbackInvoker, webrtc")]
			void OnEncodedFrame (global::Org.Webrtc.EncodedImage? p0, global::Org.Webrtc.IVideoEncoder.CodecSpecificInfo? p1);

		}

		[global::Android.Runtime.Register ("org/webrtc/VideoEncoder$Callback", DoNotGenerateAcw=true)]
		internal partial class ICallbackInvoker : global::Java.Lang.Object, ICallback {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoEncoder$Callback", typeof (ICallbackInvoker));

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
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.webrtc.VideoEncoder.Callback'.");
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

			static Delegate? cb_onEncodedFrame_Lorg_webrtc_EncodedImage_Lorg_webrtc_VideoEncoder_CodecSpecificInfo_;
#pragma warning disable 0169
			static Delegate GetOnEncodedFrame_Lorg_webrtc_EncodedImage_Lorg_webrtc_VideoEncoder_CodecSpecificInfo_Handler ()
			{
				if (cb_onEncodedFrame_Lorg_webrtc_EncodedImage_Lorg_webrtc_VideoEncoder_CodecSpecificInfo_ == null)
					cb_onEncodedFrame_Lorg_webrtc_EncodedImage_Lorg_webrtc_VideoEncoder_CodecSpecificInfo_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnEncodedFrame_Lorg_webrtc_EncodedImage_Lorg_webrtc_VideoEncoder_CodecSpecificInfo_);
				return cb_onEncodedFrame_Lorg_webrtc_EncodedImage_Lorg_webrtc_VideoEncoder_CodecSpecificInfo_;
			}

			static void n_OnEncodedFrame_Lorg_webrtc_EncodedImage_Lorg_webrtc_VideoEncoder_CodecSpecificInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoder.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EncodedImage> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoder.CodecSpecificInfo> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnEncodedFrame (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onEncodedFrame_Lorg_webrtc_EncodedImage_Lorg_webrtc_VideoEncoder_CodecSpecificInfo_;
			public unsafe void OnEncodedFrame (global::Org.Webrtc.EncodedImage? p0, global::Org.Webrtc.IVideoEncoder.CodecSpecificInfo? p1)
			{
				if (id_onEncodedFrame_Lorg_webrtc_EncodedImage_Lorg_webrtc_VideoEncoder_CodecSpecificInfo_ == IntPtr.Zero)
					id_onEncodedFrame_Lorg_webrtc_EncodedImage_Lorg_webrtc_VideoEncoder_CodecSpecificInfo_ = JNIEnv.GetMethodID (class_ref, "onEncodedFrame", "(Lorg/webrtc/EncodedImage;Lorg/webrtc/VideoEncoder$CodecSpecificInfo;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onEncodedFrame_Lorg_webrtc_EncodedImage_Lorg_webrtc_VideoEncoder_CodecSpecificInfo_, __args);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.Capabilities']"
		[global::Android.Runtime.Register ("org/webrtc/VideoEncoder$Capabilities", DoNotGenerateAcw=true)]
		public partial class Capabilities : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.Capabilities']/field[@name='lossNotification']"
			[Register ("lossNotification")]
			public bool LossNotification {
				get {
					const string __id = "lossNotification.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "lossNotification.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoEncoder$Capabilities", typeof (Capabilities));

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

			protected Capabilities (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.Capabilities']/constructor[@name='VideoEncoder.Capabilities' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register (".ctor", "(Z)V", "")]
			public unsafe Capabilities (bool lossNotification) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Z)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (lossNotification);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.CodecSpecificInfo']"
		[global::Android.Runtime.Register ("org/webrtc/VideoEncoder$CodecSpecificInfo", DoNotGenerateAcw=true)]
		public partial class CodecSpecificInfo : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoEncoder$CodecSpecificInfo", typeof (CodecSpecificInfo));

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

			protected CodecSpecificInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.CodecSpecificInfo']/constructor[@name='VideoEncoder.CodecSpecificInfo' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe CodecSpecificInfo () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.CodecSpecificInfoAV1']"
		[global::Android.Runtime.Register ("org/webrtc/VideoEncoder$CodecSpecificInfoAV1", DoNotGenerateAcw=true)]
		public partial class CodecSpecificInfoAV1 : global::Org.Webrtc.IVideoEncoder.CodecSpecificInfo {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoEncoder$CodecSpecificInfoAV1", typeof (CodecSpecificInfoAV1));

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

			protected CodecSpecificInfoAV1 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.CodecSpecificInfoAV1']/constructor[@name='VideoEncoder.CodecSpecificInfoAV1' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe CodecSpecificInfoAV1 () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.CodecSpecificInfoH264']"
		[global::Android.Runtime.Register ("org/webrtc/VideoEncoder$CodecSpecificInfoH264", DoNotGenerateAcw=true)]
		public partial class CodecSpecificInfoH264 : global::Org.Webrtc.IVideoEncoder.CodecSpecificInfo {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoEncoder$CodecSpecificInfoH264", typeof (CodecSpecificInfoH264));

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

			protected CodecSpecificInfoH264 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.CodecSpecificInfoH264']/constructor[@name='VideoEncoder.CodecSpecificInfoH264' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe CodecSpecificInfoH264 () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.CodecSpecificInfoVP8']"
		[global::Android.Runtime.Register ("org/webrtc/VideoEncoder$CodecSpecificInfoVP8", DoNotGenerateAcw=true)]
		public partial class CodecSpecificInfoVP8 : global::Org.Webrtc.IVideoEncoder.CodecSpecificInfo {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoEncoder$CodecSpecificInfoVP8", typeof (CodecSpecificInfoVP8));

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

			protected CodecSpecificInfoVP8 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.CodecSpecificInfoVP8']/constructor[@name='VideoEncoder.CodecSpecificInfoVP8' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe CodecSpecificInfoVP8 () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.CodecSpecificInfoVP9']"
		[global::Android.Runtime.Register ("org/webrtc/VideoEncoder$CodecSpecificInfoVP9", DoNotGenerateAcw=true)]
		public partial class CodecSpecificInfoVP9 : global::Org.Webrtc.IVideoEncoder.CodecSpecificInfo {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoEncoder$CodecSpecificInfoVP9", typeof (CodecSpecificInfoVP9));

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

			protected CodecSpecificInfoVP9 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.CodecSpecificInfoVP9']/constructor[@name='VideoEncoder.CodecSpecificInfoVP9' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe CodecSpecificInfoVP9 () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.EncodeInfo']"
		[global::Android.Runtime.Register ("org/webrtc/VideoEncoder$EncodeInfo", DoNotGenerateAcw=true)]
		public partial class EncodeInfo : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.EncodeInfo']/field[@name='frameTypes']"
			[Register ("frameTypes")]
			public IList<Org.Webrtc.EncodedImage.FrameType>? FrameTypes {
				get {
					const string __id = "frameTypes.[Lorg/webrtc/EncodedImage$FrameType;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaArray<global::Org.Webrtc.EncodedImage.FrameType>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "frameTypes.[Lorg/webrtc/EncodedImage$FrameType;";

					IntPtr native_value = global::Android.Runtime.JavaArray<global::Org.Webrtc.EncodedImage.FrameType>.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoEncoder$EncodeInfo", typeof (EncodeInfo));

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

			protected EncodeInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.EncodeInfo']/constructor[@name='VideoEncoder.EncodeInfo' and count(parameter)=1 and parameter[1][@type='org.webrtc.EncodedImage.FrameType[]']]"
			[Register (".ctor", "([Lorg/webrtc/EncodedImage$FrameType;)V", "")]
			public unsafe EncodeInfo (global::Org.Webrtc.EncodedImage.FrameType[]? frameTypes) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "([Lorg/webrtc/EncodedImage$FrameType;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_frameTypes = JNIEnv.NewArray (frameTypes);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_frameTypes);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					if (frameTypes != null) {
						JNIEnv.CopyArray (native_frameTypes, frameTypes);
						JNIEnv.DeleteLocalRef (native_frameTypes);
					}
					global::System.GC.KeepAlive (frameTypes);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.EncoderInfo']"
		[global::Android.Runtime.Register ("org/webrtc/VideoEncoder$EncoderInfo", DoNotGenerateAcw=true)]
		public partial class EncoderInfo : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoEncoder$EncoderInfo", typeof (EncoderInfo));

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

			protected EncoderInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.EncoderInfo']/constructor[@name='VideoEncoder.EncoderInfo' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
			[Register (".ctor", "(IZ)V", "")]
			public unsafe EncoderInfo (int requestedResolutionAlignment, bool applyAlignmentToAllSimulcastLayers) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(IZ)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (requestedResolutionAlignment);
					__args [1] = new JniArgumentValue (applyAlignmentToAllSimulcastLayers);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate? cb_getApplyAlignmentToAllSimulcastLayers;
#pragma warning disable 0169
			static Delegate GetGetApplyAlignmentToAllSimulcastLayersHandler ()
			{
				if (cb_getApplyAlignmentToAllSimulcastLayers == null)
					cb_getApplyAlignmentToAllSimulcastLayers = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetApplyAlignmentToAllSimulcastLayers);
				return cb_getApplyAlignmentToAllSimulcastLayers;
			}

			static bool n_GetApplyAlignmentToAllSimulcastLayers (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoder.EncoderInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.ApplyAlignmentToAllSimulcastLayers;
			}
#pragma warning restore 0169

			public virtual unsafe bool ApplyAlignmentToAllSimulcastLayers {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.EncoderInfo']/method[@name='getApplyAlignmentToAllSimulcastLayers' and count(parameter)=0]"
				[Register ("getApplyAlignmentToAllSimulcastLayers", "()Z", "GetGetApplyAlignmentToAllSimulcastLayersHandler")]
				get {
					const string __id = "getApplyAlignmentToAllSimulcastLayers.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate? cb_getRequestedResolutionAlignment;
#pragma warning disable 0169
			static Delegate GetGetRequestedResolutionAlignmentHandler ()
			{
				if (cb_getRequestedResolutionAlignment == null)
					cb_getRequestedResolutionAlignment = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetRequestedResolutionAlignment);
				return cb_getRequestedResolutionAlignment;
			}

			static int n_GetRequestedResolutionAlignment (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoder.EncoderInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.RequestedResolutionAlignment;
			}
#pragma warning restore 0169

			public virtual unsafe int RequestedResolutionAlignment {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.EncoderInfo']/method[@name='getRequestedResolutionAlignment' and count(parameter)=0]"
				[Register ("getRequestedResolutionAlignment", "()I", "GetGetRequestedResolutionAlignmentHandler")]
				get {
					const string __id = "getRequestedResolutionAlignment.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.RateControlParameters']"
		[global::Android.Runtime.Register ("org/webrtc/VideoEncoder$RateControlParameters", DoNotGenerateAcw=true)]
		public partial class RateControlParameters : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.RateControlParameters']/field[@name='bitrate']"
			[Register ("bitrate")]
			public global::Org.Webrtc.IVideoEncoder.BitrateAllocation? Bitrate {
				get {
					const string __id = "bitrate.Lorg/webrtc/VideoEncoder$BitrateAllocation;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoder.BitrateAllocation> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "bitrate.Lorg/webrtc/VideoEncoder$BitrateAllocation;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.RateControlParameters']/field[@name='framerateFps']"
			[Register ("framerateFps")]
			public double FramerateFps {
				get {
					const string __id = "framerateFps.D";

					var __v = _members.InstanceFields.GetDoubleValue (__id, this);
					return __v;
				}
				set {
					const string __id = "framerateFps.D";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoEncoder$RateControlParameters", typeof (RateControlParameters));

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

			protected RateControlParameters (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.RateControlParameters']/constructor[@name='VideoEncoder.RateControlParameters' and count(parameter)=2 and parameter[1][@type='org.webrtc.VideoEncoder.BitrateAllocation'] and parameter[2][@type='double']]"
			[Register (".ctor", "(Lorg/webrtc/VideoEncoder$BitrateAllocation;D)V", "")]
			public unsafe RateControlParameters (global::Org.Webrtc.IVideoEncoder.BitrateAllocation? bitrate, double framerateFps) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lorg/webrtc/VideoEncoder$BitrateAllocation;D)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((bitrate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitrate).Handle);
					__args [1] = new JniArgumentValue (framerateFps);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (bitrate);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.ResolutionBitrateLimits']"
		[global::Android.Runtime.Register ("org/webrtc/VideoEncoder$ResolutionBitrateLimits", DoNotGenerateAcw=true)]
		public partial class ResolutionBitrateLimits : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoEncoder$ResolutionBitrateLimits", typeof (ResolutionBitrateLimits));

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

			protected ResolutionBitrateLimits (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.ResolutionBitrateLimits']/constructor[@name='VideoEncoder.ResolutionBitrateLimits' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register (".ctor", "(IIII)V", "")]
			public unsafe ResolutionBitrateLimits (int frameSizePixels, int minStartBitrateBps, int minBitrateBps, int maxBitrateBps) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(IIII)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (frameSizePixels);
					__args [1] = new JniArgumentValue (minStartBitrateBps);
					__args [2] = new JniArgumentValue (minBitrateBps);
					__args [3] = new JniArgumentValue (maxBitrateBps);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate? cb_getFrameSizePixels;
#pragma warning disable 0169
			static Delegate GetGetFrameSizePixelsHandler ()
			{
				if (cb_getFrameSizePixels == null)
					cb_getFrameSizePixels = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetFrameSizePixels);
				return cb_getFrameSizePixels;
			}

			static int n_GetFrameSizePixels (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoder.ResolutionBitrateLimits> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.FrameSizePixels;
			}
#pragma warning restore 0169

			public virtual unsafe int FrameSizePixels {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.ResolutionBitrateLimits']/method[@name='getFrameSizePixels' and count(parameter)=0]"
				[Register ("getFrameSizePixels", "()I", "GetGetFrameSizePixelsHandler")]
				get {
					const string __id = "getFrameSizePixels.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate? cb_getMaxBitrateBps;
#pragma warning disable 0169
			static Delegate GetGetMaxBitrateBpsHandler ()
			{
				if (cb_getMaxBitrateBps == null)
					cb_getMaxBitrateBps = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetMaxBitrateBps);
				return cb_getMaxBitrateBps;
			}

			static int n_GetMaxBitrateBps (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoder.ResolutionBitrateLimits> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.MaxBitrateBps;
			}
#pragma warning restore 0169

			public virtual unsafe int MaxBitrateBps {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.ResolutionBitrateLimits']/method[@name='getMaxBitrateBps' and count(parameter)=0]"
				[Register ("getMaxBitrateBps", "()I", "GetGetMaxBitrateBpsHandler")]
				get {
					const string __id = "getMaxBitrateBps.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate? cb_getMinBitrateBps;
#pragma warning disable 0169
			static Delegate GetGetMinBitrateBpsHandler ()
			{
				if (cb_getMinBitrateBps == null)
					cb_getMinBitrateBps = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetMinBitrateBps);
				return cb_getMinBitrateBps;
			}

			static int n_GetMinBitrateBps (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoder.ResolutionBitrateLimits> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.MinBitrateBps;
			}
#pragma warning restore 0169

			public virtual unsafe int MinBitrateBps {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.ResolutionBitrateLimits']/method[@name='getMinBitrateBps' and count(parameter)=0]"
				[Register ("getMinBitrateBps", "()I", "GetGetMinBitrateBpsHandler")]
				get {
					const string __id = "getMinBitrateBps.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate? cb_getMinStartBitrateBps;
#pragma warning disable 0169
			static Delegate GetGetMinStartBitrateBpsHandler ()
			{
				if (cb_getMinStartBitrateBps == null)
					cb_getMinStartBitrateBps = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetMinStartBitrateBps);
				return cb_getMinStartBitrateBps;
			}

			static int n_GetMinStartBitrateBps (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoder.ResolutionBitrateLimits> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.MinStartBitrateBps;
			}
#pragma warning restore 0169

			public virtual unsafe int MinStartBitrateBps {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.ResolutionBitrateLimits']/method[@name='getMinStartBitrateBps' and count(parameter)=0]"
				[Register ("getMinStartBitrateBps", "()I", "GetGetMinStartBitrateBpsHandler")]
				get {
					const string __id = "getMinStartBitrateBps.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.ScalingSettings']"
		[global::Android.Runtime.Register ("org/webrtc/VideoEncoder$ScalingSettings", DoNotGenerateAcw=true)]
		public partial class ScalingSettings : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.ScalingSettings']/field[@name='high']"
			[Register ("high")]
			public global::Java.Lang.Integer? High {
				get {
					const string __id = "high.Ljava/lang/Integer;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "high.Ljava/lang/Integer;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.ScalingSettings']/field[@name='low']"
			[Register ("low")]
			public global::Java.Lang.Integer? Low {
				get {
					const string __id = "low.Ljava/lang/Integer;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "low.Ljava/lang/Integer;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.ScalingSettings']/field[@name='OFF']"
			[Register ("OFF")]
			public static global::Org.Webrtc.IVideoEncoder.ScalingSettings? Off {
				get {
					const string __id = "OFF.Lorg/webrtc/VideoEncoder$ScalingSettings;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoder.ScalingSettings> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.ScalingSettings']/field[@name='on']"
			[Register ("on")]
			public bool On {
				get {
					const string __id = "on.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "on.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoEncoder$ScalingSettings", typeof (ScalingSettings));

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

			protected ScalingSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.ScalingSettings']/constructor[@name='VideoEncoder.ScalingSettings' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register (".ctor", "(Z)V", "")]
			[global::System.Obsolete (@"deprecated")]
			public unsafe ScalingSettings (bool on) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Z)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (on);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.ScalingSettings']/constructor[@name='VideoEncoder.ScalingSettings' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register (".ctor", "(ZII)V", "")]
			[global::System.Obsolete (@"deprecated")]
			public unsafe ScalingSettings (bool on, int low, int high) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(ZII)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (on);
					__args [1] = new JniArgumentValue (low);
					__args [2] = new JniArgumentValue (high);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.ScalingSettings']/constructor[@name='VideoEncoder.ScalingSettings' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register (".ctor", "(II)V", "")]
			public unsafe ScalingSettings (int low, int high) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(II)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (low);
					__args [1] = new JniArgumentValue (high);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.Settings']"
		[global::Android.Runtime.Register ("org/webrtc/VideoEncoder$Settings", DoNotGenerateAcw=true)]
		public partial class Settings : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.Settings']/field[@name='automaticResizeOn']"
			[Register ("automaticResizeOn")]
			public bool AutomaticResizeOn {
				get {
					const string __id = "automaticResizeOn.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "automaticResizeOn.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.Settings']/field[@name='capabilities']"
			[Register ("capabilities")]
			public global::Org.Webrtc.IVideoEncoder.Capabilities? Capabilities {
				get {
					const string __id = "capabilities.Lorg/webrtc/VideoEncoder$Capabilities;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoder.Capabilities> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "capabilities.Lorg/webrtc/VideoEncoder$Capabilities;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.Settings']/field[@name='height']"
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


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.Settings']/field[@name='maxFramerate']"
			[Register ("maxFramerate")]
			public int MaxFramerate {
				get {
					const string __id = "maxFramerate.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "maxFramerate.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.Settings']/field[@name='numberOfCores']"
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


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.Settings']/field[@name='numberOfSimulcastStreams']"
			[Register ("numberOfSimulcastStreams")]
			public int NumberOfSimulcastStreams {
				get {
					const string __id = "numberOfSimulcastStreams.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "numberOfSimulcastStreams.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.Settings']/field[@name='startBitrate']"
			[Register ("startBitrate")]
			public int StartBitrate {
				get {
					const string __id = "startBitrate.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "startBitrate.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.Settings']/field[@name='width']"
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

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoEncoder$Settings", typeof (Settings));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.Settings']/constructor[@name='VideoEncoder.Settings' and count(parameter)=7 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='boolean']]"
			[Register (".ctor", "(IIIIIIZ)V", "")]
			[global::System.Obsolete (@"deprecated")]
			public unsafe Settings (int numberOfCores, int width, int height, int startBitrate, int maxFramerate, int numberOfSimulcastStreams, bool automaticResizeOn) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(IIIIIIZ)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [7];
					__args [0] = new JniArgumentValue (numberOfCores);
					__args [1] = new JniArgumentValue (width);
					__args [2] = new JniArgumentValue (height);
					__args [3] = new JniArgumentValue (startBitrate);
					__args [4] = new JniArgumentValue (maxFramerate);
					__args [5] = new JniArgumentValue (numberOfSimulcastStreams);
					__args [6] = new JniArgumentValue (automaticResizeOn);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='VideoEncoder.Settings']/constructor[@name='VideoEncoder.Settings' and count(parameter)=8 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='boolean'] and parameter[8][@type='org.webrtc.VideoEncoder.Capabilities']]"
			[Register (".ctor", "(IIIIIIZLorg/webrtc/VideoEncoder$Capabilities;)V", "")]
			public unsafe Settings (int numberOfCores, int width, int height, int startBitrate, int maxFramerate, int numberOfSimulcastStreams, bool automaticResizeOn, global::Org.Webrtc.IVideoEncoder.Capabilities? capabilities) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(IIIIIIZLorg/webrtc/VideoEncoder$Capabilities;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [8];
					__args [0] = new JniArgumentValue (numberOfCores);
					__args [1] = new JniArgumentValue (width);
					__args [2] = new JniArgumentValue (height);
					__args [3] = new JniArgumentValue (startBitrate);
					__args [4] = new JniArgumentValue (maxFramerate);
					__args [5] = new JniArgumentValue (numberOfSimulcastStreams);
					__args [6] = new JniArgumentValue (automaticResizeOn);
					__args [7] = new JniArgumentValue ((capabilities == null) ? IntPtr.Zero : ((global::Java.Lang.Object) capabilities).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (capabilities);
				}
			}

		}

	}

	[global::Android.Runtime.Register ("org/webrtc/VideoEncoder", DoNotGenerateAcw=true)]
	internal partial class IVideoEncoderInvoker : global::Java.Lang.Object, IVideoEncoder {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoEncoder", typeof (IVideoEncoderInvoker));

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

		public static IVideoEncoder? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoEncoder> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.webrtc.VideoEncoder'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoEncoderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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

		static Delegate? cb_encode_Lorg_webrtc_VideoFrame_Lorg_webrtc_VideoEncoder_EncodeInfo_;
#pragma warning disable 0169
		static Delegate GetEncode_Lorg_webrtc_VideoFrame_Lorg_webrtc_VideoEncoder_EncodeInfo_Handler ()
		{
			if (cb_encode_Lorg_webrtc_VideoFrame_Lorg_webrtc_VideoEncoder_EncodeInfo_ == null)
				cb_encode_Lorg_webrtc_VideoFrame_Lorg_webrtc_VideoEncoder_EncodeInfo_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Encode_Lorg_webrtc_VideoFrame_Lorg_webrtc_VideoEncoder_EncodeInfo_);
			return cb_encode_Lorg_webrtc_VideoFrame_Lorg_webrtc_VideoEncoder_EncodeInfo_;
		}

		static IntPtr n_Encode_Lorg_webrtc_VideoFrame_Lorg_webrtc_VideoEncoder_EncodeInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoder.EncodeInfo> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Encode (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_encode_Lorg_webrtc_VideoFrame_Lorg_webrtc_VideoEncoder_EncodeInfo_;
		public unsafe global::Org.Webrtc.VideoCodecStatus? Encode (global::Org.Webrtc.VideoFrame? p0, global::Org.Webrtc.IVideoEncoder.EncodeInfo? p1)
		{
			if (id_encode_Lorg_webrtc_VideoFrame_Lorg_webrtc_VideoEncoder_EncodeInfo_ == IntPtr.Zero)
				id_encode_Lorg_webrtc_VideoFrame_Lorg_webrtc_VideoEncoder_EncodeInfo_ = JNIEnv.GetMethodID (class_ref, "encode", "(Lorg/webrtc/VideoFrame;Lorg/webrtc/VideoEncoder$EncodeInfo;)Lorg/webrtc/VideoCodecStatus;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCodecStatus> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encode_Lorg_webrtc_VideoFrame_Lorg_webrtc_VideoEncoder_EncodeInfo_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate? cb_getScalingSettings;
#pragma warning disable 0169
		static Delegate GetGetScalingSettingsHandler ()
		{
			if (cb_getScalingSettings == null)
				cb_getScalingSettings = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetScalingSettings);
			return cb_getScalingSettings;
		}

		static IntPtr n_GetScalingSettings (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.GetScalingSettings ());
		}
#pragma warning restore 0169

		IntPtr id_getScalingSettings;
		public unsafe global::Org.Webrtc.IVideoEncoder.ScalingSettings? GetScalingSettings ()
		{
			if (id_getScalingSettings == IntPtr.Zero)
				id_getScalingSettings = JNIEnv.GetMethodID (class_ref, "getScalingSettings", "()Lorg/webrtc/VideoEncoder$ScalingSettings;");
			return global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoder.ScalingSettings> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getScalingSettings), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate? cb_initEncode_Lorg_webrtc_VideoEncoder_Settings_Lorg_webrtc_VideoEncoder_Callback_;
#pragma warning disable 0169
		static Delegate GetInitEncode_Lorg_webrtc_VideoEncoder_Settings_Lorg_webrtc_VideoEncoder_Callback_Handler ()
		{
			if (cb_initEncode_Lorg_webrtc_VideoEncoder_Settings_Lorg_webrtc_VideoEncoder_Callback_ == null)
				cb_initEncode_Lorg_webrtc_VideoEncoder_Settings_Lorg_webrtc_VideoEncoder_Callback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_InitEncode_Lorg_webrtc_VideoEncoder_Settings_Lorg_webrtc_VideoEncoder_Callback_);
			return cb_initEncode_Lorg_webrtc_VideoEncoder_Settings_Lorg_webrtc_VideoEncoder_Callback_;
		}

		static IntPtr n_InitEncode_Lorg_webrtc_VideoEncoder_Settings_Lorg_webrtc_VideoEncoder_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoder.Settings> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Org.Webrtc.IVideoEncoder.ICallback?)global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoder.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InitEncode (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_initEncode_Lorg_webrtc_VideoEncoder_Settings_Lorg_webrtc_VideoEncoder_Callback_;
		public unsafe global::Org.Webrtc.VideoCodecStatus? InitEncode (global::Org.Webrtc.IVideoEncoder.Settings? p0, global::Org.Webrtc.IVideoEncoder.ICallback? p1)
		{
			if (id_initEncode_Lorg_webrtc_VideoEncoder_Settings_Lorg_webrtc_VideoEncoder_Callback_ == IntPtr.Zero)
				id_initEncode_Lorg_webrtc_VideoEncoder_Settings_Lorg_webrtc_VideoEncoder_Callback_ = JNIEnv.GetMethodID (class_ref, "initEncode", "(Lorg/webrtc/VideoEncoder$Settings;Lorg/webrtc/VideoEncoder$Callback;)Lorg/webrtc/VideoCodecStatus;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCodecStatus> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_initEncode_Lorg_webrtc_VideoEncoder_Settings_Lorg_webrtc_VideoEncoder_Callback_, __args), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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

		static Delegate? cb_setRateAllocation_Lorg_webrtc_VideoEncoder_BitrateAllocation_I;
#pragma warning disable 0169
		static Delegate GetSetRateAllocation_Lorg_webrtc_VideoEncoder_BitrateAllocation_IHandler ()
		{
			if (cb_setRateAllocation_Lorg_webrtc_VideoEncoder_BitrateAllocation_I == null)
				cb_setRateAllocation_Lorg_webrtc_VideoEncoder_BitrateAllocation_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_L) n_SetRateAllocation_Lorg_webrtc_VideoEncoder_BitrateAllocation_I);
			return cb_setRateAllocation_Lorg_webrtc_VideoEncoder_BitrateAllocation_I;
		}

		static IntPtr n_SetRateAllocation_Lorg_webrtc_VideoEncoder_BitrateAllocation_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoder.BitrateAllocation> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRateAllocation (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setRateAllocation_Lorg_webrtc_VideoEncoder_BitrateAllocation_I;
		public unsafe global::Org.Webrtc.VideoCodecStatus? SetRateAllocation (global::Org.Webrtc.IVideoEncoder.BitrateAllocation? p0, int p1)
		{
			if (id_setRateAllocation_Lorg_webrtc_VideoEncoder_BitrateAllocation_I == IntPtr.Zero)
				id_setRateAllocation_Lorg_webrtc_VideoEncoder_BitrateAllocation_I = JNIEnv.GetMethodID (class_ref, "setRateAllocation", "(Lorg/webrtc/VideoEncoder$BitrateAllocation;I)Lorg/webrtc/VideoCodecStatus;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			var __ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCodecStatus> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setRateAllocation_Lorg_webrtc_VideoEncoder_BitrateAllocation_I, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
