using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace タイマー
{
    public partial class settingForm : Form
    {
        public settingForm(bool tenmetu, int tenmetuSec, Color tenmetuColor, int beepFreq)
        {
            InitializeComponent();
            tenmetuCheckBox.Checked = tenmetu;
            tenmetuSecBox.Value = tenmetuSec;
            colorButton.BackColor = tenmetuColor;
            beepFreqBox.Value = beepFreq;
        }

        private void tenmetuCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            tenmetuSecBox.Enabled = tenmetuCheckBox.Checked;
            colorButton.Enabled = tenmetuCheckBox.Checked;
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colordialog = new ColorDialog();
            colordialog.Color = colorButton.BackColor;
            DialogResult result = colordialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                colorButton.BackColor = colordialog.Color;
            }
        }
    }
}
