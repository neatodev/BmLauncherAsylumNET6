using System.Diagnostics;

namespace BmLauncherAsylumNET6.ui
{
    public partial class SpeedrunHint : Form
    {
        public SpeedrunHint()
        {
            InitializeComponent();
        }

        private void speedrunLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.speedrun.com/arkhamasylum/guide/ng47r");
        }
    }
}