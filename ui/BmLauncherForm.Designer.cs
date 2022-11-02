using System.ComponentModel;
using System.Windows.Forms;

namespace BmLauncherWForm.ui
{
    partial class BmLauncherForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BmLauncherForm));
            this.msaaLabel = new System.Windows.Forms.Label();
            this.resLabel = new System.Windows.Forms.Label();
            this.vsyncLabel = new System.Windows.Forms.Label();
            this.detailLabel = new System.Windows.Forms.Label();
            this.fscreenLabel = new System.Windows.Forms.Label();
            this.vsyncBox = new System.Windows.Forms.ComboBox();
            this.detailBox = new System.Windows.Forms.ComboBox();
            this.fullscreenBox = new System.Windows.Forms.ComboBox();
            this.resBox = new System.Windows.Forms.ComboBox();
            this.displayBox = new System.Windows.Forms.GroupBox();
            this.langBox = new System.Windows.Forms.ComboBox();
            this.langLabel = new System.Windows.Forms.Label();
            this.maxSmoothTextBox = new System.Windows.Forms.MaskedTextBox();
            this.smoothFrameLabel = new System.Windows.Forms.Label();
            this.aaBox = new System.Windows.Forms.ComboBox();
            this.dofLabel = new System.Windows.Forms.Label();
            this.dofBox = new System.Windows.Forms.ComboBox();
            this.aoLabel = new System.Windows.Forms.Label();
            this.aoBox = new System.Windows.Forms.ComboBox();
            this.lensFlareLabel = new System.Windows.Forms.Label();
            this.lensFlareBox = new System.Windows.Forms.ComboBox();
            this.bloomLabel = new System.Windows.Forms.Label();
            this.bloomBox = new System.Windows.Forms.ComboBox();
            this.anisoLabel = new System.Windows.Forms.Label();
            this.anisoBox = new System.Windows.Forms.ComboBox();
            this.dshadowLabel = new System.Windows.Forms.Label();
            this.dShadowBox = new System.Windows.Forms.ComboBox();
            this.maxShadowLabel = new System.Windows.Forms.Label();
            this.maxShadowBox = new System.Windows.Forms.ComboBox();
            this.graphicsBox = new System.Windows.Forms.GroupBox();
            this.frameCheckBox = new System.Windows.Forms.CheckBox();
            this.miscBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fov2 = new System.Windows.Forms.Label();
            this.fov1 = new System.Windows.Forms.Label();
            this.mBlurBox = new System.Windows.Forms.ComboBox();
            this.mBlurLabel = new System.Windows.Forms.Label();
            this.distBox = new System.Windows.Forms.ComboBox();
            this.distLabel = new System.Windows.Forms.Label();
            this.fogBox = new System.Windows.Forms.ComboBox();
            this.fogLabel = new System.Windows.Forms.Label();
            this.sphericBox = new System.Windows.Forms.ComboBox();
            this.sphericalLabel = new System.Windows.Forms.Label();
            this.memPoolBox = new System.Windows.Forms.ComboBox();
            this.memPoolLabel = new System.Windows.Forms.Label();
            this.texelBox = new System.Windows.Forms.ComboBox();
            this.shadowTexelLabel = new System.Windows.Forms.Label();
            this.nvidiaBox = new System.Windows.Forms.GroupBox();
            this.nvBox = new System.Windows.Forms.CheckBox();
            this.physxBox = new System.Windows.Forms.ComboBox();
            this.physxLabel = new System.Windows.Forms.Label();
            this.keyButton = new System.Windows.Forms.Button();
            this.ultraButton = new System.Windows.Forms.Button();
            this.optiButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.texgroupButton = new System.Windows.Forms.Button();
            this.gpLabel = new System.Windows.Forms.Label();
            this.gpInfoLabel = new System.Windows.Forms.Label();
            this.credLabel = new System.Windows.Forms.LinkLabel();
            this.launchButton = new System.Windows.Forms.Button();
            this.basicToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.disableIntroButton = new System.Windows.Forms.Button();
            this.TexmodLabel = new System.Windows.Forms.Label();
            this.ManualModeBtn = new System.Windows.Forms.Button();
            this.rebornButton = new System.Windows.Forms.Button();
            this.nvidiaToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.amdToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.criticalTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.displayBox.SuspendLayout();
            this.graphicsBox.SuspendLayout();
            this.miscBox.SuspendLayout();
            this.nvidiaBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // msaaLabel
            // 
            this.msaaLabel.AutoSize = true;
            this.msaaLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msaaLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.msaaLabel.Location = new System.Drawing.Point(13, 22);
            this.msaaLabel.Name = "msaaLabel";
            this.msaaLabel.Size = new System.Drawing.Size(79, 15);
            this.msaaLabel.TabIndex = 11;
            this.msaaLabel.Text = "Anti-Aliasing:";
            this.basicToolTip.SetToolTip(this.msaaLabel, "Cleans up edge aliasing using MSAA. Off is recommended if you are using Reshade. " +
        "\r\nReshade SMAA and/or downsampling is recommended.\r\n");
            // 
            // resLabel
            // 
            this.resLabel.AutoSize = true;
            this.resLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.resLabel.Location = new System.Drawing.Point(6, 49);
            this.resLabel.Name = "resLabel";
            this.resLabel.Size = new System.Drawing.Size(69, 15);
            this.resLabel.TabIndex = 0;
            this.resLabel.Text = "Resolution:";
            this.basicToolTip.SetToolTip(this.resLabel, "Every resolution available on your machine is supported.");
            // 
            // vsyncLabel
            // 
            this.vsyncLabel.AutoSize = true;
            this.vsyncLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.vsyncLabel.Location = new System.Drawing.Point(285, 22);
            this.vsyncLabel.Name = "vsyncLabel";
            this.vsyncLabel.Size = new System.Drawing.Size(79, 15);
            this.vsyncLabel.TabIndex = 1;
            this.vsyncLabel.Text = "Vertical Sync:";
            this.basicToolTip.SetToolTip(this.vsyncLabel, "Turn on to eliminate screen tearing.");
            // 
            // detailLabel
            // 
            this.detailLabel.AutoSize = true;
            this.detailLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.detailLabel.Location = new System.Drawing.Point(286, 49);
            this.detailLabel.Name = "detailLabel";
            this.detailLabel.Size = new System.Drawing.Size(78, 15);
            this.detailLabel.TabIndex = 3;
            this.detailLabel.Text = "Detail Mode:";
            this.basicToolTip.SetToolTip(this.detailLabel, "Highest setting is required for the HD Texture Pack.");
            // 
            // fscreenLabel
            // 
            this.fscreenLabel.AutoSize = true;
            this.fscreenLabel.ForeColor = System.Drawing.Color.Black;
            this.fscreenLabel.Location = new System.Drawing.Point(6, 22);
            this.fscreenLabel.Name = "fscreenLabel";
            this.fscreenLabel.Size = new System.Drawing.Size(66, 15);
            this.fscreenLabel.TabIndex = 4;
            this.fscreenLabel.Text = "Fullscreen:";
            this.basicToolTip.SetToolTip(this.fscreenLabel, "You can press \"scroll lock\" in game to switch between fullscreen and windowed mod" +
        "e. ");
            // 
            // vsyncBox
            // 
            this.vsyncBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vsyncBox.FormattingEnabled = true;
            this.vsyncBox.Items.AddRange(new object[] {
            "Disabled",
            "Enabled"});
            this.vsyncBox.Location = new System.Drawing.Point(369, 19);
            this.vsyncBox.Name = "vsyncBox";
            this.vsyncBox.Size = new System.Drawing.Size(110, 23);
            this.vsyncBox.TabIndex = 5;
            this.vsyncBox.TabStop = false;
            this.basicToolTip.SetToolTip(this.vsyncBox, "Turn on to eliminate screen tearing.");
            this.vsyncBox.SelectedIndexChanged += new System.EventHandler(this.vsyncBox_SelectedIndexChanged);
            // 
            // detailBox
            // 
            this.detailBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.detailBox.FormattingEnabled = true;
            this.detailBox.Items.AddRange(new object[] {
            "Lowest",
            "Medium",
            "Highest"});
            this.detailBox.Location = new System.Drawing.Point(369, 46);
            this.detailBox.Name = "detailBox";
            this.detailBox.Size = new System.Drawing.Size(110, 23);
            this.detailBox.TabIndex = 6;
            this.basicToolTip.SetToolTip(this.detailBox, "Highest setting is required for the HD Texture Pack.");
            this.detailBox.SelectedIndexChanged += new System.EventHandler(this.detailBox_SelectedIndexChanged);
            // 
            // fullscreenBox
            // 
            this.fullscreenBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fullscreenBox.FormattingEnabled = true;
            this.fullscreenBox.Items.AddRange(new object[] {
            "Disabled",
            "Enabled"});
            this.fullscreenBox.Location = new System.Drawing.Point(95, 19);
            this.fullscreenBox.Name = "fullscreenBox";
            this.fullscreenBox.Size = new System.Drawing.Size(110, 23);
            this.fullscreenBox.TabIndex = 7;
            this.basicToolTip.SetToolTip(this.fullscreenBox, "You can press \"scroll lock\" in game to switch between fullscreen and windowed mod" +
        "e. ");
            this.fullscreenBox.SelectedIndexChanged += new System.EventHandler(this.fullscreenBox_SelectedIndexChanged);
            // 
            // resBox
            // 
            this.resBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resBox.FormattingEnabled = true;
            this.resBox.Location = new System.Drawing.Point(95, 46);
            this.resBox.Name = "resBox";
            this.resBox.Size = new System.Drawing.Size(110, 23);
            this.resBox.TabIndex = 8;
            this.basicToolTip.SetToolTip(this.resBox, "Every resolution available on your machine is supported.");
            this.resBox.SelectedIndexChanged += new System.EventHandler(this.resBox_SelectedIndexChanged);
            // 
            // displayBox
            // 
            this.displayBox.AutoSize = true;
            this.displayBox.BackColor = System.Drawing.Color.Transparent;
            this.displayBox.Controls.Add(this.langBox);
            this.displayBox.Controls.Add(this.langLabel);
            this.displayBox.Controls.Add(this.resBox);
            this.displayBox.Controls.Add(this.fullscreenBox);
            this.displayBox.Controls.Add(this.maxSmoothTextBox);
            this.displayBox.Controls.Add(this.detailBox);
            this.displayBox.Controls.Add(this.smoothFrameLabel);
            this.displayBox.Controls.Add(this.vsyncBox);
            this.displayBox.Controls.Add(this.fscreenLabel);
            this.displayBox.Controls.Add(this.detailLabel);
            this.displayBox.Controls.Add(this.vsyncLabel);
            this.displayBox.Controls.Add(this.resLabel);
            this.displayBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.displayBox.Location = new System.Drawing.Point(19, 16);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(491, 118);
            this.displayBox.TabIndex = 12;
            this.displayBox.TabStop = false;
            this.displayBox.Text = "Display";
            // 
            // langBox
            // 
            this.langBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.langBox.FormattingEnabled = true;
            this.langBox.Items.AddRange(new object[] {
            "English",
            "Deutsch",
            "Français",
            "Italiano",
            "Español"});
            this.langBox.Location = new System.Drawing.Point(369, 73);
            this.langBox.Name = "langBox";
            this.langBox.Size = new System.Drawing.Size(110, 23);
            this.langBox.TabIndex = 37;
            this.basicToolTip.SetToolTip(this.langBox, "Sets the voice & text language in the game.\r\n\r\nIf you have an unofficial language" +
        " patch installed, it most likely replaces \'English\'.\r\nOtherwise, \'Unofficial\' sh" +
        "ould be selected automatically.\r\n");
            this.langBox.SelectedIndexChanged += new System.EventHandler(this.langBox_SelectedIndexChanged);
            // 
            // langLabel
            // 
            this.langLabel.AutoSize = true;
            this.langLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.langLabel.Location = new System.Drawing.Point(302, 76);
            this.langLabel.Name = "langLabel";
            this.langLabel.Size = new System.Drawing.Size(62, 15);
            this.langLabel.TabIndex = 36;
            this.langLabel.Text = "Language:";
            this.basicToolTip.SetToolTip(this.langLabel, "Sets the voice & text language in the game.\r\n\r\nIf you have an unofficial language" +
        " patch installed, it most likely replaces \'English\'.\r\nOtherwise, \'Unofficial\' sh" +
        "ould be selected automatically.\r\n\r\n");
            // 
            // maxSmoothTextBox
            // 
            this.maxSmoothTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maxSmoothTextBox.Location = new System.Drawing.Point(146, 72);
            this.maxSmoothTextBox.Mask = "000";
            this.maxSmoothTextBox.Name = "maxSmoothTextBox";
            this.maxSmoothTextBox.PromptChar = ' ';
            this.maxSmoothTextBox.Size = new System.Drawing.Size(59, 23);
            this.maxSmoothTextBox.TabIndex = 35;
            this.maxSmoothTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maxSmoothTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.basicToolTip.SetToolTip(this.maxSmoothTextBox, resources.GetString("maxSmoothTextBox.ToolTip"));
            this.maxSmoothTextBox.TextChanged += new System.EventHandler(this.maxSmoothTextBox_TextChanged);
            // 
            // smoothFrameLabel
            // 
            this.smoothFrameLabel.AutoSize = true;
            this.smoothFrameLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.smoothFrameLabel.Location = new System.Drawing.Point(6, 76);
            this.smoothFrameLabel.Name = "smoothFrameLabel";
            this.smoothFrameLabel.Size = new System.Drawing.Size(92, 15);
            this.smoothFrameLabel.TabIndex = 34;
            this.smoothFrameLabel.Text = "Framerate Cap:";
            this.basicToolTip.SetToolTip(this.smoothFrameLabel, resources.GetString("smoothFrameLabel.ToolTip"));
            // 
            // aaBox
            // 
            this.aaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aaBox.FormattingEnabled = true;
            this.aaBox.Items.AddRange(new object[] {
            "Off",
            "2x MSAA",
            "4x MSAA",
            "8xQ MSAA"});
            this.aaBox.Location = new System.Drawing.Point(95, 19);
            this.aaBox.Name = "aaBox";
            this.aaBox.Size = new System.Drawing.Size(110, 23);
            this.aaBox.TabIndex = 13;
            this.basicToolTip.SetToolTip(this.aaBox, "Cleans up edge aliasing using MSAA. Off is recommended if you are using Reshade. " +
        "\r\nReshade SMAA and/or downsampling is recommended.\r\n");
            this.aaBox.SelectedIndexChanged += new System.EventHandler(this.aaBox_SelectedIndexChanged);
            // 
            // dofLabel
            // 
            this.dofLabel.AutoSize = true;
            this.dofLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dofLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.dofLabel.Location = new System.Drawing.Point(4, 138);
            this.dofLabel.Name = "dofLabel";
            this.dofLabel.Size = new System.Drawing.Size(88, 15);
            this.dofLabel.TabIndex = 14;
            this.dofLabel.Text = "Depth of Field:";
            this.basicToolTip.SetToolTip(this.dofLabel, "Tied with Colour Grading filters and Bloom. Off is recommended for GPUnity\'s Resh" +
        "ade.\r\n");
            // 
            // dofBox
            // 
            this.dofBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dofBox.FormattingEnabled = true;
            this.dofBox.Items.AddRange(new object[] {
            "Disabled",
            "Enabled"});
            this.dofBox.Location = new System.Drawing.Point(95, 135);
            this.dofBox.Name = "dofBox";
            this.dofBox.Size = new System.Drawing.Size(110, 23);
            this.dofBox.TabIndex = 15;
            this.basicToolTip.SetToolTip(this.dofBox, "Tied with Colour Grading filters and Bloom. Off is recommended for GPUnity\'s Resh" +
        "ade.\r\n\r\n");
            this.dofBox.SelectedIndexChanged += new System.EventHandler(this.dofBox_SelectedIndexChanged);
            // 
            // aoLabel
            // 
            this.aoLabel.AutoSize = true;
            this.aoLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aoLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.aoLabel.Location = new System.Drawing.Point(253, 80);
            this.aoLabel.Name = "aoLabel";
            this.aoLabel.Size = new System.Drawing.Size(113, 15);
            this.aoLabel.TabIndex = 16;
            this.aoLabel.Text = "Ambient Occlusion:";
            this.basicToolTip.SetToolTip(this.aoLabel, "Off is recommended due to low sample count. Use Reshade AO or enable NVIDIA HBAO+" +
        ".\r\n");
            // 
            // aoBox
            // 
            this.aoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aoBox.FormattingEnabled = true;
            this.aoBox.Items.AddRange(new object[] {
            "Disabled",
            "Enabled"});
            this.aoBox.Location = new System.Drawing.Point(369, 77);
            this.aoBox.Name = "aoBox";
            this.aoBox.Size = new System.Drawing.Size(110, 23);
            this.aoBox.TabIndex = 17;
            this.basicToolTip.SetToolTip(this.aoBox, "Off is recommended due to low sample count. Use Reshade AO or enable NVIDIA HBAO+" +
        ".\r\n\r\n");
            this.aoBox.SelectedIndexChanged += new System.EventHandler(this.aoBox_SelectedIndexChanged);
            // 
            // lensFlareLabel
            // 
            this.lensFlareLabel.AutoSize = true;
            this.lensFlareLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lensFlareLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lensFlareLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lensFlareLabel.Location = new System.Drawing.Point(21, 109);
            this.lensFlareLabel.Name = "lensFlareLabel";
            this.lensFlareLabel.Size = new System.Drawing.Size(71, 15);
            this.lensFlareLabel.TabIndex = 18;
            this.lensFlareLabel.Text = "Lens Flares:";
            this.basicToolTip.SetToolTip(this.lensFlareLabel, "Simulates perspective-based flares when looking at bright lights.");
            // 
            // lensFlareBox
            // 
            this.lensFlareBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lensFlareBox.FormattingEnabled = true;
            this.lensFlareBox.Items.AddRange(new object[] {
            "Disabled",
            "Enabled"});
            this.lensFlareBox.Location = new System.Drawing.Point(95, 106);
            this.lensFlareBox.Name = "lensFlareBox";
            this.lensFlareBox.Size = new System.Drawing.Size(110, 23);
            this.lensFlareBox.TabIndex = 19;
            this.basicToolTip.SetToolTip(this.lensFlareBox, "Simulates perspective-based flares when looking at bright lights.");
            this.lensFlareBox.SelectedIndexChanged += new System.EventHandler(this.lensFlareBox_SelectedIndexChanged);
            // 
            // bloomLabel
            // 
            this.bloomLabel.AutoSize = true;
            this.bloomLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloomLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.bloomLabel.Location = new System.Drawing.Point(46, 80);
            this.bloomLabel.Name = "bloomLabel";
            this.bloomLabel.Size = new System.Drawing.Size(46, 15);
            this.bloomLabel.TabIndex = 20;
            this.bloomLabel.Text = "Bloom:";
            this.basicToolTip.SetToolTip(this.bloomLabel, "Enunciates lighting by adding a soft glow to bright areas - Requires Depth of Fie" +
        "ld to be enabled.\r\nEnabling Bloom will automatically enable High Quality Bloom a" +
        "s well.\r\n");
            // 
            // bloomBox
            // 
            this.bloomBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bloomBox.FormattingEnabled = true;
            this.bloomBox.Items.AddRange(new object[] {
            "Disabled",
            "Enabled"});
            this.bloomBox.Location = new System.Drawing.Point(95, 77);
            this.bloomBox.Name = "bloomBox";
            this.bloomBox.Size = new System.Drawing.Size(110, 23);
            this.bloomBox.TabIndex = 21;
            this.basicToolTip.SetToolTip(this.bloomBox, "Enunciates lighting by adding a soft glow to bright areas - Requires Depth of Fie" +
        "ld to be enabled.\r\nEnabling Bloom will automatically enable High Quality Bloom a" +
        "s well.\r\n");
            this.bloomBox.SelectedIndexChanged += new System.EventHandler(this.bloomBox_SelectedIndexChanged);
            // 
            // anisoLabel
            // 
            this.anisoLabel.AutoSize = true;
            this.anisoLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anisoLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.anisoLabel.Location = new System.Drawing.Point(245, 22);
            this.anisoLabel.Name = "anisoLabel";
            this.anisoLabel.Size = new System.Drawing.Size(121, 15);
            this.anisoLabel.TabIndex = 24;
            this.anisoLabel.Text = "Anisotropic Filtering:";
            this.basicToolTip.SetToolTip(this.anisoLabel, "Improve texture clarity across oblique surfaces.");
            // 
            // anisoBox
            // 
            this.anisoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.anisoBox.FormattingEnabled = true;
            this.anisoBox.Items.AddRange(new object[] {
            "4x",
            "8x",
            "16x"});
            this.anisoBox.Location = new System.Drawing.Point(369, 19);
            this.anisoBox.Name = "anisoBox";
            this.anisoBox.Size = new System.Drawing.Size(110, 23);
            this.anisoBox.TabIndex = 25;
            this.basicToolTip.SetToolTip(this.anisoBox, "Improve texture clarity across oblique surfaces.");
            this.anisoBox.SelectedIndexChanged += new System.EventHandler(this.anisoBox_SelectedIndexChanged);
            // 
            // dshadowLabel
            // 
            this.dshadowLabel.AutoSize = true;
            this.dshadowLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dshadowLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.dshadowLabel.Location = new System.Drawing.Point(258, 109);
            this.dshadowLabel.Name = "dshadowLabel";
            this.dshadowLabel.Size = new System.Drawing.Size(108, 15);
            this.dshadowLabel.TabIndex = 26;
            this.dshadowLabel.Text = "Dynamic Shadows:";
            this.basicToolTip.SetToolTip(this.dshadowLabel, "Only baked shadows from static meshes will be visible if you disable Dynamic Shad" +
        "ows.\r\n");
            // 
            // dShadowBox
            // 
            this.dShadowBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dShadowBox.FormattingEnabled = true;
            this.dShadowBox.Items.AddRange(new object[] {
            "Disabled",
            "Enabled"});
            this.dShadowBox.Location = new System.Drawing.Point(369, 106);
            this.dShadowBox.Name = "dShadowBox";
            this.dShadowBox.Size = new System.Drawing.Size(110, 23);
            this.dShadowBox.TabIndex = 27;
            this.basicToolTip.SetToolTip(this.dShadowBox, "Only baked shadows from static meshes will be visible if you disable Dynamic Shad" +
        "ows.\r\n\r\n");
            this.dShadowBox.SelectedIndexChanged += new System.EventHandler(this.dShadowBox_SelectedIndexChanged);
            // 
            // maxShadowLabel
            // 
            this.maxShadowLabel.AutoSize = true;
            this.maxShadowLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxShadowLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.maxShadowLabel.Location = new System.Drawing.Point(270, 138);
            this.maxShadowLabel.Name = "maxShadowLabel";
            this.maxShadowLabel.Size = new System.Drawing.Size(96, 15);
            this.maxShadowLabel.TabIndex = 30;
            this.maxShadowLabel.Text = "Shadow Quality:";
            this.basicToolTip.SetToolTip(this.maxShadowLabel, "Increases the quality of shadow rendering, primarily by pushing shadowmap resolut" +
        "ion. \r\nHighest setting will render crisper shadows and increase shadow casting d" +
        "istance.");
            // 
            // maxShadowBox
            // 
            this.maxShadowBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.maxShadowBox.FormattingEnabled = true;
            this.maxShadowBox.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High",
            "Highest"});
            this.maxShadowBox.Location = new System.Drawing.Point(369, 135);
            this.maxShadowBox.Name = "maxShadowBox";
            this.maxShadowBox.Size = new System.Drawing.Size(110, 23);
            this.maxShadowBox.TabIndex = 31;
            this.basicToolTip.SetToolTip(this.maxShadowBox, "Increases the quality of shadow rendering, primarily by pushing shadowmap resolut" +
        "ion. \r\nHighest setting will render crisper shadows and increase shadow casting d" +
        "istance.\r\n");
            this.maxShadowBox.SelectedIndexChanged += new System.EventHandler(this.maxShadowBox_SelectedIndexChanged);
            // 
            // graphicsBox
            // 
            this.graphicsBox.AutoSize = true;
            this.graphicsBox.BackColor = System.Drawing.Color.Transparent;
            this.graphicsBox.Controls.Add(this.frameCheckBox);
            this.graphicsBox.Controls.Add(this.miscBox);
            this.graphicsBox.Controls.Add(this.mBlurBox);
            this.graphicsBox.Controls.Add(this.mBlurLabel);
            this.graphicsBox.Controls.Add(this.distBox);
            this.graphicsBox.Controls.Add(this.distLabel);
            this.graphicsBox.Controls.Add(this.fogBox);
            this.graphicsBox.Controls.Add(this.fogLabel);
            this.graphicsBox.Controls.Add(this.sphericBox);
            this.graphicsBox.Controls.Add(this.sphericalLabel);
            this.graphicsBox.Controls.Add(this.memPoolBox);
            this.graphicsBox.Controls.Add(this.memPoolLabel);
            this.graphicsBox.Controls.Add(this.texelBox);
            this.graphicsBox.Controls.Add(this.shadowTexelLabel);
            this.graphicsBox.Controls.Add(this.maxShadowBox);
            this.graphicsBox.Controls.Add(this.maxShadowLabel);
            this.graphicsBox.Controls.Add(this.dShadowBox);
            this.graphicsBox.Controls.Add(this.dshadowLabel);
            this.graphicsBox.Controls.Add(this.anisoBox);
            this.graphicsBox.Controls.Add(this.anisoLabel);
            this.graphicsBox.Controls.Add(this.bloomBox);
            this.graphicsBox.Controls.Add(this.bloomLabel);
            this.graphicsBox.Controls.Add(this.lensFlareBox);
            this.graphicsBox.Controls.Add(this.lensFlareLabel);
            this.graphicsBox.Controls.Add(this.aoBox);
            this.graphicsBox.Controls.Add(this.aoLabel);
            this.graphicsBox.Controls.Add(this.dofBox);
            this.graphicsBox.Controls.Add(this.dofLabel);
            this.graphicsBox.Controls.Add(this.aaBox);
            this.graphicsBox.Controls.Add(this.msaaLabel);
            this.graphicsBox.Controls.Add(this.nvidiaBox);
            this.graphicsBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphicsBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.graphicsBox.Location = new System.Drawing.Point(19, 180);
            this.graphicsBox.Name = "graphicsBox";
            this.graphicsBox.Size = new System.Drawing.Size(491, 296);
            this.graphicsBox.TabIndex = 32;
            this.graphicsBox.TabStop = false;
            this.graphicsBox.Text = "Advanced Graphics";
            // 
            // frameCheckBox
            // 
            this.frameCheckBox.AutoSize = true;
            this.frameCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.frameCheckBox.ForeColor = System.Drawing.Color.Maroon;
            this.frameCheckBox.Location = new System.Drawing.Point(27, 247);
            this.frameCheckBox.Name = "frameCheckBox";
            this.frameCheckBox.Size = new System.Drawing.Size(179, 19);
            this.frameCheckBox.TabIndex = 38;
            this.frameCheckBox.Text = "Enable OneFrameThreadLag";
            this.criticalTooltip.SetToolTip(this.frameCheckBox, "Disabling this can reduce input lag, but may also cause heavy stuttering.");
            this.frameCheckBox.UseVisualStyleBackColor = true;
            this.frameCheckBox.CheckedChanged += new System.EventHandler(this.frameCheckBox_CheckedChanged);
            // 
            // miscBox
            // 
            this.miscBox.Controls.Add(this.label5);
            this.miscBox.Controls.Add(this.label3);
            this.miscBox.Controls.Add(this.label2);
            this.miscBox.Controls.Add(this.label1);
            this.miscBox.Controls.Add(this.fov2);
            this.miscBox.Controls.Add(this.fov1);
            this.miscBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.miscBox.Location = new System.Drawing.Point(211, 188);
            this.miscBox.Name = "miscBox";
            this.miscBox.Size = new System.Drawing.Size(101, 86);
            this.miscBox.TabIndex = 50;
            this.miscBox.TabStop = false;
            this.miscBox.Text = "Miscellaneous";
            this.basicToolTip.SetToolTip(this.miscBox, "Open the Developer Console (In-Game) with the F2 key.\r\n\r\nEnable/Disable HUD/User " +
        "Interface with the F3 key.\r\n\r\nChange Field of View settings according to F5-8 ke" +
        "ys.\r\n");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(6, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "F2 - Open Console";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "F3 - Toggle HUD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "F8 - FoV   110";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "F7 - FoV   100";
            // 
            // fov2
            // 
            this.fov2.AutoSize = true;
            this.fov2.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.fov2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.fov2.Location = new System.Drawing.Point(6, 48);
            this.fov2.Name = "fov2";
            this.fov2.Size = new System.Drawing.Size(61, 13);
            this.fov2.TabIndex = 1;
            this.fov2.Text = "F6 - FoV   95";
            // 
            // fov1
            // 
            this.fov1.AutoSize = true;
            this.fov1.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.fov1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.fov1.Location = new System.Drawing.Point(6, 37);
            this.fov1.Name = "fov1";
            this.fov1.Size = new System.Drawing.Size(79, 13);
            this.fov1.TabIndex = 0;
            this.fov1.Text = "F5 - Default FoV";
            // 
            // mBlurBox
            // 
            this.mBlurBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mBlurBox.FormattingEnabled = true;
            this.mBlurBox.Items.AddRange(new object[] {
            "Disabled",
            "Enabled"});
            this.mBlurBox.Location = new System.Drawing.Point(95, 193);
            this.mBlurBox.Name = "mBlurBox";
            this.mBlurBox.Size = new System.Drawing.Size(110, 23);
            this.mBlurBox.TabIndex = 47;
            this.basicToolTip.SetToolTip(this.mBlurBox, "Emphasizes movement using blur to connect movement between frames. \r\nMotion blur " +
        "in this game is of low quality due to being an early implementation.\r\n");
            this.mBlurBox.SelectedIndexChanged += new System.EventHandler(this.mBlurBox_SelectedIndexChanged);
            // 
            // mBlurLabel
            // 
            this.mBlurLabel.AutoSize = true;
            this.mBlurLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBlurLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.mBlurLabel.Location = new System.Drawing.Point(16, 196);
            this.mBlurLabel.Name = "mBlurLabel";
            this.mBlurLabel.Size = new System.Drawing.Size(76, 15);
            this.mBlurLabel.TabIndex = 46;
            this.mBlurLabel.Text = "Motion Blur:";
            this.basicToolTip.SetToolTip(this.mBlurLabel, "Emphasizes movement using blur to connect movement between frames. \r\nMotion blur " +
        "in this game is of low quality due to being an early implementation.");
            // 
            // distBox
            // 
            this.distBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.distBox.FormattingEnabled = true;
            this.distBox.Items.AddRange(new object[] {
            "Disabled",
            "Enabled"});
            this.distBox.Location = new System.Drawing.Point(95, 164);
            this.distBox.Name = "distBox";
            this.distBox.Size = new System.Drawing.Size(110, 23);
            this.distBox.TabIndex = 45;
            this.basicToolTip.SetToolTip(this.distBox, "Distorts the screen for certain actions (explosive gel, heat, etc..).\r\n");
            this.distBox.SelectedIndexChanged += new System.EventHandler(this.distBox_SelectedIndexChanged);
            // 
            // distLabel
            // 
            this.distLabel.AutoSize = true;
            this.distLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.distLabel.Location = new System.Drawing.Point(26, 167);
            this.distLabel.Name = "distLabel";
            this.distLabel.Size = new System.Drawing.Size(66, 15);
            this.distLabel.TabIndex = 44;
            this.distLabel.Text = "Distortion:";
            this.basicToolTip.SetToolTip(this.distLabel, "Distorts the screen for certain actions (explosive gel, heat, etc..).");
            // 
            // fogBox
            // 
            this.fogBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fogBox.FormattingEnabled = true;
            this.fogBox.Items.AddRange(new object[] {
            "Disabled",
            "Enabled"});
            this.fogBox.Location = new System.Drawing.Point(95, 48);
            this.fogBox.Name = "fogBox";
            this.fogBox.Size = new System.Drawing.Size(110, 23);
            this.fogBox.TabIndex = 43;
            this.basicToolTip.SetToolTip(this.fogBox, "Enables fog in certain areas.");
            this.fogBox.SelectedIndexChanged += new System.EventHandler(this.fogBox_SelectedIndexChanged);
            // 
            // fogLabel
            // 
            this.fogLabel.AutoSize = true;
            this.fogLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fogLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.fogLabel.Location = new System.Drawing.Point(12, 51);
            this.fogLabel.Name = "fogLabel";
            this.fogLabel.Size = new System.Drawing.Size(80, 15);
            this.fogLabel.TabIndex = 42;
            this.fogLabel.Text = "Fog Volumes:";
            this.basicToolTip.SetToolTip(this.fogLabel, "Enables fog in certain areas.");
            // 
            // sphericBox
            // 
            this.sphericBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sphericBox.FormattingEnabled = true;
            this.sphericBox.Items.AddRange(new object[] {
            "Disabled",
            "Enabled"});
            this.sphericBox.Location = new System.Drawing.Point(369, 48);
            this.sphericBox.Name = "sphericBox";
            this.sphericBox.Size = new System.Drawing.Size(110, 23);
            this.sphericBox.TabIndex = 41;
            this.basicToolTip.SetToolTip(this.sphericBox, "Adds additional lighting to the game. Do not disable this if Depth of Field is al" +
        "so disabled.");
            this.sphericBox.SelectedIndexChanged += new System.EventHandler(this.sphericBox_SelectedIndexChanged);
            // 
            // sphericalLabel
            // 
            this.sphericalLabel.AutoSize = true;
            this.sphericalLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sphericalLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.sphericalLabel.Location = new System.Drawing.Point(216, 51);
            this.sphericalLabel.Name = "sphericalLabel";
            this.sphericalLabel.Size = new System.Drawing.Size(150, 15);
            this.sphericalLabel.TabIndex = 40;
            this.sphericalLabel.Text = "Spherical Harmonic Lights:";
            this.basicToolTip.SetToolTip(this.sphericalLabel, "Adds additional lighting to the game. Do not disable this if Depth of Field is al" +
        "so disabled.");
            // 
            // memPoolBox
            // 
            this.memPoolBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.memPoolBox.FormattingEnabled = true;
            this.memPoolBox.Items.AddRange(new object[] {
            "512 (Default)",
            "1024",
            "2048",
            "3072",
            "4096",
            "Infinite"});
            this.memPoolBox.Location = new System.Drawing.Point(95, 222);
            this.memPoolBox.Name = "memPoolBox";
            this.memPoolBox.Size = new System.Drawing.Size(110, 23);
            this.memPoolBox.TabIndex = 39;
            this.basicToolTip.SetToolTip(this.memPoolBox, resources.GetString("memPoolBox.ToolTip"));
            this.memPoolBox.SelectedIndexChanged += new System.EventHandler(this.memPoolBox_SelectedIndexChanged);
            // 
            // memPoolLabel
            // 
            this.memPoolLabel.AutoSize = true;
            this.memPoolLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memPoolLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.memPoolLabel.Location = new System.Drawing.Point(33, 225);
            this.memPoolLabel.Name = "memPoolLabel";
            this.memPoolLabel.Size = new System.Drawing.Size(59, 15);
            this.memPoolLabel.TabIndex = 38;
            this.memPoolLabel.Text = "Pool Size:";
            this.basicToolTip.SetToolTip(this.memPoolLabel, resources.GetString("memPoolLabel.ToolTip"));
            // 
            // texelBox
            // 
            this.texelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.texelBox.FormattingEnabled = true;
            this.texelBox.Items.AddRange(new object[] {
            "Default",
            "High",
            "Higher",
            "Insane"});
            this.texelBox.Location = new System.Drawing.Point(369, 164);
            this.texelBox.Name = "texelBox";
            this.texelBox.Size = new System.Drawing.Size(110, 23);
            this.texelBox.TabIndex = 37;
            this.basicToolTip.SetToolTip(this.texelBox, resources.GetString("texelBox.ToolTip"));
            this.texelBox.SelectedIndexChanged += new System.EventHandler(this.texelBox_SelectedIndexChanged);
            // 
            // shadowTexelLabel
            // 
            this.shadowTexelLabel.AutoSize = true;
            this.shadowTexelLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shadowTexelLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.shadowTexelLabel.Location = new System.Drawing.Point(258, 167);
            this.shadowTexelLabel.Name = "shadowTexelLabel";
            this.shadowTexelLabel.Size = new System.Drawing.Size(108, 15);
            this.shadowTexelLabel.TabIndex = 36;
            this.shadowTexelLabel.Text = "Shadow Coverage:";
            this.basicToolTip.SetToolTip(this.shadowTexelLabel, resources.GetString("shadowTexelLabel.ToolTip"));
            // 
            // nvidiaBox
            // 
            this.nvidiaBox.Controls.Add(this.nvBox);
            this.nvidiaBox.Controls.Add(this.physxBox);
            this.nvidiaBox.Controls.Add(this.physxLabel);
            this.nvidiaBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.nvidiaBox.Location = new System.Drawing.Point(318, 195);
            this.nvidiaBox.Name = "nvidiaBox";
            this.nvidiaBox.Size = new System.Drawing.Size(167, 79);
            this.nvidiaBox.TabIndex = 49;
            this.nvidiaBox.TabStop = false;
            this.nvidiaBox.Text = "NVIDIA Settings";
            // 
            // nvBox
            // 
            this.nvBox.AutoSize = true;
            this.nvBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nvBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nvBox.ForeColor = System.Drawing.Color.LimeGreen;
            this.nvBox.Location = new System.Drawing.Point(18, 49);
            this.nvBox.Name = "nvBox";
            this.nvBox.Size = new System.Drawing.Size(142, 19);
            this.nvBox.TabIndex = 48;
            this.nvBox.Text = "Enable NVIDIA HBAO+";
            this.nvidiaToolTip.SetToolTip(this.nvBox, "Higher end ambient occlusion solution for creating realistic shadowing around obj" +
        "ects. \r\nYou can choose between this or Reshade AO.\r\n\r\nFullscreen needs to be ena" +
        "bled for this setting to work.\r\n");
            this.amdToolTip.SetToolTip(this.nvBox, "Nvidia GPU required for HBAO+ as it uses NvAPI");
            this.nvBox.UseVisualStyleBackColor = true;
            this.nvBox.CheckedChanged += new System.EventHandler(this.nvBox_CheckedChanged);
            // 
            // physxBox
            // 
            this.physxBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.physxBox.FormattingEnabled = true;
            this.physxBox.Items.AddRange(new object[] {
            "Off",
            "Medium",
            "High"});
            this.physxBox.Location = new System.Drawing.Point(51, 24);
            this.physxBox.Name = "physxBox";
            this.physxBox.Size = new System.Drawing.Size(110, 23);
            this.physxBox.TabIndex = 33;
            this.nvidiaToolTip.SetToolTip(this.physxBox, "Demanding feature!\r\n\r\nIt is NOT recommended to go above Medium!\r\nBreakable tiles," +
        " realistic paper simulation, advanced smoke effects.\r\n");
            this.amdToolTip.SetToolTip(this.physxBox, resources.GetString("physxBox.ToolTip"));
            this.physxBox.SelectedIndexChanged += new System.EventHandler(this.physxBox_SelectedIndexChanged);
            // 
            // physxLabel
            // 
            this.physxLabel.AutoSize = true;
            this.physxLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physxLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.physxLabel.Location = new System.Drawing.Point(5, 27);
            this.physxLabel.Name = "physxLabel";
            this.physxLabel.Size = new System.Drawing.Size(43, 15);
            this.physxLabel.TabIndex = 32;
            this.physxLabel.Text = "PhysX:";
            this.nvidiaToolTip.SetToolTip(this.physxLabel, "Demanding feature!\r\n\r\nIt is NOT recommended to go above Medium!\r\nBreakable tiles," +
        " realistic paper simulation, advanced smoke effects.");
            this.amdToolTip.SetToolTip(this.physxLabel, resources.GetString("physxLabel.ToolTip"));
            // 
            // keyButton
            // 
            this.keyButton.AutoSize = true;
            this.keyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.keyButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.keyButton.Location = new System.Drawing.Point(19, 480);
            this.keyButton.Name = "keyButton";
            this.keyButton.Size = new System.Drawing.Size(491, 30);
            this.keyButton.TabIndex = 48;
            this.keyButton.Text = "Keybinds";
            this.basicToolTip.SetToolTip(this.keyButton, "Opens a configuration window for keyboard+mouse settings.");
            this.keyButton.UseVisualStyleBackColor = true;
            this.keyButton.Click += new System.EventHandler(this.keyButton_Click);
            // 
            // ultraButton
            // 
            this.ultraButton.BackColor = System.Drawing.Color.Transparent;
            this.ultraButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ultraButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ultraButton.Location = new System.Drawing.Point(185, 142);
            this.ultraButton.Name = "ultraButton";
            this.ultraButton.Size = new System.Drawing.Size(160, 31);
            this.ultraButton.TabIndex = 33;
            this.ultraButton.Text = "Ultra Preset";
            this.basicToolTip.SetToolTip(this.ultraButton, "Highly demanding!");
            this.ultraButton.UseVisualStyleBackColor = false;
            this.ultraButton.Click += new System.EventHandler(this.ultraButton_Click);
            // 
            // optiButton
            // 
            this.optiButton.BackColor = System.Drawing.Color.Transparent;
            this.optiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optiButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optiButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.optiButton.Location = new System.Drawing.Point(19, 142);
            this.optiButton.Name = "optiButton";
            this.optiButton.Size = new System.Drawing.Size(160, 31);
            this.optiButton.TabIndex = 34;
            this.optiButton.Text = "Optimized Preset";
            this.basicToolTip.SetToolTip(this.optiButton, "Provides a great experience with reasonable performance.");
            this.optiButton.UseVisualStyleBackColor = false;
            this.optiButton.Click += new System.EventHandler(this.optiButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.AutoSize = true;
            this.applyButton.BackColor = System.Drawing.Color.Transparent;
            this.applyButton.Enabled = false;
            this.applyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applyButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.applyButton.Location = new System.Drawing.Point(412, 516);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(98, 27);
            this.applyButton.TabIndex = 35;
            this.applyButton.Text = "Apply Settings";
            this.applyButton.UseVisualStyleBackColor = false;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // texgroupButton
            // 
            this.texgroupButton.AutoSize = true;
            this.texgroupButton.BackColor = System.Drawing.Color.Transparent;
            this.texgroupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.texgroupButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texgroupButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.texgroupButton.Location = new System.Drawing.Point(114, 516);
            this.texgroupButton.Name = "texgroupButton";
            this.texgroupButton.Size = new System.Drawing.Size(151, 27);
            this.texgroupButton.TabIndex = 37;
            this.texgroupButton.Text = "Enable Texture Pack Fix";
            this.basicToolTip.SetToolTip(this.texgroupButton, "This is only required if you are using the HD Texture Pack.");
            this.texgroupButton.UseVisualStyleBackColor = false;
            this.texgroupButton.Click += new System.EventHandler(this.texgroupButton_Click);
            // 
            // gpLabel
            // 
            this.gpLabel.AutoSize = true;
            this.gpLabel.BackColor = System.Drawing.Color.Transparent;
            this.gpLabel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.gpLabel.Location = new System.Drawing.Point(16, 603);
            this.gpLabel.Name = "gpLabel";
            this.gpLabel.Size = new System.Drawing.Size(73, 13);
            this.gpLabel.TabIndex = 38;
            this.gpLabel.Text = "Graphics Card:";
            // 
            // gpInfoLabel
            // 
            this.gpInfoLabel.AutoSize = true;
            this.gpInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.gpInfoLabel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpInfoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gpInfoLabel.Location = new System.Drawing.Point(87, 603);
            this.gpInfoLabel.Name = "gpInfoLabel";
            this.gpInfoLabel.Size = new System.Drawing.Size(137, 13);
            this.gpInfoLabel.TabIndex = 39;
            this.gpInfoLabel.Text = "Graphics Card Info goes here";
            // 
            // credLabel
            // 
            this.credLabel.AutoSize = true;
            this.credLabel.BackColor = System.Drawing.Color.Transparent;
            this.credLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.credLabel.LinkColor = System.Drawing.Color.DimGray;
            this.credLabel.Location = new System.Drawing.Point(451, 602);
            this.credLabel.Name = "credLabel";
            this.credLabel.Size = new System.Drawing.Size(59, 13);
            this.credLabel.TabIndex = 41;
            this.credLabel.TabStop = true;
            this.credLabel.Text = "Information";
            this.credLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.credLabel_LinkClicked);
            // 
            // launchButton
            // 
            this.launchButton.AutoSize = true;
            this.launchButton.BackColor = System.Drawing.Color.Transparent;
            this.launchButton.BackgroundImage = global::BmLauncherWForm.Properties.Resources.LauncherStart1;
            this.launchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.launchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.launchButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.launchButton.Location = new System.Drawing.Point(19, 547);
            this.launchButton.Name = "launchButton";
            this.launchButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.launchButton.Size = new System.Drawing.Size(491, 53);
            this.launchButton.TabIndex = 36;
            this.launchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.basicToolTip.SetToolTip(this.launchButton, "Currently selected settings will automatically be applied.");
            this.launchButton.UseVisualStyleBackColor = false;
            this.launchButton.Click += new System.EventHandler(this.launchButton_Click);
            // 
            // basicToolTip
            // 
            this.basicToolTip.AutomaticDelay = 50000;
            this.basicToolTip.AutoPopDelay = 5000000;
            this.basicToolTip.InitialDelay = 500;
            this.basicToolTip.IsBalloon = true;
            this.basicToolTip.ReshowDelay = 10;
            this.basicToolTip.ShowAlways = true;
            this.basicToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.basicToolTip.ToolTipTitle = "Information";
            // 
            // disableIntroButton
            // 
            this.disableIntroButton.AutoSize = true;
            this.disableIntroButton.BackColor = System.Drawing.Color.Transparent;
            this.disableIntroButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disableIntroButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disableIntroButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.disableIntroButton.Location = new System.Drawing.Point(268, 516);
            this.disableIntroButton.Name = "disableIntroButton";
            this.disableIntroButton.Size = new System.Drawing.Size(143, 27);
            this.disableIntroButton.TabIndex = 49;
            this.disableIntroButton.Text = "Disable Intro Movies";
            this.basicToolTip.SetToolTip(this.disableIntroButton, "Find intro videos annoying? Click this to jump straight to the main menu.");
            this.disableIntroButton.UseVisualStyleBackColor = false;
            this.disableIntroButton.Click += new System.EventHandler(this.disableIntroButton_Click);
            // 
            // TexmodLabel
            // 
            this.TexmodLabel.AutoSize = true;
            this.TexmodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexmodLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.TexmodLabel.Location = new System.Drawing.Point(324, 602);
            this.TexmodLabel.Name = "TexmodLabel";
            this.TexmodLabel.Size = new System.Drawing.Size(109, 13);
            this.TexmodLabel.TabIndex = 51;
            this.TexmodLabel.Text = "Texmod detected!";
            this.basicToolTip.SetToolTip(this.TexmodLabel, "Texmod has been detected.\r\n\r\n\'Start Game\' will now launch the Texmod Autoloader.");
            // 
            // ManualModeBtn
            // 
            this.ManualModeBtn.AutoSize = true;
            this.ManualModeBtn.BackColor = System.Drawing.Color.Transparent;
            this.ManualModeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManualModeBtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManualModeBtn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ManualModeBtn.Location = new System.Drawing.Point(19, 516);
            this.ManualModeBtn.Name = "ManualModeBtn";
            this.ManualModeBtn.Size = new System.Drawing.Size(94, 27);
            this.ManualModeBtn.TabIndex = 52;
            this.ManualModeBtn.Text = "Manual Mode";
            this.basicToolTip.SetToolTip(this.ManualModeBtn, "This disables the read-only flags of the configuration files.");
            this.ManualModeBtn.UseVisualStyleBackColor = false;
            this.ManualModeBtn.Click += new System.EventHandler(this.ManualModeBtn_Click);
            // 
            // rebornButton
            // 
            this.rebornButton.BackColor = System.Drawing.Color.Transparent;
            this.rebornButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rebornButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rebornButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rebornButton.Location = new System.Drawing.Point(350, 142);
            this.rebornButton.Name = "rebornButton";
            this.rebornButton.Size = new System.Drawing.Size(160, 31);
            this.rebornButton.TabIndex = 53;
            this.rebornButton.Text = "Asylum Reborn Preset";
            this.basicToolTip.SetToolTip(this.rebornButton, "Experience the Asylum anew. Will provide the intended experience but is extremely" +
        " demanding. \r\n\r\n- This preset is not required to run the HD Texture Pack\r\n");
            this.rebornButton.UseVisualStyleBackColor = false;
            this.rebornButton.Click += new System.EventHandler(this.rebornButton_Click);
            // 
            // nvidiaToolTip
            // 
            this.nvidiaToolTip.Active = false;
            this.nvidiaToolTip.AutoPopDelay = 5000000;
            this.nvidiaToolTip.InitialDelay = 500;
            this.nvidiaToolTip.IsBalloon = true;
            this.nvidiaToolTip.ReshowDelay = 100;
            this.nvidiaToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.nvidiaToolTip.ToolTipTitle = "Information";
            // 
            // amdToolTip
            // 
            this.amdToolTip.Active = false;
            this.amdToolTip.AutoPopDelay = 5000000;
            this.amdToolTip.InitialDelay = 500;
            this.amdToolTip.IsBalloon = true;
            this.amdToolTip.ReshowDelay = 100;
            this.amdToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.amdToolTip.ToolTipTitle = "Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(334, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Tooltips are available for each setting.\r\n";
            // 
            // criticalTooltip
            // 
            this.criticalTooltip.AutoPopDelay = 5000000;
            this.criticalTooltip.InitialDelay = 500;
            this.criticalTooltip.IsBalloon = true;
            this.criticalTooltip.ReshowDelay = 100;
            this.criticalTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.criticalTooltip.ToolTipTitle = "DO NOT EDIT THIS IF YOUR GAME RUNS FINE!";
            // 
            // BmLauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(528, 622);
            this.Controls.Add(this.ultraButton);
            this.Controls.Add(this.rebornButton);
            this.Controls.Add(this.ManualModeBtn);
            this.Controls.Add(this.TexmodLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.disableIntroButton);
            this.Controls.Add(this.keyButton);
            this.Controls.Add(this.credLabel);
            this.Controls.Add(this.gpInfoLabel);
            this.Controls.Add(this.gpLabel);
            this.Controls.Add(this.texgroupButton);
            this.Controls.Add(this.launchButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.optiButton);
            this.Controls.Add(this.graphicsBox);
            this.Controls.Add(this.displayBox);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BmLauncherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batman: Arkham Asylum - Advanced Launcher";
            this.displayBox.ResumeLayout(false);
            this.displayBox.PerformLayout();
            this.graphicsBox.ResumeLayout(false);
            this.graphicsBox.PerformLayout();
            this.miscBox.ResumeLayout(false);
            this.miscBox.PerformLayout();
            this.nvidiaBox.ResumeLayout(false);
            this.nvidiaBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label msaaLabel;
        private Label resLabel;
        private Label vsyncLabel;
        private Label detailLabel;
        private Label fscreenLabel;
        private GroupBox displayBox;
        private Label dofLabel;
        private Label aoLabel;
        private Label lensFlareLabel;
        private Label bloomLabel;
        private Label anisoLabel;
        private Label dshadowLabel;
        private Label maxShadowLabel;
        private GroupBox graphicsBox;
        private Label physxLabel;
        private Button launchButton;
        private Label smoothFrameLabel;
        private Label gpLabel;
        public Button texgroupButton;
        public ComboBox vsyncBox;
        public ComboBox detailBox;
        public ComboBox fullscreenBox;
        public ComboBox resBox;
        public ComboBox aaBox;
        public ComboBox dofBox;
        public ComboBox aoBox;
        public ComboBox lensFlareBox;
        public ComboBox bloomBox;
        public ComboBox anisoBox;
        public ComboBox dShadowBox;
        public ComboBox maxShadowBox;
        public ComboBox physxBox;
        public Button ultraButton;
        public Button optiButton;
        public Button applyButton;
        private LinkLabel credLabel;
        public ComboBox texelBox;
        private Label shadowTexelLabel;
        public Label gpInfoLabel;
        public ComboBox memPoolBox;
        private Label memPoolLabel;
        public ComboBox distBox;
        private Label distLabel;
        public ComboBox fogBox;
        private Label fogLabel;
        public ComboBox sphericBox;
        private Label sphericalLabel;
        public ComboBox mBlurBox;
        private Label mBlurLabel;
        private Button keyButton;
        public MaskedTextBox maxSmoothTextBox;
        private GroupBox nvidiaBox;
        public CheckBox nvBox;
        public ToolTip amdToolTip;
        public ToolTip nvidiaToolTip;
        public Button disableIntroButton;
        private GroupBox miscBox;
        private Label fov1;
        private Label label2;
        private Label label1;
        private Label fov2;
        private Label label3;
        private Label label4;
        public ComboBox langBox;
        private Label langLabel;
        public CheckBox frameCheckBox;
        private ToolTip criticalTooltip;
        private Label label5;
        public Label TexmodLabel;
        public Button ManualModeBtn;
        public Button rebornButton;
        public ToolTip basicToolTip;
    }
}

