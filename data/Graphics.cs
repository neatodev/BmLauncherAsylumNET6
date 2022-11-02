namespace BmLauncherWForm.data
{
    /// <summary>
    ///     Static class that stores all important parameters that are needed by BmEngine
    ///     Contains setter + getter for every parameter
    /// </summary>
    internal static class Graphics
    {
        private static string language;
        private static string fullScreen;
        private static string vsync;
        private static string resolutionX = "default";
        private static string resolutionY = "default";
        private static string detailMode;
        private static string multiSampling;
        private static string depthOfField;
        private static string ambientOcclusion;
        private static string lensFlares;
        private static string motionBlur;
        private static string bloom;
        private static string highQualityBloom;
        private static string maxAnisotropy;
        private static string dynamicShadows;
        private static string maxShadowResolution;
        private static string shadowFilterRadius;
        private static string maxSmoothedFramerate;
        private static string disableSphericalHarmonicLights;
        private static string fogVolumes;
        private static string distortion;
        private static string shadowTexels;
        private static string physX;
        private static string memoryPoolsValue;
        private static string frameThreadLag;
        private static string shadowslope;

        public static string getLanguage()
        {
            return language;
        }

        public static string getFrameThreadLag()
        {
            return frameThreadLag;
        }

        public static string isFullScreen()
        {
            return fullScreen;
        }

        public static string isVsync()
        {
            return vsync;
        }

        public static string getResolutionX()
        {
            return resolutionX;
        }

        public static string getResolutionY()
        {
            return resolutionY;
        }

        public static string getDetailMode()
        {
            return detailMode;
        }

        public static string getMultiSampling()
        {
            return multiSampling;
        }

        public static string getShadowSlope()
        {
            return shadowslope;
        }

        public static string isDepthOfField()
        {
            return depthOfField;
        }

        public static string isAmbientOcclusion()
        {
            return ambientOcclusion;
        }

        public static string isLensFlares()
        {
            return lensFlares;
        }

        public static string isMotionBlur()
        {
            return motionBlur;
        }

        public static string isBloom()
        {
            return bloom;
        }

        public static string isHighQualityBloom()
        {
            return highQualityBloom;
        }

        public static string getMaxAnisotropy()
        {
            return maxAnisotropy;
        }

        public static string isDynamicShadows()
        {
            return dynamicShadows;
        }

        public static string getMaxShadowResolution()
        {
            return maxShadowResolution;
        }

        public static string getShadowFilterRadius()
        {
            return shadowFilterRadius;
        }

        public static string getMaxSmoothedFramerate()
        {
            return maxSmoothedFramerate;
        }

        public static string isDisableSphericalHarmonicLights()
        {
            return disableSphericalHarmonicLights;
        }

        public static string isFogVolumes()
        {
            return fogVolumes;
        }

        public static string isDistortion()
        {
            return distortion;
        }

        public static string getShadowTexels()
        {
            return shadowTexels;
        }

        public static string getPhysX()
        {
            return physX;
        }

        public static string getMemoryPoolsValue()
        {
            return memoryPoolsValue;
        }

        public static void setLanguage(string setLang)
        {
            language = setLang;
        }

        public static void setFullScreen(string setBool)
        {
            fullScreen = setBool;
        }

        public static void setVsync(string setBool)
        {
            vsync = setBool;
        }

        public static void setResolutionX(string xRes)
        {
            resolutionX = xRes;
        }

        public static void setResolutionY(string yRes)
        {
            resolutionY = yRes;
        }

        public static void setDetailMode(string detMode)
        {
            detailMode = detMode;
        }

        public static void setMultiSampling(string msample)
        {
            multiSampling = msample;
        }

        public static void setDepthOfField(string setBool)
        {
            depthOfField = setBool;
        }

        public static void setShadowSlope(string slope)
        {
            shadowslope = slope;
        }

        public static void setAmbientOcclusion(string setBool)
        {
            ambientOcclusion = setBool;
        }

        public static void setLensFlares(string setBool)
        {
            lensFlares = setBool;
        }

        public static void setMotionBlur(string setBool)
        {
            motionBlur = setBool;
        }

        public static void setBloom(string setBool)
        {
            bloom = setBool;
        }

        public static void setHighQualityBloom(string setBool)
        {
            highQualityBloom = setBool;
        }

        public static void setMaxAnisotropy(string maxani)
        {
            maxAnisotropy = maxani;
        }

        public static void setDynamicShadows(string setBool)
        {
            dynamicShadows = setBool;
        }

        public static void setMaxShadowResolution(string maxshadowRes)
        {
            maxShadowResolution = maxshadowRes;
        }

        public static void setShadowFilterRadius(string shadowfradius)
        {
            shadowFilterRadius = shadowfradius;
        }

        public static void setMaxSmoothedFramerate(string maxsmoothframes)
        {
            maxSmoothedFramerate = maxsmoothframes;
        }

        public static void setDisableSphericalHarmonicLights(string newLine)
        {
            disableSphericalHarmonicLights = newLine;
        }

        public static void setFogVolumes(string newLine)
        {
            fogVolumes = newLine;
        }

        public static void setDistortion(string newLine)
        {
            distortion = newLine;
        }

        public static void setShadowTexels(string newLine)
        {
            shadowTexels = newLine;
        }

        public static void setPhysX(string newLine)
        {
            physX = newLine;
        }

        public static void setMemoryPoolsValue(string newLine)
        {
            memoryPoolsValue = newLine;
        }

        public static void setFrameThreadLag(string newLine)
        {
            frameThreadLag = newLine;
        }
    }
}