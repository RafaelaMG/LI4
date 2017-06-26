package md5de813813b4c282cc1c8aebbbd632d32f;


public class pesquisar
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
		mono.android.Runtime.register ("Ambrosiov3.pesquisar, Ambrosiov3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", pesquisar.class, __md_methods);
	}


	public pesquisar () throws java.lang.Throwable
	{
		super ();
		if (getClass () == pesquisar.class)
			mono.android.TypeManager.Activate ("Ambrosiov3.pesquisar, Ambrosiov3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
