using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Plugin.Unknown {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.plugin.unknown']/class[@name='UnknownPlugin']"
	[global::Android.Runtime.Register ("com/ntt/skyway/plugin/unknown/UnknownPlugin", DoNotGenerateAcw=true)]
	public sealed partial class UnknownPlugin : global::Java.Lang.Object, global::Com.Ntt.Skyway.Plugin.IPlugin {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.plugin.unknown']/class[@name='UnknownPlugin']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.Ntt.Skyway.Plugin.Unknown.UnknownPlugin Instance {
			get {
				const string __id = "INSTANCE.Lcom/ntt/skyway/plugin/unknown/UnknownPlugin;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Plugin.Unknown.UnknownPlugin> (__v.Handle, JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/plugin/unknown/UnknownPlugin", typeof (UnknownPlugin));

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

		internal UnknownPlugin (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.plugin.unknown']/class[@name='UnknownPlugin']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.plugin.unknown']/class[@name='UnknownPlugin']/method[@name='createRemoteMember' and count(parameter)=1 and parameter[1][@type='com.ntt.skyway.core.channel.member.Member.Dto']]"
		[Register ("createRemoteMember", "(Lcom/ntt/skyway/core/channel/member/Member$Dto;)Lcom/ntt/skyway/core/channel/member/RemoteMember;", "")]
		public unsafe global::Com.Ntt.Skyway.Core.Channel.Member.RemoteMember CreateRemoteMember (global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Dto dto)
		{
			const string __id = "createRemoteMember.(Lcom/ntt/skyway/core/channel/member/Member$Dto;)Lcom/ntt/skyway/core/channel/member/RemoteMember;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dto == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dto).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.RemoteMember> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
				global::System.GC.KeepAlive (dto);
			}
		}

	}
}
