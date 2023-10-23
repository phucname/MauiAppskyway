package crc64f3f6dc613f2250a0;


public class ActivityP2PRoom
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Skyway_android.ActivityP2PRoom, Skyway_android", ActivityP2PRoom.class, __md_methods);
	}


	public ActivityP2PRoom ()
	{
		super ();
		if (getClass () == ActivityP2PRoom.class) {
			mono.android.TypeManager.Activate ("Skyway_android.ActivityP2PRoom, Skyway_android", "", this, new java.lang.Object[] {  });
		}
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
