using System.ComponentModel;
using System.Windows.Forms;

namespace BmLauncherWForm.ui
{
    partial class KeybindForm
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
            this.fwLabel = new System.Windows.Forms.Label();
            this.leftLabel = new System.Windows.Forms.Label();
            this.bwLabel = new System.Windows.Forms.Label();
            this.rightLabel = new System.Windows.Forms.Label();
            this.zoomLabel = new System.Windows.Forms.Label();
            this.crouchLabel = new System.Windows.Forms.Label();
            this.crouchtoggleLabel = new System.Windows.Forms.Label();
            this.grappleLabel = new System.Windows.Forms.Label();
            this.runglideuseLabel = new System.Windows.Forms.Label();
            this.movBox = new System.Windows.Forms.GroupBox();
            this.crouchToggleButton = new System.Windows.Forms.Button();
            this.grappleButton = new System.Windows.Forms.Button();
            this.zoomButton = new System.Windows.Forms.Button();
            this.crouchButton = new System.Windows.Forms.Button();
            this.RGUButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.bwButton = new System.Windows.Forms.Button();
            this.fwButton = new System.Windows.Forms.Button();
            this.quickBataLabel = new System.Windows.Forms.Label();
            this.quickClawLabel = new System.Windows.Forms.Label();
            this.throwLabel = new System.Windows.Forms.Label();
            this.cTakeDownLabel = new System.Windows.Forms.Label();
            this.detectiveLabel = new System.Windows.Forms.Label();
            this.useStrikeLabel1 = new System.Windows.Forms.Label();
            this.aimCounterLabel1 = new System.Windows.Forms.Label();
            this.secondaryLabel = new System.Windows.Forms.Label();
            this.aimCounterLabel3 = new System.Windows.Forms.Label();
            this.aimCounterLabel2 = new System.Windows.Forms.Label();
            this.secondaryStunLabel2 = new System.Windows.Forms.Label();
            this.quickBatButton = new System.Windows.Forms.Button();
            this.detButton = new System.Windows.Forms.Button();
            this.actionBox = new System.Windows.Forms.GroupBox();
            this.capeStunButton = new System.Windows.Forms.Button();
            this.ACTButton = new System.Windows.Forms.Button();
            this.useStrikeLabel2 = new System.Windows.Forms.Label();
            this.gadStrikeButton = new System.Windows.Forms.Button();
            this.gadSecButton = new System.Windows.Forms.Button();
            this.cTakedownButton = new System.Windows.Forms.Button();
            this.throwButton = new System.Windows.Forms.Button();
            this.quickClawButton = new System.Windows.Forms.Button();
            this.applyKeyButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.helpLabel = new System.Windows.Forms.LinkLabel();
            this.controlLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SensitivityValueLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SensitivityBar = new System.Windows.Forms.TrackBar();
            this.MouseSmoothBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.movBox.SuspendLayout();
            this.actionBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SensitivityBar)).BeginInit();
            this.SuspendLayout();
            // 
            // fwLabel
            // 
            this.fwLabel.AutoSize = true;
            this.fwLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fwLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fwLabel.Location = new System.Drawing.Point(58, 34);
            this.fwLabel.Name = "fwLabel";
            this.fwLabel.Size = new System.Drawing.Size(57, 15);
            this.fwLabel.TabIndex = 12;
            this.fwLabel.Text = "Forward:";
            // 
            // leftLabel
            // 
            this.leftLabel.AutoSize = true;
            this.leftLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.leftLabel.Location = new System.Drawing.Point(83, 92);
            this.leftLabel.Name = "leftLabel";
            this.leftLabel.Size = new System.Drawing.Size(32, 15);
            this.leftLabel.TabIndex = 13;
            this.leftLabel.Text = "Left:";
            // 
            // bwLabel
            // 
            this.bwLabel.AutoSize = true;
            this.bwLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bwLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bwLabel.Location = new System.Drawing.Point(47, 63);
            this.bwLabel.Name = "bwLabel";
            this.bwLabel.Size = new System.Drawing.Size(68, 15);
            this.bwLabel.TabIndex = 14;
            this.bwLabel.Text = "Backwards:";
            // 
            // rightLabel
            // 
            this.rightLabel.AutoSize = true;
            this.rightLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rightLabel.Location = new System.Drawing.Point(76, 121);
            this.rightLabel.Name = "rightLabel";
            this.rightLabel.Size = new System.Drawing.Size(39, 15);
            this.rightLabel.TabIndex = 15;
            this.rightLabel.Text = "Right:";
            // 
            // zoomLabel
            // 
            this.zoomLabel.AutoSize = true;
            this.zoomLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoomLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.zoomLabel.Location = new System.Drawing.Point(298, 63);
            this.zoomLabel.Name = "zoomLabel";
            this.zoomLabel.Size = new System.Drawing.Size(42, 15);
            this.zoomLabel.TabIndex = 16;
            this.zoomLabel.Text = "Zoom:";
            // 
            // crouchLabel
            // 
            this.crouchLabel.AutoSize = true;
            this.crouchLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crouchLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.crouchLabel.Location = new System.Drawing.Point(291, 34);
            this.crouchLabel.Name = "crouchLabel";
            this.crouchLabel.Size = new System.Drawing.Size(49, 15);
            this.crouchLabel.TabIndex = 17;
            this.crouchLabel.Text = "Crouch:";
            // 
            // crouchtoggleLabel
            // 
            this.crouchtoggleLabel.AutoSize = true;
            this.crouchtoggleLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crouchtoggleLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.crouchtoggleLabel.Location = new System.Drawing.Point(254, 121);
            this.crouchtoggleLabel.Name = "crouchtoggleLabel";
            this.crouchtoggleLabel.Size = new System.Drawing.Size(86, 15);
            this.crouchtoggleLabel.TabIndex = 18;
            this.crouchtoggleLabel.Text = "Crouch Toggle:";
            // 
            // grappleLabel
            // 
            this.grappleLabel.AutoSize = true;
            this.grappleLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grappleLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grappleLabel.Location = new System.Drawing.Point(286, 92);
            this.grappleLabel.Name = "grappleLabel";
            this.grappleLabel.Size = new System.Drawing.Size(54, 15);
            this.grappleLabel.TabIndex = 19;
            this.grappleLabel.Text = "Grapple:";
            // 
            // runglideuseLabel
            // 
            this.runglideuseLabel.AutoSize = true;
            this.runglideuseLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runglideuseLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.runglideuseLabel.Location = new System.Drawing.Point(160, 150);
            this.runglideuseLabel.Name = "runglideuseLabel";
            this.runglideuseLabel.Size = new System.Drawing.Size(92, 15);
            this.runglideuseLabel.TabIndex = 20;
            this.runglideuseLabel.Text = "Run/Glide/Use:";
            // 
            // movBox
            // 
            this.movBox.Controls.Add(this.crouchToggleButton);
            this.movBox.Controls.Add(this.grappleButton);
            this.movBox.Controls.Add(this.zoomButton);
            this.movBox.Controls.Add(this.crouchButton);
            this.movBox.Controls.Add(this.RGUButton);
            this.movBox.Controls.Add(this.leftButton);
            this.movBox.Controls.Add(this.rightButton);
            this.movBox.Controls.Add(this.bwButton);
            this.movBox.Controls.Add(this.fwButton);
            this.movBox.Controls.Add(this.crouchtoggleLabel);
            this.movBox.Controls.Add(this.grappleLabel);
            this.movBox.Controls.Add(this.runglideuseLabel);
            this.movBox.Controls.Add(this.fwLabel);
            this.movBox.Controls.Add(this.zoomLabel);
            this.movBox.Controls.Add(this.crouchLabel);
            this.movBox.Controls.Add(this.bwLabel);
            this.movBox.Controls.Add(this.leftLabel);
            this.movBox.Controls.Add(this.rightLabel);
            this.movBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movBox.Location = new System.Drawing.Point(12, 12);
            this.movBox.Name = "movBox";
            this.movBox.Size = new System.Drawing.Size(471, 176);
            this.movBox.TabIndex = 21;
            this.movBox.TabStop = false;
            this.movBox.Text = "Movement Controls";
            // 
            // crouchToggleButton
            // 
            this.crouchToggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crouchToggleButton.Font = new System.Drawing.Font("Calibri", 7F, System.Drawing.FontStyle.Bold);
            this.crouchToggleButton.Location = new System.Drawing.Point(345, 117);
            this.crouchToggleButton.Name = "crouchToggleButton";
            this.crouchToggleButton.Size = new System.Drawing.Size(115, 23);
            this.crouchToggleButton.TabIndex = 38;
            this.crouchToggleButton.Text = "CrouchToggleKey";
            this.crouchToggleButton.UseVisualStyleBackColor = true;
            this.crouchToggleButton.Click += new System.EventHandler(this.crouchToggleButton_Click);
            // 
            // grappleButton
            // 
            this.grappleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grappleButton.Font = new System.Drawing.Font("Calibri", 7F, System.Drawing.FontStyle.Bold);
            this.grappleButton.Location = new System.Drawing.Point(345, 88);
            this.grappleButton.Name = "grappleButton";
            this.grappleButton.Size = new System.Drawing.Size(115, 23);
            this.grappleButton.TabIndex = 37;
            this.grappleButton.Text = "GrappleKey";
            this.grappleButton.UseVisualStyleBackColor = true;
            this.grappleButton.Click += new System.EventHandler(this.grappleButton_Click);
            // 
            // zoomButton
            // 
            this.zoomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zoomButton.Font = new System.Drawing.Font("Calibri", 7F, System.Drawing.FontStyle.Bold);
            this.zoomButton.Location = new System.Drawing.Point(345, 59);
            this.zoomButton.Name = "zoomButton";
            this.zoomButton.Size = new System.Drawing.Size(115, 23);
            this.zoomButton.TabIndex = 36;
            this.zoomButton.Text = "ZoomKey";
            this.zoomButton.UseVisualStyleBackColor = true;
            this.zoomButton.Click += new System.EventHandler(this.zoomButton_Click);
            // 
            // crouchButton
            // 
            this.crouchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crouchButton.Font = new System.Drawing.Font("Calibri", 7F, System.Drawing.FontStyle.Bold);
            this.crouchButton.Location = new System.Drawing.Point(345, 30);
            this.crouchButton.Name = "crouchButton";
            this.crouchButton.Size = new System.Drawing.Size(115, 23);
            this.crouchButton.TabIndex = 35;
            this.crouchButton.Text = "CrouchKey";
            this.crouchButton.UseVisualStyleBackColor = true;
            this.crouchButton.Click += new System.EventHandler(this.crouchButton_Click);
            // 
            // RGUButton
            // 
            this.RGUButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RGUButton.Font = new System.Drawing.Font("Calibri", 7F, System.Drawing.FontStyle.Bold);
            this.RGUButton.Location = new System.Drawing.Point(257, 146);
            this.RGUButton.Name = "RGUButton";
            this.RGUButton.Size = new System.Drawing.Size(115, 23);
            this.RGUButton.TabIndex = 34;
            this.RGUButton.Text = "RGUKey";
            this.RGUButton.UseVisualStyleBackColor = true;
            this.RGUButton.Click += new System.EventHandler(this.RGUButton_Click);
            // 
            // leftButton
            // 
            this.leftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftButton.Font = new System.Drawing.Font("Calibri", 7F, System.Drawing.FontStyle.Bold);
            this.leftButton.Location = new System.Drawing.Point(120, 88);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(115, 23);
            this.leftButton.TabIndex = 32;
            this.leftButton.Text = "LeftKey";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightButton.Font = new System.Drawing.Font("Calibri", 7F, System.Drawing.FontStyle.Bold);
            this.rightButton.Location = new System.Drawing.Point(120, 117);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(115, 23);
            this.rightButton.TabIndex = 33;
            this.rightButton.Text = "RightKey";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // bwButton
            // 
            this.bwButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bwButton.Font = new System.Drawing.Font("Calibri", 7F, System.Drawing.FontStyle.Bold);
            this.bwButton.Location = new System.Drawing.Point(120, 59);
            this.bwButton.Name = "bwButton";
            this.bwButton.Size = new System.Drawing.Size(115, 23);
            this.bwButton.TabIndex = 31;
            this.bwButton.Text = "BwKey";
            this.bwButton.UseVisualStyleBackColor = true;
            this.bwButton.Click += new System.EventHandler(this.bwButton_Click);
            // 
            // fwButton
            // 
            this.fwButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fwButton.Font = new System.Drawing.Font("Calibri", 7F, System.Drawing.FontStyle.Bold);
            this.fwButton.Location = new System.Drawing.Point(120, 30);
            this.fwButton.Name = "fwButton";
            this.fwButton.Size = new System.Drawing.Size(115, 23);
            this.fwButton.TabIndex = 30;
            this.fwButton.Text = "FwKey";
            this.fwButton.UseVisualStyleBackColor = true;
            this.fwButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // quickBataLabel
            // 
            this.quickBataLabel.AutoSize = true;
            this.quickBataLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickBataLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.quickBataLabel.Location = new System.Drawing.Point(23, 22);
            this.quickBataLabel.Name = "quickBataLabel";
            this.quickBataLabel.Size = new System.Drawing.Size(92, 15);
            this.quickBataLabel.TabIndex = 39;
            this.quickBataLabel.Text = "Quick Batarang:";
            // 
            // quickClawLabel
            // 
            this.quickClawLabel.AutoSize = true;
            this.quickClawLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickClawLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.quickClawLabel.Location = new System.Drawing.Point(29, 51);
            this.quickClawLabel.Name = "quickClawLabel";
            this.quickClawLabel.Size = new System.Drawing.Size(86, 15);
            this.quickClawLabel.TabIndex = 40;
            this.quickClawLabel.Text = "Quick Batclaw:";
            // 
            // throwLabel
            // 
            this.throwLabel.AutoSize = true;
            this.throwLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.throwLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.throwLabel.Location = new System.Drawing.Point(69, 80);
            this.throwLabel.Name = "throwLabel";
            this.throwLabel.Size = new System.Drawing.Size(46, 15);
            this.throwLabel.TabIndex = 41;
            this.throwLabel.Text = "Throw:";
            // 
            // cTakeDownLabel
            // 
            this.cTakeDownLabel.AutoSize = true;
            this.cTakeDownLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTakeDownLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cTakeDownLabel.Location = new System.Drawing.Point(3, 109);
            this.cTakeDownLabel.Name = "cTakeDownLabel";
            this.cTakeDownLabel.Size = new System.Drawing.Size(112, 15);
            this.cTakeDownLabel.TabIndex = 42;
            this.cTakeDownLabel.Text = "Combat Takedown:";
            // 
            // detectiveLabel
            // 
            this.detectiveLabel.AutoSize = true;
            this.detectiveLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detectiveLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.detectiveLabel.Location = new System.Drawing.Point(241, 22);
            this.detectiveLabel.Name = "detectiveLabel";
            this.detectiveLabel.Size = new System.Drawing.Size(99, 15);
            this.detectiveLabel.TabIndex = 43;
            this.detectiveLabel.Text = "Detective Mode:";
            // 
            // useStrikeLabel1
            // 
            this.useStrikeLabel1.AutoSize = true;
            this.useStrikeLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useStrikeLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.useStrikeLabel1.Location = new System.Drawing.Point(267, 47);
            this.useStrikeLabel1.Name = "useStrikeLabel1";
            this.useStrikeLabel1.Size = new System.Drawing.Size(73, 15);
            this.useStrikeLabel1.TabIndex = 44;
            this.useStrikeLabel1.Text = "Use Gadget:";
            // 
            // aimCounterLabel1
            // 
            this.aimCounterLabel1.AutoSize = true;
            this.aimCounterLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aimCounterLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aimCounterLabel1.Location = new System.Drawing.Point(265, 83);
            this.aimCounterLabel1.Name = "aimCounterLabel1";
            this.aimCounterLabel1.Size = new System.Drawing.Size(75, 15);
            this.aimCounterLabel1.TabIndex = 45;
            this.aimCounterLabel1.Text = "Aim Gadget:";
            // 
            // secondaryLabel
            // 
            this.secondaryLabel.AutoSize = true;
            this.secondaryLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondaryLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.secondaryLabel.Location = new System.Drawing.Point(6, 138);
            this.secondaryLabel.Name = "secondaryLabel";
            this.secondaryLabel.Size = new System.Drawing.Size(109, 15);
            this.secondaryLabel.TabIndex = 46;
            this.secondaryLabel.Text = "Gadget Secondary:";
            // 
            // aimCounterLabel3
            // 
            this.aimCounterLabel3.AutoSize = true;
            this.aimCounterLabel3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aimCounterLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aimCounterLabel3.Location = new System.Drawing.Point(274, 113);
            this.aimCounterLabel3.Name = "aimCounterLabel3";
            this.aimCounterLabel3.Size = new System.Drawing.Size(66, 15);
            this.aimCounterLabel3.TabIndex = 47;
            this.aimCounterLabel3.Text = "Takedown:";
            // 
            // aimCounterLabel2
            // 
            this.aimCounterLabel2.AutoSize = true;
            this.aimCounterLabel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aimCounterLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aimCounterLabel2.Location = new System.Drawing.Point(284, 98);
            this.aimCounterLabel2.Name = "aimCounterLabel2";
            this.aimCounterLabel2.Size = new System.Drawing.Size(56, 15);
            this.aimCounterLabel2.TabIndex = 48;
            this.aimCounterLabel2.Text = "Counter:";
            // 
            // secondaryStunLabel2
            // 
            this.secondaryStunLabel2.AutoSize = true;
            this.secondaryStunLabel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondaryStunLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.secondaryStunLabel2.Location = new System.Drawing.Point(274, 138);
            this.secondaryStunLabel2.Name = "secondaryStunLabel2";
            this.secondaryStunLabel2.Size = new System.Drawing.Size(66, 15);
            this.secondaryStunLabel2.TabIndex = 49;
            this.secondaryStunLabel2.Text = "Cape Stun:";
            // 
            // quickBatButton
            // 
            this.quickBatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quickBatButton.Font = new System.Drawing.Font("Calibri", 7F, System.Drawing.FontStyle.Bold);
            this.quickBatButton.Location = new System.Drawing.Point(120, 18);
            this.quickBatButton.Name = "quickBatButton";
            this.quickBatButton.Size = new System.Drawing.Size(115, 23);
            this.quickBatButton.TabIndex = 39;
            this.quickBatButton.Text = "QBatKey";
            this.quickBatButton.UseVisualStyleBackColor = true;
            this.quickBatButton.Click += new System.EventHandler(this.quickBatButton_Click);
            // 
            // detButton
            // 
            this.detButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detButton.Font = new System.Drawing.Font("Calibri", 7F, System.Drawing.FontStyle.Bold);
            this.detButton.Location = new System.Drawing.Point(345, 18);
            this.detButton.Name = "detButton";
            this.detButton.Size = new System.Drawing.Size(115, 23);
            this.detButton.TabIndex = 39;
            this.detButton.Text = "DetKey";
            this.detButton.UseVisualStyleBackColor = true;
            this.detButton.Click += new System.EventHandler(this.detButton_Click);
            // 
            // actionBox
            // 
            this.actionBox.Controls.Add(this.capeStunButton);
            this.actionBox.Controls.Add(this.ACTButton);
            this.actionBox.Controls.Add(this.useStrikeLabel2);
            this.actionBox.Controls.Add(this.gadStrikeButton);
            this.actionBox.Controls.Add(this.aimCounterLabel3);
            this.actionBox.Controls.Add(this.aimCounterLabel2);
            this.actionBox.Controls.Add(this.gadSecButton);
            this.actionBox.Controls.Add(this.cTakedownButton);
            this.actionBox.Controls.Add(this.aimCounterLabel1);
            this.actionBox.Controls.Add(this.throwButton);
            this.actionBox.Controls.Add(this.useStrikeLabel1);
            this.actionBox.Controls.Add(this.secondaryStunLabel2);
            this.actionBox.Controls.Add(this.detectiveLabel);
            this.actionBox.Controls.Add(this.quickClawButton);
            this.actionBox.Controls.Add(this.quickBataLabel);
            this.actionBox.Controls.Add(this.quickBatButton);
            this.actionBox.Controls.Add(this.secondaryLabel);
            this.actionBox.Controls.Add(this.detButton);
            this.actionBox.Controls.Add(this.quickClawLabel);
            this.actionBox.Controls.Add(this.throwLabel);
            this.actionBox.Controls.Add(this.cTakeDownLabel);
            this.actionBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionBox.Location = new System.Drawing.Point(12, 194);
            this.actionBox.Name = "actionBox";
            this.actionBox.Size = new System.Drawing.Size(471, 185);
            this.actionBox.TabIndex = 39;
            this.actionBox.TabStop = false;
            this.actionBox.Text = "Action Controls:";
            // 
            // capeStunButton
            // 
            this.capeStunButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.capeStunButton.Font = new System.Drawing.Font("Calibri", 7F, System.Drawing.FontStyle.Bold);
            this.capeStunButton.Location = new System.Drawing.Point(345, 134);
            this.capeStunButton.Name = "capeStunButton";
            this.capeStunButton.Size = new System.Drawing.Size(115, 23);
            this.capeStunButton.TabIndex = 55;
            this.capeStunButton.Text = "StunKey";
            this.capeStunButton.UseVisualStyleBackColor = true;
            this.capeStunButton.Click += new System.EventHandler(this.capeStunButton_Click);
            // 
            // ACTButton
            // 
            this.ACTButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ACTButton.Font = new System.Drawing.Font("Calibri", 7F, System.Drawing.FontStyle.Bold);
            this.ACTButton.Location = new System.Drawing.Point(345, 83);
            this.ACTButton.Name = "ACTButton";
            this.ACTButton.Size = new System.Drawing.Size(115, 45);
            this.ACTButton.TabIndex = 54;
            this.ACTButton.Text = "ACTKey";
            this.ACTButton.UseVisualStyleBackColor = true;
            this.ACTButton.Click += new System.EventHandler(this.ACTButton_Click);
            // 
            // useStrikeLabel2
            // 
            this.useStrikeLabel2.AutoSize = true;
            this.useStrikeLabel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useStrikeLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.useStrikeLabel2.Location = new System.Drawing.Point(297, 62);
            this.useStrikeLabel2.Name = "useStrikeLabel2";
            this.useStrikeLabel2.Size = new System.Drawing.Size(43, 15);
            this.useStrikeLabel2.TabIndex = 53;
            this.useStrikeLabel2.Text = "Strike:";
            // 
            // gadStrikeButton
            // 
            this.gadStrikeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gadStrikeButton.Font = new System.Drawing.Font("Calibri", 7F, System.Drawing.FontStyle.Bold);
            this.gadStrikeButton.Location = new System.Drawing.Point(345, 47);
            this.gadStrikeButton.Name = "gadStrikeButton";
            this.gadStrikeButton.Size = new System.Drawing.Size(115, 30);
            this.gadStrikeButton.TabIndex = 52;
            this.gadStrikeButton.Text = "GSKey";
            this.gadStrikeButton.UseVisualStyleBackColor = true;
            this.gadStrikeButton.Click += new System.EventHandler(this.gadStrikeButton_Click);
            // 
            // gadSecButton
            // 
            this.gadSecButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gadSecButton.Font = new System.Drawing.Font("Calibri", 7F, System.Drawing.FontStyle.Bold);
            this.gadSecButton.Location = new System.Drawing.Point(120, 134);
            this.gadSecButton.Name = "gadSecButton";
            this.gadSecButton.Size = new System.Drawing.Size(115, 23);
            this.gadSecButton.TabIndex = 51;
            this.gadSecButton.Text = "GadSKey";
            this.gadSecButton.UseVisualStyleBackColor = true;
            this.gadSecButton.Click += new System.EventHandler(this.gadSecButton_Click);
            // 
            // cTakedownButton
            // 
            this.cTakedownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cTakedownButton.Font = new System.Drawing.Font("Calibri", 7F, System.Drawing.FontStyle.Bold);
            this.cTakedownButton.Location = new System.Drawing.Point(120, 105);
            this.cTakedownButton.Name = "cTakedownButton";
            this.cTakedownButton.Size = new System.Drawing.Size(115, 23);
            this.cTakedownButton.TabIndex = 50;
            this.cTakedownButton.Text = "CTDKey";
            this.cTakedownButton.UseVisualStyleBackColor = true;
            this.cTakedownButton.Click += new System.EventHandler(this.cTakedownButton_Click);
            // 
            // throwButton
            // 
            this.throwButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.throwButton.Font = new System.Drawing.Font("Calibri", 7F, System.Drawing.FontStyle.Bold);
            this.throwButton.Location = new System.Drawing.Point(120, 76);
            this.throwButton.Name = "throwButton";
            this.throwButton.Size = new System.Drawing.Size(115, 23);
            this.throwButton.TabIndex = 43;
            this.throwButton.Text = "ThrowKey";
            this.throwButton.UseVisualStyleBackColor = true;
            this.throwButton.Click += new System.EventHandler(this.throwButton_Click);
            // 
            // quickClawButton
            // 
            this.quickClawButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quickClawButton.Font = new System.Drawing.Font("Calibri", 7F, System.Drawing.FontStyle.Bold);
            this.quickClawButton.Location = new System.Drawing.Point(120, 47);
            this.quickClawButton.Name = "quickClawButton";
            this.quickClawButton.Size = new System.Drawing.Size(115, 23);
            this.quickClawButton.TabIndex = 42;
            this.quickClawButton.Text = "QClawKey";
            this.quickClawButton.UseVisualStyleBackColor = true;
            this.quickClawButton.Click += new System.EventHandler(this.quickClawButton_Click);
            // 
            // applyKeyButton
            // 
            this.applyKeyButton.Enabled = false;
            this.applyKeyButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyKeyButton.Location = new System.Drawing.Point(12, 488);
            this.applyKeyButton.Name = "applyKeyButton";
            this.applyKeyButton.Size = new System.Drawing.Size(364, 23);
            this.applyKeyButton.TabIndex = 42;
            this.applyKeyButton.Text = "Apply Settings";
            this.applyKeyButton.UseVisualStyleBackColor = true;
            this.applyKeyButton.Click += new System.EventHandler(this.applyKeyButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(382, 488);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(101, 23);
            this.resetButton.TabIndex = 43;
            this.resetButton.Text = "Reset Keybinds";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // helpLabel
            // 
            this.helpLabel.AutoSize = true;
            this.helpLabel.Location = new System.Drawing.Point(455, 512);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(29, 13);
            this.helpLabel.TabIndex = 44;
            this.helpLabel.TabStop = true;
            this.helpLabel.Text = "Help";
            this.helpLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.helpLabel_LinkClicked);
            // 
            // controlLabel
            // 
            this.controlLabel.AutoSize = true;
            this.controlLabel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlLabel.Location = new System.Drawing.Point(9, 514);
            this.controlLabel.Name = "controlLabel";
            this.controlLabel.Size = new System.Drawing.Size(297, 13);
            this.controlLabel.TabIndex = 45;
            this.controlLabel.Text = "If you intend to use a Controller, these settings can be ignored.";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.speedLabel.Location = new System.Drawing.Point(412, 5);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(74, 13);
            this.speedLabel.TabIndex = 46;
            this.speedLabel.TabStop = true;
            this.speedLabel.Text = "Speedrunner?";
            this.speedLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.speedLabel_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SensitivityValueLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SensitivityBar);
            this.groupBox1.Controls.Add(this.MouseSmoothBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 385);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 97);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mouse Settings:";
            // 
            // SensitivityValueLabel
            // 
            this.SensitivityValueLabel.AutoSize = true;
            this.SensitivityValueLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SensitivityValueLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SensitivityValueLabel.Location = new System.Drawing.Point(122, 31);
            this.SensitivityValueLabel.Name = "SensitivityValueLabel";
            this.SensitivityValueLabel.Size = new System.Drawing.Size(37, 15);
            this.SensitivityValueLabel.TabIndex = 60;
            this.SensitivityValueLabel.Text = "Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(13, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 59;
            this.label2.Text = "Mouse Sensitivity:";
            // 
            // SensitivityBar
            // 
            this.SensitivityBar.Location = new System.Drawing.Point(9, 49);
            this.SensitivityBar.Maximum = 100;
            this.SensitivityBar.Minimum = 1;
            this.SensitivityBar.Name = "SensitivityBar";
            this.SensitivityBar.Size = new System.Drawing.Size(451, 45);
            this.SensitivityBar.TabIndex = 58;
            this.SensitivityBar.Value = 1;
            this.SensitivityBar.Scroll += new System.EventHandler(this.SensitivityBar_Scroll);
            // 
            // MouseSmoothBox
            // 
            this.MouseSmoothBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MouseSmoothBox.FormattingEnabled = true;
            this.MouseSmoothBox.Items.AddRange(new object[] {
            "Enabled (Default)",
            "Disabled"});
            this.MouseSmoothBox.Location = new System.Drawing.Point(332, 16);
            this.MouseSmoothBox.Name = "MouseSmoothBox";
            this.MouseSmoothBox.Size = new System.Drawing.Size(128, 23);
            this.MouseSmoothBox.TabIndex = 57;
            this.MouseSmoothBox.SelectedIndexChanged += new System.EventHandler(this.MouseSmoothBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(216, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 56;
            this.label1.Text = "Mouse Smoothing:";
            // 
            // KeybindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(495, 534);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.controlLabel);
            this.Controls.Add(this.helpLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.applyKeyButton);
            this.Controls.Add(this.movBox);
            this.Controls.Add(this.actionBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KeybindForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arkham Asylum Keybind Editor";
            this.TopMost = true;
            this.movBox.ResumeLayout(false);
            this.movBox.PerformLayout();
            this.actionBox.ResumeLayout(false);
            this.actionBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SensitivityBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label fwLabel;
        private Label leftLabel;
        private Label bwLabel;
        private Label rightLabel;
        private Label zoomLabel;
        private Label crouchLabel;
        private Label crouchtoggleLabel;
        private Label grappleLabel;
        private Label runglideuseLabel;
        private GroupBox movBox;
        private Label quickBataLabel;
        private Label quickClawLabel;
        private Label throwLabel;
        private Label cTakeDownLabel;
        private Label detectiveLabel;
        private Label useStrikeLabel1;
        private Label aimCounterLabel1;
        private Label secondaryLabel;
        private Label aimCounterLabel3;
        private Label aimCounterLabel2;
        private Label secondaryStunLabel2;
        private GroupBox actionBox;
        private Button applyKeyButton;
        private Label useStrikeLabel2;
        public Button fwButton;
        public Button crouchToggleButton;
        public Button grappleButton;
        public Button zoomButton;
        public Button crouchButton;
        public Button RGUButton;
        public Button leftButton;
        public Button rightButton;
        public Button bwButton;
        public Button quickBatButton;
        public Button detButton;
        public Button gadStrikeButton;
        public Button gadSecButton;
        public Button cTakedownButton;
        public Button throwButton;
        public Button quickClawButton;
        public Button ACTButton;
        public Button capeStunButton;
        private Button resetButton;
        private LinkLabel helpLabel;
        private Label controlLabel;
        private LinkLabel speedLabel;
        private GroupBox groupBox1;
        private Label label1;
        public ComboBox MouseSmoothBox;
        protected internal TrackBar SensitivityBar;
        private Label label2;
        public Label SensitivityValueLabel;
    }
}