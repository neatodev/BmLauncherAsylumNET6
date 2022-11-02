using BmLauncherWForm.infrastructure;
using NLog;
using NvAPIWrapper.Native.Exceptions;
using System;
using System.IO;

namespace BmLauncherWForm.data
{
    /// <summary>
    ///     Graphics helper class. Initializes the GUI with correct values from BmEngine file
    /// </summary>
    internal class GuiInitializer
    {
        // logger for easy debugging
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public void init()
        {
            // all false/true values
            Program.Client.fullscreenBox.SelectedIndex =
                Graphics.isFullScreen().Equals("False", StringComparison.InvariantCultureIgnoreCase) ? 0 : 1;
            logger.Debug("init - initialized fullscreen as {0}", Graphics.isFullScreen());
            Program.Client.vsyncBox.SelectedIndex =
                Graphics.isVsync().Equals("False", StringComparison.InvariantCultureIgnoreCase) ? 0 : 1;
            logger.Debug("init - initialized vsync as {0}", Graphics.isVsync());

            Program.Client.dofBox.SelectedIndex =
                Graphics.isDepthOfField().Equals("False", StringComparison.InvariantCultureIgnoreCase) ? 0 : 1;
            logger.Debug("init - initialized depth of field as {0}", Graphics.isDepthOfField());

            Program.Client.aoBox.SelectedIndex =
                Graphics.isAmbientOcclusion().Equals("False", StringComparison.InvariantCultureIgnoreCase) ? 0 : 1;
            logger.Debug("init - initialized ambient occlusion as {0}", Graphics.isAmbientOcclusion());

            Program.Client.lensFlareBox.SelectedIndex =
                Graphics.isLensFlares().Equals("False", StringComparison.InvariantCultureIgnoreCase) ? 0 : 1;
            logger.Debug("init - initialized lens flares as {0}", Graphics.isLensFlares());

            Program.Client.mBlurBox.SelectedIndex =
                Graphics.isMotionBlur().Equals("False", StringComparison.InvariantCultureIgnoreCase) ? 0 : 1;
            logger.Debug("init - initialized motion blur as {0}", Graphics.isMotionBlur());

            Program.Client.bloomBox.SelectedIndex =
                Graphics.isBloom().Equals("False", StringComparison.InvariantCultureIgnoreCase) ? 0 : 1;
            logger.Debug("init - initialized bloom as {0}", Graphics.isBloom());

            Program.Client.dShadowBox.SelectedIndex =
                Graphics.isDynamicShadows().Equals("False", StringComparison.InvariantCultureIgnoreCase) ? 0 : 1;
            logger.Debug("init - initialized dynamic shadows as {0}", Graphics.isDynamicShadows());

            Program.Client.sphericBox.SelectedIndex = Graphics.isDisableSphericalHarmonicLights()
                .Equals("True", StringComparison.InvariantCultureIgnoreCase)
                ? 0
                : 1;
            logger.Debug("init - initialized disable spherical harmonic lights as {0}",
                Graphics.isDisableSphericalHarmonicLights());

            Program.Client.fogBox.SelectedIndex =
                Graphics.isFogVolumes().Equals("False", StringComparison.InvariantCultureIgnoreCase) ? 0 : 1;
            logger.Debug("init - initialized fog volumes as {0}", Graphics.isFogVolumes());

            Program.Client.distBox.SelectedIndex =
                Graphics.isDistortion().Equals("False", StringComparison.InvariantCultureIgnoreCase) ? 0 : 1;
            logger.Debug("init - initialized distortion as {0}", Graphics.isDistortion());

            Program.Client.frameCheckBox.Checked = Graphics.getFrameThreadLag().Equals("True");
            logger.Debug("init - initialized frame thread lag as {0}", Graphics.getFrameThreadLag());

            // everything else
            initLang();
            initAA();
            initPhysx();
            initAnisotropy();
            initDetailmode();
            initShadowTexels();
            initShadowRes();
            initMaxSmoothedFrames();
            initMemoryPoolsValue();
            initResolutions();
            try
            {
                initHBAONVIDIA();
            }
            catch (FileNotFoundException e)
            {
                Program.Client.amdToolTip.Active = true;
                Program.Client.amdToolTip.ShowAlways = true;
                Program.Client.nvBox.Enabled = false;
                logger.Warn(
                    "init - could not call initHBAONVIDIA() - This is fine if you're not using an NVIDIA GPU. Exception: {0}",
                    e);
            }

            logger.Info("init - initialized all values to the gui.");
        }

