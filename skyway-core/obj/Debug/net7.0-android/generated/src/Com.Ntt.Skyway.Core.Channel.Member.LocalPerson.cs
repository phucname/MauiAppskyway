using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Core.Channel.Member {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']"
	[global::Android.Runtime.Register ("com/ntt/skyway/core/channel/member/LocalPerson", DoNotGenerateAcw=true)]
	public abstract partial class LocalPerson : global::Java.Lang.Object, global::Com.Ntt.Skyway.Core.Channel.Member.IMember {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/member/LocalPerson", typeof (LocalPerson));

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

		protected LocalPerson (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/constructor[@name='LocalPerson' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LocalPerson () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate? cb_getOnPublicationSubscribedHandler;
#pragma warning disable 0169
		static Delegate GetGetOnPublicationSubscribedHandlerHandler ()
		{
			if (cb_getOnPublicationSubscribedHandler == null)
				cb_getOnPublicationSubscribedHandler = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOnPublicationSubscribedHandler);
			return cb_getOnPublicationSubscribedHandler;
		}

		static IntPtr n_GetOnPublicationSubscribedHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.OnPublicationSubscribedHandler);
		}
#pragma warning restore 0169

		static Delegate? cb_setOnPublicationSubscribedHandler_Lkotlin_jvm_functions_Function1_;
#pragma warning disable 0169
		static Delegate GetSetOnPublicationSubscribedHandler_Lkotlin_jvm_functions_Function1_Handler ()
		{
			if (cb_setOnPublicationSubscribedHandler_Lkotlin_jvm_functions_Function1_ == null)
				cb_setOnPublicationSubscribedHandler_Lkotlin_jvm_functions_Function1_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnPublicationSubscribedHandler_Lkotlin_jvm_functions_Function1_);
			return cb_setOnPublicationSubscribedHandler_Lkotlin_jvm_functions_Function1_;
		}

		static void n_SetOnPublicationSubscribedHandler_Lkotlin_jvm_functions_Function1_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var value = (global::Kotlin.Jvm.Functions.IFunction1?)global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.OnPublicationSubscribedHandler = value;
		}
#pragma warning restore 0169

		public abstract global::Kotlin.Jvm.Functions.IFunction1? OnPublicationSubscribedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='getOnPublicationSubscribedHandler' and count(parameter)=0]"
			[Register ("getOnPublicationSubscribedHandler", "()Lkotlin/jvm/functions/Function1;", "GetGetOnPublicationSubscribedHandlerHandler")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='setOnPublicationSubscribedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super com.ntt.skyway.core.channel.Subscription, kotlin.Unit&gt;']]"
			[Register ("setOnPublicationSubscribedHandler", "(Lkotlin/jvm/functions/Function1;)V", "GetSetOnPublicationSubscribedHandler_Lkotlin_jvm_functions_Function1_Handler")]
			set; 
		}

		static Delegate? cb_getOnPublicationUnsubscribedHandler;
#pragma warning disable 0169
		static Delegate GetGetOnPublicationUnsubscribedHandlerHandler ()
		{
			if (cb_getOnPublicationUnsubscribedHandler == null)
				cb_getOnPublicationUnsubscribedHandler = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOnPublicationUnsubscribedHandler);
			return cb_getOnPublicationUnsubscribedHandler;
		}

		static IntPtr n_GetOnPublicationUnsubscribedHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.OnPublicationUnsubscribedHandler);
		}
#pragma warning restore 0169

		static Delegate? cb_setOnPublicationUnsubscribedHandler_Lkotlin_jvm_functions_Function1_;
#pragma warning disable 0169
		static Delegate GetSetOnPublicationUnsubscribedHandler_Lkotlin_jvm_functions_Function1_Handler ()
		{
			if (cb_setOnPublicationUnsubscribedHandler_Lkotlin_jvm_functions_Function1_ == null)
				cb_setOnPublicationUnsubscribedHandler_Lkotlin_jvm_functions_Function1_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnPublicationUnsubscribedHandler_Lkotlin_jvm_functions_Function1_);
			return cb_setOnPublicationUnsubscribedHandler_Lkotlin_jvm_functions_Function1_;
		}

		static void n_SetOnPublicationUnsubscribedHandler_Lkotlin_jvm_functions_Function1_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var value = (global::Kotlin.Jvm.Functions.IFunction1?)global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.OnPublicationUnsubscribedHandler = value;
		}
#pragma warning restore 0169

		public abstract global::Kotlin.Jvm.Functions.IFunction1? OnPublicationUnsubscribedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='getOnPublicationUnsubscribedHandler' and count(parameter)=0]"
			[Register ("getOnPublicationUnsubscribedHandler", "()Lkotlin/jvm/functions/Function1;", "GetGetOnPublicationUnsubscribedHandlerHandler")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='setOnPublicationUnsubscribedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super com.ntt.skyway.core.channel.Subscription, kotlin.Unit&gt;']]"
			[Register ("setOnPublicationUnsubscribedHandler", "(Lkotlin/jvm/functions/Function1;)V", "GetSetOnPublicationUnsubscribedHandler_Lkotlin_jvm_functions_Function1_Handler")]
			set; 
		}

		static Delegate? cb_getOnStreamPublishedHandler;
#pragma warning disable 0169
		static Delegate GetGetOnStreamPublishedHandlerHandler ()
		{
			if (cb_getOnStreamPublishedHandler == null)
				cb_getOnStreamPublishedHandler = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOnStreamPublishedHandler);
			return cb_getOnStreamPublishedHandler;
		}

		static IntPtr n_GetOnStreamPublishedHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.OnStreamPublishedHandler);
		}
#pragma warning restore 0169

		static Delegate? cb_setOnStreamPublishedHandler_Lkotlin_jvm_functions_Function1_;
#pragma warning disable 0169
		static Delegate GetSetOnStreamPublishedHandler_Lkotlin_jvm_functions_Function1_Handler ()
		{
			if (cb_setOnStreamPublishedHandler_Lkotlin_jvm_functions_Function1_ == null)
				cb_setOnStreamPublishedHandler_Lkotlin_jvm_functions_Function1_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnStreamPublishedHandler_Lkotlin_jvm_functions_Function1_);
			return cb_setOnStreamPublishedHandler_Lkotlin_jvm_functions_Function1_;
		}

		static void n_SetOnStreamPublishedHandler_Lkotlin_jvm_functions_Function1_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var value = (global::Kotlin.Jvm.Functions.IFunction1?)global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.OnStreamPublishedHandler = value;
		}
