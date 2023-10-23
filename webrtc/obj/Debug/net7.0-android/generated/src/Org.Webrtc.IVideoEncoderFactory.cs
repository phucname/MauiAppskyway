using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoEncoderFactory']"
	[Register ("org/webrtc/VideoEncoderFactory", "", "Org.Webrtc.IVideoEncoderFactoryInvoker")]
	public partial interface IVideoEncoderFactory : IJavaObject, IJavaPeerable {
		private static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoEncoderFactory", typeof (IVideoEncoderFactory), isInterface: true);

		private static Delegate? cb_getEncoderSelector;
#pragma warning disable 0169
		private static Delegate GetGetEncoderSelectorHandler ()
		{
			if (cb_getEncoderSelector == null)
				cb_getEncoderSelector = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetEncoderSelector);
			return cb_getEncoderSelector;
		}

		private static IntPtr n_GetEncoderSelector (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoderFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.EncoderSelector);
		}
#pragma warning restore 0169

		virtual unsafe global::Org.Webrtc.IVideoEncoderFactory.IVideoEncoderSelector? EncoderSelector {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoEncoderFactory']/method[@name='getEncoderSelector' and count(parameter)=0]"
			[Register ("getEncoderSelector", "()Lorg/webrtc/VideoEncoderFactory$VideoEncoderSelector;", "GetGetEncoderSelectorHandler:Org.Webrtc.IVideoEncoderFactory, webrtc")]
			get {
				const string __id = "getEncoderSelector.()Lorg/webrtc/VideoEncoderFactory$VideoEncoderSelector;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoderFactory.IVideoEncoderSelector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoEncoderFactory']/method[@name='createEncoder' and count(parameter)=1 and parameter[1][@type='org.webrtc.VideoCodecInfo']]"
		[Register ("createEncoder", "(Lorg/webrtc/VideoCodecInfo;)Lorg/webrtc/VideoEncoder;", "GetCreateEncoder_Lorg_webrtc_VideoCodecInfo_Handler:Org.Webrtc.IVideoEncoderFactoryInvoker, webrtc")]
		global::Org.Webrtc.IVideoEncoder? CreateEncoder (global::Org.Webrtc.VideoCodecInfo? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoEncoderFactory']/method[@name='getSupportedCodecs' and count(parameter)=0]"
		[Register ("getSupportedCodecs", "()[Lorg/webrtc/VideoCodecInfo;", "GetGetSupportedCodecsHandler:Org.Webrtc.IVideoEncoderFactoryInvoker, webrtc")]
		global::Org.Webrtc.VideoCodecInfo[]? GetSupportedCodecs ();

		private static Delegate? cb_getImplementations;
#pragma warning disable 0169
		private static Delegate GetGetImplementationsHandler ()
		{
			if (cb_getImplementations == null)
				cb_getImplementations = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetImplementations);
			return cb_getImplementations;
		}

		private static IntPtr n_GetImplementations (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoderFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.GetImplementations ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoEncoderFactory']/method[@name='getImplementations' and count(parameter)=0]"
		[Register ("getImplementations", "()[Lorg/webrtc/VideoCodecInfo;", "GetGetImplementationsHandler:Org.Webrtc.IVideoEncoderFactory, webrtc")]
		virtual unsafe global::Org.Webrtc.VideoCodecInfo[]? GetImplementations ()
		{
			const string __id = "getImplementations.()[Lorg/webrtc/VideoCodecInfo;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Org.Webrtc.VideoCodecInfo[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.VideoCodecInfo));
			} finally {
			}
		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoEncoderFactory.VideoEncoderSelector']"
		[Register ("org/webrtc/VideoEncoderFactory$VideoEncoderSelector", "", "Org.Webrtc.IVideoEncoderFactory/IVideoEncoderSelectorInvoker")]
		public partial interface IVideoEncoderSelector : IJavaObject, IJavaPeerable {
			private static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoEncoderFactory$VideoEncoderSelector", typeof (IVideoEncoderSelector), isInterface: true);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoEncoderFactory.VideoEncoderSelector']/method[@name='onAvailableBitrate' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onAvailableBitrate", "(I)Lorg/webrtc/VideoCodecInfo;", "GetOnAvailableBitrate_IHandler:Org.Webrtc.IVideoEncoderFactory/IVideoEncoderSelectorInvoker, webrtc")]
			global::Org.Webrtc.VideoCodecInfo? OnAvailableBitrate (int p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoEncoderFactory.VideoEncoderSelector']/method[@name='onCurrentEncoder' and count(parameter)=1 and parameter[1][@type='org.webrtc.VideoCodecInfo']]"
			[Register ("onCurrentEncoder", "(Lorg/webrtc/VideoCodecInfo;)V", "GetOnCurrentEncoder_Lorg_webrtc_VideoCodecInfo_Handler:Org.Webrtc.IVideoEncoderFactory/IVideoEncoderSelectorInvoker, webrtc")]
			void OnCurrentEncoder (global::Org.Webrtc.VideoCodecInfo? p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoEncoderFactory.VideoEncoderSelector']/method[@name='onEncoderBroken' and count(parameter)=0]"
			[Register ("onEncoderBroken", "()Lorg/webrtc/VideoCodecInfo;", "GetOnEncoderBrokenHandler:Org.Webrtc.IVideoEncoderFactory/IVideoEncoderSelectorInvoker, webrtc")]
			global::Org.Webrtc.VideoCodecInfo? OnEncoderBroken ();

			private static Delegate? cb_onResolutionChange_II;
#pragma warning disable 0169
			private static Delegate GetOnResolutionChange_IIHandler ()
			{
				if (cb_onResolutionChange_II == null)
					cb_onResolutionChange_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_L) n_OnResolutionChange_II);
				return cb_onResolutionChange_II;
			}

			private static IntPtr n_OnResolutionChange_II (IntPtr jnienv, IntPtr native__this, int widht, int height)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoderFactory.IVideoEncoderSelector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.OnResolutionChange (widht, height));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoEncoderFactory.VideoEncoderSelector']/method[@name='onResolutionChange' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("onResolutionChange", "(II)Lorg/webrtc/VideoCodecInfo;", "GetOnResolutionChange_IIHandler:Org.Webrtc.IVideoEncoderFactory/IVideoEncoderSelector, webrtc")]
			virtual unsafe global::Org.Webrtc.VideoCodecInfo? OnResolutionChange (int widht, int height)
			{
				const string __id = "onResolutionChange.(II)Lorg/webrtc/VideoCodecInfo;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (widht);
					__args [1] = new JniArgumentValue (height);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCodecInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		[global::Android.Runtime.Register ("org/webrtc/VideoEncoderFactory$VideoEncoderSelector", DoNotGenerateAcw=true)]
		internal partial class IVideoEncoderSelectorInvoker : global::Java.Lang.Object, IVideoEncoderSelector {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoEncoderFactory$VideoEncoderSelector", typeof (IVideoEncoderSelectorInvoker));

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

			public static IVideoEncoderSelector? GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IVideoEncoderSelector> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.webrtc.VideoEncoderFactory.VideoEncoderSelector'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IVideoEncoderSelectorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate? cb_onAvailableBitrate_I;
#pragma warning disable 0169
			static Delegate GetOnAvailableBitrate_IHandler ()
			{
				if (cb_onAvailableBitrate_I == null)
					cb_onAvailableBitrate_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_OnAvailableBitrate_I);
				return cb_onAvailableBitrate_I;
			}

			static IntPtr n_OnAvailableBitrate_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoderFactory.IVideoEncoderSelector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.OnAvailableBitrate (p0));
			}
