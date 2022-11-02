using NLog;
using System;
using System.Runtime.InteropServices;

namespace BmLauncherWForm.data
{
    internal static class WineChecker
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public static bool IsWine()
        {
            try
            {
                logger.Info("IsWine - Wine detected. Version: {0}", GetWineVersion());
                return true;
            }
            catch (EntryPointNotFoundException e)
            {
                logger.Warn(
                    "IsWine - Wine not found. (Windows Users can ignore this.).\r\nEntryPointNotFoundException: {0}",
                    e);
                return false;
            }
        }

        [DllImport("ntdll.dll", EntryPoint = "wine_get_version", CallingConvention = CallingConvention.Cdecl,
            CharSet = CharSet.Ansi)]
        private static extern string GetWineVersion();
    }
}