#pragma warning restore 0169

		public abstract global::Kotlin.Jvm.Functions.IFunction1? OnStreamPublishedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='getOnStreamPublishedHandler' and count(parameter)=0]"
			[Register ("getOnStreamPublishedHandler", "()Lkotlin/jvm/functions/Function1;", "GetGetOnStreamPublishedHandlerHandler")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='setOnStreamPublishedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super com.ntt.skyway.core.channel.Publication, kotlin.Unit&gt;']]"
			[Register ("setOnStreamPublishedHandler", "(Lkotlin/jvm/functions/Function1;)V", "GetSetOnStreamPublishedHandler_Lkotlin_jvm_functions_Function1_Handler")]
			set; 
		}

		static Delegate? cb_getOnStreamUnpublishedHandler;
#pragma warning disable 0169
		static Delegate GetGetOnStreamUnpublishedHandlerHandler ()
		{
			if (cb_getOnStreamUnpublishedHandler == null)
				cb_getOnStreamUnpublishedHandler = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOnStreamUnpublishedHandler);
			return cb_getOnStreamUnpublishedHandler;
		}

		static IntPtr n_GetOnStreamUnpublishedHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.OnStreamUnpublishedHandler);
		}
#pragma warning restore 0169

		static Delegate? cb_setOnStreamUnpublishedHandler_Lkotlin_jvm_functions_Function1_;
#pragma warning disable 0169
		static Delegate GetSetOnStreamUnpublishedHandler_Lkotlin_jvm_functions_Function1_Handler ()
		{
			if (cb_setOnStreamUnpublishedHandler_Lkotlin_jvm_functions_Function1_ == null)
				cb_setOnStreamUnpublishedHandler_Lkotlin_jvm_functions_Function1_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnStreamUnpublishedHandler_Lkotlin_jvm_functions_Function1_);
			return cb_setOnStreamUnpublishedHandler_Lkotlin_jvm_functions_Function1_;
		}

		static void n_SetOnStreamUnpublishedHandler_Lkotlin_jvm_functions_Function1_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var value = (global::Kotlin.Jvm.Functions.IFunction1?)global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.OnStreamUnpublishedHandler = value;
		}
#pragma warning restore 0169

		public abstract global::Kotlin.Jvm.Functions.IFunction1? OnStreamUnpublishedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='getOnStreamUnpublishedHandler' and count(parameter)=0]"
			[Register ("getOnStreamUnpublishedHandler", "()Lkotlin/jvm/functions/Function1;", "GetGetOnStreamUnpublishedHandlerHandler")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='setOnStreamUnpublishedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super com.ntt.skyway.core.channel.Publication, kotlin.Unit&gt;']]"
			[Register ("setOnStreamUnpublishedHandler", "(Lkotlin/jvm/functions/Function1;)V", "GetSetOnStreamUnpublishedHandler_Lkotlin_jvm_functions_Function1_Handler")]
			set; 
		}

		static Delegate? cb_getSide;
#pragma warning disable 0169
		static Delegate GetGetSideHandler ()
		{
			if (cb_getSide == null)
				cb_getSide = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSide);
			return cb_getSide;
		}

		static IntPtr n_GetSide (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Side);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Side Side {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='getSide' and count(parameter)=0]"
			[Register ("getSide", "()Lcom/ntt/skyway/core/channel/member/Member$Side;", "GetGetSideHandler")]
			get {
				const string __id = "getSide.()Lcom/ntt/skyway/core/channel/member/Member$Side;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Side> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		static Delegate? cb_getSubType;
#pragma warning disable 0169
		static Delegate GetGetSubTypeHandler ()
		{
			if (cb_getSubType == null)
				cb_getSubType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSubType);
			return cb_getSubType;
		}

		static IntPtr n_GetSubType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.SubType);
		}
