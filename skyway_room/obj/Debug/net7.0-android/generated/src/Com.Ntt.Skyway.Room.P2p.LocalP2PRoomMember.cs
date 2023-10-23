using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Room.P2p {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.room.p2p']/class[@name='LocalP2PRoomMember']"
	[global::Android.Runtime.Register ("com/ntt/skyway/room/p2p/LocalP2PRoomMember", DoNotGenerateAcw=true)]
	public sealed partial class LocalP2PRoomMember : global::Com.Ntt.Skyway.Room.Member.LocalRoomMember {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/room/p2p/LocalP2PRoomMember", typeof (LocalP2PRoomMember));

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

		internal LocalP2PRoomMember (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

	}
}
