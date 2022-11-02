using System.ComponentModel;
using System.Windows.Forms;

namespace BmLauncherWForm.ui
{
    partial class SpeedrunHint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hint1 = new System.Windows.Forms.Label();
            this.speedrunLink = new System.Windows.Forms.LinkLabel();
            this.hint2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hint1
            // 
            this.hint1.AutoSize = true;
            this.hint1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hint1.Location = new System.Drawing.Point(12, 9);
            this.hint1.Name = "hint1";
            this.hint1.Size = new System.Drawing.Size(223, 13);
            this.hint1.TabIndex = 0;
            this.hint1.Text = "Keybinds have already been set according to:";
            // 
            // speedrunLink
            // 
            this.speedrunLink.AutoSize = true;
            this.speedrunLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedrunLink.Location = new System.Drawing.Point(12, 25);
            this.speedrunLink.Name = "speedrunLink";
            this.speedrunLink.Size = new System.Drawing.Size(272, 13);
            this.speedrunLink.TabIndex = 1;
            this.speedrunLink.TabStop = true;
            this.speedrunLink.Text = "https://www.speedrun.com/arkhamasylum/guide/ng47r";
            this.speedrunLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.speedrunLink_LinkClicked);
            // 
            // hint2
            // 
            this.hint2.AutoSize = true;
            this.hint2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hint2.Location = new System.Drawing.Point(12, 44);
            this.hint2.Name = "hint2";
            this.hint2.Size = new System.Drawing.Size(242, 52);
            this.hint2.TabIndex = 2;
            this.hint2.Text = "You can freely edit these two settings, or add new\r\nsettings above the last line " +
    "in the UserInput.ini.\r\n\r\n\r\n";
            // 
            // SpeedrunHint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 82);
            this.Controls.Add(this.hint2);
            this.Controls.Add(this.speedrunLink);
            this.Controls.Add(this.hint1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SpeedrunHint";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings taken care of!";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label hint1;
        private LinkLabel speedrunLink;
        private Label hint2;
    }
}