        private static void initLang()
        {
            switch (Graphics.getLanguage())
            {
                case "int":
                    Program.Client.langBox.SelectedIndex = 0;
                    break;

                case "deu":
                    Program.Client.langBox.SelectedIndex = 1;
                    break;

                case "fra":
                    Program.Client.langBox.SelectedIndex = 2;
                    break;

                case "ita":
                    Program.Client.langBox.SelectedIndex = 3;
                    break;

                case "esn":
                    Program.Client.langBox.SelectedIndex = 4;
                    break;
                default:
                    Program.Client.langBox.SelectedIndex = Program.Client.langBox.Items.Add("Unofficial");
                    break;
            }

            logger.Debug("initLang - initialized language as {0}", Graphics.getLanguage());
        }

        private static void initAA()
        {
            switch (Int16.Parse(Graphics.getMultiSampling()))
            {
                case 1:
                    Program.Client.aaBox.SelectedIndex = 0;
                    break;

                case 2:
                    Program.Client.aaBox.SelectedIndex = 1;
                    break;

                case 4:
                    Program.Client.aaBox.SelectedIndex = 2;
                    break;

                case 10:
                    Program.Client.aaBox.SelectedIndex = 3;
                    break;
            }

            logger.Debug("initAA - initialized multisampling as {0}", Graphics.getMultiSampling());
        }

        private static void initPhysx()
        {
            switch (Int16.Parse(Graphics.getPhysX()))
            {
                case 0:
                    Program.Client.physxBox.SelectedIndex = 0;
                    break;

                case 1:
                    Program.Client.physxBox.SelectedIndex = 1;
                    break;

                case 2:
                    Program.Client.physxBox.SelectedIndex = 2;
                    break;
            }

            logger.Debug("initPhysx - initialized physx as {0}", Graphics.getPhysX());
        }

        private static void initAnisotropy()
        {
            switch (Int16.Parse(Graphics.getMaxAnisotropy()))
            {
                case 4:
                    Program.Client.anisoBox.SelectedIndex = 0;
                    break;

                case 8:
                    Program.Client.anisoBox.SelectedIndex = 1;
                    break;

                case 16:
                    Program.Client.anisoBox.SelectedIndex = 2;
                    break;
            }

            logger.Debug("initAnisotropy - initialized max anisotropy as {0}", Graphics.getMaxAnisotropy());
        }

        private static void initDetailmode()
        {
            switch (Int16.Parse(Graphics.getDetailMode()))
            {
                case 0:
                    Program.Client.detailBox.SelectedIndex = 0;
                    break;

                case 1:
                    Program.Client.detailBox.SelectedIndex = 1;
                    break;

                case 2:
                    Program.Client.detailBox.SelectedIndex = 2;
                    break;
            }

            logger.Debug("initDetailmode - initialized detail mode as {0}", Graphics.getDetailMode());
        }

        private static void initShadowTexels()
        {
            switch (Graphics.getShadowTexels())
            {
                case "0.012000":
                    Program.Client.texelBox.SelectedIndex = 0;
                    break;

                case "0.008000":
                    Program.Client.texelBox.SelectedIndex = Graphics.getShadowSlope() == "10.000000" ? 1 : 2;

                    break;

                case "0.002000":
                    Program.Client.texelBox.SelectedIndex = 3;
                    break;
            }

            logger.Debug("initShadowTexels - initialized shadow depth bias as {0}", Graphics.getShadowTexels());
        }

