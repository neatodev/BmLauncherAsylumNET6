using System.Diagnostics;

namespace BmLauncherAsylumNET6.ui
{
    public partial class CreditsWindow : Form
    {
        public CreditsWindow()
        {
            InitializeComponent();
        }

        private void rockCred_Click(object sender, EventArgs e)
        {
        }

        private void frofooLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://steamcommunity.com/id/frofoo/", UseShellExecute = true });
        }

        private void gpLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://www.youtube.com/c/GPUnity", UseShellExecute = true });
        }

        private void everLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Random number = new();

            if ((number.NextDouble() * (100.0 - 1.0)) + 1.0 <= 7.0)
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://en.wikipedia.org/wiki/Baguette", UseShellExecute = true });
            }
            else
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://www.nexusmods.com/users/6875632?tab=user+files", UseShellExecute = true });
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://steamcommunity.com/sharedfiles/filedetails/?id=1159691355", UseShellExecute = true });

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://github.com/neatodev/BmLauncherAsylumNET6", UseShellExecute = true });

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://www.paypal.com/donate/?hosted_button_id=LG7YTKP4JYN5S", UseShellExecute = true });
        }
    }
}