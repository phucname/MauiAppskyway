using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Core.Channel {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']"
	[Register ("com/ntt/skyway/core/channel/Publication", "", "Com.Ntt.Skyway.Core.Channel.IPublicationInvoker")]
	public partial interface IPublication : IJavaObject, IJavaPeerable {
		global::Com.Ntt.Skyway.Core.Channel.IChannel Channel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='getChannel' and count(parameter)=0]"
			[Register ("getChannel", "()Lcom/ntt/skyway/core/channel/Channel;", "GetGetChannelHandler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway-core")]
			get; 
		}

		global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Content.Codec> CodecCapabilities {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='getCodecCapabilities' and count(parameter)=0]"
			[Register ("getCodecCapabilities", "()Ljava/util/List;", "GetGetCodecCapabilitiesHandler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway-core")]
			get; 
		}

		global::Com.Ntt.Skyway.Core.Content.Stream.ContentType ContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='getContentType' and count(parameter)=0]"
			[Register ("getContentType", "()Lcom/ntt/skyway/core/content/Stream$ContentType;", "GetGetContentTypeHandler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway-core")]
			get; 
		}

		global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Content.Encoding> Encodings {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='getEncodings' and count(parameter)=0]"
			[Register ("getEncodings", "()Ljava/util/List;", "GetGetEncodingsHandler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway-core")]
			get; 
		}

		string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway-core")]
			get; 
		}

		string Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='getMetadata' and count(parameter)=0]"
			[Register ("getMetadata", "()Ljava/lang/String;", "GetGetMetadataHandler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway-core")]
			get; 
		}

		long NativePointer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='getNativePointer' and count(parameter)=0]"
			[Register ("getNativePointer", "()J", "GetGetNativePointerHandler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway-core")]
			get; 
		}

		global::Kotlin.Jvm.Functions.IFunction1? OnConnectionStateChangedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='getOnConnectionStateChangedHandler' and count(parameter)=0]"
			[Register ("getOnConnectionStateChangedHandler", "()Lkotlin/jvm/functions/Function1;", "GetGetOnConnectionStateChangedHandlerHandler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway-core")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='setOnConnectionStateChangedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super java.lang.String, kotlin.Unit&gt;']]"
			[Register ("setOnConnectionStateChangedHandler", "(Lkotlin/jvm/functions/Function1;)V", "GetSetOnConnectionStateChangedHandler_Lkotlin_jvm_functions_Function1_Handler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway-core")]
			set; 
		}

		global::Kotlin.Jvm.Functions.IFunction0? OnDisabledHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='getOnDisabledHandler' and count(parameter)=0]"
			[Register ("getOnDisabledHandler", "()Lkotlin/jvm/functions/Function0;", "GetGetOnDisabledHandlerHandler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway-core")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='setOnDisabledHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function0&lt;kotlin.Unit&gt;']]"
			[Register ("setOnDisabledHandler", "(Lkotlin/jvm/functions/Function0;)V", "GetSetOnDisabledHandler_Lkotlin_jvm_functions_Function0_Handler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway-core")]
			set; 
		}

		global::Kotlin.Jvm.Functions.IFunction0? OnEnabledHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='getOnEnabledHandler' and count(parameter)=0]"
			[Register ("getOnEnabledHandler", "()Lkotlin/jvm/functions/Function0;", "GetGetOnEnabledHandlerHandler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway-core")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='setOnEnabledHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function0&lt;kotlin.Unit&gt;']]"
			[Register ("setOnEnabledHandler", "(Lkotlin/jvm/functions/Function0;)V", "GetSetOnEnabledHandler_Lkotlin_jvm_functions_Function0_Handler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway-core")]
			set; 
		}

		global::Kotlin.Jvm.Functions.IFunction1? OnMetadataUpdatedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='getOnMetadataUpdatedHandler' and count(parameter)=0]"
			[Register ("getOnMetadataUpdatedHandler", "()Lkotlin/jvm/functions/Function1;", "GetGetOnMetadataUpdatedHandlerHandler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway-core")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='setOnMetadataUpdatedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super java.lang.String, kotlin.Unit&gt;']]"
			[Register ("setOnMetadataUpdatedHandler", "(Lkotlin/jvm/functions/Function1;)V", "GetSetOnMetadataUpdatedHandler_Lkotlin_jvm_functions_Function1_Handler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway-core")]
			set; 
		}

		global::Kotlin.Jvm.Functions.IFunction1? OnSubscribedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='getOnSubscribedHandler' and count(parameter)=0]"
			[Register ("getOnSubscribedHandler", "()Lkotlin/jvm/functions/Function1;", "GetGetOnSubscribedHandlerHandler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway-core")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='setOnSubscribedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super com.ntt.skyway.core.channel.Subscription, kotlin.Unit&gt;']]"
			[Register ("setOnSubscribedHandler", "(Lkotlin/jvm/functions/Function1;)V", "GetSetOnSubscribedHandler_Lkotlin_jvm_functions_Function1_Handler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway-core")]
			set; 
		}

		global::Kotlin.Jvm.Functions.IFunction0? OnSubscriptionListChangedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='getOnSubscriptionListChangedHandler' and count(parameter)=0]"
			[Register ("getOnSubscriptionListChangedHandler", "()Lkotlin/jvm/functions/Function0;", "GetGetOnSubscriptionListChangedHandlerHandler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway-core")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='setOnSubscriptionListChangedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function0&lt;kotlin.Unit&gt;']]"
			[Register ("setOnSubscriptionListChangedHandler", "(Lkotlin/jvm/functions/Function0;)V", "GetSetOnSubscriptionListChangedHandler_Lkotlin_jvm_functions_Function0_Handler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway-core")]
			set; 
		}

		global::Kotlin.Jvm.Functions.IFunction0? OnUnpublishedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='getOnUnpublishedHandler' and count(parameter)=0]"
			[Register ("getOnUnpublishedHandler", "()Lkotlin/jvm/functions/Function0;", "GetGetOnUnpublishedHandlerHandler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway-core")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='setOnUnpublishedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function0&lt;kotlin.Unit&gt;']]"
			[Register ("setOnUnpublishedHandler", "(Lkotlin/jvm/functions/Function0;)V", "GetSetOnUnpublishedHandler_Lkotlin_jvm_functions_Function0_Handler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway-core")]
			set; 
		}

		global::Kotlin.Jvm.Functions.IFunction1? OnUnsubscribedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='getOnUnsubscribedHandler' and count(parameter)=0]"
			[Register ("getOnUnsubscribedHandler", "()Lkotlin/jvm/functions/Function1;", "GetGetOnUnsubscribedHandlerHandler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway-core")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='setOnUnsubscribedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super com.ntt.skyway.core.channel.Subscription, kotlin.Unit&gt;']]"
			[Register ("setOnUnsubscribedHandler", "(Lkotlin/jvm/functions/Function1;)V", "GetSetOnUnsubscribedHandler_Lkotlin_jvm_functions_Function1_Handler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway-core")]
			set; 
		}

		global::Com.Ntt.Skyway.Core.Channel.IPublication? Origin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='getOrigin' and count(parameter)=0]"
			[Register ("getOrigin", "()Lcom/ntt/skyway/core/channel/Publication;", "GetGetOriginHandler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway-core")]
			get; 
		}

		global::Com.Ntt.Skyway.Core.Channel.Member.IMember Publisher {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='getPublisher' and count(parameter)=0]"
			[Register ("getPublisher", "()Lcom/ntt/skyway/core/channel/member/Member;", "GetGetPublisherHandler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway-core")]
			get; 
		}

		global::Com.Ntt.Skyway.Core.Content.Stream? Stream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='getStream' and count(parameter)=0]"
			[Register ("getStream", "()Lcom/ntt/skyway/core/content/Stream;", "GetGetStreamHandler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway-core")]
			get; 
		}

		global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Channel.ISubscription> Subscriptions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='getSubscriptions' and count(parameter)=0]"
			[Register ("getSubscriptions", "()Ljava/util/List;", "GetGetSubscriptionsHandler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway-core")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='cancel' and count(parameter)=1 and parameter[1][@type='kotlin.coroutines.Continuation&lt;? super java.lang.Boolean&gt;']]"
		[Register ("cancel", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetCancel_Lkotlin_coroutines_Continuation_Handler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway-core")]
		global::Java.Lang.Object? Cancel (global::Kotlin.Coroutines.IContinuation p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='disable' and count(parameter)=1 and parameter[1][@type='kotlin.coroutines.Continuation&lt;? super java.lang.Boolean&gt;']]"
		[Register ("disable", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetDisable_Lkotlin_coroutines_Continuation_Handler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway-core")]
		global::Java.Lang.Object? Disable (global::Kotlin.Coroutines.IContinuation p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='enable' and count(parameter)=1 and parameter[1][@type='kotlin.coroutines.Continuation&lt;? super java.lang.Boolean&gt;']]"
		[Register ("enable", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetEnable_Lkotlin_coroutines_Continuation_Handler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway-core")]
		global::Java.Lang.Object? Enable (global::Kotlin.Coroutines.IContinuation p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='getState' and count(parameter)=0]"
		[Register ("getState", "()Lcom/ntt/skyway/core/channel/Publication$State;", "GetGetStateHandler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway-core")]
		global::Com.Ntt.Skyway.Core.Channel.IPublication.State GetState ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='getStats' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getStats", "(Ljava/lang/String;)Lcom/ntt/skyway/core/content/WebRTCStats;", "GetGetStats_Ljava_lang_String_Handler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway-core")]
		global::Com.Ntt.Skyway.Core.Content.WebRTCStats? GetStats (string remoteMemberId);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='replaceStream' and count(parameter)=1 and parameter[1][@type='com.ntt.skyway.core.content.local.LocalStream']]"
		[Register ("replaceStream", "(Lcom/ntt/skyway/core/content/local/LocalStream;)V", "GetReplaceStream_Lcom_ntt_skyway_core_content_local_LocalStream_Handler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway-core")]
		void ReplaceStream (global::Com.Ntt.Skyway.Core.Content.Local.LocalStream stream);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='updateEncodings' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.ntt.skyway.core.content.Encoding&gt;']]"
		[Register ("updateEncodings", "(Ljava/util/List;)V", "GetUpdateEncodings_Ljava_util_List_Handler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway-core")]
		void UpdateEncodings (global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Content.Encoding> encodings);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='updateMetadata' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='kotlin.coroutines.Continuation&lt;? super java.lang.Boolean&gt;']]"
		[Register ("updateMetadata", "(Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetUpdateMetadata_Ljava_lang_String_Lkotlin_coroutines_Continuation_Handler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway-core")]
		global::Java.Lang.Object? UpdateMetadata (string metadata, global::Kotlin.Coroutines.IContinuation p1);

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Publication.Options']"
		[global::Android.Runtime.Register ("com/ntt/skyway/core/channel/Publication$Options", DoNotGenerateAcw=true)]
		public sealed partial class Options : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/Publication$Options", typeof (Options));

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

			internal Options (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Publication.Options']/constructor[@name='Publication.Options' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Options () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Publication.Options']/constructor[@name='Publication.Options' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;com.ntt.skyway.core.content.Codec&gt;'] and parameter[3][@type='java.util.List&lt;com.ntt.skyway.core.content.Encoding&gt;'] and parameter[4][@type='java.lang.Boolean']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/util/List;Ljava/util/List;Ljava/lang/Boolean;)V", "")]
			public unsafe Options (string? metadata, global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Content.Codec>? codecCapabilities, global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Content.Encoding>? encodings, global::Java.Lang.Boolean? isEnabled) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Ljava/util/List;Ljava/util/List;Ljava/lang/Boolean;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_metadata = JNIEnv.NewString ((string?)metadata);
				IntPtr native_codecCapabilities = global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Content.Codec>.ToLocalJniHandle (codecCapabilities);
				IntPtr native_encodings = global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Content.Encoding>.ToLocalJniHandle (encodings);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (native_metadata);
					__args [1] = new JniArgumentValue (native_codecCapabilities);
					__args [2] = new JniArgumentValue (native_encodings);
					__args [3] = new JniArgumentValue ((isEnabled == null) ? IntPtr.Zero : ((global::Java.Lang.Object) isEnabled).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_metadata);
					JNIEnv.DeleteLocalRef (native_codecCapabilities);
					JNIEnv.DeleteLocalRef (native_encodings);
					global::System.GC.KeepAlive (codecCapabilities);
					global::System.GC.KeepAlive (encodings);
					global::System.GC.KeepAlive (isEnabled);
				}
			}

			public unsafe global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Content.Codec>? CodecCapabilities {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Publication.Options']/method[@name='getCodecCapabilities' and count(parameter)=0]"
				[Register ("getCodecCapabilities", "()Ljava/util/List;", "")]
				get {
					const string __id = "getCodecCapabilities.()Ljava/util/List;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Content.Codec>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Content.Encoding>? Encodings {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Publication.Options']/method[@name='getEncodings' and count(parameter)=0]"
				[Register ("getEncodings", "()Ljava/util/List;", "")]
				get {
					const string __id = "getEncodings.()Ljava/util/List;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Content.Encoding>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe string? Metadata {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Publication.Options']/method[@name='getMetadata' and count(parameter)=0]"
				[Register ("getMetadata", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getMetadata.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Publication.Options']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()Ljava/lang/String;", "")]
			public unsafe string? Component1 ()
			{
				const string __id = "component1.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Publication.Options']/method[@name='component2' and count(parameter)=0]"
			[Register ("component2", "()Ljava/util/List;", "")]
			public unsafe global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Content.Codec>? Component2 ()
			{
				const string __id = "component2.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Content.Codec>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Publication.Options']/method[@name='component3' and count(parameter)=0]"
			[Register ("component3", "()Ljava/util/List;", "")]
			public unsafe global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Content.Encoding>? Component3 ()
			{
				const string __id = "component3.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Content.Encoding>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Publication.Options']/method[@name='component4' and count(parameter)=0]"
			[Register ("component4", "()Ljava/lang/Boolean;", "")]
			public unsafe global::Java.Lang.Boolean? Component4 ()
			{
				const string __id = "component4.()Ljava/lang/Boolean;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Publication.Options']/method[@name='copy' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;com.ntt.skyway.core.content.Codec&gt;'] and parameter[3][@type='java.util.List&lt;com.ntt.skyway.core.content.Encoding&gt;'] and parameter[4][@type='java.lang.Boolean']]"
			[Register ("copy", "(Ljava/lang/String;Ljava/util/List;Ljava/util/List;Ljava/lang/Boolean;)Lcom/ntt/skyway/core/channel/Publication$Options;", "")]
			public unsafe global::Com.Ntt.Skyway.Core.Channel.IPublication.Options Copy (string? metadata, global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Content.Codec>? codecCapabilities, global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Content.Encoding>? encodings, global::Java.Lang.Boolean? isEnabled)
			{
				const string __id = "copy.(Ljava/lang/String;Ljava/util/List;Ljava/util/List;Ljava/lang/Boolean;)Lcom/ntt/skyway/core/channel/Publication$Options;";
				IntPtr native_metadata = JNIEnv.NewString ((string?)metadata);
				IntPtr native_codecCapabilities = global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Content.Codec>.ToLocalJniHandle (codecCapabilities);
				IntPtr native_encodings = global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Content.Encoding>.ToLocalJniHandle (encodings);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (native_metadata);
					__args [1] = new JniArgumentValue (native_codecCapabilities);
					__args [2] = new JniArgumentValue (native_encodings);
					__args [3] = new JniArgumentValue ((isEnabled == null) ? IntPtr.Zero : ((global::Java.Lang.Object) isEnabled).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication.Options> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
					JNIEnv.DeleteLocalRef (native_metadata);
					JNIEnv.DeleteLocalRef (native_codecCapabilities);
					JNIEnv.DeleteLocalRef (native_encodings);
					global::System.GC.KeepAlive (codecCapabilities);
					global::System.GC.KeepAlive (encodings);
					global::System.GC.KeepAlive (isEnabled);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Publication.Options']/method[@name='isEnabled' and count(parameter)=0]"
			[Register ("isEnabled", "()Ljava/lang/Boolean;", "")]
			public unsafe global::Java.Lang.Boolean? IsEnabled ()
			{
				const string __id = "isEnabled.()Ljava/lang/Boolean;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Publication.State']"
		[global::Android.Runtime.Register ("com/ntt/skyway/core/channel/Publication$State", DoNotGenerateAcw=true)]
		public sealed partial class State : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Publication.State']/field[@name='CANCELED']"
			[Register ("CANCELED")]
			public static global::Com.Ntt.Skyway.Core.Channel.IPublication.State? Canceled {
				get {
					const string __id = "CANCELED.Lcom/ntt/skyway/core/channel/Publication$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Publication.State']/field[@name='DISABLED']"
			[Register ("DISABLED")]
			public static global::Com.Ntt.Skyway.Core.Channel.IPublication.State? Disabled {
				get {
					const string __id = "DISABLED.Lcom/ntt/skyway/core/channel/Publication$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Publication.State']/field[@name='ENABLED']"
			[Register ("ENABLED")]
			public static global::Com.Ntt.Skyway.Core.Channel.IPublication.State? Enabled {
				get {
					const string __id = "ENABLED.Lcom/ntt/skyway/core/channel/Publication$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Publication.State.Companion']"
			[global::Android.Runtime.Register ("com/ntt/skyway/core/channel/Publication$State$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/Publication$State$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Publication.State.Companion']/constructor[@name='Publication.State.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/Publication$State", typeof (State));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Publication.State']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/ntt/skyway/core/channel/Publication$State;", "")]
			public static unsafe global::Com.Ntt.Skyway.Core.Channel.IPublication.State? ValueOf (string? value)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/ntt/skyway/core/channel/Publication$State;";
				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication.State> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Publication.State']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/ntt/skyway/core/channel/Publication$State;", "")]
			public static unsafe global::Com.Ntt.Skyway.Core.Channel.IPublication.State[]? Values ()
			{
				const string __id = "values.()[Lcom/ntt/skyway/core/channel/Publication$State;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Ntt.Skyway.Core.Channel.IPublication.State[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Ntt.Skyway.Core.Channel.IPublication.State));
				} finally {
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/ntt/skyway/core/channel/Publication", DoNotGenerateAcw=true)]
	internal partial class IPublicationInvoker : global::Java.Lang.Object, IPublication {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/Publication", typeof (IPublicationInvoker));

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

		public static IPublication? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPublication> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ntt.skyway.core.channel.Publication'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPublicationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Channel);
		}
#pragma warning restore 0169

		IntPtr id_getChannel;
		public unsafe global::Com.Ntt.Skyway.Core.Channel.IChannel Channel {
			get {
				if (id_getChannel == IntPtr.Zero)
					id_getChannel = JNIEnv.GetMethodID (class_ref, "getChannel", "()Lcom/ntt/skyway/core/channel/Channel;");
				return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannel), JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static Delegate? cb_getCodecCapabilities;
#pragma warning disable 0169
		static Delegate GetGetCodecCapabilitiesHandler ()
		{
			if (cb_getCodecCapabilities == null)
				cb_getCodecCapabilities = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCodecCapabilities);
			return cb_getCodecCapabilities;
		}

		static IntPtr n_GetCodecCapabilities (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Content.Codec>.ToLocalJniHandle (__this.CodecCapabilities);
		}
#pragma warning restore 0169

		IntPtr id_getCodecCapabilities;
		public unsafe global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Content.Codec> CodecCapabilities {
			get {
				if (id_getCodecCapabilities == IntPtr.Zero)
					id_getCodecCapabilities = JNIEnv.GetMethodID (class_ref, "getCodecCapabilities", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Content.Codec>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCodecCapabilities), JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static Delegate? cb_getContentType;
#pragma warning disable 0169
		static Delegate GetGetContentTypeHandler ()
		{
			if (cb_getContentType == null)
				cb_getContentType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetContentType);
			return cb_getContentType;
		}

		static IntPtr n_GetContentType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.ContentType);
		}
#pragma warning restore 0169

		IntPtr id_getContentType;
		public unsafe global::Com.Ntt.Skyway.Core.Content.Stream.ContentType ContentType {
			get {
				if (id_getContentType == IntPtr.Zero)
					id_getContentType = JNIEnv.GetMethodID (class_ref, "getContentType", "()Lcom/ntt/skyway/core/content/Stream$ContentType;");
				return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Stream.ContentType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContentType), JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static Delegate? cb_getEncodings;
#pragma warning disable 0169
		static Delegate GetGetEncodingsHandler ()
		{
			if (cb_getEncodings == null)
				cb_getEncodings = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetEncodings);
			return cb_getEncodings;
		}

		static IntPtr n_GetEncodings (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Content.Encoding>.ToLocalJniHandle (__this.Encodings);
		}
#pragma warning restore 0169

		IntPtr id_getEncodings;
		public unsafe global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Content.Encoding> Encodings {
			get {
				if (id_getEncodings == IntPtr.Zero)
					id_getEncodings = JNIEnv.GetMethodID (class_ref, "getEncodings", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Content.Encoding>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEncodings), JniHandleOwnership.TransferLocalRef)!;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.NativePointer;
		}
#pragma warning restore 0169

		IntPtr id_getNativePointer;
		public unsafe long NativePointer {
			get {
				if (id_getNativePointer == IntPtr.Zero)
					id_getNativePointer = JNIEnv.GetMethodID (class_ref, "getNativePointer", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getNativePointer);
			}
		}

		static Delegate? cb_getOnConnectionStateChangedHandler;
#pragma warning disable 0169
		static Delegate GetGetOnConnectionStateChangedHandlerHandler ()
		{
			if (cb_getOnConnectionStateChangedHandler == null)
				cb_getOnConnectionStateChangedHandler = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOnConnectionStateChangedHandler);
			return cb_getOnConnectionStateChangedHandler;
		}

		static IntPtr n_GetOnConnectionStateChangedHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.OnConnectionStateChangedHandler);
		}
#pragma warning restore 0169

		static Delegate? cb_setOnConnectionStateChangedHandler_Lkotlin_jvm_functions_Function1_;
#pragma warning disable 0169
		static Delegate GetSetOnConnectionStateChangedHandler_Lkotlin_jvm_functions_Function1_Handler ()
		{
			if (cb_setOnConnectionStateChangedHandler_Lkotlin_jvm_functions_Function1_ == null)
				cb_setOnConnectionStateChangedHandler_Lkotlin_jvm_functions_Function1_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnConnectionStateChangedHandler_Lkotlin_jvm_functions_Function1_);
			return cb_setOnConnectionStateChangedHandler_Lkotlin_jvm_functions_Function1_;
		}

		static void n_SetOnConnectionStateChangedHandler_Lkotlin_jvm_functions_Function1_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var value = (global::Kotlin.Jvm.Functions.IFunction1?)global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionStateChangedHandler = value;
		}
#pragma warning restore 0169

		IntPtr id_getOnConnectionStateChangedHandler;
		IntPtr id_setOnConnectionStateChangedHandler_Lkotlin_jvm_functions_Function1_;
		public unsafe global::Kotlin.Jvm.Functions.IFunction1? OnConnectionStateChangedHandler {
			get {
				if (id_getOnConnectionStateChangedHandler == IntPtr.Zero)
					id_getOnConnectionStateChangedHandler = JNIEnv.GetMethodID (class_ref, "getOnConnectionStateChangedHandler", "()Lkotlin/jvm/functions/Function1;");
				return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnConnectionStateChangedHandler), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setOnConnectionStateChangedHandler_Lkotlin_jvm_functions_Function1_ == IntPtr.Zero)
					id_setOnConnectionStateChangedHandler_Lkotlin_jvm_functions_Function1_ = JNIEnv.GetMethodID (class_ref, "setOnConnectionStateChangedHandler", "(Lkotlin/jvm/functions/Function1;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnConnectionStateChangedHandler_Lkotlin_jvm_functions_Function1_, __args);
			}
		}

		static Delegate? cb_getOnDisabledHandler;
#pragma warning disable 0169
		static Delegate GetGetOnDisabledHandlerHandler ()
		{
			if (cb_getOnDisabledHandler == null)
				cb_getOnDisabledHandler = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOnDisabledHandler);
			return cb_getOnDisabledHandler;
		}

		static IntPtr n_GetOnDisabledHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.OnDisabledHandler);
		}
#pragma warning restore 0169

		static Delegate? cb_setOnDisabledHandler_Lkotlin_jvm_functions_Function0_;
#pragma warning disable 0169
		static Delegate GetSetOnDisabledHandler_Lkotlin_jvm_functions_Function0_Handler ()
		{
			if (cb_setOnDisabledHandler_Lkotlin_jvm_functions_Function0_ == null)
				cb_setOnDisabledHandler_Lkotlin_jvm_functions_Function0_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnDisabledHandler_Lkotlin_jvm_functions_Function0_);
			return cb_setOnDisabledHandler_Lkotlin_jvm_functions_Function0_;
		}

		static void n_SetOnDisabledHandler_Lkotlin_jvm_functions_Function0_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var value = (global::Kotlin.Jvm.Functions.IFunction0?)global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction0> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.OnDisabledHandler = value;
		}
#pragma warning restore 0169

		IntPtr id_getOnDisabledHandler;
		IntPtr id_setOnDisabledHandler_Lkotlin_jvm_functions_Function0_;
		public unsafe global::Kotlin.Jvm.Functions.IFunction0? OnDisabledHandler {
			get {
				if (id_getOnDisabledHandler == IntPtr.Zero)
					id_getOnDisabledHandler = JNIEnv.GetMethodID (class_ref, "getOnDisabledHandler", "()Lkotlin/jvm/functions/Function0;");
				return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction0> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnDisabledHandler), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setOnDisabledHandler_Lkotlin_jvm_functions_Function0_ == IntPtr.Zero)
					id_setOnDisabledHandler_Lkotlin_jvm_functions_Function0_ = JNIEnv.GetMethodID (class_ref, "setOnDisabledHandler", "(Lkotlin/jvm/functions/Function0;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnDisabledHandler_Lkotlin_jvm_functions_Function0_, __args);
			}
		}

		static Delegate? cb_getOnEnabledHandler;
#pragma warning disable 0169
		static Delegate GetGetOnEnabledHandlerHandler ()
		{
			if (cb_getOnEnabledHandler == null)
				cb_getOnEnabledHandler = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOnEnabledHandler);
			return cb_getOnEnabledHandler;
		}

		static IntPtr n_GetOnEnabledHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.OnEnabledHandler);
		}
#pragma warning restore 0169

		static Delegate? cb_setOnEnabledHandler_Lkotlin_jvm_functions_Function0_;
#pragma warning disable 0169
		static Delegate GetSetOnEnabledHandler_Lkotlin_jvm_functions_Function0_Handler ()
		{
			if (cb_setOnEnabledHandler_Lkotlin_jvm_functions_Function0_ == null)
				cb_setOnEnabledHandler_Lkotlin_jvm_functions_Function0_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnEnabledHandler_Lkotlin_jvm_functions_Function0_);
			return cb_setOnEnabledHandler_Lkotlin_jvm_functions_Function0_;
		}

		static void n_SetOnEnabledHandler_Lkotlin_jvm_functions_Function0_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var value = (global::Kotlin.Jvm.Functions.IFunction0?)global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction0> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.OnEnabledHandler = value;
		}
#pragma warning restore 0169

		IntPtr id_getOnEnabledHandler;
		IntPtr id_setOnEnabledHandler_Lkotlin_jvm_functions_Function0_;
		public unsafe global::Kotlin.Jvm.Functions.IFunction0? OnEnabledHandler {
			get {
				if (id_getOnEnabledHandler == IntPtr.Zero)
					id_getOnEnabledHandler = JNIEnv.GetMethodID (class_ref, "getOnEnabledHandler", "()Lkotlin/jvm/functions/Function0;");
				return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction0> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnEnabledHandler), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setOnEnabledHandler_Lkotlin_jvm_functions_Function0_ == IntPtr.Zero)
					id_setOnEnabledHandler_Lkotlin_jvm_functions_Function0_ = JNIEnv.GetMethodID (class_ref, "setOnEnabledHandler", "(Lkotlin/jvm/functions/Function0;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnEnabledHandler_Lkotlin_jvm_functions_Function0_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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

		static Delegate? cb_getOnSubscribedHandler;
#pragma warning disable 0169
		static Delegate GetGetOnSubscribedHandlerHandler ()
		{
			if (cb_getOnSubscribedHandler == null)
				cb_getOnSubscribedHandler = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOnSubscribedHandler);
			return cb_getOnSubscribedHandler;
		}

		static IntPtr n_GetOnSubscribedHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.OnSubscribedHandler);
		}
#pragma warning restore 0169

		static Delegate? cb_setOnSubscribedHandler_Lkotlin_jvm_functions_Function1_;
#pragma warning disable 0169
		static Delegate GetSetOnSubscribedHandler_Lkotlin_jvm_functions_Function1_Handler ()
		{
			if (cb_setOnSubscribedHandler_Lkotlin_jvm_functions_Function1_ == null)
				cb_setOnSubscribedHandler_Lkotlin_jvm_functions_Function1_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnSubscribedHandler_Lkotlin_jvm_functions_Function1_);
			return cb_setOnSubscribedHandler_Lkotlin_jvm_functions_Function1_;
		}

		static void n_SetOnSubscribedHandler_Lkotlin_jvm_functions_Function1_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var value = (global::Kotlin.Jvm.Functions.IFunction1?)global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.OnSubscribedHandler = value;
		}
