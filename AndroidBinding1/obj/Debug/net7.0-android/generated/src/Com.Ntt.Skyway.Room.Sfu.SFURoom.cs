using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Room.Sfu {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.room.sfu']/class[@name='SFURoom']"
	[global::Android.Runtime.Register ("com/ntt/skyway/room/sfu/SFURoom", DoNotGenerateAcw=true)]
	public sealed partial class SFURoom : global::Com.Ntt.Skyway.Room.Room {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.room.sfu']/class[@name='SFURoom.Companion']"
		[global::Android.Runtime.Register ("com/ntt/skyway/room/sfu/SFURoom$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/room/sfu/SFURoom$Companion", typeof (Companion));

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

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/room/sfu/SFURoom", typeof (SFURoom));

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

		internal SFURoom (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room.sfu']/class[@name='SFURoom']/method[@name='getType' and count(parameter)=0]"
		[Register ("getType", "()Lcom/ntt/skyway/room/Room$Type;", "")]
		public override unsafe global::Com.Ntt.Skyway.Room.Room.Type GetType ()
		{
			const string __id = "getType.()Lcom/ntt/skyway/room/Room$Type;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Room.Room.Type> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
			}
		}

	}
}
