package crc64e19d6d5a4f0709ca;


public class MainActivity_Continuation
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		kotlin.coroutines.Continuation
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getContext:()Lkotlin/coroutines/CoroutineContext;:GetGetContextHandler:Kotlin.Coroutines.IContinuationInvoker, Xamarin.Kotlin.StdLib\n" +
			"n_resumeWith:(Ljava/lang/Object;)V:GetResumeWith_Ljava_lang_Object_Handler:Kotlin.Coroutines.IContinuationInvoker, Xamarin.Kotlin.StdLib\n" +
			"";
		mono.android.Runtime.register ("AndroidApp1.MainActivity+Continuation, Skyway_android", MainActivity_Continuation.class, __md_methods);
	}


	public MainActivity_Continuation ()
	{
		super ();
		if (getClass () == MainActivity_Continuation.class) {
			mono.android.TypeManager.Activate ("AndroidApp1.MainActivity+Continuation, Skyway_android", "", this, new java.lang.Object[] {  });
		}
	}


	public kotlin.coroutines.CoroutineContext getContext ()
	{
		return n_getContext ();
	}

	private native kotlin.coroutines.CoroutineContext n_getContext ();


	public void resumeWith (java.lang.Object p0)
	{
		n_resumeWith (p0);
	}

	private native void n_resumeWith (java.lang.Object p0);

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
