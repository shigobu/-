﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;

namespace タイマー
{
    public partial class Form1 : Form
    {
        double textsize = 4;
        System.Timers.Timer timer;

        public Form1()
        {
            InitializeComponent();
            label1.Font = new Font(label1.Font.FontFamily, (int)(this.Width / textsize));
            // タイマーの生成
            timer = new System.Timers.Timer();
            timer.Elapsed += new ElapsedEventHandler(OnElapsed_TimersTimer);
            timer.Interval = 500;
            timer.SynchronizingObject = this;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, (int)(this.Width / textsize));
        }

        int sec = 0; // 計測時間

        private void viewtime()
        {
            label1.Text = "" /*+ sec / 36000 % 10 + sec / 3600 % 10 +":" */
                             + sec / 600 % 6 + sec / 60 % 10 +":"
                             + sec / 10 % 6 + sec % 10;
            label1.Refresh();
        }

        int timeCount = 0;
        bool tenmetu = true;
        int tenmetuSec = 10;
        Color tenmetuColor = Color.Red;
        int beepFreq = 2500;
        private void OnElapsed_TimersTimer(object sender, ElapsedEventArgs e)
        {
            timeCount++;
            if(timeCount > 1)
            {
                sec--;
                timeCount = 0;
            }
            
            viewtime();
            if(sec < (tenmetuSec + 1) && tenmetu)
            {
                if(label1.BackColor == SystemColors.Control)
                {
                    label1.BackColor = tenmetuColor;
                }
                else
                {
                    label1.BackColor = SystemColors.Control;
                }
            }
            
            if (0 == sec)
            {
                timer.Enabled = false;
                Console.Beep(beepFreq, 2000);
                this.Activate();
                label1.BackColor = SystemColors.Control;
                stopButton.PerformClick();
            }
        }

        private void HourButton_Click(object sender, EventArgs e)
        {
            sec += 3600;
            if (sec >= 360000) sec = 0;
            viewtime();
            resetButton.Enabled = true;
        }

        private void MinButton_Click(object sender, EventArgs e)
        {
            sec += 60;
            viewtime();
            resetButton.Enabled = true;
        }

        private void SecButton_Click(object sender, EventArgs e)
        {
            sec += 10;
            viewtime();
            resetButton.Enabled = true;
        }

        int startTime = 0;
        int buttonClick = 0;
        private void startButton_Click(object sender, EventArgs e)
        {
            if (0 == sec) return;
            if(startTime < sec)
            {
                startTime = sec;
            }
            timer.Enabled = true;
            this.stopButton.Enabled = true;
            this.startButton.Enabled = false;
            //this.HourButton.Enabled = false;
            this.MinButton.Enabled = false;
            this.SecButton.Enabled = false;
            this.resetButton.Enabled = false;
            buttonClick = 0;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            this.stopButton.Enabled = false;
            this.startButton.Enabled = true;
            //this.HourButton.Enabled = true;
            this.MinButton.Enabled = true;
            this.SecButton.Enabled = true;
            this.resetButton.Enabled = true;
            label1.BackColor = SystemColors.Control;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            buttonClick++;
            if (buttonClick > 1)
            {
                label1.Text = "00:00";
                sec = 0;
                buttonClick = 0;
                startTime = 0;
                resetButton.Enabled = false;
            }
            else
            {
                sec = startTime;
                viewtime();
            }
            label1.BackColor = SystemColors.Control;
        }

        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingForm setForm = new settingForm(tenmetu, tenmetuSec, tenmetuColor, beepFreq);
            DialogResult result = setForm.ShowDialog();
            if(result == DialogResult.OK)
            {
                tenmetu = setForm.tenmetuCheckBox.Checked;
                tenmetuSec = (int)setForm.tenmetuSecBox.Value;
                tenmetuColor = setForm.colorButton.BackColor;
                beepFreq = (int)setForm.beepFreqBox.Value;
                if(!tenmetu)
                {
                    label1.BackColor = SystemColors.Control;
                }
            }
        }
    }
}