using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='EglBase10']"
	[Register ("org/webrtc/EglBase10", "", "Org.Webrtc.IEglBase10Invoker")]
	public partial interface IEglBase10 : global::Org.Webrtc.IEglBase {
		// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='EglBase10.Context']"
		[Register ("org/webrtc/EglBase10$Context", "", "Org.Webrtc.IEglBase10/IContextInvoker")]
		public partial interface IContext : global::Org.Webrtc.IEglBase.IContext {
			global::Javax.Microedition.Khronos.Egl.EGLContext? RawContext {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='EglBase10.Context']/method[@name='getRawContext' and count(parameter)=0]"
				[Register ("getRawContext", "()Ljavax/microedition/khronos/egl/EGLContext;", "GetGetRawContextHandler:Org.Webrtc.IEglBase10/IContextInvoker, webrtc")]
				get; 
			}

		}

		[global::Android.Runtime.Register ("org/webrtc/EglBase10$Context", DoNotGenerateAcw=true)]
		internal partial class IContextInvoker : global::Java.Lang.Object, IContext {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/EglBase10$Context", typeof (IContextInvoker));

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

			public static IContext? GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IContext> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.webrtc.EglBase10.Context'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IContextInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate? cb_getRawContext;
#pragma warning disable 0169
			static Delegate GetGetRawContextHandler ()
			{
				if (cb_getRawContext == null)
					cb_getRawContext = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRawContext);
				return cb_getRawContext;
			}

			static IntPtr n_GetRawContext (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBase10.IContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.RawContext);
			}
#pragma warning restore 0169

			IntPtr id_getRawContext;
			public unsafe global::Javax.Microedition.Khronos.Egl.EGLContext? RawContext {
				get {
					if (id_getRawContext == IntPtr.Zero)
						id_getRawContext = JNIEnv.GetMethodID (class_ref, "getRawContext", "()Ljavax/microedition/khronos/egl/EGLContext;");
					return global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Egl.EGLContext> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRawContext), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate? cb_getNativeEglContext;
#pragma warning disable 0169
			static Delegate GetGetNativeEglContextHandler ()
			{
				if (cb_getNativeEglContext == null)
					cb_getNativeEglContext = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetNativeEglContext);
				return cb_getNativeEglContext;
			}

			static long n_GetNativeEglContext (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBase10.IContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.NativeEglContext;
			}
#pragma warning restore 0169

			IntPtr id_getNativeEglContext;
			public unsafe long NativeEglContext {
				get {
					if (id_getNativeEglContext == IntPtr.Zero)
						id_getNativeEglContext = JNIEnv.GetMethodID (class_ref, "getNativeEglContext", "()J");
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getNativeEglContext);
				}
			}

		}

	}

	[global::Android.Runtime.Register ("org/webrtc/EglBase10", DoNotGenerateAcw=true)]
	internal partial class IEglBase10Invoker : global::Java.Lang.Object, IEglBase10 {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/EglBase10", typeof (IEglBase10Invoker));

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

		public static IEglBase10? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEglBase10> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.webrtc.EglBase10'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEglBase10Invoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getEglBaseContext;
#pragma warning disable 0169
		static Delegate GetGetEglBaseContextHandler ()
		{
			if (cb_getEglBaseContext == null)
				cb_getEglBaseContext = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetEglBaseContext);
			return cb_getEglBaseContext;
		}

		static IntPtr n_GetEglBaseContext (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBase10> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.EglBaseContext);
		}
#pragma warning restore 0169

		IntPtr id_getEglBaseContext;
		public unsafe global::Org.Webrtc.IEglBase.IContext? EglBaseContext {
			get {
				if (id_getEglBaseContext == IntPtr.Zero)
					id_getEglBaseContext = JNIEnv.GetMethodID (class_ref, "getEglBaseContext", "()Lorg/webrtc/EglBase$Context;");
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBase.IContext> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEglBaseContext), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_hasSurface;
#pragma warning disable 0169
		static Delegate GetHasSurfaceHandler ()
		{
			if (cb_hasSurface == null)
				cb_hasSurface = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasSurface);
			return cb_hasSurface;
		}

		static bool n_HasSurface (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBase10> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.HasSurface;
		}
#pragma warning restore 0169

		IntPtr id_hasSurface;
		public unsafe bool HasSurface {
			get {
				if (id_hasSurface == IntPtr.Zero)
					id_hasSurface = JNIEnv.GetMethodID (class_ref, "hasSurface", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasSurface);
			}
		}

		static Delegate? cb_createDummyPbufferSurface;
