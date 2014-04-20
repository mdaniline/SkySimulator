namespace SkySimulator
{
    partial class SettingsForm
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
            this.button = new System.Windows.Forms.Button();
            this.widthBox = new System.Windows.Forms.NumericUpDown();
            this.heightBox = new System.Windows.Forms.NumericUpDown();
            this.earthRadius = new System.Windows.Forms.NumericUpDown();
            this.atmosphereRadius = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sunIntensity = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.sunAngleBox = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.scaleHeightR = new System.Windows.Forms.NumericUpDown();
            this.raleighSettings = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.betaBlueR = new System.Windows.Forms.NumericUpDown();
            this.betaGreenR = new System.Windows.Forms.NumericUpDown();
            this.betaRedR = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.g = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.betaBlueM = new System.Windows.Forms.NumericUpDown();
            this.betaGreenM = new System.Windows.Forms.NumericUpDown();
            this.betaRedM = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.scaleHeightM = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.widthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.earthRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atmosphereRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunIntensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunAngleBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleHeightR)).BeginInit();
            this.raleighSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betaBlueR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betaGreenR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betaRedR)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.g)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betaBlueM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betaGreenM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betaRedM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleHeightM)).BeginInit();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button.Location = new System.Drawing.Point(0, 445);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(348, 28);
            this.button.TabIndex = 0;
            this.button.Text = "Go!";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button1_Click);
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(108, 12);
            this.widthBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(120, 20);
            this.widthBox.TabIndex = 3;
            this.widthBox.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(108, 38);
            this.heightBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(120, 20);
            this.heightBox.TabIndex = 4;
            this.heightBox.Value = new decimal(new int[] {
            480,
            0,
            0,
            0});
            // 
            // earthRadius
            // 
            this.earthRadius.Location = new System.Drawing.Point(108, 94);
            this.earthRadius.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.earthRadius.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.earthRadius.Name = "earthRadius";
            this.earthRadius.Size = new System.Drawing.Size(120, 20);
            this.earthRadius.TabIndex = 5;
            this.earthRadius.Value = new decimal(new int[] {
            6360,
            0,
            0,
            0});
            // 
            // atmosphereRadius
            // 
            this.atmosphereRadius.Location = new System.Drawing.Point(108, 120);
            this.atmosphereRadius.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.atmosphereRadius.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.atmosphereRadius.Name = "atmosphereRadius";
            this.atmosphereRadius.Size = new System.Drawing.Size(120, 20);
            this.atmosphereRadius.TabIndex = 6;
            this.atmosphereRadius.Value = new decimal(new int[] {
            6420,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Planet Radius";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Atmospere Radius";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Km";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Km";
            // 
            // sunIntensity
            // 
            this.sunIntensity.Location = new System.Drawing.Point(108, 159);
            this.sunIntensity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sunIntensity.Name = "sunIntensity";
            this.sunIntensity.Size = new System.Drawing.Size(120, 20);
            this.sunIntensity.TabIndex = 13;
            this.sunIntensity.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Sun Intensity";
            // 
            // sunAngleBox
            // 
            this.sunAngleBox.Location = new System.Drawing.Point(108, 185);
            this.sunAngleBox.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.sunAngleBox.Name = "sunAngleBox";
            this.sunAngleBox.Size = new System.Drawing.Size(120, 20);
            this.sunAngleBox.TabIndex = 15;
            this.sunAngleBox.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Sun Angle";
            // 
            // scaleHeightR
            // 
            this.scaleHeightR.Location = new System.Drawing.Point(102, 24);
            this.scaleHeightR.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.scaleHeightR.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.scaleHeightR.Name = "scaleHeightR";
            this.scaleHeightR.Size = new System.Drawing.Size(98, 20);
            this.scaleHeightR.TabIndex = 17;
            this.scaleHeightR.Value = new decimal(new int[] {
            7994,
            0,
            0,
            0});
            // 
            // raleighSettings
            // 
            this.raleighSettings.Controls.Add(this.label11);
            this.raleighSettings.Controls.Add(this.label10);
            this.raleighSettings.Controls.Add(this.betaBlueR);
            this.raleighSettings.Controls.Add(this.betaGreenR);
            this.raleighSettings.Controls.Add(this.betaRedR);
            this.raleighSettings.Controls.Add(this.label9);
            this.raleighSettings.Controls.Add(this.scaleHeightR);
            this.raleighSettings.Location = new System.Drawing.Point(12, 225);
            this.raleighSettings.Name = "raleighSettings";
            this.raleighSettings.Size = new System.Drawing.Size(322, 100);
            this.raleighSettings.TabIndex = 18;
            this.raleighSettings.TabStop = false;
            this.raleighSettings.Text = "Raleigh Scattering";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(276, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "x10^-6";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Beta Coefficients";
            // 
            // betaBlueR
            // 
            this.betaBlueR.DecimalPlaces = 2;
            this.betaBlueR.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.betaBlueR.Location = new System.Drawing.Point(218, 50);
            this.betaBlueR.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.betaBlueR.Name = "betaBlueR";
            this.betaBlueR.Size = new System.Drawing.Size(52, 20);
            this.betaBlueR.TabIndex = 21;
            this.betaBlueR.Value = new decimal(new int[] {
            224,
            0,
            0,
            65536});
            // 
            // betaGreenR
            // 
            this.betaGreenR.DecimalPlaces = 2;
            this.betaGreenR.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.betaGreenR.Location = new System.Drawing.Point(160, 50);
            this.betaGreenR.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.betaGreenR.Name = "betaGreenR";
            this.betaGreenR.Size = new System.Drawing.Size(52, 20);
            this.betaGreenR.TabIndex = 20;
            this.betaGreenR.Value = new decimal(new int[] {
            130,
            0,
            0,
            65536});
            // 
            // betaRedR
            // 
            this.betaRedR.DecimalPlaces = 2;
            this.betaRedR.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.betaRedR.Location = new System.Drawing.Point(102, 50);
            this.betaRedR.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.betaRedR.Name = "betaRedR";
            this.betaRedR.Size = new System.Drawing.Size(52, 20);
            this.betaRedR.TabIndex = 19;
            this.betaRedR.Value = new decimal(new int[] {
            55,
            0,
            0,
            65536});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Scale Height";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.g);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.betaBlueM);
            this.groupBox1.Controls.Add(this.betaGreenM);
            this.groupBox1.Controls.Add(this.betaRedM);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.scaleHeightM);
            this.groupBox1.Location = new System.Drawing.Point(15, 331);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 108);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mie Scattering";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "G";
            // 
            // g
            // 
            this.g.DecimalPlaces = 2;
            this.g.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.g.Location = new System.Drawing.Point(102, 76);
            this.g.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(98, 20);
            this.g.TabIndex = 24;
            this.g.Value = new decimal(new int[] {
            76,
            0,
            0,
            131072});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(276, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "x10^-6";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Beta Coefficients";
            // 
            // betaBlueM
            // 
            this.betaBlueM.DecimalPlaces = 2;
            this.betaBlueM.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.betaBlueM.Location = new System.Drawing.Point(218, 50);
            this.betaBlueM.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.betaBlueM.Name = "betaBlueM";
            this.betaBlueM.Size = new System.Drawing.Size(52, 20);
            this.betaBlueM.TabIndex = 21;
            this.betaBlueM.Value = new decimal(new int[] {
            21,
            0,
            0,
            0});
            // 
            // betaGreenM
            // 
            this.betaGreenM.DecimalPlaces = 2;
            this.betaGreenM.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.betaGreenM.Location = new System.Drawing.Point(160, 50);
            this.betaGreenM.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.betaGreenM.Name = "betaGreenM";
            this.betaGreenM.Size = new System.Drawing.Size(52, 20);
            this.betaGreenM.TabIndex = 20;
            this.betaGreenM.Value = new decimal(new int[] {
            21,
            0,
            0,
            0});
            // 
            // betaRedM
            // 
            this.betaRedM.DecimalPlaces = 2;
            this.betaRedM.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.betaRedM.Location = new System.Drawing.Point(102, 50);
            this.betaRedM.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.betaRedM.Name = "betaRedM";
            this.betaRedM.Size = new System.Drawing.Size(52, 20);
            this.betaRedM.TabIndex = 19;
            this.betaRedM.Value = new decimal(new int[] {
            21,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Scale Height";
            // 
            // scaleHeightM
            // 
            this.scaleHeightM.Location = new System.Drawing.Point(102, 24);
            this.scaleHeightM.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.scaleHeightM.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.scaleHeightM.Name = "scaleHeightM";
            this.scaleHeightM.Size = new System.Drawing.Size(98, 20);
            this.scaleHeightM.TabIndex = 17;
            this.scaleHeightM.Value = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 473);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.raleighSettings);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sunAngleBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sunIntensity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.atmosphereRadius);
            this.Controls.Add(this.earthRadius);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.button);
            this.Name = "SettingsForm";
            this.Text = "Sky Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.widthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.earthRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atmosphereRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunIntensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunAngleBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleHeightR)).EndInit();
            this.raleighSettings.ResumeLayout(false);
            this.raleighSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betaBlueR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betaGreenR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betaRedR)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.g)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betaBlueM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betaGreenM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betaRedM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleHeightM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.NumericUpDown widthBox;
        private System.Windows.Forms.NumericUpDown heightBox;
        private System.Windows.Forms.NumericUpDown earthRadius;
        private System.Windows.Forms.NumericUpDown atmosphereRadius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown sunIntensity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown sunAngleBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown scaleHeightR;
        private System.Windows.Forms.GroupBox raleighSettings;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown betaRedR;
        private System.Windows.Forms.NumericUpDown betaBlueR;
        private System.Windows.Forms.NumericUpDown betaGreenR;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown betaBlueM;
        private System.Windows.Forms.NumericUpDown betaGreenM;
        private System.Windows.Forms.NumericUpDown betaRedM;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown scaleHeightM;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown g;
    }
}

