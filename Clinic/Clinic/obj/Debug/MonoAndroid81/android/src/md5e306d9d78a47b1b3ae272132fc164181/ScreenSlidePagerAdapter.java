package md5e306d9d78a47b1b3ae272132fc164181;


public class ScreenSlidePagerAdapter
	extends android.support.v4.app.FragmentStatePagerAdapter
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getItem:(I)Landroid/support/v4/app/Fragment;:GetGetItem_IHandler\n" +
			"n_getCount:()I:GetGetCountHandler\n" +
			"";
		mono.android.Runtime.register ("Clinic.ScreenSlidePagerAdapter, Clinic", ScreenSlidePagerAdapter.class, __md_methods);
	}


	public ScreenSlidePagerAdapter (android.support.v4.app.FragmentManager p0)
	{
		super (p0);
		if (getClass () == ScreenSlidePagerAdapter.class)
			mono.android.TypeManager.Activate ("Clinic.ScreenSlidePagerAdapter, Clinic", "Android.Support.V4.App.FragmentManager, Xamarin.Android.Support.Fragment", this, new java.lang.Object[] { p0 });
	}


	public android.support.v4.app.Fragment getItem (int p0)
	{
		return n_getItem (p0);
	}

	private native android.support.v4.app.Fragment n_getItem (int p0);


	public int getCount ()
	{
		return n_getCount ();
	}

	private native int n_getCount ();

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