#pragma warning restore 0169

		public virtual unsafe string SubType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='getSubType' and count(parameter)=0]"
			[Register ("getSubType", "()Ljava/lang/String;", "GetGetSubTypeHandler")]
			get {
				const string __id = "getSubType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		static Delegate? cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Type Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Lcom/ntt/skyway/core/channel/member/Member$Type;", "GetGetTypeHandler")]
			get {
				const string __id = "getType.()Lcom/ntt/skyway/core/channel/member/Member$Type;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Type> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		static Delegate? cb_publish_Lcom_ntt_skyway_core_content_local_LocalStream_Lcom_ntt_skyway_core_channel_Publication_Options_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetPublish_Lcom_ntt_skyway_core_content_local_LocalStream_Lcom_ntt_skyway_core_channel_Publication_Options_Lkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_publish_Lcom_ntt_skyway_core_content_local_LocalStream_Lcom_ntt_skyway_core_channel_Publication_Options_Lkotlin_coroutines_Continuation_ == null)
				cb_publish_Lcom_ntt_skyway_core_content_local_LocalStream_Lcom_ntt_skyway_core_channel_Publication_Options_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_Publish_Lcom_ntt_skyway_core_content_local_LocalStream_Lcom_ntt_skyway_core_channel_Publication_Options_Lkotlin_coroutines_Continuation_);
			return cb_publish_Lcom_ntt_skyway_core_content_local_LocalStream_Lcom_ntt_skyway_core_channel_Publication_Options_Lkotlin_coroutines_Continuation_;
		}

		static IntPtr n_Publish_Lcom_ntt_skyway_core_content_local_LocalStream_Lcom_ntt_skyway_core_channel_Publication_Options_Lkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_localStream, IntPtr native_options, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var localStream = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Local.LocalStream> (native_localStream, JniHandleOwnership.DoNotTransfer);
			var options = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication.Options> (native_options, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Kotlin.Coroutines.IContinuation?)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Publish (localStream!, options, p2!));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='publish' and count(parameter)=3 and parameter[1][@type='com.ntt.skyway.core.content.local.LocalStream'] and parameter[2][@type='com.ntt.skyway.core.channel.Publication.Options'] and parameter[3][@type='kotlin.coroutines.Continuation&lt;? super com.ntt.skyway.core.channel.Publication&gt;']]"
		[Register ("publish", "(Lcom/ntt/skyway/core/content/local/LocalStream;Lcom/ntt/skyway/core/channel/Publication$Options;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetPublish_Lcom_ntt_skyway_core_content_local_LocalStream_Lcom_ntt_skyway_core_channel_Publication_Options_Lkotlin_coroutines_Continuation_Handler")]
		public abstract global::Java.Lang.Object? Publish (global::Com.Ntt.Skyway.Core.Content.Local.LocalStream localStream, global::Com.Ntt.Skyway.Core.Channel.IPublication.Options? options, global::Kotlin.Coroutines.IContinuation p2);

		static Delegate? cb_subscribe_Lcom_ntt_skyway_core_channel_Publication_Lcom_ntt_skyway_core_channel_Subscription_Options_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetSubscribe_Lcom_ntt_skyway_core_channel_Publication_Lcom_ntt_skyway_core_channel_Subscription_Options_Lkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_subscribe_Lcom_ntt_skyway_core_channel_Publication_Lcom_ntt_skyway_core_channel_Subscription_Options_Lkotlin_coroutines_Continuation_ == null)
				cb_subscribe_Lcom_ntt_skyway_core_channel_Publication_Lcom_ntt_skyway_core_channel_Subscription_Options_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_Subscribe_Lcom_ntt_skyway_core_channel_Publication_Lcom_ntt_skyway_core_channel_Subscription_Options_Lkotlin_coroutines_Continuation_);
			return cb_subscribe_Lcom_ntt_skyway_core_channel_Publication_Lcom_ntt_skyway_core_channel_Subscription_Options_Lkotlin_coroutines_Continuation_;
		}

		static IntPtr n_Subscribe_Lcom_ntt_skyway_core_channel_Publication_Lcom_ntt_skyway_core_channel_Subscription_Options_Lkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_publication, IntPtr native_options, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var publication = (global::Com.Ntt.Skyway.Core.Channel.IPublication?)global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (native_publication, JniHandleOwnership.DoNotTransfer);
			var options = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.ISubscription.Options> (native_options, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Kotlin.Coroutines.IContinuation?)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Subscribe (publication!, options, p2!));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='subscribe' and count(parameter)=3 and parameter[1][@type='com.ntt.skyway.core.channel.Publication'] and parameter[2][@type='com.ntt.skyway.core.channel.Subscription.Options'] and parameter[3][@type='kotlin.coroutines.Continuation&lt;? super com.ntt.skyway.core.channel.Subscription&gt;']]"
		[Register ("subscribe", "(Lcom/ntt/skyway/core/channel/Publication;Lcom/ntt/skyway/core/channel/Subscription$Options;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetSubscribe_Lcom_ntt_skyway_core_channel_Publication_Lcom_ntt_skyway_core_channel_Subscription_Options_Lkotlin_coroutines_Continuation_Handler")]
		public abstract global::Java.Lang.Object? Subscribe (global::Com.Ntt.Skyway.Core.Channel.IPublication publication, global::Com.Ntt.Skyway.Core.Channel.ISubscription.Options? options, global::Kotlin.Coroutines.IContinuation p2);

		static Delegate? cb_subscribe_Ljava_lang_String_Lcom_ntt_skyway_core_channel_Subscription_Options_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetSubscribe_Ljava_lang_String_Lcom_ntt_skyway_core_channel_Subscription_Options_Lkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_subscribe_Ljava_lang_String_Lcom_ntt_skyway_core_channel_Subscription_Options_Lkotlin_coroutines_Continuation_ == null)
				cb_subscribe_Ljava_lang_String_Lcom_ntt_skyway_core_channel_Subscription_Options_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_Subscribe_Ljava_lang_String_Lcom_ntt_skyway_core_channel_Subscription_Options_Lkotlin_coroutines_Continuation_);
			return cb_subscribe_Ljava_lang_String_Lcom_ntt_skyway_core_channel_Subscription_Options_Lkotlin_coroutines_Continuation_;
		}

		static IntPtr n_Subscribe_Ljava_lang_String_Lcom_ntt_skyway_core_channel_Subscription_Options_Lkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_publicationId, IntPtr native_options, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var publicationId = JNIEnv.GetString (native_publicationId, JniHandleOwnership.DoNotTransfer);
			var options = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.ISubscription.Options> (native_options, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Kotlin.Coroutines.IContinuation?)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Subscribe (publicationId!, options, p2!));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='subscribe' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.ntt.skyway.core.channel.Subscription.Options'] and parameter[3][@type='kotlin.coroutines.Continuation&lt;? super com.ntt.skyway.core.channel.Subscription&gt;']]"
		[Register ("subscribe", "(Ljava/lang/String;Lcom/ntt/skyway/core/channel/Subscription$Options;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetSubscribe_Ljava_lang_String_Lcom_ntt_skyway_core_channel_Subscription_Options_Lkotlin_coroutines_Continuation_Handler")]
		public abstract global::Java.Lang.Object? Subscribe (string publicationId, global::Com.Ntt.Skyway.Core.Channel.ISubscription.Options? options, global::Kotlin.Coroutines.IContinuation p2);

		static Delegate? cb_unpublish_Lcom_ntt_skyway_core_channel_Publication_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetUnpublish_Lcom_ntt_skyway_core_channel_Publication_Lkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_unpublish_Lcom_ntt_skyway_core_channel_Publication_Lkotlin_coroutines_Continuation_ == null)
				cb_unpublish_Lcom_ntt_skyway_core_channel_Publication_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Unpublish_Lcom_ntt_skyway_core_channel_Publication_Lkotlin_coroutines_Continuation_);
			return cb_unpublish_Lcom_ntt_skyway_core_channel_Publication_Lkotlin_coroutines_Continuation_;
		}

		static IntPtr n_Unpublish_Lcom_ntt_skyway_core_channel_Publication_Lkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_publication, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var publication = (global::Com.Ntt.Skyway.Core.Channel.IPublication?)global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (native_publication, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Kotlin.Coroutines.IContinuation?)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Unpublish (publication!, p1!));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='unpublish' and count(parameter)=2 and parameter[1][@type='com.ntt.skyway.core.channel.Publication'] and parameter[2][@type='kotlin.coroutines.Continuation&lt;? super java.lang.Boolean&gt;']]"
		[Register ("unpublish", "(Lcom/ntt/skyway/core/channel/Publication;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetUnpublish_Lcom_ntt_skyway_core_channel_Publication_Lkotlin_coroutines_Continuation_Handler")]
		public abstract global::Java.Lang.Object? Unpublish (global::Com.Ntt.Skyway.Core.Channel.IPublication publication, global::Kotlin.Coroutines.IContinuation p1);

		static Delegate? cb_unpublish_Ljava_lang_String_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetUnpublish_Ljava_lang_String_Lkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_unpublish_Ljava_lang_String_Lkotlin_coroutines_Continuation_ == null)
				cb_unpublish_Ljava_lang_String_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Unpublish_Ljava_lang_String_Lkotlin_coroutines_Continuation_);
			return cb_unpublish_Ljava_lang_String_Lkotlin_coroutines_Continuation_;
		}

		static IntPtr n_Unpublish_Ljava_lang_String_Lkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_publicationId, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var publicationId = JNIEnv.GetString (native_publicationId, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Kotlin.Coroutines.IContinuation?)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Unpublish (publicationId!, p1!));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='unpublish' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='kotlin.coroutines.Continuation&lt;? super java.lang.Boolean&gt;']]"
		[Register ("unpublish", "(Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetUnpublish_Ljava_lang_String_Lkotlin_coroutines_Continuation_Handler")]
		public abstract global::Java.Lang.Object? Unpublish (string publicationId, global::Kotlin.Coroutines.IContinuation p1);

		static Delegate? cb_unsubscribe_Lcom_ntt_skyway_core_channel_Subscription_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetUnsubscribe_Lcom_ntt_skyway_core_channel_Subscription_Lkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_unsubscribe_Lcom_ntt_skyway_core_channel_Subscription_Lkotlin_coroutines_Continuation_ == null)
				cb_unsubscribe_Lcom_ntt_skyway_core_channel_Subscription_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Unsubscribe_Lcom_ntt_skyway_core_channel_Subscription_Lkotlin_coroutines_Continuation_);
			return cb_unsubscribe_Lcom_ntt_skyway_core_channel_Subscription_Lkotlin_coroutines_Continuation_;
		}

		static IntPtr n_Unsubscribe_Lcom_ntt_skyway_core_channel_Subscription_Lkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_subscription, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var subscription = (global::Com.Ntt.Skyway.Core.Channel.ISubscription?)global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.ISubscription> (native_subscription, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Kotlin.Coroutines.IContinuation?)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Unsubscribe (subscription!, p1!));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='unsubscribe' and count(parameter)=2 and parameter[1][@type='com.ntt.skyway.core.channel.Subscription'] and parameter[2][@type='kotlin.coroutines.Continuation&lt;? super java.lang.Boolean&gt;']]"
		[Register ("unsubscribe", "(Lcom/ntt/skyway/core/channel/Subscription;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetUnsubscribe_Lcom_ntt_skyway_core_channel_Subscription_Lkotlin_coroutines_Continuation_Handler")]
		public abstract global::Java.Lang.Object? Unsubscribe (global::Com.Ntt.Skyway.Core.Channel.ISubscription subscription, global::Kotlin.Coroutines.IContinuation p1);

		static Delegate? cb_unsubscribe_Ljava_lang_String_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetUnsubscribe_Ljava_lang_String_Lkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_unsubscribe_Ljava_lang_String_Lkotlin_coroutines_Continuation_ == null)
				cb_unsubscribe_Ljava_lang_String_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Unsubscribe_Ljava_lang_String_Lkotlin_coroutines_Continuation_);
			return cb_unsubscribe_Ljava_lang_String_Lkotlin_coroutines_Continuation_;
		}

		static IntPtr n_Unsubscribe_Ljava_lang_String_Lkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_subscriptionId, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var subscriptionId = JNIEnv.GetString (native_subscriptionId, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Kotlin.Coroutines.IContinuation?)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Unsubscribe (subscriptionId!, p1!));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='unsubscribe' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='kotlin.coroutines.Continuation&lt;? super java.lang.Boolean&gt;']]"
		[Register ("unsubscribe", "(Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetUnsubscribe_Ljava_lang_String_Lkotlin_coroutines_Continuation_Handler")]
		public abstract global::Java.Lang.Object? Unsubscribe (string subscriptionId, global::Kotlin.Coroutines.IContinuation p1);

		static Delegate? cb_getState;