        private static void initShadowRes()
        {
            switch (Int16.Parse(Graphics.getMaxShadowResolution()))
            {
                case 512:
                    Program.Client.maxShadowBox.SelectedIndex = 0;
                    Program.Client.texelBox.SelectedIndex = 0;
                    Program.Client.texelBox.Enabled = false;
                    break;

                case 1024:
                    Program.Client.maxShadowBox.SelectedIndex = 1;
                    Program.Client.texelBox.SelectedIndex = 0;
                    Program.Client.texelBox.Enabled = false;
                    break;

                case 2048:
                    Program.Client.maxShadowBox.SelectedIndex = 2;
                    break;

                case 4096:
                    Program.Client.maxShadowBox.SelectedIndex = 3;
                    break;
            }

            logger.Debug("initShadowRes - initialized max shadow resolution as {0}", Graphics.getMaxShadowResolution());
        }

        private static void initMaxSmoothedFrames()
        {
            int framecap = Int32.Parse(Graphics.getMaxSmoothedFramerate()
                .Substring(0, Graphics.getMaxSmoothedFramerate().LastIndexOf(".")));
            framecap -= 2;
            Program.Client.maxSmoothTextBox.Text = framecap.ToString();
            logger.Debug("initLang - initialized framerate cap as {0}", Graphics.getMaxSmoothedFramerate());
        }

        private static void initMemoryPoolsValue()
        {
            switch (Int16.Parse(Graphics.getMemoryPoolsValue()))
            {
                case 0:
                    Program.Client.memPoolBox.SelectedIndex = 5;
                    break;

                case 512:
                    Program.Client.memPoolBox.SelectedIndex = 0;
                    break;

                case 1024:
                    Program.Client.memPoolBox.SelectedIndex = 1;
                    break;

                case 2048:
                    Program.Client.memPoolBox.SelectedIndex = 2;
                    break;

                case 3072:
                    Program.Client.memPoolBox.SelectedIndex = 3;
                    break;

                case 4096:
                    Program.Client.memPoolBox.SelectedIndex = 4;
                    break;
            }

            logger.Debug("initMemoryPoolsValue - initialized memory pools value as {0}",
                Graphics.getMemoryPoolsValue());
        }

        private static void initResolutions()
        {
            foreach (string resolution in SysResolutions.ResolutionList)
            {
                Program.Client.resBox.Items.Add(resolution);
            }

            string myResolution = Graphics.getResolutionX() + "x" + Graphics.getResolutionY();

            foreach (string res in Program.Client.resBox.Items)
            {
                if (!res.Equals(myResolution))
                {
                    continue;
                }

                Program.Client.resBox.SelectedIndex = Program.Client.resBox.Items.IndexOf(res);
            }

            logger.Debug("initResolutions - initialized resolution as {0}x{1}", Graphics.getResolutionX(),
                Graphics.getResolutionY());
        }

        /// <summary>
        ///     Initializes NVIDIA component, only if NVIDIA card is found.
        ///     Sets displayed tooltips accordingly.
        /// </summary>
        private static void initHBAONVIDIA()
        {
            if (!Program.Client.gpInfoLabel.Text.Contains("NVIDIA"))
            {
                Program.Client.amdToolTip.Active = true;
                Program.Client.amdToolTip.ShowAlways = true;
                Program.Client.nvBox.Enabled = false;
                logger.Debug("initHBAONVIDIA - initialized hbao+ possibility as false.");
                return;
            }

            if (Program.Client.gpInfoLabel.Text.Contains("NVIDIA") && !WineChecker.IsWine())
            {
                try
                {
                    Program.NvWorker = new NvidiaWorker();
                    Program.Client.nvBox.Enabled = true;
                    Program.Client.nvidiaToolTip.Active = true;
                    logger.Debug("initHBAONVIDIA - initialized hbao+ possibility as true.");
                }
                catch (NVIDIANotSupportedException e)
                {
                    logger.Warn("initHBAONVIDIA - Caught NVIDIANotSupportedException: {0}", e);
                    Program.Client.nvBox.Enabled = false;
                }
            }
            else if (Program.Client.gpInfoLabel.Text.Contains("NVIDIA"))
            {
                Program.Client.nvBox.Enabled = false;
                Program.Client.nvidiaToolTip.Active = true;
                logger.Debug(
                    "initHBAONVIDIA - initialized hbao+ possibility as false. You're using an NVIDIA card on a Linux machine.");
            }
        }
    }
}