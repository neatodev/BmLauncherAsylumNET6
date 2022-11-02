using NLog;

namespace BmLauncherWForm.data
{
    /// <summary>
    ///     Helper class for the static Graphics class
    ///     Used to read and write all of the values to and from Graphics
    /// </summary>
    internal class GraphicsInterpreter
    {
        // logger for easy debugging
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        private static bool charCheck;
        private static bool charNormalCheck;
        private static bool poolCheck;
        private static bool introOne;
        private static bool introTwo;
        private static bool introThree;
        private static bool introFour;

        /// <summary>
        ///     Large method that serves as the main function for this class.
        ///     Reads and writes Graphics.
        /// </summary>
        /// <param name="lineToCheck">Input line that is being read or written</param>
        /// <param name="read">Boolean that determines if Graphics should be written to or read from</param>
        /// <returns>BmEngine value of string or new line to write into BmEngine</returns>
        public string interpretGraphics(string lineToCheck, bool read, int switchCase)
        {
            switch (switchCase)
            {
                // language
                case 21:
                    if (read)
                    {
                        Graphics.setLanguage(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        if (Graphics.getLanguage() == "nochange")
                        {
                            return lineToCheck;
                        }

                        lineToCheck = "Language=" + Graphics.getLanguage();
                    }

                    Program.MyFactory.LineInt = 110;
                    return lineToCheck;

                // physx
                case 110:
                    if (read)
                    {
                        Graphics.setPhysX(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "PhysXLevel=" + Graphics.getPhysX();
                    }

                    Program.MyFactory.LineInt = 154;
                    return lineToCheck;

                // max smoothed framerate
                case 154:
                    if (read)
                    {
                        Graphics.setMaxSmoothedFramerate(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "MaxSmoothedFrameRate=" + Graphics.getMaxSmoothedFramerate();
                    }

                    Program.MyFactory.LineInt = 663;
                    return lineToCheck;

                // Poolsize
                case 663:
                    if (read)
                    {
                        Graphics.setMemoryPoolsValue(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "PoolSize=" + Graphics.getMemoryPoolsValue();
                    }

                    Program.MyFactory.LineInt = 1038;
                    return lineToCheck;

                // dynamic shadows
                case 1038:
                    if (read)
                    {
                        Graphics.setDynamicShadows(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "DynamicShadows=" + Graphics.isDynamicShadows();
                    }

                    Program.MyFactory.LineInt = 1048;
                    return lineToCheck;

                // motion blur
                case 1048:
                    if (read)
                    {
                        Graphics.setMotionBlur(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "MotionBlur=" + Graphics.isMotionBlur();
                    }

                    Program.MyFactory.LineInt = 1057;
                    return lineToCheck;

                // depth of field
                case 1057:
                    if (read)
                    {
                        Graphics.setDepthOfField(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "DepthOfField=" + Graphics.isDepthOfField();
                    }

                    Program.MyFactory.LineInt = 1058;
                    return lineToCheck;

                // ambient occlusion
                case 1058:
                    if (read)
                    {
                        Graphics.setAmbientOcclusion(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "AmbientOcclusion=" + Graphics.isAmbientOcclusion();
                    }

                    Program.MyFactory.LineInt = 1059;
                    return lineToCheck;

                // bloom
                case 1059:
                    if (read)
                    {
                        Graphics.setBloom(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "Bloom=" + Graphics.isBloom();
                    }

                    Program.MyFactory.LineInt = 1060;
                    return lineToCheck;

                // hq bloom
                case 1060:
                    if (read)
                    {
                        Graphics.setHighQualityBloom(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "UseHighQualityBloom=" + Graphics.isBloom();
                    }

                    Program.MyFactory.LineInt = 1061;
                    return lineToCheck;

                // distortion
                case 1061:
                    if (read)
                    {
                        Graphics.setDistortion(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "Distortion=" + Graphics.isDistortion();
                    }

                    Program.MyFactory.LineInt = 1066;
                    return lineToCheck;

                // lens flares
                case 1066:
                    if (read)
                    {
                        Graphics.setLensFlares(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "LensFlares=" + Graphics.isLensFlares();
                    }

                    Program.MyFactory.LineInt = 1067;
                    return lineToCheck;

                // fog volumes
                case 1067:
                    if (read)
                    {
                        Graphics.setFogVolumes(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "FogVolumes=" + Graphics.isFogVolumes();
                    }

                    Program.MyFactory.LineInt = 1069;
                    return lineToCheck;

                // oneframethreadlag
                case 1069:
                    if (read)
                    {
                        Graphics.setFrameThreadLag(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "OneFrameThreadLag=" + Graphics.getFrameThreadLag();
                    }

                    Program.MyFactory.LineInt = 1070;
                    return lineToCheck;

                // vsync
                case 1070:
                    if (read)
                    {
                        Graphics.setVsync(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "UseVsync=" + Graphics.isVsync();
                    }

                    Program.MyFactory.LineInt = 1072;
                    return lineToCheck;

                // fullscreen
                case 1072:
                    if (read)
                    {
                        Graphics.setFullScreen(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "Fullscreen=" + Graphics.isFullScreen();
                    }

                    Program.MyFactory.LineInt = 1076;
                    return lineToCheck;

                // detail mode
                case 1076:
                    if (read)
                    {
                        Graphics.setDetailMode(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "DetailMode=" + Graphics.getDetailMode();
                    }

                    Program.MyFactory.LineInt = 1078;
                    return lineToCheck;

                // max anisotropy
                case 1078:
                    if (read)
                    {
                        Graphics.setMaxAnisotropy(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "MaxAnisotropy=" + Graphics.getMaxAnisotropy();
                    }

                    Program.MyFactory.LineInt = 1079;
                    return lineToCheck;

                // max aa
                case 1079:
                    if (read)
                    {
                        Graphics.setMultiSampling(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "MaxMultisamples=" + Graphics.getMultiSampling();
                    }

                    Program.MyFactory.LineInt = 1082;
                    return lineToCheck;

                // max shadow res
                case 1082:
                    if (read)
                    {
                        Graphics.setMaxShadowResolution(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "MaxShadowResolution=" + Graphics.getMaxShadowResolution();
                    }

                    Program.MyFactory.LineInt = 1083;
                    return lineToCheck;

                // shadow fade res
                case 1083:
                    if (read)
                    {
                    }
                    else
                    {
                        switch (Graphics.getMaxShadowResolution())
                        {
                            case "512":
                                lineToCheck = "ShadowFadeResolution=45";
                                break;

                            case "1024":
                                lineToCheck = "ShadowFadeResolution=32";
                                break;

                            case "2048":
                                lineToCheck = "ShadowFadeResolution=32";
                                break;

                            case "4096":
                                lineToCheck = "ShadowFadeResolution=32";
                                break;
                        }
                    }

                    Program.MyFactory.LineInt = 1084;
                    return lineToCheck;

                // shadow fade exponent
                case 1084:
                    if (read)
                    {
                    }
                    else
                    {
                        switch (Graphics.getShadowTexels())
                        {
                            case "0.012000":
                                lineToCheck = "ShadowFadeExponent=1.000000";
                                break;

                            case "0.008000":
                                if (Program.Client.texelBox.SelectedIndex == 2)
                                {
                                    lineToCheck = "ShadowFadeExponent=2.200000";
                                }
                                else
                                {
                                    lineToCheck = "ShadowFadeExponent=1.000000";
                                }

                                break;

                            case "0.003000":
                                lineToCheck = "ShadowFadeExponent=2.200000";
                                break;
                        }
                    }

                    Program.MyFactory.LineInt = 1085;
                    return lineToCheck;

                // res x
                case 1085:
                    if (read && Graphics.getResolutionX().Equals("default"))
                    {
                        Graphics.setResolutionX(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "ResX=" + Graphics.getResolutionX();
                    }

                    Program.MyFactory.LineInt = 1086;
                    return lineToCheck;

                // res y
                case 1086:
                    if (read && Graphics.getResolutionY().Equals("default"))
                    {
                        Graphics.setResolutionY(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "ResY=" + Graphics.getResolutionY();
                    }

                    Program.MyFactory.LineInt = 1096;
                    return lineToCheck;


                // shadow filter radius
                case 1096:
                    if (read)
                    {
                        Graphics.setShadowFilterRadius(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        switch (Graphics.getMaxShadowResolution())
                        {
                            case "512":
                                lineToCheck = "ShadowFilterRadius=2.000000";
                                break;

                            case "1024":
                                lineToCheck = "ShadowFilterRadius=5.000000";
                                break;

                            case "2048":
                                lineToCheck = "ShadowFilterRadius=5.000000";
                                break;

                            case "4096":
                                lineToCheck = "ShadowFilterRadius=3.000000";
                                break;
                        }
                    }

                    Program.MyFactory.LineInt = 1097;
                    return lineToCheck;

                // shadow depth bias
                case 1097:
                    if (read)
                    {
                        Graphics.setShadowTexels(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "ShadowDepthBias=" + Graphics.getShadowTexels();
                    }

                    Program.MyFactory.LineInt = 1098;
                    return lineToCheck;

                // shadow slope scale depth bias
                case 1098:
                    if (read)
                    {
                        Graphics.setShadowSlope(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        switch (Graphics.getShadowTexels())
                        {
                            case "0.012000":
                                lineToCheck = "ShadowSlopeScaleDepthBias=10.000000";
                                break;

                            case "0.008000":

                                if (Program.Client.texelBox.SelectedIndex == 2)
                                {
                                    lineToCheck = "ShadowSlopeScaleDepthBias=8.000000";
                                }
                                else
                                {
                                    lineToCheck = "ShadowSlopeScaleDepthBias=10.000000";
                                }

                                break;

                            case "0.003000":
                                lineToCheck = "ShadowSlopeScaleDepthBias=5.000000";
                                break;
                        }
                    }

                    Program.MyFactory.LineInt = 1127;
                    return lineToCheck;

                case 1127:
                    if (read)
                    {
                        Graphics.setDisableSphericalHarmonicLights(
                            lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "DisableSphericalHarmonicLights=" + Graphics.isDisableSphericalHarmonicLights();
                    }

                    Program.MyFactory.LineInt = 21;
                    return lineToCheck;
            }

            return lineToCheck;
        }

        public static void checkTex(string lineToCheck)
        {
            if (charCheck && charNormalCheck && poolCheck)
            {
                Program.MyFactory.texApplied();
                logger.Info("checkTex - Texture Pack Fix is enabled.");
                return;
            }

            if (lineToCheck.Equals("TEXTUREGROUP_Character=(MinLODSize=512,MaxLODSize=4096,LODBias=0)") && !charCheck)
            {
                charCheck = true;
                return;
            }

            if (lineToCheck.Equals("TEXTUREGROUP_CharacterNormalMap=(MinLODSize=512,MaxLODSize=4096,LODBias=0)") &&
                !charNormalCheck)
            {
                charNormalCheck = true;
                return;
            }

            if ((lineToCheck.Equals("PoolSize=2048") || lineToCheck.Equals("PoolSize=3072") ||
                 lineToCheck.Equals("PoolSize=4096") ||
                 lineToCheck.Equals("PoolSize=0")) && !poolCheck)
            {
                poolCheck = true;
            }
        }

        public static void checkIntro(string lineToCheck)
        {
            if (introOne && introTwo && introThree && introFour)
            {
                Program.MyFactory.introApplied();
                logger.Info("checkIntro - Startup Movies are disabled.");
                return;
            }

            if (lineToCheck.Equals(";StartupMovies=baa_logo_run_v5_h264") && !introOne)
            {
                introOne = true;
                return;
            }

            if (lineToCheck.Equals(";StartupMovies=UTlogo") && !introTwo)
            {
                introTwo = true;
                return;
            }

            if (lineToCheck.Equals(";StartupMovies=Legal") && !introThree)
            {
                introThree = true;
                return;
            }

            if (lineToCheck.Equals(";StartupMovies=Black") && !introFour)
            {
                introFour = true;
            }
        }
    }
}