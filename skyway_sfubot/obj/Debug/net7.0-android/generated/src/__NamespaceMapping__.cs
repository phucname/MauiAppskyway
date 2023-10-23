using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ntt.skyway.plugin.sfuBot", Managed="Com.Ntt.Skyway.Plugin.SfuBot")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ntt.skyway.plugin.sfubot", Managed="Com.Ntt.Skyway.Plugin.Sfubot")]

#if !NET
namespace System.Runtime.Versioning {
    [System.Diagnostics.Conditional("NEVER")]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Event | AttributeTargets.Method | AttributeTargets.Module | AttributeTargets.Property | AttributeTargets.Struct, AllowMultiple = true, Inherited = false)]
    internal sealed class SupportedOSPlatformAttribute : Attribute {
        public SupportedOSPlatformAttribute (string platformName) { }
    }
}
#endif