#pragma warning restore 0169

		IntPtr id_getOnSubscribedHandler;
		IntPtr id_setOnSubscribedHandler_Lkotlin_jvm_functions_Function1_;
		public unsafe global::Kotlin.Jvm.Functions.IFunction1? OnSubscribedHandler {
			get {
				if (id_getOnSubscribedHandler == IntPtr.Zero)
					id_getOnSubscribedHandler = JNIEnv.GetMethodID (class_ref, "getOnSubscribedHandler", "()Lkotlin/jvm/functions/Function1;");
				return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnSubscribedHandler), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setOnSubscribedHandler_Lkotlin_jvm_functions_Function1_ == IntPtr.Zero)
					id_setOnSubscribedHandler_Lkotlin_jvm_functions_Function1_ = JNIEnv.GetMethodID (class_ref, "setOnSubscribedHandler", "(Lkotlin/jvm/functions/Function1;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnSubscribedHandler_Lkotlin_jvm_functions_Function1_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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

		static Delegate? cb_getOnUnpublishedHandler;
#pragma warning disable 0169
		static Delegate GetGetOnUnpublishedHandlerHandler ()
		{
			if (cb_getOnUnpublishedHandler == null)
				cb_getOnUnpublishedHandler = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOnUnpublishedHandler);
			return cb_getOnUnpublishedHandler;
		}

		static IntPtr n_GetOnUnpublishedHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.OnUnpublishedHandler);
		}
