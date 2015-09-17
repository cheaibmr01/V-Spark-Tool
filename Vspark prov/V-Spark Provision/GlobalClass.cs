using System;

public class GlobalClass
{
	public Variables()
	{
        private string original_location = "";
	}

    public static string GlobalVar
    {
        get { return original_location; }
        set {original_location = value}
    }


}
