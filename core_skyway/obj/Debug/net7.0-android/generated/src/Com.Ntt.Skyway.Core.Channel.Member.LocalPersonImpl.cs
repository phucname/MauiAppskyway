using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Core.Channel.Member {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']"
	[global::Android.Runtime.Register ("com/ntt/skyway/core/channel/member/LocalPersonImpl", DoNotGenerateAcw=true)]
	public sealed partial class LocalPersonImpl : global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/field[@name='PUBLISH_TIMEOUT_SEC']"
		[Register ("PUBLISH_TIMEOUT_SEC")]
		[global::System.Obsolete (@"deprecated")]
		public const long PublishTimeoutSec = (long) 10000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/field[@name='SUBSCRIBE_TIMEOUT_SEC']"
		[Register ("SUBSCRIBE_TIMEOUT_SEC")]
		[global::System.Obsolete (@"deprecated")]
		public const long SubscribeTimeoutSec = (long) 10000;

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/member/LocalPersonImpl", typeof (LocalPersonImpl));

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

		internal LocalPersonImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/constructor[@name='LocalPersonImpl' and count(parameter)=2 and parameter[1][@type='com.ntt.skyway.core.channel.member.Member.Dto'] and parameter[2][@type='com.ntt.skyway.core.channel.Repository']]"
		[Register (".ctor", "(Lcom/ntt/skyway/core/channel/member/Member$Dto;Lcom/ntt/skyway/core/channel/Repository;)V", "")]
		public unsafe LocalPersonImpl (global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Dto dto, global::Com.Ntt.Skyway.Core.Channel.Repository repository) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/ntt/skyway/core/channel/member/Member$Dto;Lcom/ntt/skyway/core/channel/Repository;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((dto == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dto).Handle);
				__args [1] = new JniArgumentValue ((repository == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repository).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (dto);
				global::System.GC.KeepAlive (repository);
			}
		}

		public override unsafe global::Com.Ntt.Skyway.Core.Channel.IChannel Channel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/method[@name='getChannel' and count(parameter)=0]"
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

		public override unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/method[@name='getId' and count(parameter)=0]"
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

		public override unsafe string Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/method[@name='getMetadata' and count(parameter)=0]"
			[Register ("getMetadata", "()Ljava/lang/String;", "")]
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "")]
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/method[@name='getNativePointer' and count(parameter)=0]"
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

		public override unsafe global::Kotlin.Jvm.Functions.IFunction0? OnLeftHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/method[@name='getOnLeftHandler' and count(parameter)=0]"
			[Register ("getOnLeftHandler", "()Lkotlin/jvm/functions/Function0;", "")]
			get {
				const string __id = "getOnLeftHandler.()Lkotlin/jvm/functions/Function0;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction0> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/method[@name='setOnLeftHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function0&lt;kotlin.Unit&gt;']]"
			[Register ("setOnLeftHandler", "(Lkotlin/jvm/functions/Function0;)V", "")]
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/method[@name='getOnMetadataUpdatedHandler' and count(parameter)=0]"
			[Register ("getOnMetadataUpdatedHandler", "()Lkotlin/jvm/functions/Function1;", "")]
			get {
				const string __id = "getOnMetadataUpdatedHandler.()Lkotlin/jvm/functions/Function1;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/method[@name='setOnMetadataUpdatedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super java.lang.String, kotlin.Unit&gt;']]"
			[Register ("setOnMetadataUpdatedHandler", "(Lkotlin/jvm/functions/Function1;)V", "")]
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/method[@name='getOnPublicationListChangedHandler' and count(parameter)=0]"
			[Register ("getOnPublicationListChangedHandler", "()Lkotlin/jvm/functions/Function0;", "")]
			get {
				const string __id = "getOnPublicationListChangedHandler.()Lkotlin/jvm/functions/Function0;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction0> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/method[@name='setOnPublicationListChangedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function0&lt;kotlin.Unit&gt;']]"
			[Register ("setOnPublicationListChangedHandler", "(Lkotlin/jvm/functions/Function0;)V", "")]
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

		public override unsafe global::Kotlin.Jvm.Functions.IFunction1? OnPublicationSubscribedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/method[@name='getOnPublicationSubscribedHandler' and count(parameter)=0]"
			[Register ("getOnPublicationSubscribedHandler", "()Lkotlin/jvm/functions/Function1;", "")]
			get {
				const string __id = "getOnPublicationSubscribedHandler.()Lkotlin/jvm/functions/Function1;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/method[@name='setOnPublicationSubscribedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super com.ntt.skyway.core.channel.Subscription, kotlin.Unit&gt;']]"
			[Register ("setOnPublicationSubscribedHandler", "(Lkotlin/jvm/functions/Function1;)V", "")]
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/method[@name='getOnPublicationUnsubscribedHandler' and count(parameter)=0]"
			[Register ("getOnPublicationUnsubscribedHandler", "()Lkotlin/jvm/functions/Function1;", "")]
			get {
				const string __id = "getOnPublicationUnsubscribedHandler.()Lkotlin/jvm/functions/Function1;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/method[@name='setOnPublicationUnsubscribedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super com.ntt.skyway.core.channel.Subscription, kotlin.Unit&gt;']]"
			[Register ("setOnPublicationUnsubscribedHandler", "(Lkotlin/jvm/functions/Function1;)V", "")]
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/method[@name='getOnStreamPublishedHandler' and count(parameter)=0]"
			[Register ("getOnStreamPublishedHandler", "()Lkotlin/jvm/functions/Function1;", "")]
			get {
				const string __id = "getOnStreamPublishedHandler.()Lkotlin/jvm/functions/Function1;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/method[@name='setOnStreamPublishedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super com.ntt.skyway.core.channel.Publication, kotlin.Unit&gt;']]"
			[Register ("setOnStreamPublishedHandler", "(Lkotlin/jvm/functions/Function1;)V", "")]
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/method[@name='getOnStreamUnpublishedHandler' and count(parameter)=0]"
			[Register ("getOnStreamUnpublishedHandler", "()Lkotlin/jvm/functions/Function1;", "")]
			get {
				const string __id = "getOnStreamUnpublishedHandler.()Lkotlin/jvm/functions/Function1;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/method[@name='setOnStreamUnpublishedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super com.ntt.skyway.core.channel.Publication, kotlin.Unit&gt;']]"
			[Register ("setOnStreamUnpublishedHandler", "(Lkotlin/jvm/functions/Function1;)V", "")]
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

		public override unsafe global::Kotlin.Jvm.Functions.IFunction0? OnSubscriptionListChangedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/method[@name='getOnSubscriptionListChangedHandler' and count(parameter)=0]"
			[Register ("getOnSubscriptionListChangedHandler", "()Lkotlin/jvm/functions/Function0;", "")]
			get {
				const string __id = "getOnSubscriptionListChangedHandler.()Lkotlin/jvm/functions/Function0;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction0> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/method[@name='setOnSubscriptionListChangedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function0&lt;kotlin.Unit&gt;']]"
			[Register ("setOnSubscriptionListChangedHandler", "(Lkotlin/jvm/functions/Function0;)V", "")]
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/method[@name='getPublications' and count(parameter)=0]"
			[Register ("getPublications", "()Ljava/util/List;", "")]
			get {
				const string __id = "getPublications.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Channel.IPublication>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe global::Com.Ntt.Skyway.Core.Channel.Member.IMember.State State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()Lcom/ntt/skyway/core/channel/member/Member$State;", "")]
			get {
				const string __id = "getState.()Lcom/ntt/skyway/core/channel/member/Member$State;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember.State> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public override unsafe global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Channel.ISubscription> Subscriptions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/method[@name='getSubscriptions' and count(parameter)=0]"
			[Register ("getSubscriptions", "()Ljava/util/List;", "")]
			get {
				const string __id = "getSubscriptions.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Channel.ISubscription>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/method[@name='leave' and count(parameter)=1 and parameter[1][@type='kotlin.coroutines.Continuation&lt;? super java.lang.Boolean&gt;']]"
		[Register ("leave", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		public override unsafe global::Java.Lang.Object? Leave (global::Kotlin.Coroutines.IContinuation _completion)
		{
			const string __id = "leave.(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((_completion == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _completion).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (_completion);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/method[@name='publish' and count(parameter)=3 and parameter[1][@type='com.ntt.skyway.core.content.local.LocalStream'] and parameter[2][@type='com.ntt.skyway.core.channel.Publication.Options'] and parameter[3][@type='kotlin.coroutines.Continuation&lt;? super com.ntt.skyway.core.channel.Publication&gt;']]"
		[Register ("publish", "(Lcom/ntt/skyway/core/content/local/LocalStream;Lcom/ntt/skyway/core/channel/Publication$Options;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		public override unsafe global::Java.Lang.Object? Publish (global::Com.Ntt.Skyway.Core.Content.Local.LocalStream localStream, global::Com.Ntt.Skyway.Core.Channel.IPublication.Options? options, global::Kotlin.Coroutines.IContinuation _completion)
		{
			const string __id = "publish.(Lcom/ntt/skyway/core/content/local/LocalStream;Lcom/ntt/skyway/core/channel/Publication$Options;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((localStream == null) ? IntPtr.Zero : ((global::Java.Lang.Object) localStream).Handle);
				__args [1] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				__args [2] = new JniArgumentValue ((_completion == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _completion).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (localStream);
				global::System.GC.KeepAlive (options);
				global::System.GC.KeepAlive (_completion);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/method[@name='subscribe' and count(parameter)=3 and parameter[1][@type='com.ntt.skyway.core.channel.Publication'] and parameter[2][@type='com.ntt.skyway.core.channel.Subscription.Options'] and parameter[3][@type='kotlin.coroutines.Continuation&lt;? super com.ntt.skyway.core.channel.Subscription&gt;']]"
		[Register ("subscribe", "(Lcom/ntt/skyway/core/channel/Publication;Lcom/ntt/skyway/core/channel/Subscription$Options;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		public override unsafe global::Java.Lang.Object? Subscribe (global::Com.Ntt.Skyway.Core.Channel.IPublication publication, global::Com.Ntt.Skyway.Core.Channel.ISubscription.Options? options, global::Kotlin.Coroutines.IContinuation _completion)
		{
			const string __id = "subscribe.(Lcom/ntt/skyway/core/channel/Publication;Lcom/ntt/skyway/core/channel/Subscription$Options;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((publication == null) ? IntPtr.Zero : ((global::Java.Lang.Object) publication).Handle);
				__args [1] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				__args [2] = new JniArgumentValue ((_completion == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _completion).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (publication);
				global::System.GC.KeepAlive (options);
				global::System.GC.KeepAlive (_completion);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/method[@name='subscribe' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.ntt.skyway.core.channel.Subscription.Options'] and parameter[3][@type='kotlin.coroutines.Continuation&lt;? super com.ntt.skyway.core.channel.Subscription&gt;']]"
		[Register ("subscribe", "(Ljava/lang/String;Lcom/ntt/skyway/core/channel/Subscription$Options;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		public override unsafe global::Java.Lang.Object? Subscribe (string publicationId, global::Com.Ntt.Skyway.Core.Channel.ISubscription.Options? options, global::Kotlin.Coroutines.IContinuation _completion)
		{
			const string __id = "subscribe.(Ljava/lang/String;Lcom/ntt/skyway/core/channel/Subscription$Options;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
			IntPtr native_publicationId = JNIEnv.NewString ((string?)publicationId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_publicationId);
				__args [1] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				__args [2] = new JniArgumentValue ((_completion == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _completion).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_publicationId);
				global::System.GC.KeepAlive (options);
				global::System.GC.KeepAlive (_completion);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/method[@name='unpublish' and count(parameter)=2 and parameter[1][@type='com.ntt.skyway.core.channel.Publication'] and parameter[2][@type='kotlin.coroutines.Continuation&lt;? super java.lang.Boolean&gt;']]"
		[Register ("unpublish", "(Lcom/ntt/skyway/core/channel/Publication;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		public override unsafe global::Java.Lang.Object? Unpublish (global::Com.Ntt.Skyway.Core.Channel.IPublication publication, global::Kotlin.Coroutines.IContinuation _completion)
		{
			const string __id = "unpublish.(Lcom/ntt/skyway/core/channel/Publication;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((publication == null) ? IntPtr.Zero : ((global::Java.Lang.Object) publication).Handle);
				__args [1] = new JniArgumentValue ((_completion == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _completion).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (publication);
				global::System.GC.KeepAlive (_completion);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/method[@name='unpublish' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='kotlin.coroutines.Continuation&lt;? super java.lang.Boolean&gt;']]"
		[Register ("unpublish", "(Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		public override unsafe global::Java.Lang.Object? Unpublish (string publicationId, global::Kotlin.Coroutines.IContinuation _completion)
		{
			const string __id = "unpublish.(Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
			IntPtr native_publicationId = JNIEnv.NewString ((string?)publicationId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_publicationId);
				__args [1] = new JniArgumentValue ((_completion == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _completion).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_publicationId);
				global::System.GC.KeepAlive (_completion);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/method[@name='unsubscribe' and count(parameter)=2 and parameter[1][@type='com.ntt.skyway.core.channel.Subscription'] and parameter[2][@type='kotlin.coroutines.Continuation&lt;? super java.lang.Boolean&gt;']]"
		[Register ("unsubscribe", "(Lcom/ntt/skyway/core/channel/Subscription;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		public override unsafe global::Java.Lang.Object? Unsubscribe (global::Com.Ntt.Skyway.Core.Channel.ISubscription subscription, global::Kotlin.Coroutines.IContinuation _completion)
		{
			const string __id = "unsubscribe.(Lcom/ntt/skyway/core/channel/Subscription;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((subscription == null) ? IntPtr.Zero : ((global::Java.Lang.Object) subscription).Handle);
				__args [1] = new JniArgumentValue ((_completion == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _completion).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (subscription);
				global::System.GC.KeepAlive (_completion);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/method[@name='unsubscribe' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='kotlin.coroutines.Continuation&lt;? super java.lang.Boolean&gt;']]"
		[Register ("unsubscribe", "(Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		public override unsafe global::Java.Lang.Object? Unsubscribe (string subscriptionId, global::Kotlin.Coroutines.IContinuation _completion)
		{
			const string __id = "unsubscribe.(Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
			IntPtr native_subscriptionId = JNIEnv.NewString ((string?)subscriptionId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_subscriptionId);
				__args [1] = new JniArgumentValue ((_completion == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _completion).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_subscriptionId);
				global::System.GC.KeepAlive (_completion);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/method[@name='updateMetadata' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='kotlin.coroutines.Continuation&lt;? super java.lang.Boolean&gt;']]"
		[Register ("updateMetadata", "(Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		public override unsafe global::Java.Lang.Object? UpdateMetadata (string metadata, global::Kotlin.Coroutines.IContinuation _completion)
		{
			const string __id = "updateMetadata.(Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
			IntPtr native_metadata = JNIEnv.NewString ((string?)metadata);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_metadata);
				__args [1] = new JniArgumentValue ((_completion == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _completion).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_metadata);
				global::System.GC.KeepAlive (_completion);
			}
		}

        public override IMember.State GetState()
        {
            throw new NotImplementedException();
        }
    }
}