#pragma warning disable 0169
		static Delegate GetGetStateHandler ()
		{
			if (cb_getState == null)
				cb_getState = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetState);
			return cb_getState;
		}

		static IntPtr n_GetState (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.GetState ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/interface[@name='Member']/method[@name='getState' and count(parameter)=0]"
		[Register ("getState", "()Lcom/ntt/skyway/core/channel/member/Member$State;", "GetGetStateHandler")]
		public abstract global::Com.Ntt.Skyway.Core.Channel.Member.IMember.State GetState ();

		static Delegate? cb_leave_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetLeave_Lkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_leave_Lkotlin_coroutines_Continuation_ == null)
				cb_leave_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Leave_Lkotlin_coroutines_Continuation_);
			return cb_leave_Lkotlin_coroutines_Continuation_;
		}

		static IntPtr n_Leave_Lkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Kotlin.Coroutines.IContinuation?)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Leave (p0!));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/interface[@name='Member']/method[@name='leave' and count(parameter)=1 and parameter[1][@type='kotlin.coroutines.Continuation&lt;? super java.lang.Boolean&gt;']]"
		[Register ("leave", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetLeave_Lkotlin_coroutines_Continuation_Handler")]
		public abstract global::Java.Lang.Object? Leave (global::Kotlin.Coroutines.IContinuation p0);

		static Delegate? cb_updateMetadata_Ljava_lang_String_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetUpdateMetadata_Ljava_lang_String_Lkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_updateMetadata_Ljava_lang_String_Lkotlin_coroutines_Continuation_ == null)
				cb_updateMetadata_Ljava_lang_String_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_UpdateMetadata_Ljava_lang_String_Lkotlin_coroutines_Continuation_);
			return cb_updateMetadata_Ljava_lang_String_Lkotlin_coroutines_Continuation_;
		}

		static IntPtr n_UpdateMetadata_Ljava_lang_String_Lkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_metadata, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var metadata = JNIEnv.GetString (native_metadata, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Kotlin.Coroutines.IContinuation?)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UpdateMetadata (metadata!, p1!));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/interface[@name='Member']/method[@name='updateMetadata' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='kotlin.coroutines.Continuation&lt;? super java.lang.Boolean&gt;']]"
		[Register ("updateMetadata", "(Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetUpdateMetadata_Ljava_lang_String_Lkotlin_coroutines_Continuation_Handler")]
		public abstract global::Java.Lang.Object? UpdateMetadata (string metadata, global::Kotlin.Coroutines.IContinuation p1);

		static Delegate? cb_getChannel;
#pragma warning disable 0169
		static Delegate GetGetChannelHandler ()
		{
			if (cb_getChannel == null)
				cb_getChannel = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetChannel);
			return cb_getChannel;
		}

		static IntPtr n_GetChannel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Channel);
		}
#pragma warning restore 0169

		public abstract global::Com.Ntt.Skyway.Core.Channel.IChannel Channel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='getChannel' and count(parameter)=0]"
			[Register ("getChannel", "()Lcom/ntt/skyway/core/channel/Channel;", "GetGetChannelHandler")]
			get; 
		}

		static Delegate? cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		public abstract string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get; 
		}

		static Delegate? cb_getMetadata;
#pragma warning disable 0169
		static Delegate GetGetMetadataHandler ()
		{
			if (cb_getMetadata == null)
				cb_getMetadata = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMetadata);
			return cb_getMetadata;
		}

		static IntPtr n_GetMetadata (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Metadata);
		}
#pragma warning restore 0169

		public abstract string Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='getMetadata' and count(parameter)=0]"
			[Register ("getMetadata", "()Ljava/lang/String;", "GetGetMetadataHandler")]
			get; 
		}

		static Delegate? cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		public abstract string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get; 
		}

		static Delegate? cb_getNativePointer;
