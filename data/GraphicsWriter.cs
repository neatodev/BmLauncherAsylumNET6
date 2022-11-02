using BmLauncherWForm.infrastructure;
using NLog;
using NvAPIWrapper.Native.Exceptions;
using System;
using System.IO;

namespace BmLauncherWForm.data
{
    /// <summary>
    ///     Helper Class for Graphics. Used to change parameters in Graphics class in accordance with user input.
    /// </summary>
    internal class GraphicsWriter
    {
        // logger for easy debugging
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        private static bool isHbao;

        public void writeAll()
        {
            setLang();
            setAAMode();
            setAO();
            setAnisotropy();
            setBloom();
            setBlur();
            setDOF();
            setDetailMode();
            setDist();
            setDynamicShadows();
            setFogVolumes();
            setFullScreen();
            try
            {
                setHbaoPlus();
            }
            catch (FileNotFoundException e)
            {
                logger.Warn(
                    "writeAll - could not call setHbaoPlus() - This is fine if you're not using an NVIDIA GPU. Exception: {0}",
                    e);
            }

            setLensFlares();
            setMaxShadowRes();
            setMaxSmoothedFrames();
            setMemoryPools();
            setPhysX();
            setRes();
            setShadowTexels();
            setSphericalHarmonic();
            setVsync();
            setThreadLag();
            logger.Debug("writeAll - saved all Graphics parameters to their assigned values.");
        }

        private static void setRes()
        {
            Object selectedRes = Program.Client.resBox.SelectedItem;
            string resX = selectedRes.ToString().Substring(0, selectedRes.ToString().LastIndexOf("x"));
            string resY = selectedRes.ToString().Substring(selectedRes.ToString().LastIndexOf("x") + 1);

            Graphics.setResolutionX(resX);
            Graphics.setResolutionY(resY);
            logger.Debug("setRes - set resolution to {0}x{1}", resX, resY);
        }

        private static void setLang()
        {
            int caseValue = Program.Client.langBox.SelectedIndex;
            switch (caseValue)
            {
                case 0:
                    Graphics.setLanguage("int");
                    break;

                case 1:
                    Graphics.setLanguage("deu");
                    break;

                case 2:
                    Graphics.setLanguage("fra");
                    break;

                case 3:
                    Graphics.setLanguage("ita");
                    break;

                case 4:
                    Graphics.setLanguage("esn");
                    break;

                default:
                    Graphics.setLanguage("nochange");
                    break;
            }

            logger.Debug("setLang - set language to {0}", Graphics.getLanguage());
        }

        private static void setFullScreen()
        {
            Graphics.setFullScreen(Program.Client.fullscreenBox.SelectedIndex == 0 ? "False" : "True");
            logger.Debug("setFullScreen - set fullscreen to {0}", Graphics.isFullScreen());
        }

        private static void setVsync()
        {
            Graphics.setVsync(Program.Client.vsyncBox.SelectedIndex == 0 ? "False" : "True");
            logger.Debug("setVsync - set vsync to {0}", Graphics.isVsync());
        }

        private static void setFogVolumes()
        {
            Graphics.setFogVolumes(Program.Client.fogBox.SelectedIndex == 0 ? "False" : "True");
            logger.Debug("setFogVolumes - set fog volumes to {0}", Graphics.isFogVolumes());
        }

        private static void setBloom()
        {
            if (Program.Client.bloomBox.SelectedIndex == 0)
            {
                Graphics.setBloom("False");
                Graphics.setHighQualityBloom("False");
            }
            else
            {
                Graphics.setBloom("True");
                Graphics.setHighQualityBloom("True");
            }

            logger.Debug("setBloom - set bloom to {0}", Graphics.isBloom());
        }

        private static void setLensFlares()
        {
            Graphics.setLensFlares(Program.Client.lensFlareBox.SelectedIndex == 0 ? "False" : "True");
            logger.Debug("setLensFlares - set lens flares to {0}", Graphics.isLensFlares());
        }

        private static void setDOF()
        {
            Graphics.setDepthOfField(Program.Client.dofBox.SelectedIndex == 0 ? "False" : "True");
            logger.Debug("setDOF - set depth of field to {0}", Graphics.isDepthOfField());
        }

        private static void setDist()
        {
            Graphics.setDistortion(Program.Client.distBox.SelectedIndex == 0 ? "False" : "True");
            logger.Debug("setDist - set distortion to {0}", Graphics.isDistortion());
        }

        private static void setBlur()
        {
            Graphics.setMotionBlur(Program.Client.mBlurBox.SelectedIndex == 0 ? "False" : "True");
            logger.Debug("setBlur - set motion blur to {0}", Graphics.isMotionBlur());
        }

        private static void setAO()
        {
            if ((Program.Client.aoBox.SelectedIndex == 0 && Program.Client.aoBox.Enabled) ||
                !Program.Client.aoBox.Enabled)
            {
                Graphics.setAmbientOcclusion("False");
            }
            else
            {
                Graphics.setAmbientOcclusion("True");
            }

            logger.Debug("setAO - set ambient occlusion to {0}", Graphics.isAmbientOcclusion());
        }

        private static void setSphericalHarmonic()
        {
            Graphics.setDisableSphericalHarmonicLights(Program.Client.sphericBox.SelectedIndex == 0 ? "True" : "False");
            logger.Debug("setSphericalHarmonic - set disable spherical harmonic lights to {0}",
                Graphics.isDisableSphericalHarmonicLights());
        }

        private static void setDynamicShadows()
        {
            Graphics.setDynamicShadows(Program.Client.dShadowBox.SelectedIndex == 0 ? "False" : "True");
            logger.Debug("setDynamicShadows - set dynamic shadows to {0}", Graphics.isDynamicShadows());
        }