#pragma warning restore 0169

		static Delegate? cb_setOnUnpublishedHandler_Lkotlin_jvm_functions_Function0_;
#pragma warning disable 0169
		static Delegate GetSetOnUnpublishedHandler_Lkotlin_jvm_functions_Function0_Handler ()
		{
			if (cb_setOnUnpublishedHandler_Lkotlin_jvm_functions_Function0_ == null)
				cb_setOnUnpublishedHandler_Lkotlin_jvm_functions_Function0_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnUnpublishedHandler_Lkotlin_jvm_functions_Function0_);
			return cb_setOnUnpublishedHandler_Lkotlin_jvm_functions_Function0_;
		}

		static void n_SetOnUnpublishedHandler_Lkotlin_jvm_functions_Function0_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var value = (global::Kotlin.Jvm.Functions.IFunction0?)global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction0> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.OnUnpublishedHandler = value;
		}
#pragma warning restore 0169

		IntPtr id_getOnUnpublishedHandler;
		IntPtr id_setOnUnpublishedHandler_Lkotlin_jvm_functions_Function0_;
		public unsafe global::Kotlin.Jvm.Functions.IFunction0? OnUnpublishedHandler {
			get {
				if (id_getOnUnpublishedHandler == IntPtr.Zero)
					id_getOnUnpublishedHandler = JNIEnv.GetMethodID (class_ref, "getOnUnpublishedHandler", "()Lkotlin/jvm/functions/Function0;");
				return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction0> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnUnpublishedHandler), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setOnUnpublishedHandler_Lkotlin_jvm_functions_Function0_ == IntPtr.Zero)
					id_setOnUnpublishedHandler_Lkotlin_jvm_functions_Function0_ = JNIEnv.GetMethodID (class_ref, "setOnUnpublishedHandler", "(Lkotlin/jvm/functions/Function0;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnUnpublishedHandler_Lkotlin_jvm_functions_Function0_, __args);
			}
		}

		static Delegate? cb_getOnUnsubscribedHandler;
