using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Core.Channel {

	[Register ("com/ntt/skyway/core/channel/Channel", DoNotGenerateAcw=true)]
	[global::System.Obsolete (@"Use the 'Com.Ntt.Skyway.Core.Channel.IChannel' type. This class will be removed in a future release.")]
	public abstract class Channel : Java.Lang.Object {
		internal Channel ()
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='create' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='kotlin.coroutines.Continuation&lt;? super com.ntt.skyway.core.channel.Channel&gt;']]"
		[global::System.Obsolete (@"Use 'Com.Ntt.Skyway.Core.Channel.IChannel.Create'. This class will be removed in a future release.")]
		[Register ("create", "(Ljava/lang/String;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object? Create (string? name, string? metadata, global::Kotlin.Coroutines.IContinuation _completion)
		{
			const string __id = "create.(Ljava/lang/String;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
			IntPtr native_name = JNIEnv.NewString ((string?)name);
			IntPtr native_metadata = JNIEnv.NewString ((string?)metadata);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_metadata);
				__args [2] = new JniArgumentValue ((_completion == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _completion).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_metadata);
				global::System.GC.KeepAlive (_completion);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='find' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='kotlin.coroutines.Continuation&lt;? super com.ntt.skyway.core.channel.Channel&gt;']]"
		[global::System.Obsolete (@"Use 'Com.Ntt.Skyway.Core.Channel.IChannel.Find'. This class will be removed in a future release.")]
		[Register ("find", "(Ljava/lang/String;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object? Find (string? name, string? id, global::Kotlin.Coroutines.IContinuation _completion)
		{
			const string __id = "find.(Ljava/lang/String;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
			IntPtr native_name = JNIEnv.NewString ((string?)name);
			IntPtr native_id = JNIEnv.NewString ((string?)id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_id);
				__args [2] = new JniArgumentValue ((_completion == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _completion).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_id);
				global::System.GC.KeepAlive (_completion);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='findOrCreate' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='kotlin.coroutines.Continuation&lt;? super com.ntt.skyway.core.channel.Channel&gt;']]"
		[global::System.Obsolete (@"Use 'Com.Ntt.Skyway.Core.Channel.IChannel.FindOrCreate'. This class will be removed in a future release.")]
		[Register ("findOrCreate", "(Ljava/lang/String;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object? FindOrCreate (string? name, string? metadata, global::Kotlin.Coroutines.IContinuation _completion)
		{
			const string __id = "findOrCreate.(Ljava/lang/String;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
			IntPtr native_name = JNIEnv.NewString ((string?)name);
			IntPtr native_metadata = JNIEnv.NewString ((string?)metadata);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_metadata);
				__args [2] = new JniArgumentValue ((_completion == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _completion).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_metadata);
				global::System.GC.KeepAlive (_completion);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/Channel", typeof (Channel));

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']"
	[Register ("com/ntt/skyway/core/channel/Channel", "", "Com.Ntt.Skyway.Core.Channel.IChannelInvoker")]
	public partial interface IChannel : IJavaObject, IJavaPeerable {
		private static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/Channel", typeof (IChannel), isInterface: true);

		global::System.Collections.Generic.ICollection<global::Com.Ntt.Skyway.Core.Channel.Member.IMember> Bots {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='getBots' and count(parameter)=0]"
			[Register ("getBots", "()Ljava/util/Set;", "GetGetBotsHandler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
			get; 
		}

		string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
			get; 
		}

		global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson? LocalPerson {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='getLocalPerson' and count(parameter)=0]"
			[Register ("getLocalPerson", "()Lcom/ntt/skyway/core/channel/member/LocalPerson;", "GetGetLocalPersonHandler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
			get; 
		}

		global::System.Collections.Generic.ICollection<global::Com.Ntt.Skyway.Core.Channel.Member.IMember> Members {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='getMembers' and count(parameter)=0]"
			[Register ("getMembers", "()Ljava/util/Set;", "GetGetMembersHandler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
			get; 
		}

		string Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='getMetadata' and count(parameter)=0]"
			[Register ("getMetadata", "()Ljava/lang/String;", "GetGetMetadataHandler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
			get; 
		}

		string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
			get; 
		}

		global::Kotlin.Jvm.Functions.IFunction0? OnClosedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='getOnClosedHandler' and count(parameter)=0]"
			[Register ("getOnClosedHandler", "()Lkotlin/jvm/functions/Function0;", "GetGetOnClosedHandlerHandler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='setOnClosedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function0&lt;kotlin.Unit&gt;']]"
			[Register ("setOnClosedHandler", "(Lkotlin/jvm/functions/Function0;)V", "GetSetOnClosedHandler_Lkotlin_jvm_functions_Function0_Handler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
			set; 
		}

		global::Kotlin.Jvm.Functions.IFunction1? OnErrorHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='getOnErrorHandler' and count(parameter)=0]"
			[Register ("getOnErrorHandler", "()Lkotlin/jvm/functions/Function1;", "GetGetOnErrorHandlerHandler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='setOnErrorHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super java.lang.Exception, kotlin.Unit&gt;']]"
			[Register ("setOnErrorHandler", "(Lkotlin/jvm/functions/Function1;)V", "GetSetOnErrorHandler_Lkotlin_jvm_functions_Function1_Handler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
			set; 
		}

		global::Kotlin.Jvm.Functions.IFunction1? OnMemberJoinedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='getOnMemberJoinedHandler' and count(parameter)=0]"
			[Register ("getOnMemberJoinedHandler", "()Lkotlin/jvm/functions/Function1;", "GetGetOnMemberJoinedHandlerHandler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='setOnMemberJoinedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super com.ntt.skyway.core.channel.member.Member, kotlin.Unit&gt;']]"
			[Register ("setOnMemberJoinedHandler", "(Lkotlin/jvm/functions/Function1;)V", "GetSetOnMemberJoinedHandler_Lkotlin_jvm_functions_Function1_Handler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
			set; 
		}

		global::Kotlin.Jvm.Functions.IFunction1? OnMemberLeftHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='getOnMemberLeftHandler' and count(parameter)=0]"
			[Register ("getOnMemberLeftHandler", "()Lkotlin/jvm/functions/Function1;", "GetGetOnMemberLeftHandlerHandler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='setOnMemberLeftHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super com.ntt.skyway.core.channel.member.Member, kotlin.Unit&gt;']]"
			[Register ("setOnMemberLeftHandler", "(Lkotlin/jvm/functions/Function1;)V", "GetSetOnMemberLeftHandler_Lkotlin_jvm_functions_Function1_Handler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
			set; 
		}

		global::Kotlin.Jvm.Functions.IFunction0? OnMemberListChangedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='getOnMemberListChangedHandler' and count(parameter)=0]"
			[Register ("getOnMemberListChangedHandler", "()Lkotlin/jvm/functions/Function0;", "GetGetOnMemberListChangedHandlerHandler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='setOnMemberListChangedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function0&lt;kotlin.Unit&gt;']]"
			[Register ("setOnMemberListChangedHandler", "(Lkotlin/jvm/functions/Function0;)V", "GetSetOnMemberListChangedHandler_Lkotlin_jvm_functions_Function0_Handler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
			set; 
		}

		global::Kotlin.Jvm.Functions.IFunction2? OnMemberMetadataUpdatedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='getOnMemberMetadataUpdatedHandler' and count(parameter)=0]"
			[Register ("getOnMemberMetadataUpdatedHandler", "()Lkotlin/jvm/functions/Function2;", "GetGetOnMemberMetadataUpdatedHandlerHandler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='setOnMemberMetadataUpdatedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function2&lt;? super com.ntt.skyway.core.channel.member.Member, ? super java.lang.String, kotlin.Unit&gt;']]"
			[Register ("setOnMemberMetadataUpdatedHandler", "(Lkotlin/jvm/functions/Function2;)V", "GetSetOnMemberMetadataUpdatedHandler_Lkotlin_jvm_functions_Function2_Handler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
			set; 
		}

		global::Kotlin.Jvm.Functions.IFunction1? OnMetadataUpdatedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='getOnMetadataUpdatedHandler' and count(parameter)=0]"
			[Register ("getOnMetadataUpdatedHandler", "()Lkotlin/jvm/functions/Function1;", "GetGetOnMetadataUpdatedHandlerHandler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='setOnMetadataUpdatedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super java.lang.String, kotlin.Unit&gt;']]"
			[Register ("setOnMetadataUpdatedHandler", "(Lkotlin/jvm/functions/Function1;)V", "GetSetOnMetadataUpdatedHandler_Lkotlin_jvm_functions_Function1_Handler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
			set; 
		}

		global::Kotlin.Jvm.Functions.IFunction1? OnPublicationDisabledHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='getOnPublicationDisabledHandler' and count(parameter)=0]"
			[Register ("getOnPublicationDisabledHandler", "()Lkotlin/jvm/functions/Function1;", "GetGetOnPublicationDisabledHandlerHandler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='setOnPublicationDisabledHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super com.ntt.skyway.core.channel.Publication, kotlin.Unit&gt;']]"
			[Register ("setOnPublicationDisabledHandler", "(Lkotlin/jvm/functions/Function1;)V", "GetSetOnPublicationDisabledHandler_Lkotlin_jvm_functions_Function1_Handler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
			set; 
		}

		global::Kotlin.Jvm.Functions.IFunction1? OnPublicationEnabledHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='getOnPublicationEnabledHandler' and count(parameter)=0]"
			[Register ("getOnPublicationEnabledHandler", "()Lkotlin/jvm/functions/Function1;", "GetGetOnPublicationEnabledHandlerHandler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='setOnPublicationEnabledHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super com.ntt.skyway.core.channel.Publication, kotlin.Unit&gt;']]"
			[Register ("setOnPublicationEnabledHandler", "(Lkotlin/jvm/functions/Function1;)V", "GetSetOnPublicationEnabledHandler_Lkotlin_jvm_functions_Function1_Handler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
			set; 
		}

		global::Kotlin.Jvm.Functions.IFunction0? OnPublicationListChangedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='getOnPublicationListChangedHandler' and count(parameter)=0]"
			[Register ("getOnPublicationListChangedHandler", "()Lkotlin/jvm/functions/Function0;", "GetGetOnPublicationListChangedHandlerHandler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='setOnPublicationListChangedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function0&lt;kotlin.Unit&gt;']]"
			[Register ("setOnPublicationListChangedHandler", "(Lkotlin/jvm/functions/Function0;)V", "GetSetOnPublicationListChangedHandler_Lkotlin_jvm_functions_Function0_Handler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
			set; 
		}

		global::Kotlin.Jvm.Functions.IFunction2? OnPublicationMetadataUpdatedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='getOnPublicationMetadataUpdatedHandler' and count(parameter)=0]"
			[Register ("getOnPublicationMetadataUpdatedHandler", "()Lkotlin/jvm/functions/Function2;", "GetGetOnPublicationMetadataUpdatedHandlerHandler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='setOnPublicationMetadataUpdatedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function2&lt;? super com.ntt.skyway.core.channel.Publication, ? super java.lang.String, kotlin.Unit&gt;']]"
			[Register ("setOnPublicationMetadataUpdatedHandler", "(Lkotlin/jvm/functions/Function2;)V", "GetSetOnPublicationMetadataUpdatedHandler_Lkotlin_jvm_functions_Function2_Handler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
			set; 
		}

		global::Kotlin.Jvm.Functions.IFunction1? OnPublicationSubscribedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='getOnPublicationSubscribedHandler' and count(parameter)=0]"
			[Register ("getOnPublicationSubscribedHandler", "()Lkotlin/jvm/functions/Function1;", "GetGetOnPublicationSubscribedHandlerHandler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='setOnPublicationSubscribedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super com.ntt.skyway.core.channel.Subscription, kotlin.Unit&gt;']]"
			[Register ("setOnPublicationSubscribedHandler", "(Lkotlin/jvm/functions/Function1;)V", "GetSetOnPublicationSubscribedHandler_Lkotlin_jvm_functions_Function1_Handler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
			set; 
		}

		global::Kotlin.Jvm.Functions.IFunction1? OnPublicationUnsubscribedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='getOnPublicationUnsubscribedHandler' and count(parameter)=0]"
			[Register ("getOnPublicationUnsubscribedHandler", "()Lkotlin/jvm/functions/Function1;", "GetGetOnPublicationUnsubscribedHandlerHandler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='setOnPublicationUnsubscribedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super com.ntt.skyway.core.channel.Subscription, kotlin.Unit&gt;']]"
			[Register ("setOnPublicationUnsubscribedHandler", "(Lkotlin/jvm/functions/Function1;)V", "GetSetOnPublicationUnsubscribedHandler_Lkotlin_jvm_functions_Function1_Handler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
			set; 
		}

		global::Kotlin.Jvm.Functions.IFunction1? OnStreamPublishedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='getOnStreamPublishedHandler' and count(parameter)=0]"
			[Register ("getOnStreamPublishedHandler", "()Lkotlin/jvm/functions/Function1;", "GetGetOnStreamPublishedHandlerHandler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='setOnStreamPublishedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super com.ntt.skyway.core.channel.Publication, kotlin.Unit&gt;']]"
			[Register ("setOnStreamPublishedHandler", "(Lkotlin/jvm/functions/Function1;)V", "GetSetOnStreamPublishedHandler_Lkotlin_jvm_functions_Function1_Handler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
			set; 
		}

		global::Kotlin.Jvm.Functions.IFunction1? OnStreamUnpublishedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='getOnStreamUnpublishedHandler' and count(parameter)=0]"
			[Register ("getOnStreamUnpublishedHandler", "()Lkotlin/jvm/functions/Function1;", "GetGetOnStreamUnpublishedHandlerHandler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='setOnStreamUnpublishedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super com.ntt.skyway.core.channel.Publication, kotlin.Unit&gt;']]"
			[Register ("setOnStreamUnpublishedHandler", "(Lkotlin/jvm/functions/Function1;)V", "GetSetOnStreamUnpublishedHandler_Lkotlin_jvm_functions_Function1_Handler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
			set; 
		}

		global::Kotlin.Jvm.Functions.IFunction0? OnSubscriptionListChangedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='getOnSubscriptionListChangedHandler' and count(parameter)=0]"
			[Register ("getOnSubscriptionListChangedHandler", "()Lkotlin/jvm/functions/Function0;", "GetGetOnSubscriptionListChangedHandlerHandler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='setOnSubscriptionListChangedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function0&lt;kotlin.Unit&gt;']]"
			[Register ("setOnSubscriptionListChangedHandler", "(Lkotlin/jvm/functions/Function0;)V", "GetSetOnSubscriptionListChangedHandler_Lkotlin_jvm_functions_Function0_Handler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
			set; 
		}

		global::System.Collections.Generic.ICollection<global::Com.Ntt.Skyway.Core.Channel.IPublication> Publications {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='getPublications' and count(parameter)=0]"
			[Register ("getPublications", "()Ljava/util/Set;", "GetGetPublicationsHandler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
			get; 
		}

		global::System.Collections.Generic.ICollection<global::Com.Ntt.Skyway.Core.Channel.ISubscription> Subscriptions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='getSubscriptions' and count(parameter)=0]"
			[Register ("getSubscriptions", "()Ljava/util/Set;", "GetGetSubscriptionsHandler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='close' and count(parameter)=1 and parameter[1][@type='kotlin.coroutines.Continuation&lt;? super java.lang.Boolean&gt;']]"
		[Register ("close", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetClose_Lkotlin_coroutines_Continuation_Handler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
		global::Java.Lang.Object? Close (global::Kotlin.Coroutines.IContinuation p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
		void Dispose ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='getState' and count(parameter)=0]"
		[Register ("getState", "()Lcom/ntt/skyway/core/channel/Channel$State;", "GetGetStateHandler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
		global::Com.Ntt.Skyway.Core.Channel.IChannel.State GetState ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='join' and count(parameter)=2 and parameter[1][@type='com.ntt.skyway.core.channel.member.Member.Init'] and parameter[2][@type='kotlin.coroutines.Continuation&lt;? super com.ntt.skyway.core.channel.member.LocalPerson&gt;']]"
		[Register ("join", "(Lcom/ntt/skyway/core/channel/member/Member$Init;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetJoin_Lcom_ntt_skyway_core_channel_member_Member_Init_Lkotlin_coroutines_Continuation_Handler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
		global::Java.Lang.Object? Join (global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Init memberInit, global::Kotlin.Coroutines.IContinuation p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='leave' and count(parameter)=2 and parameter[1][@type='com.ntt.skyway.core.channel.member.Member'] and parameter[2][@type='kotlin.coroutines.Continuation&lt;? super java.lang.Boolean&gt;']]"
		[Register ("leave", "(Lcom/ntt/skyway/core/channel/member/Member;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetLeave_Lcom_ntt_skyway_core_channel_member_Member_Lkotlin_coroutines_Continuation_Handler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
		global::Java.Lang.Object? Leave (global::Com.Ntt.Skyway.Core.Channel.Member.IMember member, global::Kotlin.Coroutines.IContinuation p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='updateMetadata' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='kotlin.coroutines.Continuation&lt;? super java.lang.Boolean&gt;']]"
		[Register ("updateMetadata", "(Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetUpdateMetadata_Ljava_lang_String_Lkotlin_coroutines_Continuation_Handler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway-core")]
		global::Java.Lang.Object? UpdateMetadata (string metadata, global::Kotlin.Coroutines.IContinuation p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='create' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='kotlin.coroutines.Continuation&lt;? super com.ntt.skyway.core.channel.Channel&gt;']]"
		[Register ("create", "(Ljava/lang/String;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object? Create (string? name, string? metadata, global::Kotlin.Coroutines.IContinuation _completion)
		{
			const string __id = "create.(Ljava/lang/String;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
			IntPtr native_name = JNIEnv.NewString ((string?)name);
			IntPtr native_metadata = JNIEnv.NewString ((string?)metadata);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_metadata);
				__args [2] = new JniArgumentValue ((_completion == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _completion).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_metadata);
				global::System.GC.KeepAlive (_completion);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='find' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='kotlin.coroutines.Continuation&lt;? super com.ntt.skyway.core.channel.Channel&gt;']]"
		[Register ("find", "(Ljava/lang/String;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object? Find (string? name, string? id, global::Kotlin.Coroutines.IContinuation _completion)
		{
			const string __id = "find.(Ljava/lang/String;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
			IntPtr native_name = JNIEnv.NewString ((string?)name);
			IntPtr native_id = JNIEnv.NewString ((string?)id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_id);
				__args [2] = new JniArgumentValue ((_completion == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _completion).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_id);
				global::System.GC.KeepAlive (_completion);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='findOrCreate' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='kotlin.coroutines.Continuation&lt;? super com.ntt.skyway.core.channel.Channel&gt;']]"
		[Register ("findOrCreate", "(Ljava/lang/String;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object? FindOrCreate (string? name, string? metadata, global::Kotlin.Coroutines.IContinuation _completion)
		{
			const string __id = "findOrCreate.(Ljava/lang/String;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
			IntPtr native_name = JNIEnv.NewString ((string?)name);
			IntPtr native_metadata = JNIEnv.NewString ((string?)metadata);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_metadata);
				__args [2] = new JniArgumentValue ((_completion == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _completion).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_metadata);
				global::System.GC.KeepAlive (_completion);
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Channel.Companion']"
		[global::Android.Runtime.Register ("com/ntt/skyway/core/channel/Channel$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/Channel$Companion", typeof (Companion));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Channel.Companion']/method[@name='create' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='kotlin.coroutines.Continuation&lt;? super com.ntt.skyway.core.channel.Channel&gt;']]"
			[Register ("create", "(Ljava/lang/String;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
			public unsafe global::Java.Lang.Object? Create (string? name, string? metadata, global::Kotlin.Coroutines.IContinuation _completion)
			{
				const string __id = "create.(Ljava/lang/String;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
				IntPtr native_name = JNIEnv.NewString ((string?)name);
				IntPtr native_metadata = JNIEnv.NewString ((string?)metadata);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_name);
					__args [1] = new JniArgumentValue (native_metadata);
					__args [2] = new JniArgumentValue ((_completion == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _completion).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_metadata);
					global::System.GC.KeepAlive (_completion);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Channel.Companion']/method[@name='find' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='kotlin.coroutines.Continuation&lt;? super com.ntt.skyway.core.channel.Channel&gt;']]"
			[Register ("find", "(Ljava/lang/String;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
			public unsafe global::Java.Lang.Object? Find (string? name, string? id, global::Kotlin.Coroutines.IContinuation _completion)
			{
				const string __id = "find.(Ljava/lang/String;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
				IntPtr native_name = JNIEnv.NewString ((string?)name);
				IntPtr native_id = JNIEnv.NewString ((string?)id);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_name);
					__args [1] = new JniArgumentValue (native_id);
					__args [2] = new JniArgumentValue ((_completion == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _completion).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_id);
					global::System.GC.KeepAlive (_completion);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Channel.Companion']/method[@name='findOrCreate' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='kotlin.coroutines.Continuation&lt;? super com.ntt.skyway.core.channel.Channel&gt;']]"
			[Register ("findOrCreate", "(Ljava/lang/String;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
			public unsafe global::Java.Lang.Object? FindOrCreate (string? name, string? metadata, global::Kotlin.Coroutines.IContinuation _completion)
			{
				const string __id = "findOrCreate.(Ljava/lang/String;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
				IntPtr native_name = JNIEnv.NewString ((string?)name);
				IntPtr native_metadata = JNIEnv.NewString ((string?)metadata);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_name);
					__args [1] = new JniArgumentValue (native_metadata);
					__args [2] = new JniArgumentValue ((_completion == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _completion).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_metadata);
					global::System.GC.KeepAlive (_completion);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Channel.State']"
		[global::Android.Runtime.Register ("com/ntt/skyway/core/channel/Channel$State", DoNotGenerateAcw=true)]
		public sealed partial class State : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Channel.State']/field[@name='CLOSED']"
			[Register ("CLOSED")]
			public static global::Com.Ntt.Skyway.Core.Channel.IChannel.State? Closed {
				get {
					const string __id = "CLOSED.Lcom/ntt/skyway/core/channel/Channel$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Channel.State']/field[@name='OPENED']"
			[Register ("OPENED")]
			public static global::Com.Ntt.Skyway.Core.Channel.IChannel.State? Opened {
				get {
					const string __id = "OPENED.Lcom/ntt/skyway/core/channel/Channel$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Channel.State.Companion']"
			[global::Android.Runtime.Register ("com/ntt/skyway/core/channel/Channel$State$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/Channel$State$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Channel.State.Companion']/constructor[@name='Channel.State.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/Channel$State", typeof (State));

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

			internal State (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Channel.State']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/ntt/skyway/core/channel/Channel$State;", "")]
			public static unsafe global::Com.Ntt.Skyway.Core.Channel.IChannel.State? ValueOf (string? value)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/ntt/skyway/core/channel/Channel$State;";
				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel.State> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Channel.State']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/ntt/skyway/core/channel/Channel$State;", "")]
			public static unsafe global::Com.Ntt.Skyway.Core.Channel.IChannel.State[]? Values ()
			{
				const string __id = "values.()[Lcom/ntt/skyway/core/channel/Channel$State;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Ntt.Skyway.Core.Channel.IChannel.State[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Ntt.Skyway.Core.Channel.IChannel.State));
				} finally {
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/ntt/skyway/core/channel/Channel", DoNotGenerateAcw=true)]
	internal partial class IChannelInvoker : global::Java.Lang.Object, IChannel {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/Channel", typeof (IChannelInvoker));

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

		public static IChannel? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IChannel> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ntt.skyway.core.channel.Channel'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IChannelInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getBots;
#pragma warning disable 0169
		static Delegate GetGetBotsHandler ()
		{
			if (cb_getBots == null)
				cb_getBots = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBots);
			return cb_getBots;
		}

		static IntPtr n_GetBots (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaSet<global::Com.Ntt.Skyway.Core.Channel.Member.IMember>.ToLocalJniHandle (__this.Bots);
		}
#pragma warning restore 0169

		IntPtr id_getBots;
		public unsafe global::System.Collections.Generic.ICollection<global::Com.Ntt.Skyway.Core.Channel.Member.IMember> Bots {
			get {
				if (id_getBots == IntPtr.Zero)
					id_getBots = JNIEnv.GetMethodID (class_ref, "getBots", "()Ljava/util/Set;");
				return global::Android.Runtime.JavaSet<global::Com.Ntt.Skyway.Core.Channel.Member.IMember>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBots), JniHandleOwnership.TransferLocalRef)!;
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		IntPtr id_getId;
		public unsafe string Id {
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getId), JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static Delegate? cb_getLocalPerson;
#pragma warning disable 0169
		static Delegate GetGetLocalPersonHandler ()
		{
			if (cb_getLocalPerson == null)
				cb_getLocalPerson = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLocalPerson);
			return cb_getLocalPerson;
		}

		static IntPtr n_GetLocalPerson (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.LocalPerson);
		}
#pragma warning restore 0169

		IntPtr id_getLocalPerson;
		public unsafe global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson? LocalPerson {
			get {
				if (id_getLocalPerson == IntPtr.Zero)
					id_getLocalPerson = JNIEnv.GetMethodID (class_ref, "getLocalPerson", "()Lcom/ntt/skyway/core/channel/member/LocalPerson;");
				return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocalPerson), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getMembers;
#pragma warning disable 0169
		static Delegate GetGetMembersHandler ()
		{
			if (cb_getMembers == null)
				cb_getMembers = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMembers);
			return cb_getMembers;
		}

		static IntPtr n_GetMembers (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaSet<global::Com.Ntt.Skyway.Core.Channel.Member.IMember>.ToLocalJniHandle (__this.Members);
		}
#pragma warning restore 0169

		IntPtr id_getMembers;
		public unsafe global::System.Collections.Generic.ICollection<global::Com.Ntt.Skyway.Core.Channel.Member.IMember> Members {
			get {
				if (id_getMembers == IntPtr.Zero)
					id_getMembers = JNIEnv.GetMethodID (class_ref, "getMembers", "()Ljava/util/Set;");
				return global::Android.Runtime.JavaSet<global::Com.Ntt.Skyway.Core.Channel.Member.IMember>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMembers), JniHandleOwnership.TransferLocalRef)!;
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Metadata);
		}
#pragma warning restore 0169

		IntPtr id_getMetadata;
		public unsafe string Metadata {
			get {
				if (id_getMetadata == IntPtr.Zero)
					id_getMetadata = JNIEnv.GetMethodID (class_ref, "getMetadata", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMetadata), JniHandleOwnership.TransferLocalRef)!;
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		IntPtr id_getName;
		public unsafe string Name {
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static Delegate? cb_getOnClosedHandler;
#pragma warning disable 0169
		static Delegate GetGetOnClosedHandlerHandler ()
		{
			if (cb_getOnClosedHandler == null)
				cb_getOnClosedHandler = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOnClosedHandler);
			return cb_getOnClosedHandler;
		}

		static IntPtr n_GetOnClosedHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.OnClosedHandler);
		}
#pragma warning restore 0169

		static Delegate? cb_setOnClosedHandler_Lkotlin_jvm_functions_Function0_;
#pragma warning disable 0169
		static Delegate GetSetOnClosedHandler_Lkotlin_jvm_functions_Function0_Handler ()
		{
			if (cb_setOnClosedHandler_Lkotlin_jvm_functions_Function0_ == null)
				cb_setOnClosedHandler_Lkotlin_jvm_functions_Function0_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnClosedHandler_Lkotlin_jvm_functions_Function0_);
			return cb_setOnClosedHandler_Lkotlin_jvm_functions_Function0_;
		}

		static void n_SetOnClosedHandler_Lkotlin_jvm_functions_Function0_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var value = (global::Kotlin.Jvm.Functions.IFunction0?)global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction0> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.OnClosedHandler = value;
		}
#pragma warning restore 0169

		IntPtr id_getOnClosedHandler;
		IntPtr id_setOnClosedHandler_Lkotlin_jvm_functions_Function0_;
		public unsafe global::Kotlin.Jvm.Functions.IFunction0? OnClosedHandler {
			get {
				if (id_getOnClosedHandler == IntPtr.Zero)
					id_getOnClosedHandler = JNIEnv.GetMethodID (class_ref, "getOnClosedHandler", "()Lkotlin/jvm/functions/Function0;");
				return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction0> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnClosedHandler), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setOnClosedHandler_Lkotlin_jvm_functions_Function0_ == IntPtr.Zero)
					id_setOnClosedHandler_Lkotlin_jvm_functions_Function0_ = JNIEnv.GetMethodID (class_ref, "setOnClosedHandler", "(Lkotlin/jvm/functions/Function0;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnClosedHandler_Lkotlin_jvm_functions_Function0_, __args);
			}
		}

		static Delegate? cb_getOnErrorHandler;
#pragma warning disable 0169
		static Delegate GetGetOnErrorHandlerHandler ()
		{
			if (cb_getOnErrorHandler == null)
				cb_getOnErrorHandler = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOnErrorHandler);
			return cb_getOnErrorHandler;
		}

		static IntPtr n_GetOnErrorHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.OnErrorHandler);
		}
#pragma warning restore 0169

		static Delegate? cb_setOnErrorHandler_Lkotlin_jvm_functions_Function1_;
#pragma warning disable 0169
		static Delegate GetSetOnErrorHandler_Lkotlin_jvm_functions_Function1_Handler ()
		{
			if (cb_setOnErrorHandler_Lkotlin_jvm_functions_Function1_ == null)
				cb_setOnErrorHandler_Lkotlin_jvm_functions_Function1_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnErrorHandler_Lkotlin_jvm_functions_Function1_);
			return cb_setOnErrorHandler_Lkotlin_jvm_functions_Function1_;
		}

		static void n_SetOnErrorHandler_Lkotlin_jvm_functions_Function1_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var value = (global::Kotlin.Jvm.Functions.IFunction1?)global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.OnErrorHandler = value;
		}
#pragma warning restore 0169

		IntPtr id_getOnErrorHandler;
		IntPtr id_setOnErrorHandler_Lkotlin_jvm_functions_Function1_;
		public unsafe global::Kotlin.Jvm.Functions.IFunction1? OnErrorHandler {
			get {
				if (id_getOnErrorHandler == IntPtr.Zero)
					id_getOnErrorHandler = JNIEnv.GetMethodID (class_ref, "getOnErrorHandler", "()Lkotlin/jvm/functions/Function1;");
				return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnErrorHandler), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setOnErrorHandler_Lkotlin_jvm_functions_Function1_ == IntPtr.Zero)
					id_setOnErrorHandler_Lkotlin_jvm_functions_Function1_ = JNIEnv.GetMethodID (class_ref, "setOnErrorHandler", "(Lkotlin/jvm/functions/Function1;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnErrorHandler_Lkotlin_jvm_functions_Function1_, __args);
			}
		}

		static Delegate? cb_getOnMemberJoinedHandler;
#pragma warning disable 0169
		static Delegate GetGetOnMemberJoinedHandlerHandler ()
		{
			if (cb_getOnMemberJoinedHandler == null)
				cb_getOnMemberJoinedHandler = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOnMemberJoinedHandler);
			return cb_getOnMemberJoinedHandler;
		}

		static IntPtr n_GetOnMemberJoinedHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.OnMemberJoinedHandler);
		}
#pragma warning restore 0169

		static Delegate? cb_setOnMemberJoinedHandler_Lkotlin_jvm_functions_Function1_;
#pragma warning disable 0169
		static Delegate GetSetOnMemberJoinedHandler_Lkotlin_jvm_functions_Function1_Handler ()
		{
			if (cb_setOnMemberJoinedHandler_Lkotlin_jvm_functions_Function1_ == null)
				cb_setOnMemberJoinedHandler_Lkotlin_jvm_functions_Function1_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnMemberJoinedHandler_Lkotlin_jvm_functions_Function1_);
			return cb_setOnMemberJoinedHandler_Lkotlin_jvm_functions_Function1_;
		}

		static void n_SetOnMemberJoinedHandler_Lkotlin_jvm_functions_Function1_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var value = (global::Kotlin.Jvm.Functions.IFunction1?)global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.OnMemberJoinedHandler = value;
		}
#pragma warning restore 0169

		IntPtr id_getOnMemberJoinedHandler;
		IntPtr id_setOnMemberJoinedHandler_Lkotlin_jvm_functions_Function1_;
		public unsafe global::Kotlin.Jvm.Functions.IFunction1? OnMemberJoinedHandler {
			get {
				if (id_getOnMemberJoinedHandler == IntPtr.Zero)
					id_getOnMemberJoinedHandler = JNIEnv.GetMethodID (class_ref, "getOnMemberJoinedHandler", "()Lkotlin/jvm/functions/Function1;");
				return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnMemberJoinedHandler), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setOnMemberJoinedHandler_Lkotlin_jvm_functions_Function1_ == IntPtr.Zero)
					id_setOnMemberJoinedHandler_Lkotlin_jvm_functions_Function1_ = JNIEnv.GetMethodID (class_ref, "setOnMemberJoinedHandler", "(Lkotlin/jvm/functions/Function1;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnMemberJoinedHandler_Lkotlin_jvm_functions_Function1_, __args);
			}
		}

		static Delegate? cb_getOnMemberLeftHandler;
#pragma warning disable 0169
		static Delegate GetGetOnMemberLeftHandlerHandler ()
		{
			if (cb_getOnMemberLeftHandler == null)
				cb_getOnMemberLeftHandler = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOnMemberLeftHandler);
			return cb_getOnMemberLeftHandler;
		}

		static IntPtr n_GetOnMemberLeftHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.OnMemberLeftHandler);
		}
#pragma warning restore 0169

		static Delegate? cb_setOnMemberLeftHandler_Lkotlin_jvm_functions_Function1_;
#pragma warning disable 0169
		static Delegate GetSetOnMemberLeftHandler_Lkotlin_jvm_functions_Function1_Handler ()
		{
			if (cb_setOnMemberLeftHandler_Lkotlin_jvm_functions_Function1_ == null)
				cb_setOnMemberLeftHandler_Lkotlin_jvm_functions_Function1_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnMemberLeftHandler_Lkotlin_jvm_functions_Function1_);
			return cb_setOnMemberLeftHandler_Lkotlin_jvm_functions_Function1_;
		}

		static void n_SetOnMemberLeftHandler_Lkotlin_jvm_functions_Function1_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var value = (global::Kotlin.Jvm.Functions.IFunction1?)global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.OnMemberLeftHandler = value;
		}
#pragma warning restore 0169

		IntPtr id_getOnMemberLeftHandler;
		IntPtr id_setOnMemberLeftHandler_Lkotlin_jvm_functions_Function1_;
		public unsafe global::Kotlin.Jvm.Functions.IFunction1? OnMemberLeftHandler {
			get {
				if (id_getOnMemberLeftHandler == IntPtr.Zero)
					id_getOnMemberLeftHandler = JNIEnv.GetMethodID (class_ref, "getOnMemberLeftHandler", "()Lkotlin/jvm/functions/Function1;");
				return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnMemberLeftHandler), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setOnMemberLeftHandler_Lkotlin_jvm_functions_Function1_ == IntPtr.Zero)
					id_setOnMemberLeftHandler_Lkotlin_jvm_functions_Function1_ = JNIEnv.GetMethodID (class_ref, "setOnMemberLeftHandler", "(Lkotlin/jvm/functions/Function1;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnMemberLeftHandler_Lkotlin_jvm_functions_Function1_, __args);
			}
		}

		static Delegate? cb_getOnMemberListChangedHandler;
#pragma warning disable 0169
		static Delegate GetGetOnMemberListChangedHandlerHandler ()
		{
			if (cb_getOnMemberListChangedHandler == null)
				cb_getOnMemberListChangedHandler = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOnMemberListChangedHandler);
			return cb_getOnMemberListChangedHandler;
		}

		static IntPtr n_GetOnMemberListChangedHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.OnMemberListChangedHandler);
		}
#pragma warning restore 0169

		static Delegate? cb_setOnMemberListChangedHandler_Lkotlin_jvm_functions_Function0_;
#pragma warning disable 0169
		static Delegate GetSetOnMemberListChangedHandler_Lkotlin_jvm_functions_Function0_Handler ()
		{
			if (cb_setOnMemberListChangedHandler_Lkotlin_jvm_functions_Function0_ == null)
				cb_setOnMemberListChangedHandler_Lkotlin_jvm_functions_Function0_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnMemberListChangedHandler_Lkotlin_jvm_functions_Function0_);
			return cb_setOnMemberListChangedHandler_Lkotlin_jvm_functions_Function0_;
		}

		static void n_SetOnMemberListChangedHandler_Lkotlin_jvm_functions_Function0_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var value = (global::Kotlin.Jvm.Functions.IFunction0?)global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction0> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.OnMemberListChangedHandler = value;
		}
#pragma warning restore 0169

		IntPtr id_getOnMemberListChangedHandler;
		IntPtr id_setOnMemberListChangedHandler_Lkotlin_jvm_functions_Function0_;
		public unsafe global::Kotlin.Jvm.Functions.IFunction0? OnMemberListChangedHandler {
			get {
				if (id_getOnMemberListChangedHandler == IntPtr.Zero)
					id_getOnMemberListChangedHandler = JNIEnv.GetMethodID (class_ref, "getOnMemberListChangedHandler", "()Lkotlin/jvm/functions/Function0;");
				return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction0> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnMemberListChangedHandler), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setOnMemberListChangedHandler_Lkotlin_jvm_functions_Function0_ == IntPtr.Zero)
					id_setOnMemberListChangedHandler_Lkotlin_jvm_functions_Function0_ = JNIEnv.GetMethodID (class_ref, "setOnMemberListChangedHandler", "(Lkotlin/jvm/functions/Function0;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnMemberListChangedHandler_Lkotlin_jvm_functions_Function0_, __args);
			}
		}

		static Delegate? cb_getOnMemberMetadataUpdatedHandler;
#pragma warning disable 0169
		static Delegate GetGetOnMemberMetadataUpdatedHandlerHandler ()
		{
			if (cb_getOnMemberMetadataUpdatedHandler == null)
				cb_getOnMemberMetadataUpdatedHandler = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOnMemberMetadataUpdatedHandler);
			return cb_getOnMemberMetadataUpdatedHandler;
		}

		static IntPtr n_GetOnMemberMetadataUpdatedHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.OnMemberMetadataUpdatedHandler);
		}
#pragma warning restore 0169

		static Delegate? cb_setOnMemberMetadataUpdatedHandler_Lkotlin_jvm_functions_Function2_;
#pragma warning disable 0169
		static Delegate GetSetOnMemberMetadataUpdatedHandler_Lkotlin_jvm_functions_Function2_Handler ()
		{
			if (cb_setOnMemberMetadataUpdatedHandler_Lkotlin_jvm_functions_Function2_ == null)
				cb_setOnMemberMetadataUpdatedHandler_Lkotlin_jvm_functions_Function2_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnMemberMetadataUpdatedHandler_Lkotlin_jvm_functions_Function2_);
			return cb_setOnMemberMetadataUpdatedHandler_Lkotlin_jvm_functions_Function2_;
		}

		static void n_SetOnMemberMetadataUpdatedHandler_Lkotlin_jvm_functions_Function2_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var value = (global::Kotlin.Jvm.Functions.IFunction2?)global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction2> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.OnMemberMetadataUpdatedHandler = value;
		}
#pragma warning restore 0169

		IntPtr id_getOnMemberMetadataUpdatedHandler;
		IntPtr id_setOnMemberMetadataUpdatedHandler_Lkotlin_jvm_functions_Function2_;
		public unsafe global::Kotlin.Jvm.Functions.IFunction2? OnMemberMetadataUpdatedHandler {
			get {
				if (id_getOnMemberMetadataUpdatedHandler == IntPtr.Zero)
					id_getOnMemberMetadataUpdatedHandler = JNIEnv.GetMethodID (class_ref, "getOnMemberMetadataUpdatedHandler", "()Lkotlin/jvm/functions/Function2;");
				return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction2> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnMemberMetadataUpdatedHandler), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setOnMemberMetadataUpdatedHandler_Lkotlin_jvm_functions_Function2_ == IntPtr.Zero)
					id_setOnMemberMetadataUpdatedHandler_Lkotlin_jvm_functions_Function2_ = JNIEnv.GetMethodID (class_ref, "setOnMemberMetadataUpdatedHandler", "(Lkotlin/jvm/functions/Function2;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnMemberMetadataUpdatedHandler_Lkotlin_jvm_functions_Function2_, __args);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var value = (global::Kotlin.Jvm.Functions.IFunction1?)global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.OnMetadataUpdatedHandler = value;
		}
#pragma warning restore 0169

		IntPtr id_getOnMetadataUpdatedHandler;
		IntPtr id_setOnMetadataUpdatedHandler_Lkotlin_jvm_functions_Function1_;
		public unsafe global::Kotlin.Jvm.Functions.IFunction1? OnMetadataUpdatedHandler {
			get {
				if (id_getOnMetadataUpdatedHandler == IntPtr.Zero)
					id_getOnMetadataUpdatedHandler = JNIEnv.GetMethodID (class_ref, "getOnMetadataUpdatedHandler", "()Lkotlin/jvm/functions/Function1;");
				return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnMetadataUpdatedHandler), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setOnMetadataUpdatedHandler_Lkotlin_jvm_functions_Function1_ == IntPtr.Zero)
					id_setOnMetadataUpdatedHandler_Lkotlin_jvm_functions_Function1_ = JNIEnv.GetMethodID (class_ref, "setOnMetadataUpdatedHandler", "(Lkotlin/jvm/functions/Function1;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnMetadataUpdatedHandler_Lkotlin_jvm_functions_Function1_, __args);
			}
		}

		static Delegate? cb_getOnPublicationDisabledHandler;
#pragma warning disable 0169
		static Delegate GetGetOnPublicationDisabledHandlerHandler ()
		{
			if (cb_getOnPublicationDisabledHandler == null)
				cb_getOnPublicationDisabledHandler = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOnPublicationDisabledHandler);
			return cb_getOnPublicationDisabledHandler;
		}

		static IntPtr n_GetOnPublicationDisabledHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.OnPublicationDisabledHandler);
		}
#pragma warning restore 0169

		static Delegate? cb_setOnPublicationDisabledHandler_Lkotlin_jvm_functions_Function1_;
#pragma warning disable 0169
		static Delegate GetSetOnPublicationDisabledHandler_Lkotlin_jvm_functions_Function1_Handler ()
		{
			if (cb_setOnPublicationDisabledHandler_Lkotlin_jvm_functions_Function1_ == null)
				cb_setOnPublicationDisabledHandler_Lkotlin_jvm_functions_Function1_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnPublicationDisabledHandler_Lkotlin_jvm_functions_Function1_);
			return cb_setOnPublicationDisabledHandler_Lkotlin_jvm_functions_Function1_;
		}

		static void n_SetOnPublicationDisabledHandler_Lkotlin_jvm_functions_Function1_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var value = (global::Kotlin.Jvm.Functions.IFunction1?)global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.OnPublicationDisabledHandler = value;
		}
#pragma warning restore 0169

		IntPtr id_getOnPublicationDisabledHandler;
		IntPtr id_setOnPublicationDisabledHandler_Lkotlin_jvm_functions_Function1_;
		public unsafe global::Kotlin.Jvm.Functions.IFunction1? OnPublicationDisabledHandler {
			get {
				if (id_getOnPublicationDisabledHandler == IntPtr.Zero)
					id_getOnPublicationDisabledHandler = JNIEnv.GetMethodID (class_ref, "getOnPublicationDisabledHandler", "()Lkotlin/jvm/functions/Function1;");
				return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnPublicationDisabledHandler), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setOnPublicationDisabledHandler_Lkotlin_jvm_functions_Function1_ == IntPtr.Zero)
					id_setOnPublicationDisabledHandler_Lkotlin_jvm_functions_Function1_ = JNIEnv.GetMethodID (class_ref, "setOnPublicationDisabledHandler", "(Lkotlin/jvm/functions/Function1;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnPublicationDisabledHandler_Lkotlin_jvm_functions_Function1_, __args);
			}
		}

		static Delegate? cb_getOnPublicationEnabledHandler;
#pragma warning disable 0169
		static Delegate GetGetOnPublicationEnabledHandlerHandler ()
		{
			if (cb_getOnPublicationEnabledHandler == null)
				cb_getOnPublicationEnabledHandler = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOnPublicationEnabledHandler);
			return cb_getOnPublicationEnabledHandler;
		}

		static IntPtr n_GetOnPublicationEnabledHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.OnPublicationEnabledHandler);
		}
#pragma warning restore 0169

		static Delegate? cb_setOnPublicationEnabledHandler_Lkotlin_jvm_functions_Function1_;
#pragma warning disable 0169
		static Delegate GetSetOnPublicationEnabledHandler_Lkotlin_jvm_functions_Function1_Handler ()
		{
			if (cb_setOnPublicationEnabledHandler_Lkotlin_jvm_functions_Function1_ == null)
				cb_setOnPublicationEnabledHandler_Lkotlin_jvm_functions_Function1_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnPublicationEnabledHandler_Lkotlin_jvm_functions_Function1_);
			return cb_setOnPublicationEnabledHandler_Lkotlin_jvm_functions_Function1_;
		}

		static void n_SetOnPublicationEnabledHandler_Lkotlin_jvm_functions_Function1_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var value = (global::Kotlin.Jvm.Functions.IFunction1?)global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.OnPublicationEnabledHandler = value;
		}
#pragma warning restore 0169

		IntPtr id_getOnPublicationEnabledHandler;
		IntPtr id_setOnPublicationEnabledHandler_Lkotlin_jvm_functions_Function1_;
		public unsafe global::Kotlin.Jvm.Functions.IFunction1? OnPublicationEnabledHandler {
			get {
				if (id_getOnPublicationEnabledHandler == IntPtr.Zero)
					id_getOnPublicationEnabledHandler = JNIEnv.GetMethodID (class_ref, "getOnPublicationEnabledHandler", "()Lkotlin/jvm/functions/Function1;");
				return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnPublicationEnabledHandler), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setOnPublicationEnabledHandler_Lkotlin_jvm_functions_Function1_ == IntPtr.Zero)
					id_setOnPublicationEnabledHandler_Lkotlin_jvm_functions_Function1_ = JNIEnv.GetMethodID (class_ref, "setOnPublicationEnabledHandler", "(Lkotlin/jvm/functions/Function1;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnPublicationEnabledHandler_Lkotlin_jvm_functions_Function1_, __args);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var value = (global::Kotlin.Jvm.Functions.IFunction0?)global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction0> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.OnPublicationListChangedHandler = value;
		}
#pragma warning restore 0169

		IntPtr id_getOnPublicationListChangedHandler;
		IntPtr id_setOnPublicationListChangedHandler_Lkotlin_jvm_functions_Function0_;
		public unsafe global::Kotlin.Jvm.Functions.IFunction0? OnPublicationListChangedHandler {
			get {
				if (id_getOnPublicationListChangedHandler == IntPtr.Zero)
					id_getOnPublicationListChangedHandler = JNIEnv.GetMethodID (class_ref, "getOnPublicationListChangedHandler", "()Lkotlin/jvm/functions/Function0;");
				return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction0> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnPublicationListChangedHandler), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setOnPublicationListChangedHandler_Lkotlin_jvm_functions_Function0_ == IntPtr.Zero)
					id_setOnPublicationListChangedHandler_Lkotlin_jvm_functions_Function0_ = JNIEnv.GetMethodID (class_ref, "setOnPublicationListChangedHandler", "(Lkotlin/jvm/functions/Function0;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnPublicationListChangedHandler_Lkotlin_jvm_functions_Function0_, __args);
			}
		}

		static Delegate? cb_getOnPublicationMetadataUpdatedHandler;
#pragma warning disable 0169
		static Delegate GetGetOnPublicationMetadataUpdatedHandlerHandler ()
		{
			if (cb_getOnPublicationMetadataUpdatedHandler == null)
				cb_getOnPublicationMetadataUpdatedHandler = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOnPublicationMetadataUpdatedHandler);
			return cb_getOnPublicationMetadataUpdatedHandler;
		}

		static IntPtr n_GetOnPublicationMetadataUpdatedHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.OnPublicationMetadataUpdatedHandler);
		}
#pragma warning restore 0169

		static Delegate? cb_setOnPublicationMetadataUpdatedHandler_Lkotlin_jvm_functions_Function2_;
#pragma warning disable 0169
		static Delegate GetSetOnPublicationMetadataUpdatedHandler_Lkotlin_jvm_functions_Function2_Handler ()
		{
			if (cb_setOnPublicationMetadataUpdatedHandler_Lkotlin_jvm_functions_Function2_ == null)
				cb_setOnPublicationMetadataUpdatedHandler_Lkotlin_jvm_functions_Function2_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnPublicationMetadataUpdatedHandler_Lkotlin_jvm_functions_Function2_);
			return cb_setOnPublicationMetadataUpdatedHandler_Lkotlin_jvm_functions_Function2_;
		}

		static void n_SetOnPublicationMetadataUpdatedHandler_Lkotlin_jvm_functions_Function2_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var value = (global::Kotlin.Jvm.Functions.IFunction2?)global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction2> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.OnPublicationMetadataUpdatedHandler = value;
		}
#pragma warning restore 0169

		IntPtr id_getOnPublicationMetadataUpdatedHandler;
		IntPtr id_setOnPublicationMetadataUpdatedHandler_Lkotlin_jvm_functions_Function2_;
		public unsafe global::Kotlin.Jvm.Functions.IFunction2? OnPublicationMetadataUpdatedHandler {
			get {
				if (id_getOnPublicationMetadataUpdatedHandler == IntPtr.Zero)
					id_getOnPublicationMetadataUpdatedHandler = JNIEnv.GetMethodID (class_ref, "getOnPublicationMetadataUpdatedHandler", "()Lkotlin/jvm/functions/Function2;");
				return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction2> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnPublicationMetadataUpdatedHandler), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setOnPublicationMetadataUpdatedHandler_Lkotlin_jvm_functions_Function2_ == IntPtr.Zero)
					id_setOnPublicationMetadataUpdatedHandler_Lkotlin_jvm_functions_Function2_ = JNIEnv.GetMethodID (class_ref, "setOnPublicationMetadataUpdatedHandler", "(Lkotlin/jvm/functions/Function2;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnPublicationMetadataUpdatedHandler_Lkotlin_jvm_functions_Function2_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var value = (global::Kotlin.Jvm.Functions.IFunction1?)global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.OnPublicationSubscribedHandler = value;
		}
#pragma warning restore 0169

		IntPtr id_getOnPublicationSubscribedHandler;
		IntPtr id_setOnPublicationSubscribedHandler_Lkotlin_jvm_functions_Function1_;
		public unsafe global::Kotlin.Jvm.Functions.IFunction1? OnPublicationSubscribedHandler {
			get {
				if (id_getOnPublicationSubscribedHandler == IntPtr.Zero)
					id_getOnPublicationSubscribedHandler = JNIEnv.GetMethodID (class_ref, "getOnPublicationSubscribedHandler", "()Lkotlin/jvm/functions/Function1;");
				return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnPublicationSubscribedHandler), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setOnPublicationSubscribedHandler_Lkotlin_jvm_functions_Function1_ == IntPtr.Zero)
					id_setOnPublicationSubscribedHandler_Lkotlin_jvm_functions_Function1_ = JNIEnv.GetMethodID (class_ref, "setOnPublicationSubscribedHandler", "(Lkotlin/jvm/functions/Function1;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnPublicationSubscribedHandler_Lkotlin_jvm_functions_Function1_, __args);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var value = (global::Kotlin.Jvm.Functions.IFunction1?)global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.OnPublicationUnsubscribedHandler = value;
		}
#pragma warning restore 0169

		IntPtr id_getOnPublicationUnsubscribedHandler;
		IntPtr id_setOnPublicationUnsubscribedHandler_Lkotlin_jvm_functions_Function1_;
		public unsafe global::Kotlin.Jvm.Functions.IFunction1? OnPublicationUnsubscribedHandler {
			get {
				if (id_getOnPublicationUnsubscribedHandler == IntPtr.Zero)
					id_getOnPublicationUnsubscribedHandler = JNIEnv.GetMethodID (class_ref, "getOnPublicationUnsubscribedHandler", "()Lkotlin/jvm/functions/Function1;");
				return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnPublicationUnsubscribedHandler), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setOnPublicationUnsubscribedHandler_Lkotlin_jvm_functions_Function1_ == IntPtr.Zero)
					id_setOnPublicationUnsubscribedHandler_Lkotlin_jvm_functions_Function1_ = JNIEnv.GetMethodID (class_ref, "setOnPublicationUnsubscribedHandler", "(Lkotlin/jvm/functions/Function1;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnPublicationUnsubscribedHandler_Lkotlin_jvm_functions_Function1_, __args);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var value = (global::Kotlin.Jvm.Functions.IFunction1?)global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.OnStreamPublishedHandler = value;
		}
#pragma warning restore 0169

		IntPtr id_getOnStreamPublishedHandler;
		IntPtr id_setOnStreamPublishedHandler_Lkotlin_jvm_functions_Function1_;
		public unsafe global::Kotlin.Jvm.Functions.IFunction1? OnStreamPublishedHandler {
			get {
				if (id_getOnStreamPublishedHandler == IntPtr.Zero)
					id_getOnStreamPublishedHandler = JNIEnv.GetMethodID (class_ref, "getOnStreamPublishedHandler", "()Lkotlin/jvm/functions/Function1;");
				return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnStreamPublishedHandler), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setOnStreamPublishedHandler_Lkotlin_jvm_functions_Function1_ == IntPtr.Zero)
					id_setOnStreamPublishedHandler_Lkotlin_jvm_functions_Function1_ = JNIEnv.GetMethodID (class_ref, "setOnStreamPublishedHandler", "(Lkotlin/jvm/functions/Function1;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnStreamPublishedHandler_Lkotlin_jvm_functions_Function1_, __args);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var value = (global::Kotlin.Jvm.Functions.IFunction1?)global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.OnStreamUnpublishedHandler = value;
		}
#pragma warning restore 0169

		IntPtr id_getOnStreamUnpublishedHandler;
		IntPtr id_setOnStreamUnpublishedHandler_Lkotlin_jvm_functions_Function1_;
		public unsafe global::Kotlin.Jvm.Functions.IFunction1? OnStreamUnpublishedHandler {
			get {
				if (id_getOnStreamUnpublishedHandler == IntPtr.Zero)
					id_getOnStreamUnpublishedHandler = JNIEnv.GetMethodID (class_ref, "getOnStreamUnpublishedHandler", "()Lkotlin/jvm/functions/Function1;");
				return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnStreamUnpublishedHandler), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setOnStreamUnpublishedHandler_Lkotlin_jvm_functions_Function1_ == IntPtr.Zero)
					id_setOnStreamUnpublishedHandler_Lkotlin_jvm_functions_Function1_ = JNIEnv.GetMethodID (class_ref, "setOnStreamUnpublishedHandler", "(Lkotlin/jvm/functions/Function1;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnStreamUnpublishedHandler_Lkotlin_jvm_functions_Function1_, __args);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var value = (global::Kotlin.Jvm.Functions.IFunction0?)global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction0> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.OnSubscriptionListChangedHandler = value;
		}
#pragma warning restore 0169

		IntPtr id_getOnSubscriptionListChangedHandler;
		IntPtr id_setOnSubscriptionListChangedHandler_Lkotlin_jvm_functions_Function0_;
		public unsafe global::Kotlin.Jvm.Functions.IFunction0? OnSubscriptionListChangedHandler {
			get {
				if (id_getOnSubscriptionListChangedHandler == IntPtr.Zero)
					id_getOnSubscriptionListChangedHandler = JNIEnv.GetMethodID (class_ref, "getOnSubscriptionListChangedHandler", "()Lkotlin/jvm/functions/Function0;");
				return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction0> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnSubscriptionListChangedHandler), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setOnSubscriptionListChangedHandler_Lkotlin_jvm_functions_Function0_ == IntPtr.Zero)
					id_setOnSubscriptionListChangedHandler_Lkotlin_jvm_functions_Function0_ = JNIEnv.GetMethodID (class_ref, "setOnSubscriptionListChangedHandler", "(Lkotlin/jvm/functions/Function0;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnSubscriptionListChangedHandler_Lkotlin_jvm_functions_Function0_, __args);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaSet<global::Com.Ntt.Skyway.Core.Channel.IPublication>.ToLocalJniHandle (__this.Publications);
		}
#pragma warning restore 0169

		IntPtr id_getPublications;
		public unsafe global::System.Collections.Generic.ICollection<global::Com.Ntt.Skyway.Core.Channel.IPublication> Publications {
			get {
				if (id_getPublications == IntPtr.Zero)
					id_getPublications = JNIEnv.GetMethodID (class_ref, "getPublications", "()Ljava/util/Set;");
				return global::Android.Runtime.JavaSet<global::Com.Ntt.Skyway.Core.Channel.IPublication>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPublications), JniHandleOwnership.TransferLocalRef)!;
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaSet<global::Com.Ntt.Skyway.Core.Channel.ISubscription>.ToLocalJniHandle (__this.Subscriptions);
		}
#pragma warning restore 0169

		IntPtr id_getSubscriptions;
		public unsafe global::System.Collections.Generic.ICollection<global::Com.Ntt.Skyway.Core.Channel.ISubscription> Subscriptions {
			get {
				if (id_getSubscriptions == IntPtr.Zero)
					id_getSubscriptions = JNIEnv.GetMethodID (class_ref, "getSubscriptions", "()Ljava/util/Set;");
				return global::Android.Runtime.JavaSet<global::Com.Ntt.Skyway.Core.Channel.ISubscription>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSubscriptions), JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static Delegate? cb_close_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetClose_Lkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_close_Lkotlin_coroutines_Continuation_ == null)
				cb_close_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Close_Lkotlin_coroutines_Continuation_);
			return cb_close_Lkotlin_coroutines_Continuation_;
		}

		static IntPtr n_Close_Lkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Kotlin.Coroutines.IContinuation?)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Close (p0!));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_close_Lkotlin_coroutines_Continuation_;
		public unsafe global::Java.Lang.Object? Close (global::Kotlin.Coroutines.IContinuation p0)
		{
			if (id_close_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
				id_close_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID (class_ref, "close", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_close_Lkotlin_coroutines_Continuation_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate? cb_dispose;
#pragma warning disable 0169
		static Delegate GetDisposeHandler ()
		{
			if (cb_dispose == null)
				cb_dispose = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Dispose);
			return cb_dispose;
		}

		static void n_Dispose (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Dispose ();
		}
#pragma warning restore 0169

		IntPtr id_dispose;
		public unsafe void Dispose ()
		{
			if (id_dispose == IntPtr.Zero)
				id_dispose = JNIEnv.GetMethodID (class_ref, "dispose", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dispose);
		}

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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.GetState ());
		}
#pragma warning restore 0169

		IntPtr id_getState;
		public unsafe global::Com.Ntt.Skyway.Core.Channel.IChannel.State GetState ()
		{
			if (id_getState == IntPtr.Zero)
				id_getState = JNIEnv.GetMethodID (class_ref, "getState", "()Lcom/ntt/skyway/core/channel/Channel$State;");
			return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel.State> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getState), JniHandleOwnership.TransferLocalRef)!;
		}

		static Delegate? cb_join_Lcom_ntt_skyway_core_channel_member_Member_Init_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetJoin_Lcom_ntt_skyway_core_channel_member_Member_Init_Lkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_join_Lcom_ntt_skyway_core_channel_member_Member_Init_Lkotlin_coroutines_Continuation_ == null)
				cb_join_Lcom_ntt_skyway_core_channel_member_Member_Init_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Join_Lcom_ntt_skyway_core_channel_member_Member_Init_Lkotlin_coroutines_Continuation_);
			return cb_join_Lcom_ntt_skyway_core_channel_member_Member_Init_Lkotlin_coroutines_Continuation_;
		}

		static IntPtr n_Join_Lcom_ntt_skyway_core_channel_member_Member_Init_Lkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_memberInit, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var memberInit = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Init> (native_memberInit, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Kotlin.Coroutines.IContinuation?)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Join (memberInit!, p1!));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_join_Lcom_ntt_skyway_core_channel_member_Member_Init_Lkotlin_coroutines_Continuation_;
		public unsafe global::Java.Lang.Object? Join (global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Init memberInit, global::Kotlin.Coroutines.IContinuation p1)
		{
			if (id_join_Lcom_ntt_skyway_core_channel_member_Member_Init_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
				id_join_Lcom_ntt_skyway_core_channel_member_Member_Init_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID (class_ref, "join", "(Lcom/ntt/skyway/core/channel/member/Member$Init;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((memberInit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) memberInit).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_join_Lcom_ntt_skyway_core_channel_member_Member_Init_Lkotlin_coroutines_Continuation_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate? cb_leave_Lcom_ntt_skyway_core_channel_member_Member_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetLeave_Lcom_ntt_skyway_core_channel_member_Member_Lkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_leave_Lcom_ntt_skyway_core_channel_member_Member_Lkotlin_coroutines_Continuation_ == null)
				cb_leave_Lcom_ntt_skyway_core_channel_member_Member_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Leave_Lcom_ntt_skyway_core_channel_member_Member_Lkotlin_coroutines_Continuation_);
			return cb_leave_Lcom_ntt_skyway_core_channel_member_Member_Lkotlin_coroutines_Continuation_;
		}

		static IntPtr n_Leave_Lcom_ntt_skyway_core_channel_member_Member_Lkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_member, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var member = (global::Com.Ntt.Skyway.Core.Channel.Member.IMember?)global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember> (native_member, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Kotlin.Coroutines.IContinuation?)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Leave (member!, p1!));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_leave_Lcom_ntt_skyway_core_channel_member_Member_Lkotlin_coroutines_Continuation_;
		public unsafe global::Java.Lang.Object? Leave (global::Com.Ntt.Skyway.Core.Channel.Member.IMember member, global::Kotlin.Coroutines.IContinuation p1)
		{
			if (id_leave_Lcom_ntt_skyway_core_channel_member_Member_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
				id_leave_Lcom_ntt_skyway_core_channel_member_Member_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID (class_ref, "leave", "(Lcom/ntt/skyway/core/channel/member/Member;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((member == null) ? IntPtr.Zero : ((global::Java.Lang.Object) member).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_leave_Lcom_ntt_skyway_core_channel_member_Member_Lkotlin_coroutines_Continuation_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var metadata = JNIEnv.GetString (native_metadata, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Kotlin.Coroutines.IContinuation?)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UpdateMetadata (metadata!, p1!));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_updateMetadata_Ljava_lang_String_Lkotlin_coroutines_Continuation_;
		public unsafe global::Java.Lang.Object? UpdateMetadata (string metadata, global::Kotlin.Coroutines.IContinuation p1)
		{
			if (id_updateMetadata_Ljava_lang_String_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
				id_updateMetadata_Ljava_lang_String_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID (class_ref, "updateMetadata", "(Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			IntPtr native_metadata = JNIEnv.NewString ((string?)metadata);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_metadata);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_updateMetadata_Ljava_lang_String_Lkotlin_coroutines_Continuation_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_metadata);
			return __ret;
		}

	}
}