#pragma warning restore 0169

			IntPtr id_onAvailableBitrate_I;
			public unsafe global::Org.Webrtc.VideoCodecInfo? OnAvailableBitrate (int p0)
			{
				if (id_onAvailableBitrate_I == IntPtr.Zero)
					id_onAvailableBitrate_I = JNIEnv.GetMethodID (class_ref, "onAvailableBitrate", "(I)Lorg/webrtc/VideoCodecInfo;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCodecInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onAvailableBitrate_I, __args), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate? cb_onCurrentEncoder_Lorg_webrtc_VideoCodecInfo_;
#pragma warning disable 0169
			static Delegate GetOnCurrentEncoder_Lorg_webrtc_VideoCodecInfo_Handler ()
			{
				if (cb_onCurrentEncoder_Lorg_webrtc_VideoCodecInfo_ == null)
					cb_onCurrentEncoder_Lorg_webrtc_VideoCodecInfo_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnCurrentEncoder_Lorg_webrtc_VideoCodecInfo_);
				return cb_onCurrentEncoder_Lorg_webrtc_VideoCodecInfo_;
			}

			static void n_OnCurrentEncoder_Lorg_webrtc_VideoCodecInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoderFactory.IVideoEncoderSelector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCodecInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnCurrentEncoder (p0);
			}