#pragma warning disable 0169
		static Delegate GetGetOnUnsubscribedHandlerHandler ()
		{
			if (cb_getOnUnsubscribedHandler == null)
				cb_getOnUnsubscribedHandler = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOnUnsubscribedHandler);
			return cb_getOnUnsubscribedHandler;
		}

		static IntPtr n_GetOnUnsubscribedHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.OnUnsubscribedHandler);
		}
#pragma warning restore 0169

		static Delegate? cb_setOnUnsubscribedHandler_Lkotlin_jvm_functions_Function1_;
#pragma warning disable 0169
		static Delegate GetSetOnUnsubscribedHandler_Lkotlin_jvm_functions_Function1_Handler ()
		{
			if (cb_setOnUnsubscribedHandler_Lkotlin_jvm_functions_Function1_ == null)
				cb_setOnUnsubscribedHandler_Lkotlin_jvm_functions_Function1_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnUnsubscribedHandler_Lkotlin_jvm_functions_Function1_);
			return cb_setOnUnsubscribedHandler_Lkotlin_jvm_functions_Function1_;
		}

		static void n_SetOnUnsubscribedHandler_Lkotlin_jvm_functions_Function1_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var value = (global::Kotlin.Jvm.Functions.IFunction1?)global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.OnUnsubscribedHandler = value;
		}