#pragma warning disable 0169
		static Delegate GetCreateDummyPbufferSurfaceHandler ()
		{
			if (cb_createDummyPbufferSurface == null)
				cb_createDummyPbufferSurface = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_CreateDummyPbufferSurface);
			return cb_createDummyPbufferSurface;
		}

		static void n_CreateDummyPbufferSurface (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBase10> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.CreateDummyPbufferSurface ();
		}
#pragma warning restore 0169

		IntPtr id_createDummyPbufferSurface;
		public unsafe void CreateDummyPbufferSurface ()
		{
			if (id_createDummyPbufferSurface == IntPtr.Zero)
				id_createDummyPbufferSurface = JNIEnv.GetMethodID (class_ref, "createDummyPbufferSurface", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createDummyPbufferSurface);
		}

		static Delegate? cb_createPbufferSurface_II;
#pragma warning disable 0169
		static Delegate GetCreatePbufferSurface_IIHandler ()
		{
			if (cb_createPbufferSurface_II == null)
				cb_createPbufferSurface_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_CreatePbufferSurface_II);
			return cb_createPbufferSurface_II;
		}

		static void n_CreatePbufferSurface_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBase10> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.CreatePbufferSurface (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_createPbufferSurface_II;
		public unsafe void CreatePbufferSurface (int p0, int p1)
		{
			if (id_createPbufferSurface_II == IntPtr.Zero)
				id_createPbufferSurface_II = JNIEnv.GetMethodID (class_ref, "createPbufferSurface", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createPbufferSurface_II, __args);
		}

		static Delegate? cb_createSurface_Landroid_graphics_SurfaceTexture_;
#pragma warning disable 0169
		static Delegate GetCreateSurface_Landroid_graphics_SurfaceTexture_Handler ()
		{
			if (cb_createSurface_Landroid_graphics_SurfaceTexture_ == null)
				cb_createSurface_Landroid_graphics_SurfaceTexture_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_CreateSurface_Landroid_graphics_SurfaceTexture_);
			return cb_createSurface_Landroid_graphics_SurfaceTexture_;
		}

		static void n_CreateSurface_Landroid_graphics_SurfaceTexture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBase10> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CreateSurface (p0);
		}
#pragma warning restore 0169

		IntPtr id_createSurface_Landroid_graphics_SurfaceTexture_;
		public unsafe void CreateSurface (global::Android.Graphics.SurfaceTexture? p0)
		{
			if (id_createSurface_Landroid_graphics_SurfaceTexture_ == IntPtr.Zero)
				id_createSurface_Landroid_graphics_SurfaceTexture_ = JNIEnv.GetMethodID (class_ref, "createSurface", "(Landroid/graphics/SurfaceTexture;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createSurface_Landroid_graphics_SurfaceTexture_, __args);
		}

		static Delegate? cb_createSurface_Landroid_view_Surface_;
#pragma warning disable 0169
		static Delegate GetCreateSurface_Landroid_view_Surface_Handler ()
		{
			if (cb_createSurface_Landroid_view_Surface_ == null)
				cb_createSurface_Landroid_view_Surface_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_CreateSurface_Landroid_view_Surface_);
			return cb_createSurface_Landroid_view_Surface_;
		}

		static void n_CreateSurface_Landroid_view_Surface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBase10> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.Surface> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CreateSurface (p0);
		}
#pragma warning restore 0169

		IntPtr id_createSurface_Landroid_view_Surface_;
		public unsafe void CreateSurface (global::Android.Views.Surface? p0)
		{
			if (id_createSurface_Landroid_view_Surface_ == IntPtr.Zero)
				id_createSurface_Landroid_view_Surface_ = JNIEnv.GetMethodID (class_ref, "createSurface", "(Landroid/view/Surface;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createSurface_Landroid_view_Surface_, __args);
		}

		static Delegate? cb_detachCurrent;
#pragma warning disable 0169
		static Delegate GetDetachCurrentHandler ()
		{
			if (cb_detachCurrent == null)
				cb_detachCurrent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_DetachCurrent);
			return cb_detachCurrent;
		}

		static void n_DetachCurrent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBase10> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.DetachCurrent ();
		}
