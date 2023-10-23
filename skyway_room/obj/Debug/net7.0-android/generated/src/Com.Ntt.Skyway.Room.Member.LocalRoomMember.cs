using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Room.Member {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.room.member']/class[@name='LocalRoomMember']"
	[global::Android.Runtime.Register ("com/ntt/skyway/room/member/LocalRoomMember", DoNotGenerateAcw=true)]
	public abstract partial class LocalRoomMember : global::Com.Ntt.Skyway.Room.Member.RoomMember {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/room/member/LocalRoomMember", typeof (LocalRoomMember));

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

		protected LocalRoomMember (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe global::Kotlin.Jvm.Functions.IFunction1? OnPublicationSubscribedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room.member']/class[@name='LocalRoomMember']/method[@name='getOnPublicationSubscribedHandler' and count(parameter)=0]"
			[Register ("getOnPublicationSubscribedHandler", "()Lkotlin/jvm/functions/Function1;", "")]
			get {
				const string __id = "getOnPublicationSubscribedHandler.()Lkotlin/jvm/functions/Function1;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room.member']/class[@name='LocalRoomMember']/method[@name='setOnPublicationSubscribedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super com.ntt.skyway.room.RoomSubscription, kotlin.Unit&gt;']]"
			[Register ("setOnPublicationSubscribedHandler", "(Lkotlin/jvm/functions/Function1;)V", "")]
			set {
				const string __id = "setOnPublicationSubscribedHandler.(Lkotlin/jvm/functions/Function1;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Kotlin.Jvm.Functions.IFunction1? OnPublicationUnsubscribedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room.member']/class[@name='LocalRoomMember']/method[@name='getOnPublicationUnsubscribedHandler' and count(parameter)=0]"
			[Register ("getOnPublicationUnsubscribedHandler", "()Lkotlin/jvm/functions/Function1;", "")]
			get {
				const string __id = "getOnPublicationUnsubscribedHandler.()Lkotlin/jvm/functions/Function1;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room.member']/class[@name='LocalRoomMember']/method[@name='setOnPublicationUnsubscribedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super com.ntt.skyway.room.RoomSubscription, kotlin.Unit&gt;']]"
			[Register ("setOnPublicationUnsubscribedHandler", "(Lkotlin/jvm/functions/Function1;)V", "")]
			set {
				const string __id = "setOnPublicationUnsubscribedHandler.(Lkotlin/jvm/functions/Function1;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Kotlin.Jvm.Functions.IFunction1? OnStreamPublishedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room.member']/class[@name='LocalRoomMember']/method[@name='getOnStreamPublishedHandler' and count(parameter)=0]"
			[Register ("getOnStreamPublishedHandler", "()Lkotlin/jvm/functions/Function1;", "")]
			get {
				const string __id = "getOnStreamPublishedHandler.()Lkotlin/jvm/functions/Function1;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room.member']/class[@name='LocalRoomMember']/method[@name='setOnStreamPublishedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super com.ntt.skyway.room.RoomPublication, kotlin.Unit&gt;']]"
			[Register ("setOnStreamPublishedHandler", "(Lkotlin/jvm/functions/Function1;)V", "")]
			set {
				const string __id = "setOnStreamPublishedHandler.(Lkotlin/jvm/functions/Function1;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Kotlin.Jvm.Functions.IFunction1? OnStreamUnpublishedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room.member']/class[@name='LocalRoomMember']/method[@name='getOnStreamUnpublishedHandler' and count(parameter)=0]"
			[Register ("getOnStreamUnpublishedHandler", "()Lkotlin/jvm/functions/Function1;", "")]
			get {
				const string __id = "getOnStreamUnpublishedHandler.()Lkotlin/jvm/functions/Function1;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room.member']/class[@name='LocalRoomMember']/method[@name='setOnStreamUnpublishedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super com.ntt.skyway.room.RoomPublication, kotlin.Unit&gt;']]"
			[Register ("setOnStreamUnpublishedHandler", "(Lkotlin/jvm/functions/Function1;)V", "")]
			set {
				const string __id = "setOnStreamUnpublishedHandler.(Lkotlin/jvm/functions/Function1;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room.member']/class[@name='LocalRoomMember']/method[@name='subscribe' and count(parameter)=3 and parameter[1][@type='com.ntt.skyway.room.RoomPublication'] and parameter[2][@type='com.ntt.skyway.room.RoomSubscription.Options'] and parameter[3][@type='kotlin.coroutines.Continuation&lt;? super com.ntt.skyway.room.RoomSubscription&gt;']]"
		[Register ("subscribe", "(Lcom/ntt/skyway/room/RoomPublication;Lcom/ntt/skyway/room/RoomSubscription$Options;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object? Subscribe (global::Com.Ntt.Skyway.Room.RoomPublication publication, global::Com.Ntt.Skyway.Room.RoomSubscription.Options? options, global::Kotlin.Coroutines.IContinuation _completion)
		{
			const string __id = "subscribe.(Lcom/ntt/skyway/room/RoomPublication;Lcom/ntt/skyway/room/RoomSubscription$Options;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((publication == null) ? IntPtr.Zero : ((global::Java.Lang.Object) publication).Handle);
				__args [1] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				__args [2] = new JniArgumentValue ((_completion == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _completion).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (publication);
				global::System.GC.KeepAlive (options);
				global::System.GC.KeepAlive (_completion);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room.member']/class[@name='LocalRoomMember']/method[@name='subscribe' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.ntt.skyway.room.RoomSubscription.Options'] and parameter[3][@type='kotlin.coroutines.Continuation&lt;? super com.ntt.skyway.room.RoomSubscription&gt;']]"
		[Register ("subscribe", "(Ljava/lang/String;Lcom/ntt/skyway/room/RoomSubscription$Options;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object? Subscribe (string publicationId, global::Com.Ntt.Skyway.Room.RoomSubscription.Options? options, global::Kotlin.Coroutines.IContinuation _completion)
		{
			const string __id = "subscribe.(Ljava/lang/String;Lcom/ntt/skyway/room/RoomSubscription$Options;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
			IntPtr native_publicationId = JNIEnv.NewString ((string?)publicationId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_publicationId);
				__args [1] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				__args [2] = new JniArgumentValue ((_completion == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _completion).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_publicationId);
				global::System.GC.KeepAlive (options);
				global::System.GC.KeepAlive (_completion);
			}
		}

		static Delegate? cb_unpublish_Lcom_ntt_skyway_room_RoomPublication_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetUnpublish_Lcom_ntt_skyway_room_RoomPublication_Lkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_unpublish_Lcom_ntt_skyway_room_RoomPublication_Lkotlin_coroutines_Continuation_ == null)
				cb_unpublish_Lcom_ntt_skyway_room_RoomPublication_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Unpublish_Lcom_ntt_skyway_room_RoomPublication_Lkotlin_coroutines_Continuation_);
			return cb_unpublish_Lcom_ntt_skyway_room_RoomPublication_Lkotlin_coroutines_Continuation_;
		}

		static IntPtr n_Unpublish_Lcom_ntt_skyway_room_RoomPublication_Lkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_publication, IntPtr native__completion)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Room.Member.LocalRoomMember> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var publication = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Room.RoomPublication> (native_publication, JniHandleOwnership.DoNotTransfer);
			var _completion = (global::Kotlin.Coroutines.IContinuation?)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native__completion, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Unpublish (publication!, _completion!));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room.member']/class[@name='LocalRoomMember']/method[@name='unpublish' and count(parameter)=2 and parameter[1][@type='com.ntt.skyway.room.RoomPublication'] and parameter[2][@type='kotlin.coroutines.Continuation&lt;? super java.lang.Boolean&gt;']]"
		[Register ("unpublish", "(Lcom/ntt/skyway/room/RoomPublication;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetUnpublish_Lcom_ntt_skyway_room_RoomPublication_Lkotlin_coroutines_Continuation_Handler")]
		public virtual unsafe global::Java.Lang.Object? Unpublish (global::Com.Ntt.Skyway.Room.RoomPublication publication, global::Kotlin.Coroutines.IContinuation _completion)
		{
			const string __id = "unpublish.(Lcom/ntt/skyway/room/RoomPublication;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((publication == null) ? IntPtr.Zero : ((global::Java.Lang.Object) publication).Handle);
				__args [1] = new JniArgumentValue ((_completion == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _completion).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (publication);
				global::System.GC.KeepAlive (_completion);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room.member']/class[@name='LocalRoomMember']/method[@name='unsubscribe' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='kotlin.coroutines.Continuation&lt;? super java.lang.Boolean&gt;']]"
		[Register ("unsubscribe", "(Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object? Unsubscribe (string subscriptionId, global::Kotlin.Coroutines.IContinuation _completion)
		{
			const string __id = "unsubscribe.(Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
			IntPtr native_subscriptionId = JNIEnv.NewString ((string?)subscriptionId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_subscriptionId);
				__args [1] = new JniArgumentValue ((_completion == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _completion).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_subscriptionId);
				global::System.GC.KeepAlive (_completion);
			}
		}

	}

	[global::Android.Runtime.Register ("com/ntt/skyway/room/member/LocalRoomMember", DoNotGenerateAcw=true)]
	internal partial class LocalRoomMemberInvoker : LocalRoomMember {
		public LocalRoomMemberInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/room/member/LocalRoomMember", typeof (LocalRoomMemberInvoker));

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

	}
}
