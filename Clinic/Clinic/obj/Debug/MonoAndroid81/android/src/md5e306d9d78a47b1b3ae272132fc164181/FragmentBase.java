package md5e306d9d78a47b1b3ae272132fc164181;


public class FragmentBase
	extends android.support.v4.app.Fragment
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAttach:(Landroid/app/Activity;)V:GetOnAttach_Landroid_app_Activity_Handler\n" +
			"n_onDetach:()V:GetOnDetachHandler\n" +
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onCreateView:(Landroid/view/LayoutInflater;Landroid/view/ViewGroup;Landroid/os/Bundle;)Landroid/view/View;:GetOnCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Clinic.FragmentBase, Clinic", FragmentBase.class, __md_methods);
	}


	public FragmentBase ()
	{
		super ();
		if (getClass () == FragmentBase.class)
			mono.android.TypeManager.Activate ("Clinic.FragmentBase, Clinic", "", this, new java.lang.Object[] {  });
	}

	public FragmentBase (android.app.Activity p0)
	{
		super ();
		if (getClass () == FragmentBase.class)
			mono.android.TypeManager.Activate ("Clinic.FragmentBase, Clinic", "Android.App.Activity, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public void onAttach (android.app.Activity p0)
	{
		n_onAttach (p0);
	}

	private native void n_onAttach (android.app.Activity p0);


	public void onDetach ()
	{
		n_onDetach ();
	}

	private native void n_onDetach ();


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public android.view.View onCreateView (android.view.LayoutInflater p0, android.view.ViewGroup p1, android.os.Bundle p2)
	{
		return n_onCreateView (p0, p1, p2);
	}

	private native android.view.View n_onCreateView (android.view.LayoutInflater p0, android.view.ViewGroup p1, android.os.Bundle p2);

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
