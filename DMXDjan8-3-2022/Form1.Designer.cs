namespace DMXDjan8_3_2022
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcbRed = new System.Windows.Forms.TrackBar();
            this.tcbBlue = new System.Windows.Forms.TrackBar();
            this.tcbGreen = new System.Windows.Forms.TrackBar();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblRedValue = new System.Windows.Forms.Label();
            this.lblBlueValue = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblGreenValue = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblInterval = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tcbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcbGreen)).BeginInit();
            this.SuspendLayout();
            // 
            // tcbRed
            // 
            this.tcbRed.Location = new System.Drawing.Point(12, 239);
            this.tcbRed.Maximum = 255;
            this.tcbRed.Name = "tcbRed";
            this.tcbRed.Size = new System.Drawing.Size(539, 45);
            this.tcbRed.TabIndex = 0;
            this.tcbRed.Scroll += new System.EventHandler(this.tcbRed_Scroll);
            // 
            // tcbBlue
            // 
            this.tcbBlue.Location = new System.Drawing.Point(12, 341);
            this.tcbBlue.Maximum = 255;
            this.tcbBlue.Name = "tcbBlue";
            this.tcbBlue.Size = new System.Drawing.Size(539, 45);
            this.tcbBlue.TabIndex = 1;
            this.tcbBlue.Scroll += new System.EventHandler(this.tcbBlue_Scroll);
            // 
            // tcbGreen
            // 
            this.tcbGreen.Location = new System.Drawing.Point(12, 290);
            this.tcbGreen.Maximum = 255;
            this.tcbGreen.Name = "tcbGreen";
            this.tcbGreen.Size = new System.Drawing.Size(539, 45);
            this.tcbGreen.TabIndex = 2;
            this.tcbGreen.Scroll += new System.EventHandler(this.tcbGreen_Scroll);
            // 
            // pnlColor
            // 
            this.pnlColor.Location = new System.Drawing.Point(588, 12);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(200, 176);
            this.pnlColor.TabIndex = 3;
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(594, 239);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(27, 15);
            this.lblRed.TabIndex = 4;
            this.lblRed.Text = "Red";
            // 
            // lblRedValue
            // 
            this.lblRedValue.AutoSize = true;
            this.lblRedValue.Location = new System.Drawing.Point(656, 239);
            this.lblRedValue.Name = "lblRedValue";
            this.lblRedValue.Size = new System.Drawing.Size(13, 15);
            this.lblRedValue.TabIndex = 5;
            this.lblRedValue.Text = "0";
            // 
            // lblBlueValue
            // 
            this.lblBlueValue.AutoSize = true;
            this.lblBlueValue.Location = new System.Drawing.Point(653, 341);
            this.lblBlueValue.Name = "lblBlueValue";
            this.lblBlueValue.Size = new System.Drawing.Size(13, 15);
            this.lblBlueValue.TabIndex = 7;
            this.lblBlueValue.Text = "0";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(591, 341);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(30, 15);
            this.lblBlue.TabIndex = 6;
            this.lblBlue.Text = "Blue";
            // 
            // lblGreenValue
            // 
            this.lblGreenValue.AutoSize = true;
            this.lblGreenValue.Location = new System.Drawing.Point(653, 290);
            this.lblGreenValue.Name = "lblGreenValue";
            this.lblGreenValue.Size = new System.Drawing.Size(13, 15);
            this.lblGreenValue.TabIndex = 9;
            this.lblGreenValue.Text = "0";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(591, 290);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(38, 15);
            this.lblGreen.TabIndex = 8;
            this.lblGreen.Text = "Green";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(130, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(130, 87);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 11;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(61, 43);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 15);
            this.lblPort.TabIndex = 12;
            this.lblPort.Text = "Port";
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(61, 90);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(46, 15);
            this.lblInterval.TabIndex = 13;
            this.lblInterval.Text = "Interval";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(698, 373);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(99, 76);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblGreenValue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblBlueValue);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblRedValue);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.pnlColor);
            this.Controls.Add(this.tcbGreen);
            this.Controls.Add(this.tcbBlue);
            this.Controls.Add(this.tcbRed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tcbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcbGreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TrackBar tcbRed;
        private TrackBar tcbBlue;
        private TrackBar tcbGreen;
        private Panel pnlColor;
        private Label lblRed;
        private Label lblRedValue;
        private Label lblBlueValue;
        private Label lblBlue;
        private Label lblGreenValue;
        private Label lblGreen;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label lblPort;
        private Label lblInterval;
        private Button btnReset;
    }
}