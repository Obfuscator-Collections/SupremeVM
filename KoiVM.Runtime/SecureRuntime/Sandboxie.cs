using System;
using System.Diagnostics;

public class Sandboxie
{
    private static IntPtr GetModuleHandle(string libName)
    {
        foreach (ProcessModule pMod in Process.GetCurrentProcess().Modules)
            if (pMod.ModuleName.ToLower().Contains(libName.ToLower()))
                return pMod.BaseAddress;
        return IntPtr.Zero;
    }

    public bool IsSandboxie()
    {
        if (GetModuleHandle("SbieDll.dll") != IntPtr.Zero)
            return true;
        return false;
    }
}