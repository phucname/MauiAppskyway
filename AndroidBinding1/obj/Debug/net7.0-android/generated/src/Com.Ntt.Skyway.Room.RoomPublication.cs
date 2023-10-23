using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Room {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.room']/class[@name='RoomPublication']"
	[global::Android.Runtime.Register ("com/ntt/skyway/room/RoomPublication", DoNotGenerateAcw=true)]
	public sealed partial class RoomPublication : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.room']/class[@name='RoomPublication.Options']"
		[global::Android.Runtime.Register ("com/ntt/skyway/room/RoomPublication$Options", DoNotGenerateAcw=true)]
		public sealed partial class Options : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/room/RoomPublication$Options", typeof (Options));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.room']/class[@name='RoomPublication.Options']/constructor[@name='RoomPublication.Options' and count(parameter)=0]"
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

			public unsafe int MaxSubscribers {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room']/class[@name='RoomPublication.Options']/method[@name='getMaxSubscribers' and count(parameter)=0]"
				[Register ("getMaxSubscribers", "()I", "")]
				get {
					const string __id = "getMaxSubscribers.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe string? Metadata {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room']/class[@name='RoomPublication.Options']/method[@name='getMetadata' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room']/class[@name='RoomPublication.Options']/method[@name='component1' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room']/class[@name='RoomPublication.Options']/method[@name='component4' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room']/class[@name='RoomPublication.Options']/method[@name='component5' and count(parameter)=0]"
			[Register ("component5", "()I", "")]
			public unsafe int Component5 ()
			{
				const string __id = "component5.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room']/class[@name='RoomPublication.Options']/method[@name='isEnabled' and count(parameter)=0]"
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/room/RoomPublication", typeof (RoomPublication));

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

		internal RoomPublication (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room']/class[@name='RoomPublication']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe string Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room']/class[@name='RoomPublication']/method[@name='getMetadata' and count(parameter)=0]"
			[Register ("getMetadata", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getMetadata.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe global::Com.Ntt.Skyway.Room.Member.RoomMember? Publisher {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room']/class[@name='RoomPublication']/method[@name='getPublisher' and count(parameter)=0]"
			[Register ("getPublisher", "()Lcom/ntt/skyway/room/member/RoomMember;", "")]
			get {
				const string __id = "getPublisher.()Lcom/ntt/skyway/room/member/RoomMember;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Room.Member.RoomMember> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Ntt.Skyway.Room.Room Room {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room']/class[@name='RoomPublication']/method[@name='getRoom' and count(parameter)=0]"
			[Register ("getRoom", "()Lcom/ntt/skyway/room/Room;", "")]
			get {
				const string __id = "getRoom.()Lcom/ntt/skyway/room/Room;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Room.Room> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Room.RoomSubscription> Subscriptions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room']/class[@name='RoomPublication']/method[@name='getSubscriptions' and count(parameter)=0]"
			[Register ("getSubscriptions", "()Ljava/util/List;", "")]
			get {
				const string __id = "getSubscriptions.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Room.RoomSubscription>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

	}
}
