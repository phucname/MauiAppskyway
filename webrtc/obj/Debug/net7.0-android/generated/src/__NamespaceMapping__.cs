using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "org.webrtc", Managed="Org.Webrtc")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "org.webrtc.audio", Managed="Org.Webrtc.Audio")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "org.webrtc.voiceengine", Managed="Org.Webrtc.Voiceengine")]

delegate double _JniMarshal_PP_D (IntPtr jnienv, IntPtr klass);
delegate int _JniMarshal_PP_I (IntPtr jnienv, IntPtr klass);
delegate long _JniMarshal_PP_J (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PP_L (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PP_V (IntPtr jnienv, IntPtr klass);
delegate bool _JniMarshal_PP_Z (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PPD_V (IntPtr jnienv, IntPtr klass, double p0);
delegate void _JniMarshal_PPF_V (IntPtr jnienv, IntPtr klass, float p0);
delegate void _JniMarshal_PPFF_V (IntPtr jnienv, IntPtr klass, float p0, float p1);
delegate void _JniMarshal_PPFFFF_V (IntPtr jnienv, IntPtr klass, float p0, float p1, float p2, float p3);
delegate IntPtr _JniMarshal_PPI_L (IntPtr jnienv, IntPtr klass, int p0);
delegate void _JniMarshal_PPI_V (IntPtr jnienv, IntPtr klass, int p0);
delegate int _JniMarshal_PPII_I (IntPtr jnienv, IntPtr klass, int p0, int p1);
delegate IntPtr _JniMarshal_PPII_L (IntPtr jnienv, IntPtr klass, int p0, int p1);
delegate void _JniMarshal_PPII_V (IntPtr jnienv, IntPtr klass, int p0, int p1);
delegate bool _JniMarshal_PPII_Z (IntPtr jnienv, IntPtr klass, int p0, int p1);
delegate int _JniMarshal_PPIID_I (IntPtr jnienv, IntPtr klass, int p0, int p1, double p2);
delegate void _JniMarshal_PPIII_V (IntPtr jnienv, IntPtr klass, int p0, int p1, int p2);
delegate IntPtr _JniMarshal_PPIIII_L (IntPtr jnienv, IntPtr klass, int p0, int p1, int p2, int p3);
delegate void _JniMarshal_PPIIIII_V (IntPtr jnienv, IntPtr klass, int p0, int p1, int p2, int p3, int p4);
delegate IntPtr _JniMarshal_PPIIIIII_L (IntPtr jnienv, IntPtr klass, int p0, int p1, int p2, int p3, int p4, int p5);
delegate void _JniMarshal_PPILIIIIII_V (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1, int p2, int p3, int p4, int p5, int p6, int p7);
delegate long _JniMarshal_PPJ_J (IntPtr jnienv, IntPtr klass, long p0);
delegate IntPtr _JniMarshal_PPJ_L (IntPtr jnienv, IntPtr klass, long p0);
delegate void _JniMarshal_PPJ_V (IntPtr jnienv, IntPtr klass, long p0);
delegate int _JniMarshal_PPL_I (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate IntPtr _JniMarshal_PPL_L (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPL_V (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate bool _JniMarshal_PPL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPLF_V (IntPtr jnienv, IntPtr klass, IntPtr p0, float p1);
delegate void _JniMarshal_PPLFL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, float p1, IntPtr p2);
delegate void _JniMarshal_PPLFLZ_V (IntPtr jnienv, IntPtr klass, IntPtr p0, float p1, IntPtr p2, bool p3);
delegate IntPtr _JniMarshal_PPLI_L (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
delegate void _JniMarshal_PPLI_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
delegate IntPtr _JniMarshal_PPLII_L (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2);
delegate bool _JniMarshal_PPLII_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2);
delegate void _JniMarshal_PPLIII_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2, int p3);
delegate void _JniMarshal_PPLIIL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2, IntPtr p3);
delegate void _JniMarshal_PPLIL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, IntPtr p2);
delegate IntPtr _JniMarshal_PPLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate void _JniMarshal_PPLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate bool _JniMarshal_PPLL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate void _JniMarshal_PPLLIIIIII_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, int p2, int p3, int p4, int p5, int p6, int p7);
delegate IntPtr _JniMarshal_PPLLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate void _JniMarshal_PPLLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate bool _JniMarshal_PPLLL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate void _JniMarshal_PPLLLIIII_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, int p3, int p4, int p5, int p6);
delegate void _JniMarshal_PPLLLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3);
delegate void _JniMarshal_PPLLLLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4);
delegate void _JniMarshal_PPLLLZ_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, bool p3);
delegate bool _JniMarshal_PPLZ_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1);
delegate IntPtr _JniMarshal_PPZ_L (IntPtr jnienv, IntPtr klass, bool p0);
delegate void _JniMarshal_PPZ_V (IntPtr jnienv, IntPtr klass, bool p0);
delegate bool _JniMarshal_PPZ_Z (IntPtr jnienv, IntPtr klass, bool p0);
delegate IntPtr _JniMarshal_PPZZ_L (IntPtr jnienv, IntPtr klass, bool p0, bool p1);
#if !NET
namespace System.Runtime.Versioning {
    [System.Diagnostics.Conditional("NEVER")]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Event | AttributeTargets.Method | AttributeTargets.Module | AttributeTargets.Property | AttributeTargets.Struct, AllowMultiple = true, Inherited = false)]
    internal sealed class SupportedOSPlatformAttribute : Attribute {
        public SupportedOSPlatformAttribute (string platformName) { }
    }
}
#endif

