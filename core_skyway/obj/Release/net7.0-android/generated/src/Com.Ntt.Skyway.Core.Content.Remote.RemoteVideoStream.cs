using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Core.Content.Remote {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.content.remote']/class[@name='RemoteVideoStream']"
	[global::Android.Runtime.Register ("com/ntt/skyway/core/content/remote/RemoteVideoStream", DoNotGenerateAcw=true)]
	public sealed partial class RemoteVideoStream : global::Com.Ntt.Skyway.Core.Content.Remote.RemoteStream {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/content/remote/RemoteVideoStream", typeof (RemoteVideoStream));

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

		internal RemoteVideoStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe global::Com.Ntt.Skyway.Core.Content.Stream.ContentType ContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.remote']/class[@name='RemoteVideoStream']/method[@name='getContentType' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.remote']/class[@name='RemoteVideoStream']/method[@name='addRenderer' and count(parameter)=1 and parameter[1][@type='com.ntt.skyway.core.content.sink.Renderer']]"
		[Register ("addRenderer", "(Lcom/ntt/skyway/core/content/sink/Renderer;)V", "")]
		public unsafe void AddRenderer (global::Com.Ntt.Skyway.Core.Content.Sink.IRenderer renderer)
		{
			const string __id = "addRenderer.(Lcom/ntt/skyway/core/content/sink/Renderer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((renderer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) renderer).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (renderer);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.remote']/class[@name='RemoteVideoStream']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "")]
		public override unsafe void Dispose ()
		{
			const string __id = "dispose.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.remote']/class[@name='RemoteVideoStream']/method[@name='removeAllRenderer' and count(parameter)=0]"
		[Register ("removeAllRenderer", "()V", "")]
		public unsafe void RemoveAllRenderer ()
		{
			const string __id = "removeAllRenderer.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.remote']/class[@name='RemoteVideoStream']/method[@name='removeRenderer' and count(parameter)=1 and parameter[1][@type='com.ntt.skyway.core.content.sink.Renderer']]"
		[Register ("removeRenderer", "(Lcom/ntt/skyway/core/content/sink/Renderer;)V", "")]
		public unsafe void RemoveRenderer (global::Com.Ntt.Skyway.Core.Content.Sink.IRenderer renderer)
		{
			const string __id = "removeRenderer.(Lcom/ntt/skyway/core/content/sink/Renderer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((renderer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) renderer).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (renderer);
			}
		}

	}
}
