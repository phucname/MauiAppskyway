using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Core.Channel {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Subscription']"
	[Register ("com/ntt/skyway/core/channel/Subscription", "", "Com.Ntt.Skyway.Core.Channel.ISubscriptionInvoker")]
	public partial interface ISubscription : IJavaObject, IJavaPeerable {
		global::Com.Ntt.Skyway.Core.Channel.IChannel Channel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Subscription']/method[@name='getChannel' and count(parameter)=0]"
			[Register ("getChannel", "()Lcom/ntt/skyway/core/channel/Channel;", "GetGetChannelHandler:Com.Ntt.Skyway.Core.Channel.ISubscriptionInvoker, skyway-core")]
			get; 
		}

		global::Com.Ntt.Skyway.Core.Content.Stream.ContentType ContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Subscription']/method[@name='getContentType' and count(parameter)=0]"
			[Register ("getContentType", "()Lcom/ntt/skyway/core/content/Stream$ContentType;", "GetGetContentTypeHandler:Com.Ntt.Skyway.Core.Channel.ISubscriptionInvoker, skyway-core")]
			get; 
		}

		string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Subscription']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler:Com.Ntt.Skyway.Core.Channel.ISubscriptionInvoker, skyway-core")]
			get; 
		}

		long NativePointer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Subscription']/method[@name='getNativePointer' and count(parameter)=0]"
			[Register ("getNativePointer", "()J", "GetGetNativePointerHandler:Com.Ntt.Skyway.Core.Channel.ISubscriptionInvoker, skyway-core")]
			get; 
		}

		global::Kotlin.Jvm.Functions.IFunction0? OnCanceledHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Subscription']/method[@name='getOnCanceledHandler' and count(parameter)=0]"
			[Register ("getOnCanceledHandler", "()Lkotlin/jvm/functions/Function0;", "GetGetOnCanceledHandlerHandler:Com.Ntt.Skyway.Core.Channel.ISubscriptionInvoker, skyway-core")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Subscription']/method[@name='setOnCanceledHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function0&lt;kotlin.Unit&gt;']]"
			[Register ("setOnCanceledHandler", "(Lkotlin/jvm/functions/Function0;)V", "GetSetOnCanceledHandler_Lkotlin_jvm_functions_Function0_Handler:Com.Ntt.Skyway.Core.Channel.ISubscriptionInvoker, skyway-core")]
			set; 
		}

		global::Kotlin.Jvm.Functions.IFunction1? OnConnectionStateChangedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Subscription']/method[@name='getOnConnectionStateChangedHandler' and count(parameter)=0]"
			[Register ("getOnConnectionStateChangedHandler", "()Lkotlin/jvm/functions/Function1;", "GetGetOnConnectionStateChangedHandlerHandler:Com.Ntt.Skyway.Core.Channel.ISubscriptionInvoker, skyway-core")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Subscription']/method[@name='setOnConnectionStateChangedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super java.lang.String, kotlin.Unit&gt;']]"
			[Register ("setOnConnectionStateChangedHandler", "(Lkotlin/jvm/functions/Function1;)V", "GetSetOnConnectionStateChangedHandler_Lkotlin_jvm_functions_Function1_Handler:Com.Ntt.Skyway.Core.Channel.ISubscriptionInvoker, skyway-core")]
			set; 
		}

		string PreferredEncodingId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Subscription']/method[@name='getPreferredEncodingId' and count(parameter)=0]"
			[Register ("getPreferredEncodingId", "()Ljava/lang/String;", "GetGetPreferredEncodingIdHandler:Com.Ntt.Skyway.Core.Channel.ISubscriptionInvoker, skyway-core")]
			get; 
		}

		global::Com.Ntt.Skyway.Core.Channel.IPublication Publication {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Subscription']/method[@name='getPublication' and count(parameter)=0]"
			[Register ("getPublication", "()Lcom/ntt/skyway/core/channel/Publication;", "GetGetPublicationHandler:Com.Ntt.Skyway.Core.Channel.ISubscriptionInvoker, skyway-core")]
			get; 
		}

		global::Com.Ntt.Skyway.Core.Content.WebRTCStats? Stats {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Subscription']/method[@name='getStats' and count(parameter)=0]"
			[Register ("getStats", "()Lcom/ntt/skyway/core/content/WebRTCStats;", "GetGetStatsHandler:Com.Ntt.Skyway.Core.Channel.ISubscriptionInvoker, skyway-core")]
			get; 
		}

		global::Com.Ntt.Skyway.Core.Content.Remote.RemoteStream? Stream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Subscription']/method[@name='getStream' and count(parameter)=0]"
			[Register ("getStream", "()Lcom/ntt/skyway/core/content/remote/RemoteStream;", "GetGetStreamHandler:Com.Ntt.Skyway.Core.Channel.ISubscriptionInvoker, skyway-core")]
			get; 
		}

		global::Com.Ntt.Skyway.Core.Channel.Member.IMember Subscriber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Subscription']/method[@name='getSubscriber' and count(parameter)=0]"
			[Register ("getSubscriber", "()Lcom/ntt/skyway/core/channel/member/Member;", "GetGetSubscriberHandler:Com.Ntt.Skyway.Core.Channel.ISubscriptionInvoker, skyway-core")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Subscription']/method[@name='cancel' and count(parameter)=1 and parameter[1][@type='kotlin.coroutines.Continuation&lt;? super java.lang.Boolean&gt;']]"
		[Register ("cancel", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetCancel_Lkotlin_coroutines_Continuation_Handler:Com.Ntt.Skyway.Core.Channel.ISubscriptionInvoker, skyway-core")]
		global::Java.Lang.Object? Cancel (global::Kotlin.Coroutines.IContinuation p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Subscription']/method[@name='changePreferredEncoding' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("changePreferredEncoding", "(Ljava/lang/String;)V", "GetChangePreferredEncoding_Ljava_lang_String_Handler:Com.Ntt.Skyway.Core.Channel.ISubscriptionInvoker, skyway-core")]
		void ChangePreferredEncoding (string id);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Subscription']/method[@name='getState' and count(parameter)=0]"
		[Register ("getState", "()Lcom/ntt/skyway/core/channel/Subscription$State;", "GetGetStateHandler:Com.Ntt.Skyway.Core.Channel.ISubscriptionInvoker, skyway-core")]
		global::Com.Ntt.Skyway.Core.Channel.ISubscription.State GetState ();

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Subscription.Options']"
		[global::Android.Runtime.Register ("com/ntt/skyway/core/channel/Subscription$Options", DoNotGenerateAcw=true)]
		public sealed partial class Options : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/Subscription$Options", typeof (Options));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Subscription.Options']/constructor[@name='Subscription.Options' and count(parameter)=0]"
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Subscription.Options']/constructor[@name='Subscription.Options' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe Options (string? preferredEncodingId) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_preferredEncodingId = JNIEnv.NewString ((string?)preferredEncodingId);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_preferredEncodingId);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_preferredEncodingId);
				}
			}

			public unsafe string? PreferredEncodingId {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Subscription.Options']/method[@name='getPreferredEncodingId' and count(parameter)=0]"
				[Register ("getPreferredEncodingId", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getPreferredEncodingId.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Subscription.Options']/method[@name='component1' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Subscription.Options']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("copy", "(Ljava/lang/String;)Lcom/ntt/skyway/core/channel/Subscription$Options;", "")]
			public unsafe global::Com.Ntt.Skyway.Core.Channel.ISubscription.Options Copy (string? preferredEncodingId)
			{
				const string __id = "copy.(Ljava/lang/String;)Lcom/ntt/skyway/core/channel/Subscription$Options;";
				IntPtr native_preferredEncodingId = JNIEnv.NewString ((string?)preferredEncodingId);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_preferredEncodingId);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.ISubscription.Options> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
					JNIEnv.DeleteLocalRef (native_preferredEncodingId);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Subscription.State']"
		[global::Android.Runtime.Register ("com/ntt/skyway/core/channel/Subscription$State", DoNotGenerateAcw=true)]
		public sealed partial class State : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Subscription.State']/field[@name='CANCELED']"
			[Register ("CANCELED")]
			public static global::Com.Ntt.Skyway.Core.Channel.ISubscription.State? Canceled {
				get {
					const string __id = "CANCELED.Lcom/ntt/skyway/core/channel/Subscription$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.ISubscription.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Subscription.State']/field[@name='DISABLED']"
			[Register ("DISABLED")]
			public static global::Com.Ntt.Skyway.Core.Channel.ISubscription.State? Disabled {
				get {
					const string __id = "DISABLED.Lcom/ntt/skyway/core/channel/Subscription$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.ISubscription.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Subscription.State']/field[@name='ENABLED']"
			[Register ("ENABLED")]
			public static global::Com.Ntt.Skyway.Core.Channel.ISubscription.State? Enabled {
				get {
					const string __id = "ENABLED.Lcom/ntt/skyway/core/channel/Subscription$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.ISubscription.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Subscription.State.Companion']"
			[global::Android.Runtime.Register ("com/ntt/skyway/core/channel/Subscription$State$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/Subscription$State$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Subscription.State.Companion']/constructor[@name='Subscription.State.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/Subscription$State", typeof (State));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Subscription.State']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/ntt/skyway/core/channel/Subscription$State;", "")]
			public static unsafe global::Com.Ntt.Skyway.Core.Channel.ISubscription.State? ValueOf (string? value)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/ntt/skyway/core/channel/Subscription$State;";
				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.ISubscription.State> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Subscription.State']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/ntt/skyway/core/channel/Subscription$State;", "")]
			public static unsafe global::Com.Ntt.Skyway.Core.Channel.ISubscription.State[]? Values ()
			{
				const string __id = "values.()[Lcom/ntt/skyway/core/channel/Subscription$State;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Ntt.Skyway.Core.Channel.ISubscription.State[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Ntt.Skyway.Core.Channel.ISubscription.State));
				} finally {
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/ntt/skyway/core/channel/Subscription", DoNotGenerateAcw=true)]
	internal partial class ISubscriptionInvoker : global::Java.Lang.Object, ISubscription {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/Subscription", typeof (ISubscriptionInvoker));

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

		public static ISubscription? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISubscription> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ntt.skyway.core.channel.Subscription'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISubscriptionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.ISubscription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.ISubscription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.ISubscription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.ISubscription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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

		static Delegate? cb_getOnCanceledHandler;
#pragma warning disable 0169
		static Delegate GetGetOnCanceledHandlerHandler ()
		{
			if (cb_getOnCanceledHandler == null)
				cb_getOnCanceledHandler = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOnCanceledHandler);
			return cb_getOnCanceledHandler;
		}

		static IntPtr n_GetOnCanceledHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.ISubscription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.OnCanceledHandler);
		}
#pragma warning restore 0169

		static Delegate? cb_setOnCanceledHandler_Lkotlin_jvm_functions_Function0_;
#pragma warning disable 0169
		static Delegate GetSetOnCanceledHandler_Lkotlin_jvm_functions_Function0_Handler ()
		{
			if (cb_setOnCanceledHandler_Lkotlin_jvm_functions_Function0_ == null)
				cb_setOnCanceledHandler_Lkotlin_jvm_functions_Function0_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnCanceledHandler_Lkotlin_jvm_functions_Function0_);
			return cb_setOnCanceledHandler_Lkotlin_jvm_functions_Function0_;
		}

		static void n_SetOnCanceledHandler_Lkotlin_jvm_functions_Function0_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.ISubscription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var value = (global::Kotlin.Jvm.Functions.IFunction0?)global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction0> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.OnCanceledHandler = value;
		}
#pragma warning restore 0169

		IntPtr id_getOnCanceledHandler;
		IntPtr id_setOnCanceledHandler_Lkotlin_jvm_functions_Function0_;
		public unsafe global::Kotlin.Jvm.Functions.IFunction0? OnCanceledHandler {
			get {
				if (id_getOnCanceledHandler == IntPtr.Zero)
					id_getOnCanceledHandler = JNIEnv.GetMethodID (class_ref, "getOnCanceledHandler", "()Lkotlin/jvm/functions/Function0;");
				return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction0> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnCanceledHandler), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setOnCanceledHandler_Lkotlin_jvm_functions_Function0_ == IntPtr.Zero)
					id_setOnCanceledHandler_Lkotlin_jvm_functions_Function0_ = JNIEnv.GetMethodID (class_ref, "setOnCanceledHandler", "(Lkotlin/jvm/functions/Function0;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnCanceledHandler_Lkotlin_jvm_functions_Function0_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.ISubscription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.ISubscription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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

		static Delegate? cb_getPreferredEncodingId;
#pragma warning disable 0169
		static Delegate GetGetPreferredEncodingIdHandler ()
		{
			if (cb_getPreferredEncodingId == null)
				cb_getPreferredEncodingId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPreferredEncodingId);
			return cb_getPreferredEncodingId;
		}

		static IntPtr n_GetPreferredEncodingId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.ISubscription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.PreferredEncodingId);
		}
#pragma warning restore 0169

		IntPtr id_getPreferredEncodingId;
		public unsafe string PreferredEncodingId {
			get {
				if (id_getPreferredEncodingId == IntPtr.Zero)
					id_getPreferredEncodingId = JNIEnv.GetMethodID (class_ref, "getPreferredEncodingId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPreferredEncodingId), JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static Delegate? cb_getPublication;
#pragma warning disable 0169
		static Delegate GetGetPublicationHandler ()
		{
			if (cb_getPublication == null)
				cb_getPublication = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPublication);
			return cb_getPublication;
		}

		static IntPtr n_GetPublication (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.ISubscription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Publication);
		}
#pragma warning restore 0169

		IntPtr id_getPublication;
		public unsafe global::Com.Ntt.Skyway.Core.Channel.IPublication Publication {
			get {
				if (id_getPublication == IntPtr.Zero)
					id_getPublication = JNIEnv.GetMethodID (class_ref, "getPublication", "()Lcom/ntt/skyway/core/channel/Publication;");
				return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPublication), JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static Delegate? cb_getStats;
#pragma warning disable 0169
		static Delegate GetGetStatsHandler ()
		{
			if (cb_getStats == null)
				cb_getStats = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetStats);
			return cb_getStats;
		}

		static IntPtr n_GetStats (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.ISubscription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Stats);
		}
#pragma warning restore 0169

		IntPtr id_getStats;
		public unsafe global::Com.Ntt.Skyway.Core.Content.WebRTCStats? Stats {
			get {
				if (id_getStats == IntPtr.Zero)
					id_getStats = JNIEnv.GetMethodID (class_ref, "getStats", "()Lcom/ntt/skyway/core/content/WebRTCStats;");
				return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.WebRTCStats> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStats), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.ISubscription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Stream);
		}
#pragma warning restore 0169

		IntPtr id_getStream;
		public unsafe global::Com.Ntt.Skyway.Core.Content.Remote.RemoteStream? Stream {
			get {
				if (id_getStream == IntPtr.Zero)
					id_getStream = JNIEnv.GetMethodID (class_ref, "getStream", "()Lcom/ntt/skyway/core/content/remote/RemoteStream;");
				return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Remote.RemoteStream> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStream), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getSubscriber;
#pragma warning disable 0169
		static Delegate GetGetSubscriberHandler ()
		{
			if (cb_getSubscriber == null)
				cb_getSubscriber = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSubscriber);
			return cb_getSubscriber;
		}

		static IntPtr n_GetSubscriber (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.ISubscription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Subscriber);
		}
#pragma warning restore 0169

		IntPtr id_getSubscriber;
		public unsafe global::Com.Ntt.Skyway.Core.Channel.Member.IMember Subscriber {
			get {
				if (id_getSubscriber == IntPtr.Zero)
					id_getSubscriber = JNIEnv.GetMethodID (class_ref, "getSubscriber", "()Lcom/ntt/skyway/core/channel/member/Member;");
				return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSubscriber), JniHandleOwnership.TransferLocalRef)!;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.ISubscription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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

		static Delegate? cb_changePreferredEncoding_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetChangePreferredEncoding_Ljava_lang_String_Handler ()
		{
			if (cb_changePreferredEncoding_Ljava_lang_String_ == null)
				cb_changePreferredEncoding_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ChangePreferredEncoding_Ljava_lang_String_);
			return cb_changePreferredEncoding_Ljava_lang_String_;
		}

		static void n_ChangePreferredEncoding_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.ISubscription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var id = JNIEnv.GetString (native_id, JniHandleOwnership.DoNotTransfer);
			__this.ChangePreferredEncoding (id!);
		}
#pragma warning restore 0169

		IntPtr id_changePreferredEncoding_Ljava_lang_String_;
		public unsafe void ChangePreferredEncoding (string id)
		{
			if (id_changePreferredEncoding_Ljava_lang_String_ == IntPtr.Zero)
				id_changePreferredEncoding_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "changePreferredEncoding", "(Ljava/lang/String;)V");
			IntPtr native_id = JNIEnv.NewString ((string?)id);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_id);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_changePreferredEncoding_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_id);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.ISubscription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.GetState ());
		}
#pragma warning restore 0169

		IntPtr id_getState;
		public unsafe global::Com.Ntt.Skyway.Core.Channel.ISubscription.State GetState ()
		{
			if (id_getState == IntPtr.Zero)
				id_getState = JNIEnv.GetMethodID (class_ref, "getState", "()Lcom/ntt/skyway/core/channel/Subscription$State;");
			return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.ISubscription.State> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getState), JniHandleOwnership.TransferLocalRef)!;
		}

	}
}