#pragma warning restore 0169

			IntPtr id_onCurrentEncoder_Lorg_webrtc_VideoCodecInfo_;
			public unsafe void OnCurrentEncoder (global::Org.Webrtc.VideoCodecInfo? p0)
			{
				if (id_onCurrentEncoder_Lorg_webrtc_VideoCodecInfo_ == IntPtr.Zero)
					id_onCurrentEncoder_Lorg_webrtc_VideoCodecInfo_ = JNIEnv.GetMethodID (class_ref, "onCurrentEncoder", "(Lorg/webrtc/VideoCodecInfo;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCurrentEncoder_Lorg_webrtc_VideoCodecInfo_, __args);
			}

			static Delegate? cb_onEncoderBroken;
#pragma warning disable 0169
			static Delegate GetOnEncoderBrokenHandler ()
			{
				if (cb_onEncoderBroken == null)
					cb_onEncoderBroken = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_OnEncoderBroken);
				return cb_onEncoderBroken;
			}

			static IntPtr n_OnEncoderBroken (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoderFactory.IVideoEncoderSelector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.OnEncoderBroken ());
			}
#pragma warning restore 0169

			IntPtr id_onEncoderBroken;
			public unsafe global::Org.Webrtc.VideoCodecInfo? OnEncoderBroken ()
			{
				if (id_onEncoderBroken == IntPtr.Zero)
					id_onEncoderBroken = JNIEnv.GetMethodID (class_ref, "onEncoderBroken", "()Lorg/webrtc/VideoCodecInfo;");
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCodecInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onEncoderBroken), JniHandleOwnership.TransferLocalRef);
			}

		}

	}

	[global::Android.Runtime.Register ("org/webrtc/VideoEncoderFactory", DoNotGenerateAcw=true)]
	internal partial class IVideoEncoderFactoryInvoker : global::Java.Lang.Object, IVideoEncoderFactory {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoEncoderFactory", typeof (IVideoEncoderFactoryInvoker));

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

		public static IVideoEncoderFactory? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoEncoderFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.webrtc.VideoEncoderFactory'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoEncoderFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_createEncoder_Lorg_webrtc_VideoCodecInfo_;
#pragma warning disable 0169
		static Delegate GetCreateEncoder_Lorg_webrtc_VideoCodecInfo_Handler ()
		{
			if (cb_createEncoder_Lorg_webrtc_VideoCodecInfo_ == null)
				cb_createEncoder_Lorg_webrtc_VideoCodecInfo_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CreateEncoder_Lorg_webrtc_VideoCodecInfo_);
			return cb_createEncoder_Lorg_webrtc_VideoCodecInfo_;
		}

		static IntPtr n_CreateEncoder_Lorg_webrtc_VideoCodecInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoderFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCodecInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateEncoder (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createEncoder_Lorg_webrtc_VideoCodecInfo_;
		public unsafe global::Org.Webrtc.IVideoEncoder? CreateEncoder (global::Org.Webrtc.VideoCodecInfo? p0)
		{
			if (id_createEncoder_Lorg_webrtc_VideoCodecInfo_ == IntPtr.Zero)
				id_createEncoder_Lorg_webrtc_VideoCodecInfo_ = JNIEnv.GetMethodID (class_ref, "createEncoder", "(Lorg/webrtc/VideoCodecInfo;)Lorg/webrtc/VideoEncoder;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createEncoder_Lorg_webrtc_VideoCodecInfo_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate? cb_getSupportedCodecs;
#pragma warning disable 0169
		static Delegate GetGetSupportedCodecsHandler ()
		{
			if (cb_getSupportedCodecs == null)
				cb_getSupportedCodecs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSupportedCodecs);
			return cb_getSupportedCodecs;
		}

		static IntPtr n_GetSupportedCodecs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoderFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.GetSupportedCodecs ());
		}
#pragma warning restore 0169

		IntPtr id_getSupportedCodecs;
		public unsafe global::Org.Webrtc.VideoCodecInfo[]? GetSupportedCodecs ()
		{
			if (id_getSupportedCodecs == IntPtr.Zero)
				id_getSupportedCodecs = JNIEnv.GetMethodID (class_ref, "getSupportedCodecs", "()[Lorg/webrtc/VideoCodecInfo;");
			return (global::Org.Webrtc.VideoCodecInfo[]?) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSupportedCodecs), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.VideoCodecInfo));
		}

	}
}