#pragma warning disable 0169
		static Delegate GetGetNativePointerHandler ()
		{
			if (cb_getNativePointer == null)
				cb_getNativePointer = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetNativePointer);
			return cb_getNativePointer;
		}

		static long n_GetNativePointer (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.NativePointer;
		}
#pragma warning restore 0169

		public abstract long NativePointer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='getNativePointer' and count(parameter)=0]"
			[Register ("getNativePointer", "()J", "GetGetNativePointerHandler")]
			get; 
		}

		static Delegate? cb_getOnLeftHandler;
#pragma warning disable 0169
		static Delegate GetGetOnLeftHandlerHandler ()
		{
			if (cb_getOnLeftHandler == null)
				cb_getOnLeftHandler = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOnLeftHandler);
			return cb_getOnLeftHandler;
		}

		static IntPtr n_GetOnLeftHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.OnLeftHandler);
		}
#pragma warning restore 0169

		static Delegate? cb_setOnLeftHandler_Lkotlin_jvm_functions_Function0_;
#pragma warning disable 0169
		static Delegate GetSetOnLeftHandler_Lkotlin_jvm_functions_Function0_Handler ()
		{
			if (cb_setOnLeftHandler_Lkotlin_jvm_functions_Function0_ == null)
				cb_setOnLeftHandler_Lkotlin_jvm_functions_Function0_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnLeftHandler_Lkotlin_jvm_functions_Function0_);
			return cb_setOnLeftHandler_Lkotlin_jvm_functions_Function0_;
		}

		static void n_SetOnLeftHandler_Lkotlin_jvm_functions_Function0_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var value = (global::Kotlin.Jvm.Functions.IFunction0?)global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction0> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.OnLeftHandler = value;
		}
#pragma warning restore 0169

		public abstract global::Kotlin.Jvm.Functions.IFunction0? OnLeftHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='getOnLeftHandler' and count(parameter)=0]"
			[Register ("getOnLeftHandler", "()Lkotlin/jvm/functions/Function0;", "GetGetOnLeftHandlerHandler")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='setOnLeftHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function0&lt;kotlin.Unit&gt;']]"
			[Register ("setOnLeftHandler", "(Lkotlin/jvm/functions/Function0;)V", "GetSetOnLeftHandler_Lkotlin_jvm_functions_Function0_Handler")]
			set; 
		}

		static Delegate? cb_getOnMetadataUpdatedHandler;
#pragma warning disable 0169
		static Delegate GetGetOnMetadataUpdatedHandlerHandler ()
		{
			if (cb_getOnMetadataUpdatedHandler == null)
				cb_getOnMetadataUpdatedHandler = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOnMetadataUpdatedHandler);
			return cb_getOnMetadataUpdatedHandler;
		}

		static IntPtr n_GetOnMetadataUpdatedHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.OnMetadataUpdatedHandler);
		}
#pragma warning restore 0169

		static Delegate? cb_setOnMetadataUpdatedHandler_Lkotlin_jvm_functions_Function1_;
#pragma warning disable 0169
		static Delegate GetSetOnMetadataUpdatedHandler_Lkotlin_jvm_functions_Function1_Handler ()
		{
			if (cb_setOnMetadataUpdatedHandler_Lkotlin_jvm_functions_Function1_ == null)
				cb_setOnMetadataUpdatedHandler_Lkotlin_jvm_functions_Function1_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnMetadataUpdatedHandler_Lkotlin_jvm_functions_Function1_);
			return cb_setOnMetadataUpdatedHandler_Lkotlin_jvm_functions_Function1_;
		}

		static void n_SetOnMetadataUpdatedHandler_Lkotlin_jvm_functions_Function1_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var value = (global::Kotlin.Jvm.Functions.IFunction1?)global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.OnMetadataUpdatedHandler = value;
		}
#pragma warning restore 0169

		public abstract global::Kotlin.Jvm.Functions.IFunction1? OnMetadataUpdatedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='getOnMetadataUpdatedHandler' and count(parameter)=0]"
			[Register ("getOnMetadataUpdatedHandler", "()Lkotlin/jvm/functions/Function1;", "GetGetOnMetadataUpdatedHandlerHandler")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='setOnMetadataUpdatedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super java.lang.String, kotlin.Unit&gt;']]"
			[Register ("setOnMetadataUpdatedHandler", "(Lkotlin/jvm/functions/Function1;)V", "GetSetOnMetadataUpdatedHandler_Lkotlin_jvm_functions_Function1_Handler")]
			set; 
		}

		static Delegate? cb_getOnPublicationListChangedHandler;
#pragma warning disable 0169
		static Delegate GetGetOnPublicationListChangedHandlerHandler ()
		{
			if (cb_getOnPublicationListChangedHandler == null)
				cb_getOnPublicationListChangedHandler = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOnPublicationListChangedHandler);
			return cb_getOnPublicationListChangedHandler;
		}

		static IntPtr n_GetOnPublicationListChangedHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.OnPublicationListChangedHandler);
		}
#pragma warning restore 0169

		static Delegate? cb_setOnPublicationListChangedHandler_Lkotlin_jvm_functions_Function0_;
#pragma warning disable 0169
		static Delegate GetSetOnPublicationListChangedHandler_Lkotlin_jvm_functions_Function0_Handler ()
		{
			if (cb_setOnPublicationListChangedHandler_Lkotlin_jvm_functions_Function0_ == null)
				cb_setOnPublicationListChangedHandler_Lkotlin_jvm_functions_Function0_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnPublicationListChangedHandler_Lkotlin_jvm_functions_Function0_);
			return cb_setOnPublicationListChangedHandler_Lkotlin_jvm_functions_Function0_;
		}

		static void n_SetOnPublicationListChangedHandler_Lkotlin_jvm_functions_Function0_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var value = (global::Kotlin.Jvm.Functions.IFunction0?)global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction0> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.OnPublicationListChangedHandler = value;
		}
#pragma warning restore 0169

		public abstract global::Kotlin.Jvm.Functions.IFunction0? OnPublicationListChangedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='getOnPublicationListChangedHandler' and count(parameter)=0]"
			[Register ("getOnPublicationListChangedHandler", "()Lkotlin/jvm/functions/Function0;", "GetGetOnPublicationListChangedHandlerHandler")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='setOnPublicationListChangedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function0&lt;kotlin.Unit&gt;']]"
			[Register ("setOnPublicationListChangedHandler", "(Lkotlin/jvm/functions/Function0;)V", "GetSetOnPublicationListChangedHandler_Lkotlin_jvm_functions_Function0_Handler")]
			set; 
		}

		static Delegate? cb_getOnSubscriptionListChangedHandler;
