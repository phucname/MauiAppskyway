using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ntt.skyway", Managed="Com.Ntt.Skyway")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ntt.skyway.core", Managed="Com.Ntt.Skyway.Core")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ntt.skyway.core.channel", Managed="Com.Ntt.Skyway.Core.Channel")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ntt.skyway.core.channel.member", Managed="Com.Ntt.Skyway.Core.Channel.Member")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ntt.skyway.core.content", Managed="Com.Ntt.Skyway.Core.Content")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ntt.skyway.core.content.local", Managed="Com.Ntt.Skyway.Core.Content.Local")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ntt.skyway.core.content.local.source", Managed="Com.Ntt.Skyway.Core.Content.Local.Source")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ntt.skyway.core.content.remote", Managed="Com.Ntt.Skyway.Core.Content.Remote")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ntt.skyway.core.content.sink", Managed="Com.Ntt.Skyway.Core.Content.Sink")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ntt.skyway.core.network", Managed="Com.Ntt.Skyway.Core.Network")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ntt.skyway.core.util", Managed="Com.Ntt.Skyway.Core.Util")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ntt.skyway.plugin", Managed="Com.Ntt.Skyway.Plugin")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ntt.skyway.plugin.remotePerson", Managed="Com.Ntt.Skyway.Plugin.RemotePerson")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ntt.skyway.plugin.unknown", Managed="Com.Ntt.Skyway.Plugin.Unknown")]

delegate int _JniMarshal_PP_I (IntPtr jnienv, IntPtr klass);
delegate long _JniMarshal_PP_J (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PP_L (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PP_V (IntPtr jnienv, IntPtr klass);
delegate bool _JniMarshal_PP_Z (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PPL_L (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPL_V (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate bool _JniMarshal_PPL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate IntPtr _JniMarshal_PPLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate IntPtr _JniMarshal_PPLLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate void _JniMarshal_PPZ_V (IntPtr jnienv, IntPtr klass, bool p0);
#if !NET
namespace System.Runtime.Versioning {
    [System.Diagnostics.Conditional("NEVER")]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Event | AttributeTargets.Method | AttributeTargets.Module | AttributeTargets.Property | AttributeTargets.Struct, AllowMultiple = true, Inherited = false)]
    internal sealed class SupportedOSPlatformAttribute : Attribute {
        public SupportedOSPlatformAttribute (string platformName) { }
    }
}
#endif

