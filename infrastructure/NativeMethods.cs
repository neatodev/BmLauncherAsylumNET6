using System.Runtime.InteropServices;

namespace BmLauncherAsylumNET6.infrastructure
{
    /// <summary>
    ///     Wrapper Class for Win32 parameters. Used to ensure only one instance of this Application is active.
    /// </summary>
    internal class NativeMethods
    {
        public const int HwndBroadcast = 0xffff;
        public static readonly int WmShowme = RegisterWindowMessage("WM_SHOWME");

        [DllImport("user32")]
        public static extern bool PostMessage(IntPtr hwnd, int msg, IntPtr wparam, IntPtr lparam);

        [DllImport("user32")]
        public static extern int RegisterWindowMessage(string message);
    }
}