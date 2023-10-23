using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Core.Content.Local {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.content.local']/class[@name='LocalDataStream']"
	[global::Android.Runtime.Register ("com/ntt/skyway/core/content/local/LocalDataStream", DoNotGenerateAcw=true)]
	public sealed partial class LocalDataStream : global::Com.Ntt.Skyway.Core.Content.Local.LocalStream {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/content/local/LocalDataStream", typeof (LocalDataStream));

		internal static new IntPtr class_ref {
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

		internal LocalDataStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe global::Com.Ntt.Skyway.Core.Content.Stream.ContentType ContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.local']/class[@name='LocalDataStream']/method[@name='getContentType' and count(parameter)=0]"
			[Register ("getContentType", "()Lcom/ntt/skyway/core/content/Stream$ContentType;", "")]
			get {
				const string __id = "getContentType.()Lcom/ntt/skyway/core/content/Stream$ContentType;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Stream.ContentType> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.local']/class[@name='LocalDataStream']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "")]
		public override unsafe void Dispose ()
		{
			const string __id = "dispose.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.local']/class[@name='LocalDataStream']/method[@name='write' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("write", "([B)V", "")]
		public unsafe void Write (byte[] data)
		{
			const string __id = "write.([B)V";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.local']/class[@name='LocalDataStream']/method[@name='write' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("write", "(Ljava/lang/String;)V", "")]
		public unsafe void Write (string data)
		{
			const string __id = "write.(Ljava/lang/String;)V";
			IntPtr native_data = JNIEnv.NewString ((string?)data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

	}
}