        private static void setHbaoPlus()
        {
            if (!Program.Client.gpInfoLabel.Text.Contains("NVIDIA") || WineChecker.IsWine())
            {
                return;
            }

            try
            {
                Program.NvWorker.setNVSettings();
            }
            catch (NVIDIANotSupportedException e)
            {
                logger.Warn("setHbaoPlus - Caught NVIDIANotSupportedException: {0}", e);
                return;
            }

            if (NvidiaWorker.HasHbao || !Program.Client.nvBox.Checked || isHbao)
            {
                return;
            }

            Program.MyFactory.ExecNvSetter();
            isHbao = true;
        }

        private static void setMaxSmoothedFrames()
        {
            if (Program.Client.maxSmoothTextBox.Text.Trim().Equals("") ||
                Int16.Parse(Program.Client.maxSmoothTextBox.Text.Trim()) < 25)
            {
                Program.Client.maxSmoothTextBox.Text = @"62";
                Graphics.setMaxSmoothedFramerate("62.000000");
            }
            else
            {
                int framecap = Int32.Parse(Program.Client.maxSmoothTextBox.Text.Trim());
                framecap += 2;
                Graphics.setMaxSmoothedFramerate(framecap + ".000000");
            }

            logger.Debug("setMaxSmoothedFrames - set max smoothed frames to {0}", Graphics.getMaxSmoothedFramerate());
        }

        private static void setDetailMode()
        {
            int caseValue = Program.Client.detailBox.SelectedIndex;

            switch (caseValue)
            {
                case 0:
                    Graphics.setDetailMode("0");
                    break;

                case 1:
                    Graphics.setDetailMode("1");
                    break;

                case 2:
                    Graphics.setDetailMode("2");
                    break;
            }

            logger.Debug("setDetailMode - set detail mode to {0}", Graphics.getDetailMode());
        }

        private static void setAAMode()
        {
            int caseValue = Program.Client.aaBox.SelectedIndex;

            switch (caseValue)
            {
                case 0:
                    Graphics.setMultiSampling("1");
                    break;

                case 1:
                    Graphics.setMultiSampling("2");
                    break;

                case 2:
                    Graphics.setMultiSampling("4");
                    break;

                case 3:
                    Graphics.setMultiSampling("10");
                    break;
            }

            logger.Debug("setAAMode - set multisampling mode to {0}", Graphics.getMultiSampling());
        }

        private static void setAnisotropy()
        {
            int caseValue = Program.Client.anisoBox.SelectedIndex;

            switch (caseValue)
            {
                case 0:
                    Graphics.setMaxAnisotropy("4");
                    break;

                case 1:
                    Graphics.setMaxAnisotropy("8");
                    break;

                case 2:
                    Graphics.setMaxAnisotropy("16");
                    break;
            }

            logger.Debug("setAnisotropy - set anisotropy to {0}", Graphics.getMaxAnisotropy());
        }

        private static void setMemoryPools()
        {
            int caseValue = Program.Client.memPoolBox.SelectedIndex;

            switch (caseValue)
            {
                case 0:
                    Graphics.setMemoryPoolsValue("512");
                    break;

                case 1:
                    Graphics.setMemoryPoolsValue("1024");
                    break;

                case 2:
                    Graphics.setMemoryPoolsValue("2048");
                    break;

                case 3:
                    Graphics.setMemoryPoolsValue("3072");
                    break;

                case 4:
                    Graphics.setMemoryPoolsValue("4096");
                    break;

                case 5:
                    Graphics.setMemoryPoolsValue("0");
                    break;
            }

            logger.Debug("setMemoryPools - set memory pools to {0}", Graphics.getMemoryPoolsValue());
        }

        private static void setShadowTexels()
        {
            int caseValue = Program.Client.texelBox.SelectedIndex;

            switch (caseValue)
            {
                case 0:
                    Graphics.setShadowTexels("0.012000");
                    break;

                case 1:
                    Graphics.setShadowTexels("0.008000");
                    break;

                case 2:
                    Graphics.setShadowTexels("0.008000");
                    break;

                case 3:
                    Graphics.setShadowTexels("0.002000");
                    break;
            }

            logger.Debug("setShadowTexels - set shadow depth bias to {0}", Graphics.getShadowTexels());
        }

        private static void setMaxShadowRes()
        {
            int caseValue = Program.Client.maxShadowBox.SelectedIndex;

            switch (caseValue)
            {
                case 0:
                    Graphics.setMaxShadowResolution("512");
                    break;

                case 1:
                    Graphics.setMaxShadowResolution("1024");
                    break;

                case 2:
                    Graphics.setMaxShadowResolution("2048");
                    break;

                case 3:
                    Graphics.setMaxShadowResolution("4096");
                    break;
            }

            logger.Debug("setMaxShadowRes - set max shadow resolution to {0}", Graphics.getMaxShadowResolution());
        }

        private static void setPhysX()
        {
            int caseValue = Program.Client.physxBox.SelectedIndex;

            switch (caseValue)
            {
                case 0:
                    Graphics.setPhysX("0");
                    break;

                case 1:
                    Graphics.setPhysX("1");
                    break;

                case 2:
                    Graphics.setPhysX("2");
                    break;
            }

            logger.Debug("setPhysX - set physx to {0}", Graphics.getPhysX());
        }

        private static void setThreadLag()
        {
            Graphics.setFrameThreadLag(Program.Client.frameCheckBox.Checked ? "True" : "False");
            logger.Debug("setThreadLag - set frame thread lag to {0}", Graphics.getFrameThreadLag());
        }
    }
}