#pragma warning restore 0169

		IntPtr id_getOnUnsubscribedHandler;
		IntPtr id_setOnUnsubscribedHandler_Lkotlin_jvm_functions_Function1_;
		public unsafe global::Kotlin.Jvm.Functions.IFunction1? OnUnsubscribedHandler {
			get {
				if (id_getOnUnsubscribedHandler == IntPtr.Zero)
					id_getOnUnsubscribedHandler = JNIEnv.GetMethodID (class_ref, "getOnUnsubscribedHandler", "()Lkotlin/jvm/functions/Function1;");
				return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnUnsubscribedHandler), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setOnUnsubscribedHandler_Lkotlin_jvm_functions_Function1_ == IntPtr.Zero)
					id_setOnUnsubscribedHandler_Lkotlin_jvm_functions_Function1_ = JNIEnv.GetMethodID (class_ref, "setOnUnsubscribedHandler", "(Lkotlin/jvm/functions/Function1;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnUnsubscribedHandler_Lkotlin_jvm_functions_Function1_, __args);
			}
		}

		static Delegate? cb_getOrigin;
#pragma warning disable 0169
		static Delegate GetGetOriginHandler ()
		{
			if (cb_getOrigin == null)
				cb_getOrigin = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOrigin);
			return cb_getOrigin;
		}

		static IntPtr n_GetOrigin (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Origin);
		}