#pragma warning disable 0169
		static Delegate GetGetOnSubscriptionListChangedHandlerHandler ()
		{
			if (cb_getOnSubscriptionListChangedHandler == null)
				cb_getOnSubscriptionListChangedHandler = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOnSubscriptionListChangedHandler);
			return cb_getOnSubscriptionListChangedHandler;
		}

		static IntPtr n_GetOnSubscriptionListChangedHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.OnSubscriptionListChangedHandler);
		}
#pragma warning restore 0169

		static Delegate? cb_setOnSubscriptionListChangedHandler_Lkotlin_jvm_functions_Function0_;
#pragma warning disable 0169
		static Delegate GetSetOnSubscriptionListChangedHandler_Lkotlin_jvm_functions_Function0_Handler ()
		{
			if (cb_setOnSubscriptionListChangedHandler_Lkotlin_jvm_functions_Function0_ == null)
				cb_setOnSubscriptionListChangedHandler_Lkotlin_jvm_functions_Function0_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnSubscriptionListChangedHandler_Lkotlin_jvm_functions_Function0_);
			return cb_setOnSubscriptionListChangedHandler_Lkotlin_jvm_functions_Function0_;
		}

		static void n_SetOnSubscriptionListChangedHandler_Lkotlin_jvm_functions_Function0_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var value = (global::Kotlin.Jvm.Functions.IFunction0?)global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction0> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.OnSubscriptionListChangedHandler = value;
		}
#pragma warning restore 0169

		public abstract global::Kotlin.Jvm.Functions.IFunction0? OnSubscriptionListChangedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='getOnSubscriptionListChangedHandler' and count(parameter)=0]"
			[Register ("getOnSubscriptionListChangedHandler", "()Lkotlin/jvm/functions/Function0;", "GetGetOnSubscriptionListChangedHandlerHandler")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='setOnSubscriptionListChangedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function0&lt;kotlin.Unit&gt;']]"
			[Register ("setOnSubscriptionListChangedHandler", "(Lkotlin/jvm/functions/Function0;)V", "GetSetOnSubscriptionListChangedHandler_Lkotlin_jvm_functions_Function0_Handler")]
			set; 
		}

		static Delegate? cb_getPublications;
#pragma warning disable 0169
		static Delegate GetGetPublicationsHandler ()
		{
			if (cb_getPublications == null)
				cb_getPublications = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPublications);
			return cb_getPublications;
		}

		static IntPtr n_GetPublications (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Channel.IPublication>.ToLocalJniHandle (__this.Publications);
		}
#pragma warning restore 0169

		public abstract global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Channel.IPublication> Publications {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='getPublications' and count(parameter)=0]"
			[Register ("getPublications", "()Ljava/util/List;", "GetGetPublicationsHandler")]
			get; 
		}

		static Delegate? cb_getSubscriptions;
#pragma warning disable 0169
		static Delegate GetGetSubscriptionsHandler ()
		{
			if (cb_getSubscriptions == null)
				cb_getSubscriptions = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSubscriptions);
			return cb_getSubscriptions;
		}

		static IntPtr n_GetSubscriptions (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Channel.ISubscription>.ToLocalJniHandle (__this.Subscriptions);
		}

        public IMember.Side GetSide()
        {
            throw new NotImplementedException();
        }

        IMember.Type IMember.GetType()
        {
            throw new NotImplementedException();
        }
