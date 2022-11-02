using System.ComponentModel;
using System.Windows.Forms;

namespace BmLauncherAsylumNET6.ui
{
    partial class CreditsWindow
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
            this.rockCred = new System.Windows.Forms.Label();
            this.credBox = new System.Windows.Forms.GroupBox();
            this.writtenLabel = new System.Windows.Forms.Label();
            this.everLabel = new System.Windows.Forms.LinkLabel();
            this.gpLabel = new System.Windows.Forms.LinkLabel();
            this.collabLabel = new System.Windows.Forms.Label();
            this.frofooLabel = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.credBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rockCred
            // 
            this.rockCred.AutoSize = true;
            this.rockCred.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rockCred.Location = new System.Drawing.Point(9, 9);
            this.rockCred.Name = "rockCred";
            this.rockCred.Size = new System.Drawing.Size(186, 13);
            this.rockCred.TabIndex = 0;
            this.rockCred.Text = "Game created by Rocksteady Studios";
            this.rockCred.Click += new System.EventHandler(this.rockCred_Click);
            // 
            // credBox
            // 
            this.credBox.Controls.Add(this.writtenLabel);
            this.credBox.Controls.Add(this.everLabel);
            this.credBox.Controls.Add(this.gpLabel);
            this.credBox.Controls.Add(this.collabLabel);
            this.credBox.Controls.Add(this.frofooLabel);
            this.credBox.Location = new System.Drawing.Point(12, 25);
            this.credBox.Name = "credBox";
            this.credBox.Size = new System.Drawing.Size(180, 91);
            this.credBox.TabIndex = 1;
            this.credBox.TabStop = false;
            // 
            // writtenLabel
            // 
            this.writtenLabel.AutoSize = true;
            this.writtenLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.writtenLabel.Location = new System.Drawing.Point(6, 12);
            this.writtenLabel.Name = "writtenLabel";
            this.writtenLabel.Size = new System.Drawing.Size(110, 13);
            this.writtenLabel.TabIndex = 4;
            this.writtenLabel.Text = "Application written by:";
            // 
            // everLabel
            // 
            this.everLabel.AutoSize = true;
            this.everLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.everLabel.Location = new System.Drawing.Point(6, 74);
            this.everLabel.Name = "everLabel";
            this.everLabel.Size = new System.Drawing.Size(74, 13);
            this.everLabel.TabIndex = 3;
            this.everLabel.TabStop = true;
            this.everLabel.Text = "EVERGREEN";
            this.everLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.everLabel_LinkClicked);
            // 
            // gpLabel
            // 
            this.gpLabel.AutoSize = true;
            this.gpLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.gpLabel.Location = new System.Drawing.Point(6, 59);
            this.gpLabel.Name = "gpLabel";
            this.gpLabel.Size = new System.Drawing.Size(46, 13);
            this.gpLabel.TabIndex = 2;
            this.gpLabel.TabStop = true;
            this.gpLabel.Text = "GPUnity";
            this.gpLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gpLabel_LinkClicked);
            // 
            // collabLabel
            // 
            this.collabLabel.AutoSize = true;
            this.collabLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.collabLabel.Location = new System.Drawing.Point(6, 45);
            this.collabLabel.Name = "collabLabel";
            this.collabLabel.Size = new System.Drawing.Size(105, 13);
            this.collabLabel.TabIndex = 1;
            this.collabLabel.Text = "In Collaboration with:";
            // 
            // frofooLabel
            // 
            this.frofooLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.frofooLabel.AutoSize = true;
            this.frofooLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.frofooLabel.Location = new System.Drawing.Point(7, 27);
            this.frofooLabel.Name = "frofooLabel";
            this.frofooLabel.Size = new System.Drawing.Size(34, 13);
            this.frofooLabel.TabIndex = 0;
            this.frofooLabel.TabStop = true;
            this.frofooLabel.Text = "frofoo";
            this.frofooLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.frofooLabel_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 30);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(45, 11);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(91, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Github Repository";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel2);
            this.groupBox2.Location = new System.Drawing.Point(12, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 30);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel2.Location = new System.Drawing.Point(45, 11);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(90, 13);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "HD Texture Pack";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.linkLabel3);
            this.groupBox3.Location = new System.Drawing.Point(12, 169);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 30);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // linkLabel3
            // 
            this.linkLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel3.LinkColor = System.Drawing.Color.DarkGoldenrod;
            this.linkLabel3.Location = new System.Drawing.Point(33, 11);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(117, 13);
            this.linkLabel3.TabIndex = 5;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Support the Project";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // CreditsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(204, 208);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.credBox);
            this.Controls.Add(this.rockCred);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreditsWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information";
            this.TopMost = true;
            this.credBox.ResumeLayout(false);
            this.credBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label rockCred;
        private GroupBox credBox;
        private LinkLabel everLabel;
        private LinkLabel gpLabel;
        private Label collabLabel;
        private LinkLabel frofooLabel;
        private Label writtenLabel;
        private GroupBox groupBox1;
        private LinkLabel linkLabel1;
        private GroupBox groupBox2;
        private LinkLabel linkLabel2;
        private GroupBox groupBox3;
        private LinkLabel linkLabel3;
    }
}