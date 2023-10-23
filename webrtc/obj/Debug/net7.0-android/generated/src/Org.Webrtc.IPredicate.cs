using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='Predicate']"
	[Register ("org/webrtc/Predicate", "", "Org.Webrtc.IPredicateInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IPredicate : IJavaObject, IJavaPeerable {
		private static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/Predicate", typeof (IPredicate), isInterface: true);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='Predicate']/method[@name='test' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("test", "(Ljava/lang/Object;)Z", "GetTest_Ljava_lang_Object_Handler:Org.Webrtc.IPredicateInvoker, webrtc")]
		bool Test (global::Java.Lang.Object? p0);

		private static Delegate? cb_and_Lorg_webrtc_Predicate_;
#pragma warning disable 0169
		private static Delegate GetAnd_Lorg_webrtc_Predicate_Handler ()
		{
			if (cb_and_Lorg_webrtc_Predicate_ == null)
				cb_and_Lorg_webrtc_Predicate_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_And_Lorg_webrtc_Predicate_);
			return cb_and_Lorg_webrtc_Predicate_;
		}

		private static IntPtr n_And_Lorg_webrtc_Predicate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IPredicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var other = (global::Org.Webrtc.IPredicate?)global::Java.Lang.Object.GetObject<global::Org.Webrtc.IPredicate> (native_other, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.And (other));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='Predicate']/method[@name='and' and count(parameter)=1 and parameter[1][@type='org.webrtc.Predicate&lt;? super T&gt;']]"
		[Register ("and", "(Lorg/webrtc/Predicate;)Lorg/webrtc/Predicate;", "GetAnd_Lorg_webrtc_Predicate_Handler:Org.Webrtc.IPredicate, webrtc")]
		virtual unsafe global::Org.Webrtc.IPredicate? And (global::Org.Webrtc.IPredicate? other)
		{
			const string __id = "and.(Lorg/webrtc/Predicate;)Lorg/webrtc/Predicate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.IPredicate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (other);
			}
		}

		private static Delegate? cb_negate;
#pragma warning disable 0169
		private static Delegate GetNegateHandler ()
		{
			if (cb_negate == null)
				cb_negate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Negate);
			return cb_negate;
		}

		private static IntPtr n_Negate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IPredicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Negate ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='Predicate']/method[@name='negate' and count(parameter)=0]"
		[Register ("negate", "()Lorg/webrtc/Predicate;", "GetNegateHandler:Org.Webrtc.IPredicate, webrtc")]
		virtual unsafe global::Org.Webrtc.IPredicate? Negate ()
		{
			const string __id = "negate.()Lorg/webrtc/Predicate;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.IPredicate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		private static Delegate? cb_or_Lorg_webrtc_Predicate_;
#pragma warning disable 0169
		private static Delegate GetOr_Lorg_webrtc_Predicate_Handler ()
		{
			if (cb_or_Lorg_webrtc_Predicate_ == null)
				cb_or_Lorg_webrtc_Predicate_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Or_Lorg_webrtc_Predicate_);
			return cb_or_Lorg_webrtc_Predicate_;
		}

		private static IntPtr n_Or_Lorg_webrtc_Predicate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IPredicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var other = (global::Org.Webrtc.IPredicate?)global::Java.Lang.Object.GetObject<global::Org.Webrtc.IPredicate> (native_other, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Or (other));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='Predicate']/method[@name='or' and count(parameter)=1 and parameter[1][@type='org.webrtc.Predicate&lt;? super T&gt;']]"
		[Register ("or", "(Lorg/webrtc/Predicate;)Lorg/webrtc/Predicate;", "GetOr_Lorg_webrtc_Predicate_Handler:Org.Webrtc.IPredicate, webrtc")]
		virtual unsafe global::Org.Webrtc.IPredicate? Or (global::Org.Webrtc.IPredicate? other)
		{
			const string __id = "or.(Lorg/webrtc/Predicate;)Lorg/webrtc/Predicate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.IPredicate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (other);
			}
		}

	}

	[global::Android.Runtime.Register ("org/webrtc/Predicate", DoNotGenerateAcw=true)]
	internal partial class IPredicateInvoker : global::Java.Lang.Object, IPredicate {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/Predicate", typeof (IPredicateInvoker));

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

		public static IPredicate? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPredicate> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.webrtc.Predicate'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPredicateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_test_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetTest_Ljava_lang_Object_Handler ()
		{
			if (cb_test_Ljava_lang_Object_ == null)
				cb_test_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Test_Ljava_lang_Object_);
			return cb_test_Ljava_lang_Object_;
		}

		static bool n_Test_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IPredicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Test (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_test_Ljava_lang_Object_;
		public unsafe bool Test (global::Java.Lang.Object? p0)
		{
			if (id_test_Ljava_lang_Object_ == IntPtr.Zero)
				id_test_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "test", "(Ljava/lang/Object;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_test_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
