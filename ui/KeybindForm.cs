using BmLauncherWForm.data;
using BmLauncherWForm.infrastructure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BmLauncherWForm.ui
{
    /**
     * Keybind editor class that uses buttons as inputreaders.
     */
    public partial class KeybindForm : Form
    {
        public List<Button> ButtonList = new List<Button>();

        /**
         * constructor for the KeybindForm that adds all the button to a static list
         */
        public KeybindForm()
        {
            InitializeComponent();
            ButtonList.Add(fwButton);
            ButtonList.Add(bwButton);
            ButtonList.Add(leftButton);
            ButtonList.Add(rightButton);
            ButtonList.Add(crouchButton);
            ButtonList.Add(zoomButton);
            ButtonList.Add(grappleButton);
            ButtonList.Add(crouchToggleButton);
            ButtonList.Add(RGUButton);
            ButtonList.Add(quickBatButton);
            ButtonList.Add(quickClawButton);
            ButtonList.Add(throwButton);
            ButtonList.Add(cTakedownButton);
            ButtonList.Add(gadSecButton);
            ButtonList.Add(detButton);
            ButtonList.Add(gadStrikeButton);
            ButtonList.Add(ACTButton);
            ButtonList.Add(capeStunButton);
            applyKeyButton.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new inputForm(fwButton).ShowDialog();
            applyKeyButton.Enabled = true;
        }

        private void applyKeyButton_Click(object sender, EventArgs e)
        {
            bool inputsOk = KeybindInterpreter.validateInput();
            if (inputsOk)
            {
                Program.MyFactory.writeInputFile();
                Program.MyFactory.writeBmInputFile();
                applyKeyButton.Enabled = false;
            }
            else
            {
                MessageBox.Show(@"All keys have to be bound!", @"Unbound Key found", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void bwButton_Click(object sender, EventArgs e)
        {
            new inputForm(bwButton).ShowDialog();
            applyKeyButton.Enabled = true;
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            new inputForm(leftButton).ShowDialog();
            applyKeyButton.Enabled = true;
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            new inputForm(rightButton).ShowDialog();
            applyKeyButton.Enabled = true;
        }

        private void crouchButton_Click(object sender, EventArgs e)
        {
            new inputForm(crouchButton).ShowDialog();
            applyKeyButton.Enabled = true;
        }

        private void zoomButton_Click(object sender, EventArgs e)
        {
            new inputForm(zoomButton).ShowDialog();
            applyKeyButton.Enabled = true;
        }

        private void grappleButton_Click(object sender, EventArgs e)
        {
            new inputForm(grappleButton).ShowDialog();
            applyKeyButton.Enabled = true;
        }

        private void crouchToggleButton_Click(object sender, EventArgs e)
        {
            new inputForm(crouchToggleButton).ShowDialog();
            applyKeyButton.Enabled = true;
        }

        private void RGUButton_Click(object sender, EventArgs e)
        {
            new inputForm(RGUButton).ShowDialog();
            applyKeyButton.Enabled = true;
        }

        private void quickBatButton_Click(object sender, EventArgs e)
        {
            new inputForm(quickBatButton).ShowDialog();
            applyKeyButton.Enabled = true;
        }

        private void quickClawButton_Click(object sender, EventArgs e)
        {
            new inputForm(quickClawButton).ShowDialog();
            applyKeyButton.Enabled = true;
        }

        private void throwButton_Click(object sender, EventArgs e)
        {
            new inputForm(throwButton).ShowDialog();
            applyKeyButton.Enabled = true;
        }

        private void cTakedownButton_Click(object sender, EventArgs e)
        {
            new inputForm(cTakedownButton).ShowDialog();
            applyKeyButton.Enabled = true;
        }

        private void gadSecButton_Click(object sender, EventArgs e)
        {
            new inputForm(gadSecButton).ShowDialog();
            applyKeyButton.Enabled = true;
        }

        private void detButton_Click(object sender, EventArgs e)
        {
            new inputForm(detButton).ShowDialog();
            applyKeyButton.Enabled = true;
        }

        private void gadStrikeButton_Click(object sender, EventArgs e)
        {
            new inputForm(gadStrikeButton).ShowDialog();
            applyKeyButton.Enabled = true;
        }

        private void ACTButton_Click(object sender, EventArgs e)
        {
            new inputForm(ACTButton).ShowDialog();
            applyKeyButton.Enabled = true;
        }

        private void capeStunButton_Click(object sender, EventArgs e)
        {
            new inputForm(capeStunButton).ShowDialog();
            applyKeyButton.Enabled = true;
        }

        private void helpLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new KeyHelpForm().ShowDialog();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            File.Delete(Factory.InputFile);
            Factory.InputList.Clear();
            Program.MyFactory.readInputFile();
            foreach (Button bt in ButtonList)
            {
                bt.ForeColor = Color.Black;
            }

            applyKeyButton.Enabled = false;
        }

        private void speedLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new SpeedrunHint().ShowDialog();
        }

        private void SensitivityBar_Scroll(object sender, EventArgs e)
        {
            SensitivityValueLabel.Text = SensitivityBar.Value.ToString();
            applyKeyButton.Enabled = true;
        }

        private void MouseSmoothBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            applyKeyButton.Enabled = true;
        }
    }
}