using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Room.Member {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.room.member']/class[@name='RoomMember']"
	[global::Android.Runtime.Register ("com/ntt/skyway/room/member/RoomMember", DoNotGenerateAcw=true)]
	public abstract partial class RoomMember : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.room.member']/class[@name='RoomMember.Init']"
		[global::Android.Runtime.Register ("com/ntt/skyway/room/member/RoomMember$Init", DoNotGenerateAcw=true)]
		public sealed partial class Init : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/room/member/RoomMember$Init", typeof (Init));

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

			internal Init (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.room.member']/class[@name='RoomMember.Init']/constructor[@name='RoomMember.Init' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;I)V", "")]
			public unsafe Init (string name, string? metadata, int keepAliveIntervalSec) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Ljava/lang/String;I)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_name = JNIEnv.NewString ((string?)name);
				IntPtr native_metadata = JNIEnv.NewString ((string?)metadata);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_name);
					__args [1] = new JniArgumentValue (native_metadata);
					__args [2] = new JniArgumentValue (keepAliveIntervalSec);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_metadata);
				}
			}

			public unsafe int KeepAliveIntervalSec {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room.member']/class[@name='RoomMember.Init']/method[@name='getKeepAliveIntervalSec' and count(parameter)=0]"
				[Register ("getKeepAliveIntervalSec", "()I", "")]
				get {
					const string __id = "getKeepAliveIntervalSec.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe string? Metadata {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room.member']/class[@name='RoomMember.Init']/method[@name='getMetadata' and count(parameter)=0]"
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

			public unsafe string Name {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room.member']/class[@name='RoomMember.Init']/method[@name='getName' and count(parameter)=0]"
				[Register ("getName", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getName.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room.member']/class[@name='RoomMember.Init']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()Ljava/lang/String;", "")]
			public unsafe string Component1 ()
			{
				const string __id = "component1.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room.member']/class[@name='RoomMember.Init']/method[@name='component2' and count(parameter)=0]"
			[Register ("component2", "()Ljava/lang/String;", "")]
			public unsafe string? Component2 ()
			{
				const string __id = "component2.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room.member']/class[@name='RoomMember.Init']/method[@name='component3' and count(parameter)=0]"
			[Register ("component3", "()I", "")]
			public unsafe int Component3 ()
			{
				const string __id = "component3.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room.member']/class[@name='RoomMember.Init']/method[@name='copy' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
			[Register ("copy", "(Ljava/lang/String;Ljava/lang/String;I)Lcom/ntt/skyway/room/member/RoomMember$Init;", "")]
			public unsafe global::Com.Ntt.Skyway.Room.Member.RoomMember.Init Copy (string name, string? metadata, int keepAliveIntervalSec)
			{
				const string __id = "copy.(Ljava/lang/String;Ljava/lang/String;I)Lcom/ntt/skyway/room/member/RoomMember$Init;";
				IntPtr native_name = JNIEnv.NewString ((string?)name);
				IntPtr native_metadata = JNIEnv.NewString ((string?)metadata);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_name);
					__args [1] = new JniArgumentValue (native_metadata);
					__args [2] = new JniArgumentValue (keepAliveIntervalSec);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Room.Member.RoomMember.Init> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_metadata);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/room/member/RoomMember", typeof (RoomMember));

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

		protected RoomMember (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room.member']/class[@name='RoomMember']/method[@name='getId' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room.member']/class[@name='RoomMember']/method[@name='getMetadata' and count(parameter)=0]"
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

		public unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room.member']/class[@name='RoomMember']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Room.RoomPublication> Publications {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room.member']/class[@name='RoomMember']/method[@name='getPublications' and count(parameter)=0]"
			[Register ("getPublications", "()Ljava/util/List;", "")]
			get {
				const string __id = "getPublications.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Room.RoomPublication>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe global::Com.Ntt.Skyway.Room.Room Room {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room.member']/class[@name='RoomMember']/method[@name='getRoom' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room.member']/class[@name='RoomMember']/method[@name='getSubscriptions' and count(parameter)=0]"
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

	[global::Android.Runtime.Register ("com/ntt/skyway/room/member/RoomMember", DoNotGenerateAcw=true)]
	internal partial class RoomMemberInvoker : RoomMember {
		public RoomMemberInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/room/member/RoomMember", typeof (RoomMemberInvoker));

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
