package mono.org.webrtc.audio;


public class WebRtcAudioTrack_OnAudioBufferListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		org.webrtc.audio.WebRtcAudioTrack.OnAudioBufferListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAudioBuffer:(Ljava/nio/ByteBuffer;)V:GetOnAudioBuffer_Ljava_nio_ByteBuffer_Handler:Org.Webrtc.Audio.WebRtcAudioTrack/IOnAudioBufferListenerInvoker, webrtc\n" +
			"";
		mono.android.Runtime.register ("Org.Webrtc.Audio.WebRtcAudioTrack+IOnAudioBufferListenerImplementor, webrtc", WebRtcAudioTrack_OnAudioBufferListenerImplementor.class, __md_methods);
	}


	public WebRtcAudioTrack_OnAudioBufferListenerImplementor ()
	{
		super ();
		if (getClass () == WebRtcAudioTrack_OnAudioBufferListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Org.Webrtc.Audio.WebRtcAudioTrack+IOnAudioBufferListenerImplementor, webrtc", "", this, new java.lang.Object[] {  });
		}
	}


	public void onAudioBuffer (java.nio.ByteBuffer p0)
	{
		n_onAudioBuffer (p0);
	}

	private native void n_onAudioBuffer (java.nio.ByteBuffer p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