#pragma warning restore 0169

		IntPtr id_getOrigin;
		public unsafe global::Com.Ntt.Skyway.Core.Channel.IPublication? Origin {
			get {
				if (id_getOrigin == IntPtr.Zero)
					id_getOrigin = JNIEnv.GetMethodID (class_ref, "getOrigin", "()Lcom/ntt/skyway/core/channel/Publication;");
				return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOrigin), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getPublisher;
#pragma warning disable 0169
		static Delegate GetGetPublisherHandler ()
		{
			if (cb_getPublisher == null)
				cb_getPublisher = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPublisher);
			return cb_getPublisher;
		}

		static IntPtr n_GetPublisher (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Publisher);
		}
#pragma warning restore 0169

		IntPtr id_getPublisher;
		public unsafe global::Com.Ntt.Skyway.Core.Channel.Member.IMember Publisher {
			get {
				if (id_getPublisher == IntPtr.Zero)
					id_getPublisher = JNIEnv.GetMethodID (class_ref, "getPublisher", "()Lcom/ntt/skyway/core/channel/member/Member;");
				return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPublisher), JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static Delegate? cb_getStream;
#pragma warning disable 0169
		static Delegate GetGetStreamHandler ()
		{
			if (cb_getStream == null)
				cb_getStream = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetStream);
			return cb_getStream;
		}

		static IntPtr n_GetStream (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Stream);
		}
