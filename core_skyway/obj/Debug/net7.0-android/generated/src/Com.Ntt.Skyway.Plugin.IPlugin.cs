using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Plugin {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ntt.skyway.plugin']/interface[@name='Plugin']"
	[Register ("com/ntt/skyway/plugin/Plugin", "", "Com.Ntt.Skyway.Plugin.IPluginInvoker")]
	public partial interface IPlugin : IJavaObject, IJavaPeerable {
		string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.plugin']/interface[@name='Plugin']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Com.Ntt.Skyway.Plugin.IPluginInvoker, core_skyway")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.plugin']/interface[@name='Plugin']/method[@name='createRemoteMember' and count(parameter)=1 and parameter[1][@type='com.ntt.skyway.core.channel.member.Member.Dto']]"
		[Register ("createRemoteMember", "(Lcom/ntt/skyway/core/channel/member/Member$Dto;)Lcom/ntt/skyway/core/channel/member/RemoteMember;", "GetCreateRemoteMember_Lcom_ntt_skyway_core_channel_member_Member_Dto_Handler:Com.Ntt.Skyway.Plugin.IPluginInvoker, core_skyway")]
		global::Com.Ntt.Skyway.Core.Channel.Member.RemoteMember CreateRemoteMember (global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Dto dto);

	}

	[global::Android.Runtime.Register ("com/ntt/skyway/plugin/Plugin", DoNotGenerateAcw=true)]
	internal partial class IPluginInvoker : global::Java.Lang.Object, IPlugin {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/plugin/Plugin", typeof (IPluginInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IPlugin? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPlugin> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ntt.skyway.plugin.Plugin'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPluginInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Plugin.IPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		IntPtr id_getName;
		public unsafe string Name {
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static Delegate? cb_createRemoteMember_Lcom_ntt_skyway_core_channel_member_Member_Dto_;
#pragma warning disable 0169
		static Delegate GetCreateRemoteMember_Lcom_ntt_skyway_core_channel_member_Member_Dto_Handler ()
		{
			if (cb_createRemoteMember_Lcom_ntt_skyway_core_channel_member_Member_Dto_ == null)
				cb_createRemoteMember_Lcom_ntt_skyway_core_channel_member_Member_Dto_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CreateRemoteMember_Lcom_ntt_skyway_core_channel_member_Member_Dto_);
			return cb_createRemoteMember_Lcom_ntt_skyway_core_channel_member_Member_Dto_;
		}

		static IntPtr n_CreateRemoteMember_Lcom_ntt_skyway_core_channel_member_Member_Dto_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dto)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Plugin.IPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var dto = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Dto> (native_dto, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateRemoteMember (dto!));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createRemoteMember_Lcom_ntt_skyway_core_channel_member_Member_Dto_;
		public unsafe global::Com.Ntt.Skyway.Core.Channel.Member.RemoteMember CreateRemoteMember (global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Dto dto)
		{
			if (id_createRemoteMember_Lcom_ntt_skyway_core_channel_member_Member_Dto_ == IntPtr.Zero)
				id_createRemoteMember_Lcom_ntt_skyway_core_channel_member_Member_Dto_ = JNIEnv.GetMethodID (class_ref, "createRemoteMember", "(Lcom/ntt/skyway/core/channel/member/Member$Dto;)Lcom/ntt/skyway/core/channel/member/RemoteMember;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((dto == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dto).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.RemoteMember> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createRemoteMember_Lcom_ntt_skyway_core_channel_member_Member_Dto_, __args), JniHandleOwnership.TransferLocalRef)!;
			return __ret;
		}

	}
}
