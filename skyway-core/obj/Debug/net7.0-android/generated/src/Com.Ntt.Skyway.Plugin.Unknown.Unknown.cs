using System;
using System.Collections.Generic;
using Android.Runtime;
using Com.Ntt.Skyway.Core.Channel.Member;
using Java.Interop;

namespace Com.Ntt.Skyway.Plugin.Unknown {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.plugin.unknown']/class[@name='Unknown']"
	[global::Android.Runtime.Register ("com/ntt/skyway/plugin/unknown/Unknown", DoNotGenerateAcw=true)]
	public sealed partial class Unknown : global::Com.Ntt.Skyway.Core.Channel.Member.RemoteMemberImpl {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/plugin/unknown/Unknown", typeof (Unknown));

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

		internal Unknown (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public override unsafe string SubType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.plugin.unknown']/class[@name='Unknown']/method[@name='getSubType' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.plugin.unknown']/class[@name='Unknown']/method[@name='getType' and count(parameter)=0]"
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