#pragma warning restore 0169

		IntPtr id_getStream;
		public unsafe global::Com.Ntt.Skyway.Core.Content.Stream? Stream {
			get {
				if (id_getStream == IntPtr.Zero)
					id_getStream = JNIEnv.GetMethodID (class_ref, "getStream", "()Lcom/ntt/skyway/core/content/Stream;");
				return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Stream> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStream), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Channel.ISubscription>.ToLocalJniHandle (__this.Subscriptions);
		}
#pragma warning restore 0169

		IntPtr id_getSubscriptions;
		public unsafe global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Channel.ISubscription> Subscriptions {
			get {
				if (id_getSubscriptions == IntPtr.Zero)
					id_getSubscriptions = JNIEnv.GetMethodID (class_ref, "getSubscriptions", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Channel.ISubscription>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSubscriptions), JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static Delegate? cb_cancel_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetCancel_Lkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_cancel_Lkotlin_coroutines_Continuation_ == null)
				cb_cancel_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Cancel_Lkotlin_coroutines_Continuation_);
			return cb_cancel_Lkotlin_coroutines_Continuation_;
		}

		static IntPtr n_Cancel_Lkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Kotlin.Coroutines.IContinuation?)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Cancel (p0!));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_cancel_Lkotlin_coroutines_Continuation_;
		public unsafe global::Java.Lang.Object? Cancel (global::Kotlin.Coroutines.IContinuation p0)
		{
			if (id_cancel_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
				id_cancel_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID (class_ref, "cancel", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_cancel_Lkotlin_coroutines_Continuation_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate? cb_disable_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetDisable_Lkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_disable_Lkotlin_coroutines_Continuation_ == null)
				cb_disable_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Disable_Lkotlin_coroutines_Continuation_);
			return cb_disable_Lkotlin_coroutines_Continuation_;
		}

		static IntPtr n_Disable_Lkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Kotlin.Coroutines.IContinuation?)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Disable (p0!));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_disable_Lkotlin_coroutines_Continuation_;
		public unsafe global::Java.Lang.Object? Disable (global::Kotlin.Coroutines.IContinuation p0)
		{
			if (id_disable_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
				id_disable_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID (class_ref, "disable", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_disable_Lkotlin_coroutines_Continuation_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate? cb_enable_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetEnable_Lkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_enable_Lkotlin_coroutines_Continuation_ == null)
				cb_enable_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Enable_Lkotlin_coroutines_Continuation_);
			return cb_enable_Lkotlin_coroutines_Continuation_;
		}

		static IntPtr n_Enable_Lkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Kotlin.Coroutines.IContinuation?)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Enable (p0!));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_enable_Lkotlin_coroutines_Continuation_;
		public unsafe global::Java.Lang.Object? Enable (global::Kotlin.Coroutines.IContinuation p0)
		{
			if (id_enable_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
				id_enable_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID (class_ref, "enable", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_enable_Lkotlin_coroutines_Continuation_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.GetState ());
		}
#pragma warning restore 0169

		IntPtr id_getState;
		public unsafe global::Com.Ntt.Skyway.Core.Channel.IPublication.State GetState ()
		{
			if (id_getState == IntPtr.Zero)
				id_getState = JNIEnv.GetMethodID (class_ref, "getState", "()Lcom/ntt/skyway/core/channel/Publication$State;");
			return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication.State> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getState), JniHandleOwnership.TransferLocalRef)!;
		}

		static Delegate? cb_getStats_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetStats_Ljava_lang_String_Handler ()
		{
			if (cb_getStats_Ljava_lang_String_ == null)
				cb_getStats_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetStats_Ljava_lang_String_);
			return cb_getStats_Ljava_lang_String_;
		}

		static IntPtr n_GetStats_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_remoteMemberId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var remoteMemberId = JNIEnv.GetString (native_remoteMemberId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetStats (remoteMemberId!));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getStats_Ljava_lang_String_;
		public unsafe global::Com.Ntt.Skyway.Core.Content.WebRTCStats? GetStats (string remoteMemberId)
		{
			if (id_getStats_Ljava_lang_String_ == IntPtr.Zero)
				id_getStats_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getStats", "(Ljava/lang/String;)Lcom/ntt/skyway/core/content/WebRTCStats;");
			IntPtr native_remoteMemberId = JNIEnv.NewString ((string?)remoteMemberId);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_remoteMemberId);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.WebRTCStats> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStats_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_remoteMemberId);
			return __ret;
		}

		static Delegate? cb_replaceStream_Lcom_ntt_skyway_core_content_local_LocalStream_;
