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
