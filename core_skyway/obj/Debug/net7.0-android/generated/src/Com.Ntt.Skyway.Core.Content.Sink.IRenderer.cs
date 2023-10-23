using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Core.Content.Sink {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/interface[@name='Renderer']"
	[Register ("com/ntt/skyway/core/content/sink/Renderer", "", "Com.Ntt.Skyway.Core.Content.Sink.IRendererInvoker")]
	public partial interface IRenderer : IJavaObject, IJavaPeerable {
		bool Setup {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/interface[@name='Renderer']/method[@name='isSetup' and count(parameter)=0]"
			[Register ("isSetup", "()Z", "GetIsSetupHandler:Com.Ntt.Skyway.Core.Content.Sink.IRendererInvoker, core_skyway")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/interface[@name='Renderer']/method[@name='setSetup' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSetup", "(Z)V", "GetSetSetup_ZHandler:Com.Ntt.Skyway.Core.Content.Sink.IRendererInvoker, core_skyway")]
			set; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/interface[@name='Renderer']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler:Com.Ntt.Skyway.Core.Content.Sink.IRendererInvoker, core_skyway")]
		void Dispose ();

	}

	[global::Android.Runtime.Register ("com/ntt/skyway/core/content/sink/Renderer", DoNotGenerateAcw=true)]
	internal partial class IRendererInvoker : global::Java.Lang.Object, IRenderer {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/content/sink/Renderer", typeof (IRendererInvoker));

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

		public static IRenderer? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRenderer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ntt.skyway.core.content.sink.Renderer'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRendererInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_isSetup;
#pragma warning disable 0169
		static Delegate GetIsSetupHandler ()
		{
			if (cb_isSetup == null)
				cb_isSetup = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsSetup);
			return cb_isSetup;
		}

		static bool n_IsSetup (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Sink.IRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Setup;
		}
#pragma warning restore 0169

		static Delegate? cb_setSetup_Z;
#pragma warning disable 0169
		static Delegate GetSetSetup_ZHandler ()
		{
			if (cb_setSetup_Z == null)
				cb_setSetup_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetSetup_Z);
			return cb_setSetup_Z;
		}

		static void n_SetSetup_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Sink.IRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Setup = p0;
		}
#pragma warning restore 0169

		IntPtr id_isSetup;
		IntPtr id_setSetup_Z;
		public unsafe bool Setup {
			get {
				if (id_isSetup == IntPtr.Zero)
					id_isSetup = JNIEnv.GetMethodID (class_ref, "isSetup", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSetup);
			}
			set {
				if (id_setSetup_Z == IntPtr.Zero)
					id_setSetup_Z = JNIEnv.GetMethodID (class_ref, "setSetup", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSetup_Z, __args);
			}
		}

		static Delegate? cb_dispose;
#pragma warning disable 0169
		static Delegate GetDisposeHandler ()
		{
			if (cb_dispose == null)
				cb_dispose = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Dispose);
			return cb_dispose;
		}

		static void n_Dispose (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Sink.IRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Dispose ();
		}
#pragma warning restore 0169

		IntPtr id_dispose;
		public unsafe void Dispose ()
		{
			if (id_dispose == IntPtr.Zero)
				id_dispose = JNIEnv.GetMethodID (class_ref, "dispose", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dispose);
		}

	}
}
