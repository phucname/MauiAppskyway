using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Core.Content.Local.Source {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='AudioSource']"
	[global::Android.Runtime.Register ("com/ntt/skyway/core/content/local/source/AudioSource", DoNotGenerateAcw=true)]
	public sealed partial class AudioSource : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='AudioSource']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.Ntt.Skyway.Core.Content.Local.Source.AudioSource Instance {
			get {
				const string __id = "INSTANCE.Lcom/ntt/skyway/core/content/local/source/AudioSource;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Local.Source.AudioSource> (__v.Handle, JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/content/local/source/AudioSource", typeof (AudioSource));

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

		internal AudioSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe global::Android.Media.AudioRecord? AudioRecord {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='AudioSource']/method[@name='getAudioRecord' and count(parameter)=0]"
			[Register ("getAudioRecord", "()Landroid/media/AudioRecord;", "")]
			get {
				const string __id = "getAudioRecord.()Landroid/media/AudioRecord;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Media.AudioRecord> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool IsStarted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='AudioSource']/method[@name='isStarted' and count(parameter)=0]"
			[Register ("isStarted", "()Z", "")]
			get {
				const string __id = "isStarted.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Kotlin.Jvm.Functions.IFunction1? OnAudioBufferHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='AudioSource']/method[@name='getOnAudioBufferHandler' and count(parameter)=0]"
			[Register ("getOnAudioBufferHandler", "()Lkotlin/jvm/functions/Function1;", "")]
			get {
				const string __id = "getOnAudioBufferHandler.()Lkotlin/jvm/functions/Function1;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='AudioSource']/method[@name='setOnAudioBufferHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super java.nio.ByteBuffer, kotlin.Unit&gt;']]"
			[Register ("setOnAudioBufferHandler", "(Lkotlin/jvm/functions/Function1;)V", "")]
			set {
				const string __id = "setOnAudioBufferHandler.(Lkotlin/jvm/functions/Function1;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='AudioSource']/method[@name='changeRecord' and count(parameter)=1 and parameter[1][@type='android.media.AudioRecord']]"
		[Register ("changeRecord", "(Landroid/media/AudioRecord;)V", "")]
		public static unsafe void ChangeRecord (global::Android.Media.AudioRecord audioRecord)
		{
			const string __id = "changeRecord.(Landroid/media/AudioRecord;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((audioRecord == null) ? IntPtr.Zero : ((global::Java.Lang.Object) audioRecord).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (audioRecord);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='AudioSource']/method[@name='createStream' and count(parameter)=0]"
		[Register ("createStream", "()Lcom/ntt/skyway/core/content/local/LocalAudioStream;", "")]
		public static unsafe global::Com.Ntt.Skyway.Core.Content.Local.LocalAudioStream CreateStream ()
		{
			const string __id = "createStream.()Lcom/ntt/skyway/core/content/local/LocalAudioStream;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Local.LocalAudioStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='AudioSource']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "")]
		public static unsafe void Start ()
		{
			const string __id = "start.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='AudioSource']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "")]
		public static unsafe void Stop ()
		{
			const string __id = "stop.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

	}
}
