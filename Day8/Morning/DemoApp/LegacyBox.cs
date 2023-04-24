using System.Runtime.InteropServices;

unsafe struct LegacyBox
{
    fixed double dimensions[3]; //fixed size buffer
    float thickness;

    public LegacyBox(double l, double b, double h, float t)
    {
        dimensions[0] = l;
        dimensions[1] = b;
        dimensions[2] = h;
        thickness = t;
    }

    //An extern static method is linked to a native function
    //through DllImport attribute. When such a method is called
    //CLR invokes the function specified by the EntryPoint property
    //of DllImport attribute from the platform specific dynamically
    //linkable library identified by that attribute (platform invocation)
    [DllImport("legacy", EntryPoint="box_volume")]
    extern static bool BoxVolume(in LegacyBox box, out double result);

    public double GetInnerVolume()
    {
        if(BoxVolume(this, out double volume))
            return volume;
        throw new ArgumentException("Invalid Box");
    }
}