using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	[Register ("org/webrtc/VideoFrameBufferType", DoNotGenerateAcw=true)]
	[global::System.Obsolete (@"Use the 'Org.Webrtc.IVideoFrameBufferType' type. This class will be removed in a future release.")]
	public abstract class VideoFrameBufferType : Java.Lang.Object {
		internal VideoFrameBufferType ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoFrameBufferType']/field[@name='I010']"
		[Register ("I010")]
		[global::System.Obsolete (@"Use 'Org.Webrtc.IVideoFrameBufferType.I010'. This class will be removed in a future release.")]
		public const int I010 = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoFrameBufferType']/field[@name='I420']"
		[Register ("I420")]
		[global::System.Obsolete (@"Use 'Org.Webrtc.IVideoFrameBufferType.I420'. This class will be removed in a future release.")]
		public const int I420 = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoFrameBufferType']/field[@name='I420A']"
		[Register ("I420A")]
		[global::System.Obsolete (@"Use 'Org.Webrtc.IVideoFrameBufferType.I420a'. This class will be removed in a future release.")]
		public const int I420a = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoFrameBufferType']/field[@name='I422']"
		[Register ("I422")]
		[global::System.Obsolete (@"Use 'Org.Webrtc.IVideoFrameBufferType.I422'. This class will be removed in a future release.")]
		public const int I422 = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoFrameBufferType']/field[@name='I444']"
		[Register ("I444")]
		[global::System.Obsolete (@"Use 'Org.Webrtc.IVideoFrameBufferType.I444'. This class will be removed in a future release.")]
		public const int I444 = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoFrameBufferType']/field[@name='NATIVE']"
		[Register ("NATIVE")]
		[global::System.Obsolete (@"Use 'Org.Webrtc.IVideoFrameBufferType.Native'. This class will be removed in a future release.")]
		public const int Native = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoFrameBufferType']/field[@name='NV12']"
		[Register ("NV12")]
		[global::System.Obsolete (@"Use 'Org.Webrtc.IVideoFrameBufferType.Nv12'. This class will be removed in a future release.")]
		public const int Nv12 = (int) 6;

		// The following are fields from: java.lang.annotation.Annotation

		// The following are fields from: Android.Runtime.IJavaObject

		// The following are fields from: System.IDisposable

		// The following are fields from: Java.Interop.IJavaPeerable

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoFrameBufferType']"
	[Register ("org/webrtc/VideoFrameBufferType", "", "Org.Webrtc.IVideoFrameBufferTypeInvoker")]
	public partial interface IVideoFrameBufferType : global::Java.Lang.Annotation.IAnnotation {
		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoFrameBufferType']/field[@name='I010']"
		[Register ("I010")]
		public const int I010 = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoFrameBufferType']/field[@name='I420']"
		[Register ("I420")]
		public const int I420 = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoFrameBufferType']/field[@name='I420A']"
		[Register ("I420A")]
		public const int I420a = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoFrameBufferType']/field[@name='I422']"
		[Register ("I422")]
		public const int I422 = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoFrameBufferType']/field[@name='I444']"
		[Register ("I444")]
		public const int I444 = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoFrameBufferType']/field[@name='NATIVE']"
		[Register ("NATIVE")]
		public const int Native = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoFrameBufferType']/field[@name='NV12']"
		[Register ("NV12")]
		public const int Nv12 = (int) 6;

	}

	[global::Android.Runtime.Register ("org/webrtc/VideoFrameBufferType", DoNotGenerateAcw=true)]
	internal partial class IVideoFrameBufferTypeInvoker : global::Java.Lang.Object, IVideoFrameBufferType {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoFrameBufferType", typeof (IVideoFrameBufferTypeInvoker));

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

		public static IVideoFrameBufferType? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoFrameBufferType> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.webrtc.VideoFrameBufferType'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoFrameBufferTypeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_annotationType;
#pragma warning disable 0169
		static Delegate GetAnnotationTypeHandler ()
		{
			if (cb_annotationType == null)
				cb_annotationType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AnnotationType);
			return cb_annotationType;
		}

		static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoFrameBufferType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
		}
#pragma warning restore 0169

		IntPtr id_annotationType;
		public unsafe global::Java.Lang.Class? AnnotationType ()
		{
			if (id_annotationType == IntPtr.Zero)
				id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate? cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetEquals_Ljava_lang_Object_Handler ()
		{
			if (cb_equals_Ljava_lang_Object_ == null)
				cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Equals_Ljava_lang_Object_);
			return cb_equals_Ljava_lang_Object_;
		}

		static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoFrameBufferType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (obj);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_equals_Ljava_lang_Object_;
		public unsafe bool Equals (global::Java.Lang.Object? obj)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
			return __ret;
		}

		static Delegate? cb_hashCode;
#pragma warning disable 0169
		static Delegate GetGetHashCodeHandler ()
		{
			if (cb_hashCode == null)
				cb_hashCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetHashCode);
			return cb_hashCode;
		}

		static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoFrameBufferType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.GetHashCode ();
		}
#pragma warning restore 0169

		IntPtr id_hashCode;
		public unsafe int GetHashCode ()
		{
			if (id_hashCode == IntPtr.Zero)
				id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
		}

		static Delegate? cb_toString;
#pragma warning disable 0169
		static Delegate GetToStringHandler ()
		{
			if (cb_toString == null)
				cb_toString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToString);
			return cb_toString;
		}

		static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoFrameBufferType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.ToString ());
		}
#pragma warning restore 0169

		IntPtr id_toString;
		public unsafe string? ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

	}
}
