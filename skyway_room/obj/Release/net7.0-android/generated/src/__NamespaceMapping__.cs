using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ntt.skyway.room", Managed="Com.Ntt.Skyway.Room")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ntt.skyway.room.member", Managed="Com.Ntt.Skyway.Room.Member")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ntt.skyway.room.p2p", Managed="Com.Ntt.Skyway.Room.P2p")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ntt.skyway.room.sfu", Managed="Com.Ntt.Skyway.Room.Sfu")]

delegate IntPtr _JniMarshal_PP_L (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PPLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
#if !NET
namespace System.Runtime.Versioning {
    [System.Diagnostics.Conditional("NEVER")]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Event | AttributeTargets.Method | AttributeTargets.Module | AttributeTargets.Property | AttributeTargets.Struct, AllowMultiple = true, Inherited = false)]
    internal sealed class SupportedOSPlatformAttribute : Attribute {
        public SupportedOSPlatformAttribute (string platformName) { }
    }
}
#endif

