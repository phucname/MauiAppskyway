using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='GlUtil']"
	[global::Android.Runtime.Register ("org/webrtc/GlUtil", DoNotGenerateAcw=true)]
	public partial class GlUtil : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='GlUtil.GlOutOfMemoryException']"
		[global::Android.Runtime.Register ("org/webrtc/GlUtil$GlOutOfMemoryException", DoNotGenerateAcw=true)]
		public partial class GlOutOfMemoryException : global::Android.Opengl.GLException {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/GlUtil$GlOutOfMemoryException", typeof (GlOutOfMemoryException));

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

			protected GlOutOfMemoryException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='GlUtil.GlOutOfMemoryException']/constructor[@name='GlUtil.GlOutOfMemoryException' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
			[Register (".ctor", "(ILjava/lang/String;)V", "")]
			public unsafe GlOutOfMemoryException (int error, string? msg) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(ILjava/lang/String;)V";

				if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_msg = JNIEnv.NewString ((string?)msg);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (error);
					__args [1] = new JniArgumentValue (native_msg);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_msg);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/GlUtil", typeof (GlUtil));

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

		protected GlUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='GlUtil']/method[@name='checkNoGLES2Error' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("checkNoGLES2Error", "(Ljava/lang/String;)V", "")]
		public static unsafe void CheckNoGLES2Error (string? msg)
		{
			const string __id = "checkNoGLES2Error.(Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString ((string?)msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_msg);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='GlUtil']/method[@name='createFloatBuffer' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("createFloatBuffer", "([F)Ljava/nio/FloatBuffer;", "")]
		public static unsafe global::Java.Nio.FloatBuffer? CreateFloatBuffer (float[]? coords)
		{
			const string __id = "createFloatBuffer.([F)Ljava/nio/FloatBuffer;";
			IntPtr native_coords = JNIEnv.NewArray (coords);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_coords);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.FloatBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (coords != null) {
					JNIEnv.CopyArray (native_coords, coords);
					JNIEnv.DeleteLocalRef (native_coords);
				}
				global::System.GC.KeepAlive (coords);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='GlUtil']/method[@name='generateTexture' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("generateTexture", "(I)I", "")]
		public static unsafe int GenerateTexture (int target)
		{
			const string __id = "generateTexture.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (target);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
