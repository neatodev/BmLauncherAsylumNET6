using BmLauncherAsylumNET6.data;
using BmLauncherAsylumNET6.infrastructure;
using NLog;
using System.Diagnostics;
using System.Globalization;

namespace BmLauncherAsylumNET6.ui
{
    public partial class BmLauncherForm : Form

    {
        // logger for easy debugging
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        private static bool firstLaunch;
        private static bool readWarning;

        public bool ChangedConfig;

        public BmLauncherForm()
        {
            InitializeComponent();
        }

        private void texgroupButton_Click(object sender, EventArgs e)
        {
            Program.MyFactory.SetTexfix();
        }

        private void launchButton_Click(object sender, EventArgs e)
        {
            if (ChangedConfig)
            {
                Program.MyFactory.writeGraphFile();
            }
            else
            {
                logger.Info("No configuration changes made.");
            }


            using (Process launchBmGame = new())
            {
                try
                {
                    Factory.InputFileInfo.IsReadOnly = true;
                    if (Factory.TexmodDetected)
                    {
                        launchBmGame.StartInfo.FileName = "texmod_autoload.exe";
                        launchBmGame.StartInfo.CreateNoWindow = true;
                        launchBmGame.Start();
                        logger.Info("Launching Texmod. Logging has concluded at {0}, on {1}.",
                            DateTime.Now.ToString("HH:mm:ss"), DateTime.Now.ToString("D", new CultureInfo("en-GB")));
                        launchButton.Enabled = false;
                        LogManager.Flush();
                        Application.Exit();
                    }
                    else
                    {
                        launchBmGame.StartInfo.FileName = "ShippingPC-BmGame.exe";
                        launchBmGame.StartInfo.CreateNoWindow = true;
                        launchBmGame.Start();
                        logger.Info("Launching game application. Logging has concluded at {0}, on {1}.",
                            DateTime.Now.ToString("HH:mm:ss"), DateTime.Now.ToString("D", new CultureInfo("en-GB")));
                        launchButton.Enabled = false;
                        LogManager.Flush();
                        Application.Exit();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(
                        "Couldn't find ShippingPC_BmGame.exe or texmod_autoload.exe.\r\nPlease place the Launcher files in the correct folder.\r\n" +
                        "\r\nThe correct install folder is: \\Batman Arkham Asylum GOTY\\Binaries.",
                        @"Could not start game!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void credLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new CreditsWindow().ShowDialog();
        }

        private void keyButton_Click(object sender, EventArgs e)
        {
            Program.MyFactory.Keybinds.ShowDialog();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            Program.MyFactory.writeGraphFile();
            if (langBox.SelectedIndex != 5)
            {
                try
                {
                    langBox.Items.RemoveAt(5);
                }
                catch (ArgumentOutOfRangeException)
                {
                }
            }

            applyButton.Enabled = false;
            ChangedConfig = false;
        }

        private void nvBox_CheckedChanged(object sender, EventArgs e)
        {
            aoBox.Enabled = !nvBox.Checked;
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void fullscreenBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void resBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void vsyncBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void detailBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void ultraButton_Click(object sender, EventArgs e)
        {
            Presets.setUltra();
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void optiButton_Click(object sender, EventArgs e)
        {
            Presets.setOptimized();
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void aaBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void fogBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void bloomBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void lensFlareBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void dofBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void distBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void mBlurBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void memPoolBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void anisoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void sphericBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void aoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void dShadowBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void texelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void maxShadowBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;

            switch (maxShadowBox.SelectedIndex)
            {
                case 0:
                    texelBox.Enabled = false;
                    texelBox.SelectedIndex = 0;
                    break;
                case 1:
                    texelBox.Enabled = false;
                    texelBox.SelectedIndex = 0;
                    break;
                case 2:
                    texelBox.Enabled = true;
                    break;
                case 3:
                    texelBox.Enabled = true;
                    break;
            }
        }

        private void physxBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!firstLaunch)
            {
                firstLaunch = true;
                return;
            }

            if (physxBox.SelectedIndex == 2 && !readWarning)
            {
                MessageBox.Show(
                    "Changing your PhysX settings to \'High\' will result in\r\nhuge frame drops for certain" +
                    " sections of the game.\r\nIt is recommended to select \'Medium\' settings.", @"PhysX Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                readWarning = true;
            }

            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void disableIntroButton_Click(object sender, EventArgs e)
        {
            ChangedConfig = true;
            Program.MyFactory.SetIntroFix();
        }

        private void maxSmoothTextBox_TextChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void langBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void frameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void ManualModeBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "This option removes the 'read-only' flag of the configuration files, allowing for manual edits.\r\n" +
                "The launcher will close if you choose this option and any unsaved changes will be lost.\r\n\r\n" +
                "Do you wish to continue?", @"Enable Manual Editing",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Factory.ConfigInfo.IsReadOnly = false;
                Factory.UserEngineInfo.IsReadOnly = false;
                Factory.BmInputFileInfo.IsReadOnly = false;
                logger.Info("Closing launcher and disabling read-only flags. Logging has concluded at {0}, on {1}.",
                    DateTime.Now.ToString("HH:mm:ss"), DateTime.Now.ToString("D", new CultureInfo("en-GB")));
                LogManager.Flush();
                Application.Exit();
            }
        }

        private void rebornButton_Click(object sender, EventArgs e)
        {
            Presets.setReborn();
            ChangedConfig = true;
        }
    }
}