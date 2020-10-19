using System;
using System.Drawing;

using static TweakUtility.Helpers.NativeMethods;

//Version of TweakUtility's "NativeHelpers.cs", altered for MS2start.

namespace TweakUtility.Helpers
{
    internal static class NativeHelpers
    {
        public static Icon ExtractIcon(string file, int id)
        {
            ExtractIconEx(file, id, out IntPtr icon, out _, 1);
            try
            {
                return Icon.FromHandle(icon);
            }
            catch
            {
                return null;
            }
        }
    }
}