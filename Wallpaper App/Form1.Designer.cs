namespace Wallpaper_App
{
    partial class frmWallpaperApp
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
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbLength = new System.Windows.Forms.ComboBox();
            this.cmbWidth = new System.Windows.Forms.ComboBox();
            this.cmbHeight = new System.Windows.Forms.ComboBox();
            this.cmbRollCoverage = new System.Windows.Forms.ComboBox();
            this.lblSIngleRoll = new System.Windows.Forms.Label();
            this.txtSingleRoll = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(13, 62);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(108, 17);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "Length (feet):";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(13, 110);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(94, 17);
            this.lblWidth.TabIndex = 1;
            this.lblWidth.Text = "Width(feet):";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(13, 157);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(100, 17);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Height(feet):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Roll coverage(sqrFt):";
            // 
            // cmbLength
            // 
            this.cmbLength.FormattingEnabled = true;
            this.cmbLength.Items.AddRange(new object[] {
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35"});
            this.cmbLength.Location = new System.Drawing.Point(167, 59);
            this.cmbLength.Name = "cmbLength";
            this.cmbLength.Size = new System.Drawing.Size(181, 24);
            this.cmbLength.TabIndex = 4;
            this.cmbLength.Text = "---select---";
            // 
            // cmbWidth
            // 
            this.cmbWidth.FormattingEnabled = true;
            this.cmbWidth.Items.AddRange(new object[] {
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35"});
            this.cmbWidth.Location = new System.Drawing.Point(167, 103);
            this.cmbWidth.Name = "cmbWidth";
            this.cmbWidth.Size = new System.Drawing.Size(181, 24);
            this.cmbWidth.TabIndex = 5;
            this.cmbWidth.Text = "---select---";
            // 
            // cmbHeight
            // 
            this.cmbHeight.FormattingEnabled = true;
            this.cmbHeight.Items.AddRange(new object[] {
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35"});
            this.cmbHeight.Location = new System.Drawing.Point(167, 150);
            this.cmbHeight.Name = "cmbHeight";
            this.cmbHeight.Size = new System.Drawing.Size(181, 24);
            this.cmbHeight.TabIndex = 6;
            this.cmbHeight.Text = "---select---";
            // 
            // cmbRollCoverage
            // 
            this.cmbRollCoverage.FormattingEnabled = true;
            this.cmbRollCoverage.Items.AddRange(new object[] {
            "40",
            "40,5",
            "41",
            "41,5",
            "42",
            "42,5",
            "43",
            "43,5",
            "44",
            "44,5",
            "45",
            "45,5",
            "46",
            "46,5",
            "47",
            "47,5",
            "48",
            "48,5",
            "49",
            "49,5",
            "50"});
            this.cmbRollCoverage.Location = new System.Drawing.Point(167, 197);
            this.cmbRollCoverage.Name = "cmbRollCoverage";
            this.cmbRollCoverage.Size = new System.Drawing.Size(181, 24);
            this.cmbRollCoverage.TabIndex = 7;
            this.cmbRollCoverage.Text = "---select---";
            // 
            // lblSIngleRoll
            // 
            this.lblSIngleRoll.AutoSize = true;
            this.lblSIngleRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSIngleRoll.Location = new System.Drawing.Point(418, 84);
            this.lblSIngleRoll.Name = "lblSIngleRoll";
            this.lblSIngleRoll.Size = new System.Drawing.Size(86, 17);
            this.lblSIngleRoll.TabIndex = 8;
            this.lblSIngleRoll.Text = "Single roll:";
            // 
            // txtSingleRoll
            // 
            this.txtSingleRoll.Location = new System.Drawing.Point(418, 105);
            this.txtSingleRoll.Name = "txtSingleRoll";
            this.txtSingleRoll.Size = new System.Drawing.Size(190, 22);
            this.txtSingleRoll.TabIndex = 9;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(417, 162);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(86, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(524, 162);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmWallpaperApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 298);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtSingleRoll);
            this.Controls.Add(this.lblSIngleRoll);
            this.Controls.Add(this.cmbRollCoverage);
            this.Controls.Add(this.cmbHeight);
            this.Controls.Add(this.cmbWidth);
            this.Controls.Add(this.cmbLength);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Name = "frmWallpaperApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wallpaper App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbLength;
        private System.Windows.Forms.ComboBox cmbWidth;
        private System.Windows.Forms.ComboBox cmbHeight;
        private System.Windows.Forms.ComboBox cmbRollCoverage;
        private System.Windows.Forms.Label lblSIngleRoll;
        private System.Windows.Forms.TextBox txtSingleRoll;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

