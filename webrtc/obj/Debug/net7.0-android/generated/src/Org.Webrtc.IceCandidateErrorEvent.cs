using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='IceCandidateErrorEvent']"
	[global::Android.Runtime.Register ("org/webrtc/IceCandidateErrorEvent", DoNotGenerateAcw=true)]
	public sealed partial class IceCandidateErrorEvent : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='IceCandidateErrorEvent']/field[@name='address']"
		[Register ("address")]
		public string? Address {
			get {
				const string __id = "address.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "address.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='IceCandidateErrorEvent']/field[@name='errorCode']"
		[Register ("errorCode")]
		public int ErrorCode {
			get {
				const string __id = "errorCode.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "errorCode.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='IceCandidateErrorEvent']/field[@name='errorText']"
		[Register ("errorText")]
		public string? ErrorText {
			get {
				const string __id = "errorText.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "errorText.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='IceCandidateErrorEvent']/field[@name='port']"
		[Register ("port")]
		public int Port {
			get {
				const string __id = "port.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "port.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='IceCandidateErrorEvent']/field[@name='url']"
		[Register ("url")]
		public string? Url {
			get {
				const string __id = "url.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "url.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/IceCandidateErrorEvent", typeof (IceCandidateErrorEvent));

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

		internal IceCandidateErrorEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='IceCandidateErrorEvent']/constructor[@name='IceCandidateErrorEvent' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;ILjava/lang/String;ILjava/lang/String;)V", "")]
		public unsafe IceCandidateErrorEvent (string? address, int port, string? url, int errorCode, string? errorText) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;ILjava/lang/String;ILjava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_address = JNIEnv.NewString ((string?)address);
			IntPtr native_url = JNIEnv.NewString ((string?)url);
			IntPtr native_errorText = JNIEnv.NewString ((string?)errorText);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_address);
				__args [1] = new JniArgumentValue (port);
				__args [2] = new JniArgumentValue (native_url);
				__args [3] = new JniArgumentValue (errorCode);
				__args [4] = new JniArgumentValue (native_errorText);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_address);
				JNIEnv.DeleteLocalRef (native_url);
				JNIEnv.DeleteLocalRef (native_errorText);
			}
		}

	}
}
