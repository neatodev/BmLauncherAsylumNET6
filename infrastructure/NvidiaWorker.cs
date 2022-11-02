using NLog;
using NvAPIWrapper;
using NvAPIWrapper.DRS;
using NvAPIWrapper.Native.Exceptions;
using System;

namespace BmLauncherWForm.infrastructure
{
    /// <summary>
    ///     Worker class utilizing the Nvidia API through NvAPIWrapper.
    ///     Used to find Arkham Asylum NVIDIA profile and modify it.
    /// </summary>
    internal class NvidiaWorker
    {
        // logger for easy debugging
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        private static string aoActive = "0";
        private static string aoValue = "0";

        public static bool HasHbao = true;
        private readonly DriverSettingsProfile _prof;
        private readonly DriverSettingsSession _session;

        /// <summary>
        ///     Created in Program, instantiated by GuiInitializer.
        ///     Finds the Batman: Arkham Asylum Profile or creates it if it doesn't exist yet.
        ///     Calls getNVSettings().
        /// </summary>
        public NvidiaWorker()
        {
            try
            {
                NVIDIA.Initialize();
                logger.Debug("Constructor - NVIDIA API initialized.");
                _session = DriverSettingsSession.CreateAndLoad();
                try
                {
                    _session.FindProfileByName("Batman: Arkham Asylum");
                }
                catch (NVIDIAApiException e)
                {
                    Console.WriteLine(e);
                    DriverSettingsProfile profile =
                        DriverSettingsProfile.CreateProfile(_session, "Batman: Arkham Asylum");
                    ProfileApplication profApp = ProfileApplication.CreateApplication(profile, "shippingpc-bmgame.exe");
                    profile = profApp.Profile;
                    profile.SetSetting(KnownSettingId.AmbientOcclusionModeActive, 0);
                    profile.SetSetting(KnownSettingId.AmbientOcclusionMode, 0);
                    _session.Save();
                    logger.Warn("Constructor - NVIDIA profile not found. Creating profile: {0}", profile.ToString());
                }

                _prof = _session.FindProfileByName("Batman: Arkham Asylum");
                getNVSettings();
                logger.Info("Constructor - NVIDIA profile fully processed.");
            }
            catch (NVIDIANotSupportedException e)
            {
                NVIDIA.Initialize();
                Program.Client.nvBox.Enabled = false;
                logger.Warn("Constructor - Caught NVIDIANotSupportedException: {0}.", e);
            }
        }

        /// <summary>
        ///     Sets NVIDIA settings in accordance to user input.
        ///     Called by GraphicsWriter.
        /// </summary>
        public void setNVSettings()
        {
            try
            {
                if (Program.Client.nvBox.Checked && Program.Client.nvBox.Enabled)
                {
                    _prof.SetSetting(KnownSettingId.AmbientOcclusionModeActive, 1);
                    _prof.SetSetting(KnownSettingId.AmbientOcclusionMode, 2);
                    _session.Save();
                }
                else if (Program.Client.nvBox.Enabled)
                {
                    _prof.SetSetting(KnownSettingId.AmbientOcclusionModeActive, 0);
                    _prof.SetSetting(KnownSettingId.AmbientOcclusionMode, 0);
                    _session.Save();
                }

                logger.Debug(
                    "setNVSettings - setting AmbientOcclusionModeActive to {0}, setting AmbientOcclusionMode to {1}",
                    _prof.GetSetting(KnownSettingId.AmbientOcclusionModeActive).CurrentValue,
                    _prof.GetSetting(KnownSettingId.AmbientOcclusionMode).CurrentValue);
            }
            catch (NullReferenceException e)
            {
                logger.Warn("setNVSettings - Caught NullReferenceException: {0}", e);
            }
        }

        /// <summary>
        ///     Gets the current NVIDIA settings from the profile.
        ///     Adjusts checkbox accordingly.
        /// </summary>
        public void getNVSettings()
        {
            Int16 compValue = 0;
            try
            {
                aoActive = _prof.GetSetting(KnownSettingId.AmbientOcclusionModeActive).ToString();
                aoValue = _prof.GetSetting(KnownSettingId.AmbientOcclusionMode).ToString();
                compValue = Int16.Parse(_prof.GetSetting(2916165).CurrentValue.ToString());
            }
            catch (Exception)
            {
                _prof.SetSetting(KnownSettingId.AmbientOcclusionModeActive, 0);
                _prof.SetSetting(KnownSettingId.AmbientOcclusionMode, 0);
                Program.Client.nvBox.Checked = false;
                logger.Warn(
                    "getNVSettings - couldn't find ambient occlusion settings. Generating settings with default(0) values now.");
            }

            if (!aoActive.Contains("1") || !aoValue.Contains("2") || compValue != 48)
            {
                if (compValue != 48)
                {
                    HasHbao = false;
                }
            }
            else
            {
                Program.Client.nvBox.Checked = true;
            }

            logger.Debug("getNVSettings - hbao+ is currently {0}", HasHbao);
        }
    }
}