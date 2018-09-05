package md5e306d9d78a47b1b3ae272132fc164181;


public class Page1Doctors
	extends md5e306d9d78a47b1b3ae272132fc164181.FragmentBase
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreateView:(Landroid/view/LayoutInflater;Landroid/view/ViewGroup;Landroid/os/Bundle;)Landroid/view/View;:GetOnCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Clinic.Page1Doctors, Clinic", Page1Doctors.class, __md_methods);
	}


	public Page1Doctors ()
	{
		super ();
		if (getClass () == Page1Doctors.class)
			mono.android.TypeManager.Activate ("Clinic.Page1Doctors, Clinic", "", this, new java.lang.Object[] {  });
	}

	public Page1Doctors (android.app.Activity p0)
	{
		super ();
		if (getClass () == Page1Doctors.class)
			mono.android.TypeManager.Activate ("Clinic.Page1Doctors, Clinic", "Android.App.Activity, Mono.Android", this, new java.lang.Object[] { p0 });
	}


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
