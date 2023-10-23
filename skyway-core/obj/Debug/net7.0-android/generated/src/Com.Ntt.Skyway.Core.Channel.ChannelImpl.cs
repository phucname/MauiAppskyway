using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Core.Channel {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']"
	[global::Android.Runtime.Register ("com/ntt/skyway/core/channel/ChannelImpl", DoNotGenerateAcw=true)]
	public sealed partial class ChannelImpl : global::Java.Lang.Object, global::Com.Ntt.Skyway.Core.Channel.IChannel {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl.Companion']"
		[global::Android.Runtime.Register ("com/ntt/skyway/core/channel/ChannelImpl$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/ChannelImpl$Companion", typeof (Companion));

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

			internal Companion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl.Companion']/constructor[@name='ChannelImpl.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
			[Register (".ctor", "(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", "")]
			public unsafe Companion (global::Kotlin.Jvm.Internal.DefaultConstructorMarker? _constructor_marker) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lkotlin/jvm/internal/DefaultConstructorMarker;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((_constructor_marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _constructor_marker).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (_constructor_marker);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl.Companion']/method[@name='create' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='kotlin.coroutines.Continuation&lt;? super com.ntt.skyway.core.channel.Channel&gt;']]"
			[Register ("create", "(Ljava/lang/String;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
			public unsafe global::Java.Lang.Object? Create (string? name, string? metadata, global::Kotlin.Coroutines.IContinuation _completion)
			{
				const string __id = "create.(Ljava/lang/String;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
				IntPtr native_name = JNIEnv.NewString ((string?)name);
				IntPtr native_metadata = JNIEnv.NewString ((string?)metadata);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_name);
					__args [1] = new JniArgumentValue (native_metadata);
					__args [2] = new JniArgumentValue ((_completion == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _completion).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_metadata);
					global::System.GC.KeepAlive (_completion);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl.Companion']/method[@name='find' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='kotlin.coroutines.Continuation&lt;? super com.ntt.skyway.core.channel.Channel&gt;']]"
			[Register ("find", "(Ljava/lang/String;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
			public unsafe global::Java.Lang.Object? Find (string? name, string? id, global::Kotlin.Coroutines.IContinuation _completion)
			{
				const string __id = "find.(Ljava/lang/String;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
				IntPtr native_name = JNIEnv.NewString ((string?)name);
				IntPtr native_id = JNIEnv.NewString ((string?)id);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_name);
					__args [1] = new JniArgumentValue (native_id);
					__args [2] = new JniArgumentValue ((_completion == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _completion).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_id);
					global::System.GC.KeepAlive (_completion);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl.Companion']/method[@name='findOrCreate' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='kotlin.coroutines.Continuation&lt;? super com.ntt.skyway.core.channel.Channel&gt;']]"
			[Register ("findOrCreate", "(Ljava/lang/String;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
			public unsafe global::Java.Lang.Object? FindOrCreate (string? name, string? metadata, global::Kotlin.Coroutines.IContinuation _completion)
			{
				const string __id = "findOrCreate.(Ljava/lang/String;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
				IntPtr native_name = JNIEnv.NewString ((string?)name);
				IntPtr native_metadata = JNIEnv.NewString ((string?)metadata);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_name);
					__args [1] = new JniArgumentValue (native_metadata);
					__args [2] = new JniArgumentValue ((_completion == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _completion).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_metadata);
					global::System.GC.KeepAlive (_completion);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/ChannelImpl", typeof (ChannelImpl));

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

		internal ChannelImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe global::System.Collections.Generic.ICollection<global::Com.Ntt.Skyway.Core.Channel.Member.IMember> Bots {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='getBots' and count(parameter)=0]"
			[Register ("getBots", "()Ljava/util/Set;", "")]
			get {
				const string __id = "getBots.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<global::Com.Ntt.Skyway.Core.Channel.Member.IMember>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson? LocalPerson {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='getLocalPerson' and count(parameter)=0]"
			[Register ("getLocalPerson", "()Lcom/ntt/skyway/core/channel/member/LocalPerson;", "")]
			get {
				const string __id = "getLocalPerson.()Lcom/ntt/skyway/core/channel/member/LocalPerson;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.ICollection<global::Com.Ntt.Skyway.Core.Channel.Member.IMember> Members {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='getMembers' and count(parameter)=0]"
			[Register ("getMembers", "()Ljava/util/Set;", "")]
			get {
				const string __id = "getMembers.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<global::Com.Ntt.Skyway.Core.Channel.Member.IMember>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe string Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='getMetadata' and count(parameter)=0]"
			[Register ("getMetadata", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getMetadata.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe long NativePointer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='getNativePointer' and count(parameter)=0]"
			[Register ("getNativePointer", "()J", "")]
			get {
				const string __id = "getNativePointer.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Kotlin.Jvm.Functions.IFunction0? OnClosedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='getOnClosedHandler' and count(parameter)=0]"
			[Register ("getOnClosedHandler", "()Lkotlin/jvm/functions/Function0;", "")]
			get {
				const string __id = "getOnClosedHandler.()Lkotlin/jvm/functions/Function0;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction0> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='setOnClosedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function0&lt;kotlin.Unit&gt;']]"
			[Register ("setOnClosedHandler", "(Lkotlin/jvm/functions/Function0;)V", "")]
			set {
				const string __id = "setOnClosedHandler.(Lkotlin/jvm/functions/Function0;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Kotlin.Jvm.Functions.IFunction1? OnErrorHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='getOnErrorHandler' and count(parameter)=0]"
			[Register ("getOnErrorHandler", "()Lkotlin/jvm/functions/Function1;", "")]
			get {
				const string __id = "getOnErrorHandler.()Lkotlin/jvm/functions/Function1;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='setOnErrorHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super java.lang.Exception, kotlin.Unit&gt;']]"
			[Register ("setOnErrorHandler", "(Lkotlin/jvm/functions/Function1;)V", "")]
			set {
				const string __id = "setOnErrorHandler.(Lkotlin/jvm/functions/Function1;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Kotlin.Jvm.Functions.IFunction1? OnMemberJoinedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='getOnMemberJoinedHandler' and count(parameter)=0]"
			[Register ("getOnMemberJoinedHandler", "()Lkotlin/jvm/functions/Function1;", "")]
			get {
				const string __id = "getOnMemberJoinedHandler.()Lkotlin/jvm/functions/Function1;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='setOnMemberJoinedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super com.ntt.skyway.core.channel.member.Member, kotlin.Unit&gt;']]"
			[Register ("setOnMemberJoinedHandler", "(Lkotlin/jvm/functions/Function1;)V", "")]
			set {
				const string __id = "setOnMemberJoinedHandler.(Lkotlin/jvm/functions/Function1;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Kotlin.Jvm.Functions.IFunction1? OnMemberLeftHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='getOnMemberLeftHandler' and count(parameter)=0]"
			[Register ("getOnMemberLeftHandler", "()Lkotlin/jvm/functions/Function1;", "")]
			get {
				const string __id = "getOnMemberLeftHandler.()Lkotlin/jvm/functions/Function1;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='setOnMemberLeftHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super com.ntt.skyway.core.channel.member.Member, kotlin.Unit&gt;']]"
			[Register ("setOnMemberLeftHandler", "(Lkotlin/jvm/functions/Function1;)V", "")]
			set {
				const string __id = "setOnMemberLeftHandler.(Lkotlin/jvm/functions/Function1;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Kotlin.Jvm.Functions.IFunction0? OnMemberListChangedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='getOnMemberListChangedHandler' and count(parameter)=0]"
			[Register ("getOnMemberListChangedHandler", "()Lkotlin/jvm/functions/Function0;", "")]
			get {
				const string __id = "getOnMemberListChangedHandler.()Lkotlin/jvm/functions/Function0;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction0> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='setOnMemberListChangedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function0&lt;kotlin.Unit&gt;']]"
			[Register ("setOnMemberListChangedHandler", "(Lkotlin/jvm/functions/Function0;)V", "")]
			set {
				const string __id = "setOnMemberListChangedHandler.(Lkotlin/jvm/functions/Function0;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Kotlin.Jvm.Functions.IFunction2? OnMemberMetadataUpdatedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='getOnMemberMetadataUpdatedHandler' and count(parameter)=0]"
			[Register ("getOnMemberMetadataUpdatedHandler", "()Lkotlin/jvm/functions/Function2;", "")]
			get {
				const string __id = "getOnMemberMetadataUpdatedHandler.()Lkotlin/jvm/functions/Function2;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction2> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='setOnMemberMetadataUpdatedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function2&lt;? super com.ntt.skyway.core.channel.member.Member, ? super java.lang.String, kotlin.Unit&gt;']]"
			[Register ("setOnMemberMetadataUpdatedHandler", "(Lkotlin/jvm/functions/Function2;)V", "")]
			set {
				const string __id = "setOnMemberMetadataUpdatedHandler.(Lkotlin/jvm/functions/Function2;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Kotlin.Jvm.Functions.IFunction1? OnMetadataUpdatedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='getOnMetadataUpdatedHandler' and count(parameter)=0]"
			[Register ("getOnMetadataUpdatedHandler", "()Lkotlin/jvm/functions/Function1;", "")]
			get {
				const string __id = "getOnMetadataUpdatedHandler.()Lkotlin/jvm/functions/Function1;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='setOnMetadataUpdatedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super java.lang.String, kotlin.Unit&gt;']]"
			[Register ("setOnMetadataUpdatedHandler", "(Lkotlin/jvm/functions/Function1;)V", "")]
			set {
				const string __id = "setOnMetadataUpdatedHandler.(Lkotlin/jvm/functions/Function1;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Kotlin.Jvm.Functions.IFunction1? OnPublicationDisabledHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='getOnPublicationDisabledHandler' and count(parameter)=0]"
			[Register ("getOnPublicationDisabledHandler", "()Lkotlin/jvm/functions/Function1;", "")]
			get {
				const string __id = "getOnPublicationDisabledHandler.()Lkotlin/jvm/functions/Function1;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='setOnPublicationDisabledHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super com.ntt.skyway.core.channel.Publication, kotlin.Unit&gt;']]"
			[Register ("setOnPublicationDisabledHandler", "(Lkotlin/jvm/functions/Function1;)V", "")]
			set {
				const string __id = "setOnPublicationDisabledHandler.(Lkotlin/jvm/functions/Function1;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Kotlin.Jvm.Functions.IFunction1? OnPublicationEnabledHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='getOnPublicationEnabledHandler' and count(parameter)=0]"
			[Register ("getOnPublicationEnabledHandler", "()Lkotlin/jvm/functions/Function1;", "")]
			get {
				const string __id = "getOnPublicationEnabledHandler.()Lkotlin/jvm/functions/Function1;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='setOnPublicationEnabledHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super com.ntt.skyway.core.channel.Publication, kotlin.Unit&gt;']]"
			[Register ("setOnPublicationEnabledHandler", "(Lkotlin/jvm/functions/Function1;)V", "")]
			set {
				const string __id = "setOnPublicationEnabledHandler.(Lkotlin/jvm/functions/Function1;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Kotlin.Jvm.Functions.IFunction0? OnPublicationListChangedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='getOnPublicationListChangedHandler' and count(parameter)=0]"
			[Register ("getOnPublicationListChangedHandler", "()Lkotlin/jvm/functions/Function0;", "")]
			get {
				const string __id = "getOnPublicationListChangedHandler.()Lkotlin/jvm/functions/Function0;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction0> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='setOnPublicationListChangedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function0&lt;kotlin.Unit&gt;']]"
			[Register ("setOnPublicationListChangedHandler", "(Lkotlin/jvm/functions/Function0;)V", "")]
			set {
				const string __id = "setOnPublicationListChangedHandler.(Lkotlin/jvm/functions/Function0;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Kotlin.Jvm.Functions.IFunction2? OnPublicationMetadataUpdatedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='getOnPublicationMetadataUpdatedHandler' and count(parameter)=0]"
			[Register ("getOnPublicationMetadataUpdatedHandler", "()Lkotlin/jvm/functions/Function2;", "")]
			get {
				const string __id = "getOnPublicationMetadataUpdatedHandler.()Lkotlin/jvm/functions/Function2;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction2> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='setOnPublicationMetadataUpdatedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function2&lt;? super com.ntt.skyway.core.channel.Publication, ? super java.lang.String, kotlin.Unit&gt;']]"
			[Register ("setOnPublicationMetadataUpdatedHandler", "(Lkotlin/jvm/functions/Function2;)V", "")]
			set {
				const string __id = "setOnPublicationMetadataUpdatedHandler.(Lkotlin/jvm/functions/Function2;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Kotlin.Jvm.Functions.IFunction1? OnPublicationSubscribedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='getOnPublicationSubscribedHandler' and count(parameter)=0]"
			[Register ("getOnPublicationSubscribedHandler", "()Lkotlin/jvm/functions/Function1;", "")]
			get {
				const string __id = "getOnPublicationSubscribedHandler.()Lkotlin/jvm/functions/Function1;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='setOnPublicationSubscribedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super com.ntt.skyway.core.channel.Subscription, kotlin.Unit&gt;']]"
			[Register ("setOnPublicationSubscribedHandler", "(Lkotlin/jvm/functions/Function1;)V", "")]
			set {
				const string __id = "setOnPublicationSubscribedHandler.(Lkotlin/jvm/functions/Function1;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Kotlin.Jvm.Functions.IFunction1? OnPublicationUnsubscribedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='getOnPublicationUnsubscribedHandler' and count(parameter)=0]"
			[Register ("getOnPublicationUnsubscribedHandler", "()Lkotlin/jvm/functions/Function1;", "")]
			get {
				const string __id = "getOnPublicationUnsubscribedHandler.()Lkotlin/jvm/functions/Function1;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='setOnPublicationUnsubscribedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super com.ntt.skyway.core.channel.Subscription, kotlin.Unit&gt;']]"
			[Register ("setOnPublicationUnsubscribedHandler", "(Lkotlin/jvm/functions/Function1;)V", "")]
			set {
				const string __id = "setOnPublicationUnsubscribedHandler.(Lkotlin/jvm/functions/Function1;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Kotlin.Jvm.Functions.IFunction1? OnStreamPublishedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='getOnStreamPublishedHandler' and count(parameter)=0]"
			[Register ("getOnStreamPublishedHandler", "()Lkotlin/jvm/functions/Function1;", "")]
			get {
				const string __id = "getOnStreamPublishedHandler.()Lkotlin/jvm/functions/Function1;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='setOnStreamPublishedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super com.ntt.skyway.core.channel.Publication, kotlin.Unit&gt;']]"
			[Register ("setOnStreamPublishedHandler", "(Lkotlin/jvm/functions/Function1;)V", "")]
			set {
				const string __id = "setOnStreamPublishedHandler.(Lkotlin/jvm/functions/Function1;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Kotlin.Jvm.Functions.IFunction1? OnStreamUnpublishedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='getOnStreamUnpublishedHandler' and count(parameter)=0]"
			[Register ("getOnStreamUnpublishedHandler", "()Lkotlin/jvm/functions/Function1;", "")]
			get {
				const string __id = "getOnStreamUnpublishedHandler.()Lkotlin/jvm/functions/Function1;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='setOnStreamUnpublishedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super com.ntt.skyway.core.channel.Publication, kotlin.Unit&gt;']]"
			[Register ("setOnStreamUnpublishedHandler", "(Lkotlin/jvm/functions/Function1;)V", "")]
			set {
				const string __id = "setOnStreamUnpublishedHandler.(Lkotlin/jvm/functions/Function1;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Kotlin.Jvm.Functions.IFunction0? OnSubscriptionListChangedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='getOnSubscriptionListChangedHandler' and count(parameter)=0]"
			[Register ("getOnSubscriptionListChangedHandler", "()Lkotlin/jvm/functions/Function0;", "")]
			get {
				const string __id = "getOnSubscriptionListChangedHandler.()Lkotlin/jvm/functions/Function0;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction0> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='setOnSubscriptionListChangedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function0&lt;kotlin.Unit&gt;']]"
			[Register ("setOnSubscriptionListChangedHandler", "(Lkotlin/jvm/functions/Function0;)V", "")]
			set {
				const string __id = "setOnSubscriptionListChangedHandler.(Lkotlin/jvm/functions/Function0;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::System.Collections.Generic.ICollection<global::Com.Ntt.Skyway.Core.Channel.IPublication> Publications {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='getPublications' and count(parameter)=0]"
			[Register ("getPublications", "()Ljava/util/Set;", "")]
			get {
				const string __id = "getPublications.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<global::Com.Ntt.Skyway.Core.Channel.IPublication>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe global::Com.Ntt.Skyway.Core.Channel.Repository Repository {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='getRepository' and count(parameter)=0]"
			[Register ("getRepository", "()Lcom/ntt/skyway/core/channel/Repository;", "")]
			get {
				const string __id = "getRepository.()Lcom/ntt/skyway/core/channel/Repository;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Repository> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe global::Com.Ntt.Skyway.Core.Channel.IChannel.State State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()Lcom/ntt/skyway/core/channel/Channel$State;", "")]
			get {
				const string __id = "getState.()Lcom/ntt/skyway/core/channel/Channel$State;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel.State> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.ICollection<global::Com.Ntt.Skyway.Core.Channel.ISubscription> Subscriptions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='getSubscriptions' and count(parameter)=0]"
			[Register ("getSubscriptions", "()Ljava/util/Set;", "")]
			get {
				const string __id = "getSubscriptions.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<global::Com.Ntt.Skyway.Core.Channel.ISubscription>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='close' and count(parameter)=1 and parameter[1][@type='kotlin.coroutines.Continuation&lt;? super java.lang.Boolean&gt;']]"
		[Register ("close", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object? Close (global::Kotlin.Coroutines.IContinuation _completion)
		{
			const string __id = "close.(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((_completion == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _completion).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (_completion);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='create' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='kotlin.coroutines.Continuation&lt;? super com.ntt.skyway.core.channel.Channel&gt;']]"
		[Register ("create", "(Ljava/lang/String;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object? Create (string? name, string? metadata, global::Kotlin.Coroutines.IContinuation _completion)
		{
			const string __id = "create.(Ljava/lang/String;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
			IntPtr native_name = JNIEnv.NewString ((string?)name);
			IntPtr native_metadata = JNIEnv.NewString ((string?)metadata);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_metadata);
				__args [2] = new JniArgumentValue ((_completion == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _completion).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_metadata);
				global::System.GC.KeepAlive (_completion);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "")]
		public unsafe void Dispose ()
		{
			const string __id = "dispose.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='find' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='kotlin.coroutines.Continuation&lt;? super com.ntt.skyway.core.channel.Channel&gt;']]"
		[Register ("find", "(Ljava/lang/String;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object? Find (string? name, string? id, global::Kotlin.Coroutines.IContinuation _completion)
		{
			const string __id = "find.(Ljava/lang/String;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
			IntPtr native_name = JNIEnv.NewString ((string?)name);
			IntPtr native_id = JNIEnv.NewString ((string?)id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_id);
				__args [2] = new JniArgumentValue ((_completion == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _completion).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_id);
				global::System.GC.KeepAlive (_completion);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='findOrCreate' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='kotlin.coroutines.Continuation&lt;? super com.ntt.skyway.core.channel.Channel&gt;']]"
		[Register ("findOrCreate", "(Ljava/lang/String;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object? FindOrCreate (string? name, string? metadata, global::Kotlin.Coroutines.IContinuation _completion)
		{
			const string __id = "findOrCreate.(Ljava/lang/String;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
			IntPtr native_name = JNIEnv.NewString ((string?)name);
			IntPtr native_metadata = JNIEnv.NewString ((string?)metadata);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_metadata);
				__args [2] = new JniArgumentValue ((_completion == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _completion).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_metadata);
				global::System.GC.KeepAlive (_completion);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='join' and count(parameter)=2 and parameter[1][@type='com.ntt.skyway.core.channel.member.Member.Init'] and parameter[2][@type='kotlin.coroutines.Continuation&lt;? super com.ntt.skyway.core.channel.member.LocalPerson&gt;']]"
		[Register ("join", "(Lcom/ntt/skyway/core/channel/member/Member$Init;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object? Join (global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Init memberInit, global::Kotlin.Coroutines.IContinuation _completion)
		{
			const string __id = "join.(Lcom/ntt/skyway/core/channel/member/Member$Init;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((memberInit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) memberInit).Handle);
				__args [1] = new JniArgumentValue ((_completion == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _completion).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (memberInit);
				global::System.GC.KeepAlive (_completion);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='leave' and count(parameter)=2 and parameter[1][@type='com.ntt.skyway.core.channel.member.Member'] and parameter[2][@type='kotlin.coroutines.Continuation&lt;? super java.lang.Boolean&gt;']]"
		[Register ("leave", "(Lcom/ntt/skyway/core/channel/member/Member;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object? Leave (global::Com.Ntt.Skyway.Core.Channel.Member.IMember member, global::Kotlin.Coroutines.IContinuation _completion)
		{
			const string __id = "leave.(Lcom/ntt/skyway/core/channel/member/Member;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((member == null) ? IntPtr.Zero : ((global::Java.Lang.Object) member).Handle);
				__args [1] = new JniArgumentValue ((_completion == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _completion).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (member);
				global::System.GC.KeepAlive (_completion);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='updateMetadata' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='kotlin.coroutines.Continuation&lt;? super java.lang.Boolean&gt;']]"
		[Register ("updateMetadata", "(Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object? UpdateMetadata (string metadata, global::Kotlin.Coroutines.IContinuation _completion)
		{
			const string __id = "updateMetadata.(Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
			IntPtr native_metadata = JNIEnv.NewString ((string?)metadata);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_metadata);
				__args [1] = new JniArgumentValue ((_completion == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _completion).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_metadata);
				global::System.GC.KeepAlive (_completion);
			}
		}

        public IChannel.State GetState()
        {
            throw new NotImplementedException();
        }
    }
}
