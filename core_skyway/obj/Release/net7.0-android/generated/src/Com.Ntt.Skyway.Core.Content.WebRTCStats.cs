using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Core.Content {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.content']/class[@name='WebRTCStats']"
	[global::Android.Runtime.Register ("com/ntt/skyway/core/content/WebRTCStats", DoNotGenerateAcw=true)]
	public sealed partial class WebRTCStats : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/content/WebRTCStats", typeof (WebRTCStats));

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

		internal WebRTCStats (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core.content']/class[@name='WebRTCStats']/constructor[@name='WebRTCStats' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.ntt.skyway.core.content.WebRTCStatsReport&gt;']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		public unsafe WebRTCStats (global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Content.WebRTCStatsReport> reports) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_reports = global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Content.WebRTCStatsReport>.ToLocalJniHandle (reports);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_reports);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_reports);
				global::System.GC.KeepAlive (reports);
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Content.WebRTCStatsReport> Reports {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content']/class[@name='WebRTCStats']/method[@name='getReports' and count(parameter)=0]"
			[Register ("getReports", "()Ljava/util/List;", "")]
			get {
				const string __id = "getReports.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Content.WebRTCStatsReport>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content']/class[@name='WebRTCStats']/method[@name='component1' and count(parameter)=0]"
		[Register ("component1", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Content.WebRTCStatsReport> Component1 ()
		{
			const string __id = "component1.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Content.WebRTCStatsReport>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content']/class[@name='WebRTCStats']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.ntt.skyway.core.content.WebRTCStatsReport&gt;']]"
		[Register ("copy", "(Ljava/util/List;)Lcom/ntt/skyway/core/content/WebRTCStats;", "")]
		public unsafe global::Com.Ntt.Skyway.Core.Content.WebRTCStats Copy (global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Content.WebRTCStatsReport> reports)
		{
			const string __id = "copy.(Ljava/util/List;)Lcom/ntt/skyway/core/content/WebRTCStats;";
			IntPtr native_reports = global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Content.WebRTCStatsReport>.ToLocalJniHandle (reports);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_reports);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.WebRTCStats> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
				JNIEnv.DeleteLocalRef (native_reports);
				global::System.GC.KeepAlive (reports);
			}
		}

	}
}
