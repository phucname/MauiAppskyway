using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc.Audio {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc.audio']/class[@name='WebRtcAudioRecord']"
	[global::Android.Runtime.Register ("org/webrtc/audio/WebRtcAudioRecord", DoNotGenerateAcw=true)]
	public partial class WebRtcAudioRecord : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc.audio']/class[@name='WebRtcAudioRecord']/field[@name='audioRecord']"
		[Register ("audioRecord")]
		public global::Android.Media.AudioRecord? AudioRecord {
			get {
				const string __id = "audioRecord.Landroid/media/AudioRecord;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Media.AudioRecord> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "audioRecord.Landroid/media/AudioRecord;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc.audio']/class[@name='WebRtcAudioRecord']/field[@name='DEFAULT_AUDIO_FORMAT']"
		[Register ("DEFAULT_AUDIO_FORMAT")]
		public const int DefaultAudioFormat = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc.audio']/class[@name='WebRtcAudioRecord']/field[@name='DEFAULT_AUDIO_SOURCE']"
		[Register ("DEFAULT_AUDIO_SOURCE")]
		public const int DefaultAudioSource = (int) 7;


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc.audio']/class[@name='WebRtcAudioRecord']/field[@name='onAudioBufferListener']"
		[Register ("onAudioBufferListener")]
		public global::Org.Webrtc.Audio.WebRtcAudioRecord.IOnAudioBufferListener? OnAudioBufferListener {
			get {
				const string __id = "onAudioBufferListener.Lorg/webrtc/audio/WebRtcAudioRecord$OnAudioBufferListener;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.WebRtcAudioRecord.IOnAudioBufferListener> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "onAudioBufferListener.Lorg/webrtc/audio/WebRtcAudioRecord$OnAudioBufferListener;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc.audio']/interface[@name='WebRtcAudioRecord.OnAudioBufferListener']"
		[Register ("org/webrtc/audio/WebRtcAudioRecord$OnAudioBufferListener", "", "Org.Webrtc.Audio.WebRtcAudioRecord/IOnAudioBufferListenerInvoker")]
		public partial interface IOnAudioBufferListener : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/interface[@name='WebRtcAudioRecord.OnAudioBufferListener']/method[@name='onAudioBuffer' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
			[Register ("onAudioBuffer", "(Ljava/nio/ByteBuffer;)V", "GetOnAudioBuffer_Ljava_nio_ByteBuffer_Handler:Org.Webrtc.Audio.WebRtcAudioRecord/IOnAudioBufferListenerInvoker, webrtc")]
			void OnAudioBuffer (global::Java.Nio.ByteBuffer? p0);

		}

		[global::Android.Runtime.Register ("org/webrtc/audio/WebRtcAudioRecord$OnAudioBufferListener", DoNotGenerateAcw=true)]
		internal partial class IOnAudioBufferListenerInvoker : global::Java.Lang.Object, IOnAudioBufferListener {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/audio/WebRtcAudioRecord$OnAudioBufferListener", typeof (IOnAudioBufferListenerInvoker));

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
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.webrtc.audio.WebRtcAudioRecord.OnAudioBufferListener'.");
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
				var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.WebRtcAudioRecord.IOnAudioBufferListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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

		// event args for org.webrtc.audio.WebRtcAudioRecord.OnAudioBufferListener.onAudioBuffer
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

		[global::Android.Runtime.Register ("mono/org/webrtc/audio/WebRtcAudioRecord_OnAudioBufferListenerImplementor")]
		internal sealed partial class IOnAudioBufferListenerImplementor : global::Java.Lang.Object, IOnAudioBufferListener {

			object sender;

			public IOnAudioBufferListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/org/webrtc/audio/WebRtcAudioRecord_OnAudioBufferListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/audio/WebRtcAudioRecord", typeof (WebRtcAudioRecord));

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

		protected WebRtcAudioRecord (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc.audio']/class[@name='WebRtcAudioRecord']/constructor[@name='WebRtcAudioRecord' and count(parameter)=10 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.concurrent.ScheduledExecutorService'] and parameter[3][@type='android.media.AudioManager'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='org.webrtc.audio.JavaAudioDeviceModule.AudioRecordErrorCallback'] and parameter[7][@type='org.webrtc.audio.JavaAudioDeviceModule.AudioRecordStateCallback'] and parameter[8][@type='org.webrtc.audio.JavaAudioDeviceModule.SamplesReadyCallback'] and parameter[9][@type='boolean'] and parameter[10][@type='boolean']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/util/concurrent/ScheduledExecutorService;Landroid/media/AudioManager;IILorg/webrtc/audio/JavaAudioDeviceModule$AudioRecordErrorCallback;Lorg/webrtc/audio/JavaAudioDeviceModule$AudioRecordStateCallback;Lorg/webrtc/audio/JavaAudioDeviceModule$SamplesReadyCallback;ZZ)V", "")]
		public unsafe WebRtcAudioRecord (global::Android.Content.Context? context, global::Java.Util.Concurrent.IScheduledExecutorService? scheduler, global::Android.Media.AudioManager? audioManager, int audioSource, int audioFormat, global::Org.Webrtc.Audio.JavaAudioDeviceModule.IAudioRecordErrorCallback? errorCallback, global::Org.Webrtc.Audio.JavaAudioDeviceModule.IAudioRecordStateCallback? stateCallback, global::Org.Webrtc.Audio.JavaAudioDeviceModule.ISamplesReadyCallback? audioSamplesReadyCallback, bool isAcousticEchoCancelerSupported, bool isNoiseSuppressorSupported) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Ljava/util/concurrent/ScheduledExecutorService;Landroid/media/AudioManager;IILorg/webrtc/audio/JavaAudioDeviceModule$AudioRecordErrorCallback;Lorg/webrtc/audio/JavaAudioDeviceModule$AudioRecordStateCallback;Lorg/webrtc/audio/JavaAudioDeviceModule$SamplesReadyCallback;ZZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [10];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((scheduler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scheduler).Handle);
				__args [2] = new JniArgumentValue ((audioManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) audioManager).Handle);
				__args [3] = new JniArgumentValue (audioSource);
				__args [4] = new JniArgumentValue (audioFormat);
				__args [5] = new JniArgumentValue ((errorCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) errorCallback).Handle);
				__args [6] = new JniArgumentValue ((stateCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) stateCallback).Handle);
				__args [7] = new JniArgumentValue ((audioSamplesReadyCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) audioSamplesReadyCallback).Handle);
				__args [8] = new JniArgumentValue (isAcousticEchoCancelerSupported);
				__args [9] = new JniArgumentValue (isNoiseSuppressorSupported);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (scheduler);
				global::System.GC.KeepAlive (audioManager);
				global::System.GC.KeepAlive (errorCallback);
				global::System.GC.KeepAlive (stateCallback);
				global::System.GC.KeepAlive (audioSamplesReadyCallback);
			}
		}

		static Delegate? cb_initRecording_II;
