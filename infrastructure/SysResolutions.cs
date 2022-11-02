using NLog;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BmLauncherWForm.infrastructure
{
    /// <summary>
    ///     Premade class with slight additions, originally taken off StackOverflow.
    ///     Used to collect available System Resolutions from user.
    /// </summary>
    internal class SysResolutions
    {
        // logger for easy debugging
        private static Logger logger = LogManager.GetCurrentClassLogger();

        // string list to store resolution values
        public static List<string> ResolutionList;

        public SysResolutions()
        {
            logger = LogManager.GetCurrentClassLogger();
        }

        [DllImport("user32.dll")]
        public static extern bool EnumDisplaySettings(
            string deviceName, int modeNum, ref DEVMODE devMode);

        /// <summary>
        ///     Getter for user resolutions.
        ///     Called by Program upon application start.
        /// </summary>
        public void getResolutions()
        {
            List<string> tempList = new List<string>();
            DEVMODE vDevMode = new DEVMODE();
            int i = 0;
            while (EnumDisplaySettings(null, i, ref vDevMode))
            {
                tempList.Add(vDevMode.dmPelsWidth + "x" + vDevMode.dmPelsHeight);
                i++;
            }

            int maxLength = tempList.Max(x => x.Length);
            IOrderedEnumerable<string> orderedList = tempList.OrderBy(x => x.PadLeft(maxLength, '0'));
            ResolutionList = orderedList.Distinct().ToList();
            logger.Debug("getResolutions - found a total of {0} available resolutions.", ResolutionList.Count);
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct DEVMODE
        {
            private const int Cchdevicename = 0x20;
            private const int Cchformname = 0x20;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
            public string dmDeviceName;

            public short dmSpecVersion;
            public short dmDriverVersion;
            public short dmSize;
            public short dmDriverExtra;
            public int dmFields;
            public int dmPositionX;
            public int dmPositionY;
            public ScreenOrientation dmDisplayOrientation;
            public int dmDisplayFixedOutput;
            public short dmColor;
            public short dmDuplex;
            public short dmYResolution;
            public short dmTTOption;
            public short dmCollate;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
            public string dmFormName;

            public short dmLogPixels;
            public int dmBitsPerPel;
            public int dmPelsWidth;
            public int dmPelsHeight;
            public int dmDisplayFlags;
            public int dmDisplayFrequency;
            public int dmICMMethod;
            public int dmICMIntent;
            public int dmMediaType;
            public int dmDitherType;
            public int dmReserved1;
            public int dmReserved2;
            public int dmPanningWidth;
            public int dmPanningHeight;
        }
    }
}