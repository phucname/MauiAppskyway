using System;
using System.Collections.Generic;
using Android.Runtime;
using Com.Ntt.Skyway.Core.Channel.Member;
using Java.Interop;

namespace Com.Ntt.Skyway.Plugin.RemotePerson {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.plugin.remotePerson']/class[@name='RemotePerson']"
	[global::Android.Runtime.Register ("com/ntt/skyway/plugin/remotePerson/RemotePerson", DoNotGenerateAcw=true)]
	public sealed partial class RemotePerson : global::Com.Ntt.Skyway.Core.Channel.Member.RemoteMemberImpl {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/plugin/remotePerson/RemotePerson", typeof (RemotePerson));

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

		internal RemotePerson (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public override unsafe string SubType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.plugin.remotePerson']/class[@name='RemotePerson']/method[@name='getSubType' and count(parameter)=0]"
			[Register ("getSubType", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getSubType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Type Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.plugin.remotePerson']/class[@name='RemotePerson']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Lcom/ntt/skyway/core/channel/member/Member$Type;", "")]
			get {
				const string __id = "getType.()Lcom/ntt/skyway/core/channel/member/Member$Type;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Type> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.plugin.remotePerson']/class[@name='RemotePerson']/method[@name='subscribe' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='kotlin.coroutines.Continuation&lt;? super com.ntt.skyway.core.channel.Subscription&gt;']]"
		[Register ("subscribe", "(Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object? Subscribe (string publicationId, global::Kotlin.Coroutines.IContinuation _completion)
		{
			const string __id = "subscribe.(Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
			IntPtr native_publicationId = JNIEnv.NewString ((string?)publicationId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_publicationId);
				__args [1] = new JniArgumentValue ((_completion == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _completion).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_publicationId);
				global::System.GC.KeepAlive (_completion);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.plugin.remotePerson']/class[@name='RemotePerson']/method[@name='unsubscribe' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='kotlin.coroutines.Continuation&lt;? super java.lang.Boolean&gt;']]"
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

        public override IMember.State GetState()
        {
            throw new NotImplementedException();
        }

        public override IMember.Type GetType()
        {
            throw new NotImplementedException();
        }
    }
}
