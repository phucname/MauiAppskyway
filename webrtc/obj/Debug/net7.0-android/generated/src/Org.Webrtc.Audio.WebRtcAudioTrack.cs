using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc.Audio {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc.audio']/class[@name='WebRtcAudioTrack']"
	[global::Android.Runtime.Register ("org/webrtc/audio/WebRtcAudioTrack", DoNotGenerateAcw=true)]
	public partial class WebRtcAudioTrack : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc.audio']/class[@name='WebRtcAudioTrack']/field[@name='audioTrack']"
		[Register ("audioTrack")]
		public global::Android.Media.AudioTrack? AudioTrack {
			get {
				const string __id = "audioTrack.Landroid/media/AudioTrack;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Media.AudioTrack> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "audioTrack.Landroid/media/AudioTrack;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc.audio']/class[@name='WebRtcAudioTrack']/field[@name='onAudioBufferListener']"
		[Register ("onAudioBufferListener")]
		public global::Org.Webrtc.Audio.WebRtcAudioTrack.IOnAudioBufferListener? OnAudioBufferListener {
			get {
				const string __id = "onAudioBufferListener.Lorg/webrtc/audio/WebRtcAudioTrack$OnAudioBufferListener;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.WebRtcAudioTrack.IOnAudioBufferListener> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "onAudioBufferListener.Lorg/webrtc/audio/WebRtcAudioTrack$OnAudioBufferListener;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc.audio']/interface[@name='WebRtcAudioTrack.OnAudioBufferListener']"
		[Register ("org/webrtc/audio/WebRtcAudioTrack$OnAudioBufferListener", "", "Org.Webrtc.Audio.WebRtcAudioTrack/IOnAudioBufferListenerInvoker")]
		public partial interface IOnAudioBufferListener : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/interface[@name='WebRtcAudioTrack.OnAudioBufferListener']/method[@name='onAudioBuffer' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
			[Register ("onAudioBuffer", "(Ljava/nio/ByteBuffer;)V", "GetOnAudioBuffer_Ljava_nio_ByteBuffer_Handler:Org.Webrtc.Audio.WebRtcAudioTrack/IOnAudioBufferListenerInvoker, webrtc")]
			void OnAudioBuffer (global::Java.Nio.ByteBuffer? p0);

		}

		[global::Android.Runtime.Register ("org/webrtc/audio/WebRtcAudioTrack$OnAudioBufferListener", DoNotGenerateAcw=true)]
		internal partial class IOnAudioBufferListenerInvoker : global::Java.Lang.Object, IOnAudioBufferListener {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/audio/WebRtcAudioTrack$OnAudioBufferListener", typeof (IOnAudioBufferListenerInvoker));

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

			public static IOnAudioBufferListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnAudioBufferListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.webrtc.audio.WebRtcAudioTrack.OnAudioBufferListener'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnAudioBufferListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate? cb_onAudioBuffer_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
			static Delegate GetOnAudioBuffer_Ljava_nio_ByteBuffer_Handler ()
			{
				if (cb_onAudioBuffer_Ljava_nio_ByteBuffer_ == null)
					cb_onAudioBuffer_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnAudioBuffer_Ljava_nio_ByteBuffer_);
				return cb_onAudioBuffer_Ljava_nio_ByteBuffer_;
			}

			static void n_OnAudioBuffer_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.WebRtcAudioTrack.IOnAudioBufferListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnAudioBuffer (p0);
			}
#pragma warning restore 0169

			IntPtr id_onAudioBuffer_Ljava_nio_ByteBuffer_;
			public unsafe void OnAudioBuffer (global::Java.Nio.ByteBuffer? p0)
			{
				if (id_onAudioBuffer_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
					id_onAudioBuffer_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "onAudioBuffer", "(Ljava/nio/ByteBuffer;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAudioBuffer_Ljava_nio_ByteBuffer_, __args);
			}

		}

		// event args for org.webrtc.audio.WebRtcAudioTrack.OnAudioBufferListener.onAudioBuffer
		public partial class AudioBufferEventArgs : global::System.EventArgs {
			public AudioBufferEventArgs (global::Java.Nio.ByteBuffer? p0)
			{
				this.p0 = p0;
			}

			global::Java.Nio.ByteBuffer? p0;

			public global::Java.Nio.ByteBuffer? P0 {
				get { return p0; }
			}

		}

		[global::Android.Runtime.Register ("mono/org/webrtc/audio/WebRtcAudioTrack_OnAudioBufferListenerImplementor")]
		internal sealed partial class IOnAudioBufferListenerImplementor : global::Java.Lang.Object, IOnAudioBufferListener {

			object sender;

			public IOnAudioBufferListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/org/webrtc/audio/WebRtcAudioTrack_OnAudioBufferListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

			#pragma warning disable 0649
			public EventHandler<AudioBufferEventArgs>? Handler;
			#pragma warning restore 0649

			public void OnAudioBuffer (global::Java.Nio.ByteBuffer? p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new AudioBufferEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnAudioBufferListenerImplementor value)
			{
				return value.Handler == null;
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/audio/WebRtcAudioTrack", typeof (WebRtcAudioTrack));

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

		protected WebRtcAudioTrack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate? cb_initPlayout_IID;
#pragma warning disable 0169
		static Delegate GetInitPlayout_IIDHandler ()
		{
			if (cb_initPlayout_IID == null)
				cb_initPlayout_IID = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIID_I) n_InitPlayout_IID);
			return cb_initPlayout_IID;
		}

		static int n_InitPlayout_IID (IntPtr jnienv, IntPtr native__this, int sampleRate, int channels, double bufferSizeFactor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.WebRtcAudioTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.InitPlayout (sampleRate, channels, bufferSizeFactor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/class[@name='WebRtcAudioTrack']/method[@name='initPlayout' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='double']]"
		[Register ("initPlayout", "(IID)I", "GetInitPlayout_IIDHandler")]
		public virtual unsafe int InitPlayout (int sampleRate, int channels, double bufferSizeFactor)
		{
			const string __id = "initPlayout.(IID)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (sampleRate);
				__args [1] = new JniArgumentValue (channels);
				__args [2] = new JniArgumentValue (bufferSizeFactor);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate? cb_setNativeAudioTrack_J;
#pragma warning disable 0169
		static Delegate GetSetNativeAudioTrack_JHandler ()
		{
			if (cb_setNativeAudioTrack_J == null)
				cb_setNativeAudioTrack_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetNativeAudioTrack_J);
			return cb_setNativeAudioTrack_J;
		}

		static void n_SetNativeAudioTrack_J (IntPtr jnienv, IntPtr native__this, long nativeAudioTrack)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.WebRtcAudioTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.SetNativeAudioTrack (nativeAudioTrack);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/class[@name='WebRtcAudioTrack']/method[@name='setNativeAudioTrack' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setNativeAudioTrack", "(J)V", "GetSetNativeAudioTrack_JHandler")]
		public virtual unsafe void SetNativeAudioTrack (long nativeAudioTrack)
		{
			const string __id = "setNativeAudioTrack.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (nativeAudioTrack);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate? cb_setSpeakerMute_Z;
#pragma warning disable 0169
		static Delegate GetSetSpeakerMute_ZHandler ()
		{
			if (cb_setSpeakerMute_Z == null)
				cb_setSpeakerMute_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetSpeakerMute_Z);
			return cb_setSpeakerMute_Z;
		}

		static void n_SetSpeakerMute_Z (IntPtr jnienv, IntPtr native__this, bool mute)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.WebRtcAudioTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.SetSpeakerMute (mute);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/class[@name='WebRtcAudioTrack']/method[@name='setSpeakerMute' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSpeakerMute", "(Z)V", "GetSetSpeakerMute_ZHandler")]
		public virtual unsafe void SetSpeakerMute (bool mute)
		{
			const string __id = "setSpeakerMute.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (mute);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate? cb_startPlayout;
#pragma warning disable 0169
		static Delegate GetStartPlayoutHandler ()
		{
			if (cb_startPlayout == null)
				cb_startPlayout = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_StartPlayout);
			return cb_startPlayout;
		}

		static bool n_StartPlayout (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.WebRtcAudioTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.StartPlayout ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/class[@name='WebRtcAudioTrack']/method[@name='startPlayout' and count(parameter)=0]"
		[Register ("startPlayout", "()Z", "GetStartPlayoutHandler")]
		public virtual unsafe bool StartPlayout ()
		{
			const string __id = "startPlayout.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate? cb_stopPlayout;
#pragma warning disable 0169
		static Delegate GetStopPlayoutHandler ()
		{
			if (cb_stopPlayout == null)
				cb_stopPlayout = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_StopPlayout);
			return cb_stopPlayout;
		}

		static bool n_StopPlayout (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.WebRtcAudioTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.StopPlayout ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/class[@name='WebRtcAudioTrack']/method[@name='stopPlayout' and count(parameter)=0]"
		[Register ("stopPlayout", "()Z", "GetStopPlayoutHandler")]
		public virtual unsafe bool StopPlayout ()
		{
			const string __id = "stopPlayout.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
