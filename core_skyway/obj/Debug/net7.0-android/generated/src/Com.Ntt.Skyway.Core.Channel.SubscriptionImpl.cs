using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Core.Channel {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='SubscriptionImpl']"
	[global::Android.Runtime.Register ("com/ntt/skyway/core/channel/SubscriptionImpl", DoNotGenerateAcw=true)]
	public sealed partial class SubscriptionImpl : global::Java.Lang.Object, global::Com.Ntt.Skyway.Core.Channel.ISubscription {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/SubscriptionImpl", typeof (SubscriptionImpl));

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

		internal SubscriptionImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe global::Com.Ntt.Skyway.Core.Channel.IChannel Channel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='SubscriptionImpl']/method[@name='getChannel' and count(parameter)=0]"
			[Register ("getChannel", "()Lcom/ntt/skyway/core/channel/Channel;", "")]
			get {
				const string __id = "getChannel.()Lcom/ntt/skyway/core/channel/Channel;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe global::Com.Ntt.Skyway.Core.Content.Stream.ContentType ContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='SubscriptionImpl']/method[@name='getContentType' and count(parameter)=0]"
			[Register ("getContentType", "()Lcom/ntt/skyway/core/content/Stream$ContentType;", "")]
			get {
				const string __id = "getContentType.()Lcom/ntt/skyway/core/content/Stream$ContentType;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Stream.ContentType> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='SubscriptionImpl']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe long NativePointer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='SubscriptionImpl']/method[@name='getNativePointer' and count(parameter)=0]"
			[Register ("getNativePointer", "()J", "")]
			get {
				const string __id = "getNativePointer.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Kotlin.Jvm.Functions.IFunction0? OnCanceledHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='SubscriptionImpl']/method[@name='getOnCanceledHandler' and count(parameter)=0]"
			[Register ("getOnCanceledHandler", "()Lkotlin/jvm/functions/Function0;", "")]
			get {
				const string __id = "getOnCanceledHandler.()Lkotlin/jvm/functions/Function0;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction0> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='SubscriptionImpl']/method[@name='setOnCanceledHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function0&lt;kotlin.Unit&gt;']]"
			[Register ("setOnCanceledHandler", "(Lkotlin/jvm/functions/Function0;)V", "")]
			set {
				const string __id = "setOnCanceledHandler.(Lkotlin/jvm/functions/Function0;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Kotlin.Jvm.Functions.IFunction1? OnConnectionStateChangedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='SubscriptionImpl']/method[@name='getOnConnectionStateChangedHandler' and count(parameter)=0]"
			[Register ("getOnConnectionStateChangedHandler", "()Lkotlin/jvm/functions/Function1;", "")]
			get {
				const string __id = "getOnConnectionStateChangedHandler.()Lkotlin/jvm/functions/Function1;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='SubscriptionImpl']/method[@name='setOnConnectionStateChangedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super java.lang.String, kotlin.Unit&gt;']]"
			[Register ("setOnConnectionStateChangedHandler", "(Lkotlin/jvm/functions/Function1;)V", "")]
			set {
				const string __id = "setOnConnectionStateChangedHandler.(Lkotlin/jvm/functions/Function1;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe string PreferredEncodingId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='SubscriptionImpl']/method[@name='getPreferredEncodingId' and count(parameter)=0]"
			[Register ("getPreferredEncodingId", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getPreferredEncodingId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe global::Com.Ntt.Skyway.Core.Channel.IPublication Publication {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='SubscriptionImpl']/method[@name='getPublication' and count(parameter)=0]"
			[Register ("getPublication", "()Lcom/ntt/skyway/core/channel/Publication;", "")]
			get {
				const string __id = "getPublication.()Lcom/ntt/skyway/core/channel/Publication;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe global::Com.Ntt.Skyway.Core.Channel.ISubscription.State State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='SubscriptionImpl']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()Lcom/ntt/skyway/core/channel/Subscription$State;", "")]
			get {
				const string __id = "getState.()Lcom/ntt/skyway/core/channel/Subscription$State;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.ISubscription.State> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe global::Com.Ntt.Skyway.Core.Content.WebRTCStats? Stats {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='SubscriptionImpl']/method[@name='getStats' and count(parameter)=0]"
			[Register ("getStats", "()Lcom/ntt/skyway/core/content/WebRTCStats;", "")]
			get {
				const string __id = "getStats.()Lcom/ntt/skyway/core/content/WebRTCStats;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.WebRTCStats> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Ntt.Skyway.Core.Content.Remote.RemoteStream? Stream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='SubscriptionImpl']/method[@name='getStream' and count(parameter)=0]"
			[Register ("getStream", "()Lcom/ntt/skyway/core/content/remote/RemoteStream;", "")]
			get {
				const string __id = "getStream.()Lcom/ntt/skyway/core/content/remote/RemoteStream;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Remote.RemoteStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Ntt.Skyway.Core.Channel.Member.IMember Subscriber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='SubscriptionImpl']/method[@name='getSubscriber' and count(parameter)=0]"
			[Register ("getSubscriber", "()Lcom/ntt/skyway/core/channel/member/Member;", "")]
			get {
				const string __id = "getSubscriber.()Lcom/ntt/skyway/core/channel/member/Member;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='SubscriptionImpl']/method[@name='cancel' and count(parameter)=1 and parameter[1][@type='kotlin.coroutines.Continuation&lt;? super java.lang.Boolean&gt;']]"
		[Register ("cancel", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object? Cancel (global::Kotlin.Coroutines.IContinuation _completion)
		{
			const string __id = "cancel.(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((_completion == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _completion).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (_completion);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='SubscriptionImpl']/method[@name='changePreferredEncoding' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("changePreferredEncoding", "(Ljava/lang/String;)V", "")]
		public unsafe void ChangePreferredEncoding (string id)
		{
			const string __id = "changePreferredEncoding.(Ljava/lang/String;)V";
			IntPtr native_id = JNIEnv.NewString ((string?)id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_id);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

	}
}
