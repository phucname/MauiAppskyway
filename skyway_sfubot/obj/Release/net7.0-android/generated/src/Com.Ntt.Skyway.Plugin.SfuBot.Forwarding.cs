using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Plugin.SfuBot {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.plugin.sfuBot']/class[@name='Forwarding']"
	[global::Android.Runtime.Register ("com/ntt/skyway/plugin/sfuBot/Forwarding", DoNotGenerateAcw=true)]
	public sealed partial class Forwarding : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.plugin.sfuBot']/class[@name='Forwarding.Configure']"
		[global::Android.Runtime.Register ("com/ntt/skyway/plugin/sfuBot/Forwarding$Configure", DoNotGenerateAcw=true)]
		public sealed partial class Configure : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/plugin/sfuBot/Forwarding$Configure", typeof (Configure));

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

			internal Configure (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.plugin.sfuBot']/class[@name='Forwarding.Configure']/constructor[@name='Forwarding.Configure' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register (".ctor", "(I)V", "")]
			public unsafe Configure (int maxSubscribers) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(I)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (maxSubscribers);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			public unsafe int MaxSubscribers {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.plugin.sfuBot']/class[@name='Forwarding.Configure']/method[@name='getMaxSubscribers' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.plugin.sfuBot']/class[@name='Forwarding.Configure']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()I", "")]
			public unsafe int Component1 ()
			{
				const string __id = "component1.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.plugin.sfuBot']/class[@name='Forwarding.Configure']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("copy", "(I)Lcom/ntt/skyway/plugin/sfuBot/Forwarding$Configure;", "")]
			public unsafe global::Com.Ntt.Skyway.Plugin.SfuBot.Forwarding.Configure Copy (int maxSubscribers)
			{
				const string __id = "copy.(I)Lcom/ntt/skyway/plugin/sfuBot/Forwarding$Configure;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (maxSubscribers);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Plugin.SfuBot.Forwarding.Configure> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/plugin/sfuBot/Forwarding", typeof (Forwarding));

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

		internal Forwarding (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.plugin.sfuBot']/class[@name='Forwarding']/method[@name='getId' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.plugin.sfuBot']/class[@name='Forwarding']/method[@name='getConfigure' and count(parameter)=0]"
		[Register ("getConfigure", "()Lcom/ntt/skyway/plugin/sfuBot/Forwarding$Configure;", "")]
		public unsafe global::Com.Ntt.Skyway.Plugin.SfuBot.Forwarding.Configure GetConfigure ()
		{
			const string __id = "getConfigure.()Lcom/ntt/skyway/plugin/sfuBot/Forwarding$Configure;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Plugin.SfuBot.Forwarding.Configure> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
			}
		}

	}
}