#pragma warning restore 0169

		IntPtr id_detachCurrent;
		public unsafe void DetachCurrent ()
		{
			if (id_detachCurrent == IntPtr.Zero)
				id_detachCurrent = JNIEnv.GetMethodID (class_ref, "detachCurrent", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_detachCurrent);
		}

		static Delegate? cb_makeCurrent;
#pragma warning disable 0169
		static Delegate GetMakeCurrentHandler ()
		{
			if (cb_makeCurrent == null)
				cb_makeCurrent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_MakeCurrent);
			return cb_makeCurrent;
		}

		static void n_MakeCurrent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBase10> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.MakeCurrent ();
		}
#pragma warning restore 0169

		IntPtr id_makeCurrent;
		public unsafe void MakeCurrent ()
		{
			if (id_makeCurrent == IntPtr.Zero)
				id_makeCurrent = JNIEnv.GetMethodID (class_ref, "makeCurrent", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_makeCurrent);
		}

		static Delegate? cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBase10> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Release ();
		}
#pragma warning restore 0169

		IntPtr id_release;
		public unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release);
		}

		static Delegate? cb_releaseSurface;
#pragma warning disable 0169
		static Delegate GetReleaseSurfaceHandler ()
		{
			if (cb_releaseSurface == null)
				cb_releaseSurface = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ReleaseSurface);
			return cb_releaseSurface;
		}

		static void n_ReleaseSurface (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBase10> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.ReleaseSurface ();
		}
#pragma warning restore 0169

		IntPtr id_releaseSurface;
		public unsafe void ReleaseSurface ()
		{
			if (id_releaseSurface == IntPtr.Zero)
				id_releaseSurface = JNIEnv.GetMethodID (class_ref, "releaseSurface", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_releaseSurface);
		}

		static Delegate? cb_surfaceHeight;
#pragma warning disable 0169
		static Delegate GetSurfaceHeightHandler ()
		{
			if (cb_surfaceHeight == null)
				cb_surfaceHeight = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_SurfaceHeight);
			return cb_surfaceHeight;
		}

		static int n_SurfaceHeight (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBase10> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.SurfaceHeight ();
		}
#pragma warning restore 0169

		IntPtr id_surfaceHeight;
		public unsafe int SurfaceHeight ()
		{
			if (id_surfaceHeight == IntPtr.Zero)
				id_surfaceHeight = JNIEnv.GetMethodID (class_ref, "surfaceHeight", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_surfaceHeight);
		}

		static Delegate? cb_surfaceWidth;
#pragma warning disable 0169
		static Delegate GetSurfaceWidthHandler ()
		{
			if (cb_surfaceWidth == null)
				cb_surfaceWidth = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_SurfaceWidth);
			return cb_surfaceWidth;
		}

		static int n_SurfaceWidth (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBase10> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.SurfaceWidth ();
		}
#pragma warning restore 0169

		IntPtr id_surfaceWidth;
		public unsafe int SurfaceWidth ()
		{
			if (id_surfaceWidth == IntPtr.Zero)
				id_surfaceWidth = JNIEnv.GetMethodID (class_ref, "surfaceWidth", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_surfaceWidth);
		}

		static Delegate? cb_swapBuffers;
#pragma warning disable 0169
		static Delegate GetSwapBuffersHandler ()
		{
			if (cb_swapBuffers == null)
				cb_swapBuffers = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_SwapBuffers);
			return cb_swapBuffers;
		}

		static void n_SwapBuffers (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBase10> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.SwapBuffers ();
		}
#pragma warning restore 0169

		IntPtr id_swapBuffers;
		public unsafe void SwapBuffers ()
		{
			if (id_swapBuffers == IntPtr.Zero)
				id_swapBuffers = JNIEnv.GetMethodID (class_ref, "swapBuffers", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_swapBuffers);
		}

		static Delegate? cb_swapBuffers_J;
#pragma warning disable 0169
		static Delegate GetSwapBuffers_JHandler ()
		{
			if (cb_swapBuffers_J == null)
				cb_swapBuffers_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SwapBuffers_J);
			return cb_swapBuffers_J;
		}

		static void n_SwapBuffers_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBase10> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.SwapBuffers (p0);
		}
#pragma warning restore 0169

		IntPtr id_swapBuffers_J;
		public unsafe void SwapBuffers (long p0)
		{
			if (id_swapBuffers_J == IntPtr.Zero)
				id_swapBuffers_J = JNIEnv.GetMethodID (class_ref, "swapBuffers", "(J)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_swapBuffers_J, __args);
		}

	}
}
