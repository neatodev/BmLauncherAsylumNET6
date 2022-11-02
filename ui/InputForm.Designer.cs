using System.ComponentModel;
using System.Windows.Forms;

namespace BmLauncherWForm.ui
{
    partial class inputForm
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
            this.modifierBox = new System.Windows.Forms.ComboBox();
            this.modifierLabel = new System.Windows.Forms.Label();
            this.inputButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // modifierBox
            // 
            this.modifierBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modifierBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifierBox.FormattingEnabled = true;
            this.modifierBox.Items.AddRange(new object[] {
            "None",
            "Shift",
            "Alt",
            "Ctrl"});
            this.modifierBox.Location = new System.Drawing.Point(12, 38);
            this.modifierBox.Name = "modifierBox";
            this.modifierBox.Size = new System.Drawing.Size(225, 23);
            this.modifierBox.TabIndex = 1;
            this.modifierBox.SelectedIndexChanged += new System.EventHandler(this.modifierBox_SelectedIndexChanged);
            // 
            // modifierLabel
            // 
            this.modifierLabel.AutoSize = true;
            this.modifierLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifierLabel.Location = new System.Drawing.Point(12, 16);
            this.modifierLabel.Name = "modifierLabel";
            this.modifierLabel.Size = new System.Drawing.Size(103, 15);
            this.modifierLabel.TabIndex = 2;
            this.modifierLabel.Text = "Select a Modifier:";
            // 
            // inputButton
            // 
            this.inputButton.BackColor = System.Drawing.Color.Transparent;
            this.inputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputButton.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputButton.Location = new System.Drawing.Point(-19, -17);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(287, 220);
            this.inputButton.TabIndex = 3;
            this.inputButton.Text = "Waiting for Input";
            this.inputButton.UseVisualStyleBackColor = false;
            this.inputButton.UseWaitCursor = true;
            this.inputButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputButton_KeyDown);
            this.inputButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.inputButton_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.modifierLabel);
            this.groupBox1.Controls.Add(this.modifierBox);
            this.groupBox1.Location = new System.Drawing.Point(0, -7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 69);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // inputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(249, 145);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.inputButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "inputForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input Prompt";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label modifierLabel;
        private ComboBox modifierBox;
        private Button inputButton;
        private GroupBox groupBox1;
    }
}