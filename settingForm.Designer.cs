namespace タイマー
{
    partial class settingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.tenmetuCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tenmetuSecBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.colorButton = new System.Windows.Forms.Button();
            this.OKbutton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.beepFreqBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tenmetuSecBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beepFreqBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tenmetuCheckBox
            // 
            this.tenmetuCheckBox.AutoSize = true;
            this.tenmetuCheckBox.Checked = true;
            this.tenmetuCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tenmetuCheckBox.Location = new System.Drawing.Point(12, 12);
            this.tenmetuCheckBox.Name = "tenmetuCheckBox";
            this.tenmetuCheckBox.Size = new System.Drawing.Size(108, 16);
            this.tenmetuCheckBox.TabIndex = 0;
            this.tenmetuCheckBox.Text = "背景を点滅させる";
            this.tenmetuCheckBox.UseVisualStyleBackColor = true;
            this.tenmetuCheckBox.CheckedChanged += new System.EventHandler(this.tenmetuCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "点滅開始位置(1-60)";
            // 
            // tenmetuSecBox
            // 
            this.tenmetuSecBox.Location = new System.Drawing.Point(12, 50);
            this.tenmetuSecBox.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.tenmetuSecBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tenmetuSecBox.Name = "tenmetuSecBox";
            this.tenmetuSecBox.Size = new System.Drawing.Size(40, 19);
            this.tenmetuSecBox.TabIndex = 2;
            this.tenmetuSecBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tenmetuSecBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "秒前";
            // 
            // colorButton
            // 
            this.colorButton.BackColor = System.Drawing.Color.Red;
            this.colorButton.Location = new System.Drawing.Point(12, 75);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(40, 23);
            this.colorButton.TabIndex = 4;
            this.colorButton.Text = "色";
            this.colorButton.UseVisualStyleBackColor = false;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // OKbutton
            // 
            this.OKbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKbutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKbutton.Location = new System.Drawing.Point(25, 166);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(60, 23);
            this.OKbutton.TabIndex = 6;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(91, 166);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(60, 23);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "キャンセル";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "ビープの周波数(10-10000)";
            // 
            // beepFreqBox
            // 
            this.beepFreqBox.Location = new System.Drawing.Point(12, 136);
            this.beepFreqBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.beepFreqBox.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.beepFreqBox.Name = "beepFreqBox";
            this.beepFreqBox.Size = new System.Drawing.Size(62, 19);
            this.beepFreqBox.TabIndex = 5;
            this.beepFreqBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.beepFreqBox.Value = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hz";
            // 
            // settingForm
            // 
            this.AcceptButton = this.OKbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(163, 201);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.beepFreqBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tenmetuSecBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tenmetuCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "settingForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "設定";
            ((System.ComponentModel.ISupportInitialize)(this.tenmetuSecBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beepFreqBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Button CancelButton;
        public System.Windows.Forms.CheckBox tenmetuCheckBox;
        public System.Windows.Forms.NumericUpDown tenmetuSecBox;
        public System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.NumericUpDown beepFreqBox;
    }
}