#pragma warning disable 0169
		static Delegate GetInitRecording_IIHandler ()
		{
			if (cb_initRecording_II == null)
				cb_initRecording_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_I) n_InitRecording_II);
			return cb_initRecording_II;
		}

		static int n_InitRecording_II (IntPtr jnienv, IntPtr native__this, int sampleRate, int channels)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.WebRtcAudioRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.InitRecording (sampleRate, channels);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/class[@name='WebRtcAudioRecord']/method[@name='initRecording' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("initRecording", "(II)I", "GetInitRecording_IIHandler")]
		public virtual unsafe int InitRecording (int sampleRate, int channels)
		{
			const string __id = "initRecording.(II)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (sampleRate);
				__args [1] = new JniArgumentValue (channels);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate? cb_setMicrophoneMute_Z;
#pragma warning disable 0169
		static Delegate GetSetMicrophoneMute_ZHandler ()
		{
			if (cb_setMicrophoneMute_Z == null)
				cb_setMicrophoneMute_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetMicrophoneMute_Z);
			return cb_setMicrophoneMute_Z;
		}

		static void n_SetMicrophoneMute_Z (IntPtr jnienv, IntPtr native__this, bool mute)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.WebRtcAudioRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.SetMicrophoneMute (mute);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/class[@name='WebRtcAudioRecord']/method[@name='setMicrophoneMute' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setMicrophoneMute", "(Z)V", "GetSetMicrophoneMute_ZHandler")]
		public virtual unsafe void SetMicrophoneMute (bool mute)
		{
			const string __id = "setMicrophoneMute.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (mute);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate? cb_setNativeAudioRecord_J;
#pragma warning disable 0169
		static Delegate GetSetNativeAudioRecord_JHandler ()
		{
			if (cb_setNativeAudioRecord_J == null)
				cb_setNativeAudioRecord_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetNativeAudioRecord_J);
			return cb_setNativeAudioRecord_J;
		}

		static void n_SetNativeAudioRecord_J (IntPtr jnienv, IntPtr native__this, long nativeAudioRecord)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.WebRtcAudioRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.SetNativeAudioRecord (nativeAudioRecord);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/class[@name='WebRtcAudioRecord']/method[@name='setNativeAudioRecord' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setNativeAudioRecord", "(J)V", "GetSetNativeAudioRecord_JHandler")]
		public virtual unsafe void SetNativeAudioRecord (long nativeAudioRecord)
		{
			const string __id = "setNativeAudioRecord.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (nativeAudioRecord);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate? cb_startRecording;
#pragma warning disable 0169
		static Delegate GetStartRecordingHandler ()
		{
			if (cb_startRecording == null)
				cb_startRecording = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_StartRecording);
			return cb_startRecording;
		}

		static bool n_StartRecording (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.WebRtcAudioRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.StartRecording ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/class[@name='WebRtcAudioRecord']/method[@name='startRecording' and count(parameter)=0]"
		[Register ("startRecording", "()Z", "GetStartRecordingHandler")]
		public virtual unsafe bool StartRecording ()
		{
			const string __id = "startRecording.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate? cb_stopRecording;
#pragma warning disable 0169
		static Delegate GetStopRecordingHandler ()
		{
			if (cb_stopRecording == null)
				cb_stopRecording = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_StopRecording);
			return cb_stopRecording;
		}

		static bool n_StopRecording (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.WebRtcAudioRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.StopRecording ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/class[@name='WebRtcAudioRecord']/method[@name='stopRecording' and count(parameter)=0]"
		[Register ("stopRecording", "()Z", "GetStopRecordingHandler")]
		public virtual unsafe bool StopRecording ()
		{
			const string __id = "stopRecording.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
