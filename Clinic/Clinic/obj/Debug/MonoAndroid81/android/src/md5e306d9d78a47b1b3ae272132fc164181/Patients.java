package md5e306d9d78a47b1b3ae272132fc164181;


public class Patients
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
		mono.android.Runtime.register ("Clinic.Patients, Clinic", Patients.class, __md_methods);
	}


	public Patients ()
	{
		super ();
		if (getClass () == Patients.class)
			mono.android.TypeManager.Activate ("Clinic.Patients, Clinic", "", this, new java.lang.Object[] {  });
	}

	public Patients (android.os.Bundle p0)
	{
		super ();
		if (getClass () == Patients.class)
			mono.android.TypeManager.Activate ("Clinic.Patients, Clinic", "Android.OS.Bundle, Mono.Android", this, new java.lang.Object[] { p0 });
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
