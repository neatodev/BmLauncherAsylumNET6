namespace BmLauncherAsylumNET6.data
{
    /// <summary>
    ///     Simple Class to store values for the presets.
    /// </summary>
    internal static class Presets
    {
        private static void setCommon()
        {
            Program.Client.detailBox.SelectedIndex = 2;
            Program.Client.fogBox.SelectedIndex = 1;
            Program.Client.anisoBox.SelectedIndex = 2;
            Program.Client.aoBox.SelectedIndex = 0;
            Program.Client.sphericBox.SelectedIndex = 1;
            Program.Client.bloomBox.SelectedIndex = 1;
            Program.Client.lensFlareBox.SelectedIndex = 1;
            Program.Client.dShadowBox.SelectedIndex = 1;
            Program.Client.dofBox.SelectedIndex = 1;
            Program.Client.distBox.SelectedIndex = 1;
        }

        public static void setUltra()
        {
            setCommon();
            Program.Client.aaBox.SelectedIndex = 0;
            Program.Client.maxShadowBox.SelectedIndex = 2;
            Program.Client.texelBox.SelectedIndex = 0;
            Program.Client.physxBox.SelectedIndex = Program.Client.gpInfoLabel.Text.Contains("NVIDIA") ? 1 : 0;
            Program.Client.memPoolBox.SelectedIndex = 2;
            if (Program.Client.gpInfoLabel.Text.Contains("NVIDIA") && Program.Client.nvBox.Enabled)
            {
                Program.Client.nvBox.Checked = true;
            }
        }

        public static void setOptimized()
        {
            setCommon();
            Program.Client.aaBox.SelectedIndex = 0;
            Program.Client.maxShadowBox.SelectedIndex = 1;
            Program.Client.memPoolBox.SelectedIndex = 2;
            Program.Client.texelBox.SelectedIndex = 0;
            Program.Client.physxBox.SelectedIndex = 0;
            if (Program.Client.gpInfoLabel.Text.Contains("NVIDIA") && Program.Client.nvBox.Enabled)
            {
                Program.Client.nvBox.Checked = false;
            }
        }

        public static void setReborn()
        {
            setCommon();
            Program.Client.aaBox.SelectedIndex = 0;
            Program.Client.maxShadowBox.SelectedIndex = 3;
            Program.Client.texelBox.SelectedIndex = 1;
            Program.Client.physxBox.SelectedIndex = Program.Client.gpInfoLabel.Text.Contains("NVIDIA") ? 1 : 0;
            if (Program.Client.gpInfoLabel.Text.Contains("NVIDIA") && Program.Client.nvBox.Enabled)
            {
                Program.Client.nvBox.Checked = true;
            }

            Program.Client.dofBox.SelectedIndex = 0;
            Program.Client.memPoolBox.SelectedIndex = 3;
        }
    }
}