#pragma warning restore 0169

        public abstract global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Channel.ISubscription> Subscriptions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='getSubscriptions' and count(parameter)=0]"
			[Register ("getSubscriptions", "()Ljava/util/List;", "GetGetSubscriptionsHandler")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("com/ntt/skyway/core/channel/member/LocalPerson", DoNotGenerateAcw=true)]
	internal partial class LocalPersonInvoker : LocalPerson {
		public LocalPersonInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/member/LocalPerson", typeof (LocalPersonInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe global::Kotlin.Jvm.Functions.IFunction1? OnPublicationSubscribedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='getOnPublicationSubscribedHandler' and count(parameter)=0]"
			[Register ("getOnPublicationSubscribedHandler", "()Lkotlin/jvm/functions/Function1;", "GetGetOnPublicationSubscribedHandlerHandler")]
			get {
				const string __id = "getOnPublicationSubscribedHandler.()Lkotlin/jvm/functions/Function1;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='setOnPublicationSubscribedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super com.ntt.skyway.core.channel.Subscription, kotlin.Unit&gt;']]"
			[Register ("setOnPublicationSubscribedHandler", "(Lkotlin/jvm/functions/Function1;)V", "GetSetOnPublicationSubscribedHandler_Lkotlin_jvm_functions_Function1_Handler")]
			set {
				const string __id = "setOnPublicationSubscribedHandler.(Lkotlin/jvm/functions/Function1;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public override unsafe global::Kotlin.Jvm.Functions.IFunction1? OnPublicationUnsubscribedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='getOnPublicationUnsubscribedHandler' and count(parameter)=0]"
			[Register ("getOnPublicationUnsubscribedHandler", "()Lkotlin/jvm/functions/Function1;", "GetGetOnPublicationUnsubscribedHandlerHandler")]
			get {
				const string __id = "getOnPublicationUnsubscribedHandler.()Lkotlin/jvm/functions/Function1;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='setOnPublicationUnsubscribedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super com.ntt.skyway.core.channel.Subscription, kotlin.Unit&gt;']]"
			[Register ("setOnPublicationUnsubscribedHandler", "(Lkotlin/jvm/functions/Function1;)V", "GetSetOnPublicationUnsubscribedHandler_Lkotlin_jvm_functions_Function1_Handler")]
			set {
				const string __id = "setOnPublicationUnsubscribedHandler.(Lkotlin/jvm/functions/Function1;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public override unsafe global::Kotlin.Jvm.Functions.IFunction1? OnStreamPublishedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='getOnStreamPublishedHandler' and count(parameter)=0]"
			[Register ("getOnStreamPublishedHandler", "()Lkotlin/jvm/functions/Function1;", "GetGetOnStreamPublishedHandlerHandler")]
			get {
				const string __id = "getOnStreamPublishedHandler.()Lkotlin/jvm/functions/Function1;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='setOnStreamPublishedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super com.ntt.skyway.core.channel.Publication, kotlin.Unit&gt;']]"
			[Register ("setOnStreamPublishedHandler", "(Lkotlin/jvm/functions/Function1;)V", "GetSetOnStreamPublishedHandler_Lkotlin_jvm_functions_Function1_Handler")]
			set {
				const string __id = "setOnStreamPublishedHandler.(Lkotlin/jvm/functions/Function1;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public override unsafe global::Kotlin.Jvm.Functions.IFunction1? OnStreamUnpublishedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='getOnStreamUnpublishedHandler' and count(parameter)=0]"
			[Register ("getOnStreamUnpublishedHandler", "()Lkotlin/jvm/functions/Function1;", "GetGetOnStreamUnpublishedHandlerHandler")]
			get {
				const string __id = "getOnStreamUnpublishedHandler.()Lkotlin/jvm/functions/Function1;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='setOnStreamUnpublishedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super com.ntt.skyway.core.channel.Publication, kotlin.Unit&gt;']]"
			[Register ("setOnStreamUnpublishedHandler", "(Lkotlin/jvm/functions/Function1;)V", "GetSetOnStreamUnpublishedHandler_Lkotlin_jvm_functions_Function1_Handler")]
			set {
				const string __id = "setOnStreamUnpublishedHandler.(Lkotlin/jvm/functions/Function1;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='publish' and count(parameter)=3 and parameter[1][@type='com.ntt.skyway.core.content.local.LocalStream'] and parameter[2][@type='com.ntt.skyway.core.channel.Publication.Options'] and parameter[3][@type='kotlin.coroutines.Continuation&lt;? super com.ntt.skyway.core.channel.Publication&gt;']]"
		[Register ("publish", "(Lcom/ntt/skyway/core/content/local/LocalStream;Lcom/ntt/skyway/core/channel/Publication$Options;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetPublish_Lcom_ntt_skyway_core_content_local_LocalStream_Lcom_ntt_skyway_core_channel_Publication_Options_Lkotlin_coroutines_Continuation_Handler")]
		public override unsafe global::Java.Lang.Object? Publish (global::Com.Ntt.Skyway.Core.Content.Local.LocalStream localStream, global::Com.Ntt.Skyway.Core.Channel.IPublication.Options? options, global::Kotlin.Coroutines.IContinuation p2)
		{
			const string __id = "publish.(Lcom/ntt/skyway/core/content/local/LocalStream;Lcom/ntt/skyway/core/channel/Publication$Options;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((localStream == null) ? IntPtr.Zero : ((global::Java.Lang.Object) localStream).Handle);
				__args [1] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (localStream);
				global::System.GC.KeepAlive (options);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='subscribe' and count(parameter)=3 and parameter[1][@type='com.ntt.skyway.core.channel.Publication'] and parameter[2][@type='com.ntt.skyway.core.channel.Subscription.Options'] and parameter[3][@type='kotlin.coroutines.Continuation&lt;? super com.ntt.skyway.core.channel.Subscription&gt;']]"
		[Register ("subscribe", "(Lcom/ntt/skyway/core/channel/Publication;Lcom/ntt/skyway/core/channel/Subscription$Options;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetSubscribe_Lcom_ntt_skyway_core_channel_Publication_Lcom_ntt_skyway_core_channel_Subscription_Options_Lkotlin_coroutines_Continuation_Handler")]
		public override unsafe global::Java.Lang.Object? Subscribe (global::Com.Ntt.Skyway.Core.Channel.IPublication publication, global::Com.Ntt.Skyway.Core.Channel.ISubscription.Options? options, global::Kotlin.Coroutines.IContinuation p2)
		{
			const string __id = "subscribe.(Lcom/ntt/skyway/core/channel/Publication;Lcom/ntt/skyway/core/channel/Subscription$Options;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((publication == null) ? IntPtr.Zero : ((global::Java.Lang.Object) publication).Handle);
				__args [1] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (publication);
				global::System.GC.KeepAlive (options);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='subscribe' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.ntt.skyway.core.channel.Subscription.Options'] and parameter[3][@type='kotlin.coroutines.Continuation&lt;? super com.ntt.skyway.core.channel.Subscription&gt;']]"
		[Register ("subscribe", "(Ljava/lang/String;Lcom/ntt/skyway/core/channel/Subscription$Options;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetSubscribe_Ljava_lang_String_Lcom_ntt_skyway_core_channel_Subscription_Options_Lkotlin_coroutines_Continuation_Handler")]
		public override unsafe global::Java.Lang.Object? Subscribe (string publicationId, global::Com.Ntt.Skyway.Core.Channel.ISubscription.Options? options, global::Kotlin.Coroutines.IContinuation p2)
		{
			const string __id = "subscribe.(Ljava/lang/String;Lcom/ntt/skyway/core/channel/Subscription$Options;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
			IntPtr native_publicationId = JNIEnv.NewString ((string?)publicationId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_publicationId);
				__args [1] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_publicationId);
				global::System.GC.KeepAlive (options);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='unpublish' and count(parameter)=2 and parameter[1][@type='com.ntt.skyway.core.channel.Publication'] and parameter[2][@type='kotlin.coroutines.Continuation&lt;? super java.lang.Boolean&gt;']]"
		[Register ("unpublish", "(Lcom/ntt/skyway/core/channel/Publication;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetUnpublish_Lcom_ntt_skyway_core_channel_Publication_Lkotlin_coroutines_Continuation_Handler")]
		public override unsafe global::Java.Lang.Object? Unpublish (global::Com.Ntt.Skyway.Core.Channel.IPublication publication, global::Kotlin.Coroutines.IContinuation p1)
		{
			const string __id = "unpublish.(Lcom/ntt/skyway/core/channel/Publication;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((publication == null) ? IntPtr.Zero : ((global::Java.Lang.Object) publication).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (publication);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='unpublish' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='kotlin.coroutines.Continuation&lt;? super java.lang.Boolean&gt;']]"
		[Register ("unpublish", "(Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetUnpublish_Ljava_lang_String_Lkotlin_coroutines_Continuation_Handler")]
		public override unsafe global::Java.Lang.Object? Unpublish (string publicationId, global::Kotlin.Coroutines.IContinuation p1)
		{
			const string __id = "unpublish.(Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
			IntPtr native_publicationId = JNIEnv.NewString ((string?)publicationId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_publicationId);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_publicationId);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='unsubscribe' and count(parameter)=2 and parameter[1][@type='com.ntt.skyway.core.channel.Subscription'] and parameter[2][@type='kotlin.coroutines.Continuation&lt;? super java.lang.Boolean&gt;']]"
		[Register ("unsubscribe", "(Lcom/ntt/skyway/core/channel/Subscription;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetUnsubscribe_Lcom_ntt_skyway_core_channel_Subscription_Lkotlin_coroutines_Continuation_Handler")]
		public override unsafe global::Java.Lang.Object? Unsubscribe (global::Com.Ntt.Skyway.Core.Channel.ISubscription subscription, global::Kotlin.Coroutines.IContinuation p1)
		{
			const string __id = "unsubscribe.(Lcom/ntt/skyway/core/channel/Subscription;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((subscription == null) ? IntPtr.Zero : ((global::Java.Lang.Object) subscription).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (subscription);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='unsubscribe' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='kotlin.coroutines.Continuation&lt;? super java.lang.Boolean&gt;']]"
		[Register ("unsubscribe", "(Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetUnsubscribe_Ljava_lang_String_Lkotlin_coroutines_Continuation_Handler")]
		public override unsafe global::Java.Lang.Object? Unsubscribe (string subscriptionId, global::Kotlin.Coroutines.IContinuation p1)
		{
			const string __id = "unsubscribe.(Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
			IntPtr native_subscriptionId = JNIEnv.NewString ((string?)subscriptionId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_subscriptionId);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_subscriptionId);
				global::System.GC.KeepAlive (p1);
			}
		}

		public override unsafe global::Com.Ntt.Skyway.Core.Channel.IChannel Channel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='getChannel' and count(parameter)=0]"
			[Register ("getChannel", "()Lcom/ntt/skyway/core/channel/Channel;", "GetGetChannelHandler")]
			get {
				const string __id = "getChannel.()Lcom/ntt/skyway/core/channel/Channel;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public override unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				const string __id = "getId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public override unsafe string Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='getMetadata' and count(parameter)=0]"
			[Register ("getMetadata", "()Ljava/lang/String;", "GetGetMetadataHandler")]
			get {
				const string __id = "getMetadata.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public override unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public override unsafe long NativePointer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='getNativePointer' and count(parameter)=0]"
			[Register ("getNativePointer", "()J", "GetGetNativePointerHandler")]
			get {
				const string __id = "getNativePointer.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe global::Kotlin.Jvm.Functions.IFunction0? OnLeftHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='getOnLeftHandler' and count(parameter)=0]"
			[Register ("getOnLeftHandler", "()Lkotlin/jvm/functions/Function0;", "GetGetOnLeftHandlerHandler")]
			get {
				const string __id = "getOnLeftHandler.()Lkotlin/jvm/functions/Function0;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction0> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='setOnLeftHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function0&lt;kotlin.Unit&gt;']]"
			[Register ("setOnLeftHandler", "(Lkotlin/jvm/functions/Function0;)V", "GetSetOnLeftHandler_Lkotlin_jvm_functions_Function0_Handler")]
			set {
				const string __id = "setOnLeftHandler.(Lkotlin/jvm/functions/Function0;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public override unsafe global::Kotlin.Jvm.Functions.IFunction1? OnMetadataUpdatedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='getOnMetadataUpdatedHandler' and count(parameter)=0]"
			[Register ("getOnMetadataUpdatedHandler", "()Lkotlin/jvm/functions/Function1;", "GetGetOnMetadataUpdatedHandlerHandler")]
			get {
				const string __id = "getOnMetadataUpdatedHandler.()Lkotlin/jvm/functions/Function1;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='setOnMetadataUpdatedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super java.lang.String, kotlin.Unit&gt;']]"
			[Register ("setOnMetadataUpdatedHandler", "(Lkotlin/jvm/functions/Function1;)V", "GetSetOnMetadataUpdatedHandler_Lkotlin_jvm_functions_Function1_Handler")]
			set {
				const string __id = "setOnMetadataUpdatedHandler.(Lkotlin/jvm/functions/Function1;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public override unsafe global::Kotlin.Jvm.Functions.IFunction0? OnPublicationListChangedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='getOnPublicationListChangedHandler' and count(parameter)=0]"
			[Register ("getOnPublicationListChangedHandler", "()Lkotlin/jvm/functions/Function0;", "GetGetOnPublicationListChangedHandlerHandler")]
			get {
				const string __id = "getOnPublicationListChangedHandler.()Lkotlin/jvm/functions/Function0;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction0> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='setOnPublicationListChangedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function0&lt;kotlin.Unit&gt;']]"
			[Register ("setOnPublicationListChangedHandler", "(Lkotlin/jvm/functions/Function0;)V", "GetSetOnPublicationListChangedHandler_Lkotlin_jvm_functions_Function0_Handler")]
			set {
				const string __id = "setOnPublicationListChangedHandler.(Lkotlin/jvm/functions/Function0;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public override unsafe global::Kotlin.Jvm.Functions.IFunction0? OnSubscriptionListChangedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='getOnSubscriptionListChangedHandler' and count(parameter)=0]"
			[Register ("getOnSubscriptionListChangedHandler", "()Lkotlin/jvm/functions/Function0;", "GetGetOnSubscriptionListChangedHandlerHandler")]
			get {
				const string __id = "getOnSubscriptionListChangedHandler.()Lkotlin/jvm/functions/Function0;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction0> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='setOnSubscriptionListChangedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function0&lt;kotlin.Unit&gt;']]"
			[Register ("setOnSubscriptionListChangedHandler", "(Lkotlin/jvm/functions/Function0;)V", "GetSetOnSubscriptionListChangedHandler_Lkotlin_jvm_functions_Function0_Handler")]
			set {
				const string __id = "setOnSubscriptionListChangedHandler.(Lkotlin/jvm/functions/Function0;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public override unsafe global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Channel.IPublication> Publications {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='getPublications' and count(parameter)=0]"
			[Register ("getPublications", "()Ljava/util/List;", "GetGetPublicationsHandler")]
			get {
				const string __id = "getPublications.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Channel.IPublication>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public override unsafe global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Channel.ISubscription> Subscriptions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPerson']/method[@name='getSubscriptions' and count(parameter)=0]"
			[Register ("getSubscriptions", "()Ljava/util/List;", "GetGetSubscriptionsHandler")]
			get {
				const string __id = "getSubscriptions.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Channel.ISubscription>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/interface[@name='Member']/method[@name='getState' and count(parameter)=0]"
		[Register ("getState", "()Lcom/ntt/skyway/core/channel/member/Member$State;", "GetGetStateHandler")]
		public override unsafe global::Com.Ntt.Skyway.Core.Channel.Member.IMember.State GetState ()
		{
			const string __id = "getState.()Lcom/ntt/skyway/core/channel/member/Member$State;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember.State> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/interface[@name='Member']/method[@name='leave' and count(parameter)=1 and parameter[1][@type='kotlin.coroutines.Continuation&lt;? super java.lang.Boolean&gt;']]"
		[Register ("leave", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetLeave_Lkotlin_coroutines_Continuation_Handler")]
		public override unsafe global::Java.Lang.Object? Leave (global::Kotlin.Coroutines.IContinuation p0)
		{
			const string __id = "leave.(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/interface[@name='Member']/method[@name='updateMetadata' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='kotlin.coroutines.Continuation&lt;? super java.lang.Boolean&gt;']]"
		[Register ("updateMetadata", "(Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetUpdateMetadata_Ljava_lang_String_Lkotlin_coroutines_Continuation_Handler")]
		public override unsafe global::Java.Lang.Object? UpdateMetadata (string metadata, global::Kotlin.Coroutines.IContinuation p1)
		{
			const string __id = "updateMetadata.(Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
			IntPtr native_metadata = JNIEnv.NewString ((string?)metadata);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_metadata);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_metadata);
				global::System.GC.KeepAlive (p1);
			}
		}

	}
}
