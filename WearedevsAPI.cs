using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

public static class NyxAPI
{
    [DllImport("wearedevs_exploit_api.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte initialize();

    [DllImport("wearedevs_exploit_api.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern void execute([MarshalAs(UnmanagedType.LPStr)] string script);

    public static void ExecuteScript(string script)
    {
        execute(script);
    }

    public static void Inject()
    {
        initialize();
    }

    public static void KillRoblox()
    {
        foreach (var p in Process.GetProcessesByName("RobloxPlayerBeta"))
            try { p.Kill(); } catch { }
    }
}