#pragma warning disable 0169
		static Delegate GetReplaceStream_Lcom_ntt_skyway_core_content_local_LocalStream_Handler ()
		{
			if (cb_replaceStream_Lcom_ntt_skyway_core_content_local_LocalStream_ == null)
				cb_replaceStream_Lcom_ntt_skyway_core_content_local_LocalStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ReplaceStream_Lcom_ntt_skyway_core_content_local_LocalStream_);
			return cb_replaceStream_Lcom_ntt_skyway_core_content_local_LocalStream_;
		}

		static void n_ReplaceStream_Lcom_ntt_skyway_core_content_local_LocalStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_stream)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var stream = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Local.LocalStream> (native_stream, JniHandleOwnership.DoNotTransfer);
			__this.ReplaceStream (stream!);
		}
#pragma warning restore 0169

		IntPtr id_replaceStream_Lcom_ntt_skyway_core_content_local_LocalStream_;
		public unsafe void ReplaceStream (global::Com.Ntt.Skyway.Core.Content.Local.LocalStream stream)
		{
			if (id_replaceStream_Lcom_ntt_skyway_core_content_local_LocalStream_ == IntPtr.Zero)
				id_replaceStream_Lcom_ntt_skyway_core_content_local_LocalStream_ = JNIEnv.GetMethodID (class_ref, "replaceStream", "(Lcom/ntt/skyway/core/content/local/LocalStream;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((stream == null) ? IntPtr.Zero : ((global::Java.Lang.Object) stream).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_replaceStream_Lcom_ntt_skyway_core_content_local_LocalStream_, __args);
		}

		static Delegate? cb_updateEncodings_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetUpdateEncodings_Ljava_util_List_Handler ()
		{
			if (cb_updateEncodings_Ljava_util_List_ == null)
				cb_updateEncodings_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_UpdateEncodings_Ljava_util_List_);
			return cb_updateEncodings_Ljava_util_List_;
		}

		static void n_UpdateEncodings_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_encodings)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var encodings = global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Content.Encoding>.FromJniHandle (native_encodings, JniHandleOwnership.DoNotTransfer);
			__this.UpdateEncodings (encodings!);
		}
#pragma warning restore 0169

		IntPtr id_updateEncodings_Ljava_util_List_;
		public unsafe void UpdateEncodings (global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Content.Encoding> encodings)
		{
			if (id_updateEncodings_Ljava_util_List_ == IntPtr.Zero)
				id_updateEncodings_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "updateEncodings", "(Ljava/util/List;)V");
			IntPtr native_encodings = global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Content.Encoding>.ToLocalJniHandle (encodings);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_encodings);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateEncodings_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_encodings);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
