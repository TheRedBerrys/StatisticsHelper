namespace StatisticsHelper
{
    partial class Normal
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
            this.labelX = new System.Windows.Forms.Label();
            this.labelAvg = new System.Windows.Forms.Label();
            this.labelStDev = new System.Windows.Forms.Label();
            this.labelZ = new System.Windows.Forms.Label();
            this.textX = new System.Windows.Forms.TextBox();
            this.textAvg = new System.Windows.Forms.TextBox();
            this.textStDev = new System.Windows.Forms.TextBox();
            this.textZ = new System.Windows.Forms.TextBox();
            this.buttonX = new System.Windows.Forms.Button();
            this.buttonAvg = new System.Windows.Forms.Button();
            this.buttonStDev = new System.Windows.Forms.Button();
            this.buttonZ = new System.Windows.Forms.Button();
            this.dropdownProportionType = new System.Windows.Forms.ComboBox();
            this.buttonP = new System.Windows.Forms.Button();
            this.textP = new System.Windows.Forms.TextBox();
            this.labelP = new System.Windows.Forms.Label();
            this.buttonXFromP = new System.Windows.Forms.Button();
            this.buttonAvgFromP = new System.Windows.Forms.Button();
            this.buttonStDevFromP = new System.Windows.Forms.Button();
            this.buttonZFromP = new System.Windows.Forms.Button();
            this.buttonPFromX = new System.Windows.Forms.Button();
            this.labelProportionDesc1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(90, 9);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(47, 13);
            this.labelX.TabIndex = 0;
            this.labelX.Text = "X Value:";
            this.labelX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAvg
            // 
            this.labelAvg.AutoSize = true;
            this.labelAvg.Location = new System.Drawing.Point(70, 47);
            this.labelAvg.Name = "labelAvg";
            this.labelAvg.Size = new System.Drawing.Size(67, 13);
            this.labelAvg.TabIndex = 1;
            this.labelAvg.Text = "Mean Value:";
            this.labelAvg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelStDev
            // 
            this.labelStDev.AutoSize = true;
            this.labelStDev.Location = new System.Drawing.Point(36, 84);
            this.labelStDev.Name = "labelStDev";
            this.labelStDev.Size = new System.Drawing.Size(101, 13);
            this.labelStDev.TabIndex = 2;
            this.labelStDev.Text = "Standard Deviation:";
            this.labelStDev.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Location = new System.Drawing.Point(90, 120);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(47, 13);
            this.labelZ.TabIndex = 3;
            this.labelZ.Text = "Z Value:";
            this.labelZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textX
            // 
            this.textX.Location = new System.Drawing.Point(143, 6);
            this.textX.Name = "textX";
            this.textX.Size = new System.Drawing.Size(100, 20);
            this.textX.TabIndex = 4;
            this.textX.Text = "0.0";
            // 
            // textAvg
            // 
            this.textAvg.Location = new System.Drawing.Point(143, 44);
            this.textAvg.Name = "textAvg";
            this.textAvg.Size = new System.Drawing.Size(100, 20);
            this.textAvg.TabIndex = 5;
            this.textAvg.Text = "0.0";
            // 
            // textStDev
            // 
            this.textStDev.Location = new System.Drawing.Point(143, 81);
            this.textStDev.Name = "textStDev";
            this.textStDev.Size = new System.Drawing.Size(100, 20);
            this.textStDev.TabIndex = 6;
            this.textStDev.Text = "1.0";
            // 
            // textZ
            // 
            this.textZ.Location = new System.Drawing.Point(143, 117);
            this.textZ.Name = "textZ";
            this.textZ.Size = new System.Drawing.Size(100, 20);
            this.textZ.TabIndex = 7;
            this.textZ.Text = "0.0";
            // 
            // buttonX
            // 
            this.buttonX.Location = new System.Drawing.Point(249, 4);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(89, 23);
            this.buttonX.TabIndex = 8;
            this.buttonX.Text = "Solve From Z";
            this.buttonX.UseVisualStyleBackColor = true;
            this.buttonX.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonAvg
            // 
            this.buttonAvg.Location = new System.Drawing.Point(250, 44);
            this.buttonAvg.Name = "buttonAvg";
            this.buttonAvg.Size = new System.Drawing.Size(88, 23);
            this.buttonAvg.TabIndex = 9;
            this.buttonAvg.Text = "Solve From Z";
            this.buttonAvg.UseVisualStyleBackColor = true;
            this.buttonAvg.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonStDev
            // 
            this.buttonStDev.Location = new System.Drawing.Point(249, 78);
            this.buttonStDev.Name = "buttonStDev";
            this.buttonStDev.Size = new System.Drawing.Size(89, 23);
            this.buttonStDev.TabIndex = 10;
            this.buttonStDev.Text = "Solve From Z";
            this.buttonStDev.UseVisualStyleBackColor = true;
            this.buttonStDev.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonZ
            // 
            this.buttonZ.Location = new System.Drawing.Point(250, 115);
            this.buttonZ.Name = "buttonZ";
            this.buttonZ.Size = new System.Drawing.Size(88, 23);
            this.buttonZ.TabIndex = 11;
            this.buttonZ.Text = "Solve From X";
            this.buttonZ.UseVisualStyleBackColor = true;
            this.buttonZ.Click += new System.EventHandler(this.button_Click);
            // 
            // dropdownProportionType
            // 
            this.dropdownProportionType.FormattingEnabled = true;
            this.dropdownProportionType.Items.AddRange(new object[] {
            "Greater Than",
            "Less Than"});
            this.dropdownProportionType.Location = new System.Drawing.Point(143, 179);
            this.dropdownProportionType.Name = "dropdownProportionType";
            this.dropdownProportionType.Size = new System.Drawing.Size(100, 21);
            this.dropdownProportionType.TabIndex = 15;
            this.dropdownProportionType.Text = "Less Than";
            // 
            // buttonP
            // 
            this.buttonP.Location = new System.Drawing.Point(250, 147);
            this.buttonP.Name = "buttonP";
            this.buttonP.Size = new System.Drawing.Size(88, 23);
            this.buttonP.TabIndex = 14;
            this.buttonP.Text = "Solve From Z";
            this.buttonP.UseVisualStyleBackColor = true;
            this.buttonP.Click += new System.EventHandler(this.button_Click);
            // 
            // textP
            // 
            this.textP.Location = new System.Drawing.Point(143, 149);
            this.textP.Name = "textP";
            this.textP.Size = new System.Drawing.Size(100, 20);
            this.textP.TabIndex = 13;
            this.textP.Text = "0.50";
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Location = new System.Drawing.Point(82, 152);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(55, 13);
            this.labelP.TabIndex = 12;
            this.labelP.Text = "Propotion:";
            // 
            // buttonXFromP
            // 
            this.buttonXFromP.Location = new System.Drawing.Point(344, 3);
            this.buttonXFromP.Name = "buttonXFromP";
            this.buttonXFromP.Size = new System.Drawing.Size(83, 23);
            this.buttonXFromP.TabIndex = 16;
            this.buttonXFromP.Text = "Solve From P";
            this.buttonXFromP.UseVisualStyleBackColor = true;
            this.buttonXFromP.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonAvgFromP
            // 
            this.buttonAvgFromP.Location = new System.Drawing.Point(344, 44);
            this.buttonAvgFromP.Name = "buttonAvgFromP";
            this.buttonAvgFromP.Size = new System.Drawing.Size(83, 23);
            this.buttonAvgFromP.TabIndex = 17;
            this.buttonAvgFromP.Text = "Solve From P";
            this.buttonAvgFromP.UseVisualStyleBackColor = true;
            this.buttonAvgFromP.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonStDevFromP
            // 
            this.buttonStDevFromP.Location = new System.Drawing.Point(344, 78);
            this.buttonStDevFromP.Name = "buttonStDevFromP";
            this.buttonStDevFromP.Size = new System.Drawing.Size(83, 23);
            this.buttonStDevFromP.TabIndex = 18;
            this.buttonStDevFromP.Text = "Solve From P";
            this.buttonStDevFromP.UseVisualStyleBackColor = true;
            this.buttonStDevFromP.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonZFromP
            // 
            this.buttonZFromP.Location = new System.Drawing.Point(344, 115);
            this.buttonZFromP.Name = "buttonZFromP";
            this.buttonZFromP.Size = new System.Drawing.Size(83, 23);
            this.buttonZFromP.TabIndex = 19;
            this.buttonZFromP.Text = "Solve From P";
            this.buttonZFromP.UseVisualStyleBackColor = true;
            this.buttonZFromP.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonPFromX
            // 
            this.buttonPFromX.Location = new System.Drawing.Point(344, 147);
            this.buttonPFromX.Name = "buttonPFromX";
            this.buttonPFromX.Size = new System.Drawing.Size(83, 23);
            this.buttonPFromX.TabIndex = 20;
            this.buttonPFromX.Text = "Solve From X";
            this.buttonPFromX.UseVisualStyleBackColor = true;
            this.buttonPFromX.Click += new System.EventHandler(this.button_Click);
            // 
            // labelProportionDesc1
            // 
            this.labelProportionDesc1.AutoSize = true;
            this.labelProportionDesc1.Location = new System.Drawing.Point(27, 182);
            this.labelProportionDesc1.Name = "labelProportionDesc1";
            this.labelProportionDesc1.Size = new System.Drawing.Size(110, 13);
            this.labelProportionDesc1.TabIndex = 21;
            this.labelProportionDesc1.Text = "P is for measurements";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "the given Z or X value.";
            // 
            // Normal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 213);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelProportionDesc1);
            this.Controls.Add(this.buttonPFromX);
            this.Controls.Add(this.buttonZFromP);
            this.Controls.Add(this.buttonStDevFromP);
            this.Controls.Add(this.buttonAvgFromP);
            this.Controls.Add(this.buttonXFromP);
            this.Controls.Add(this.dropdownProportionType);
            this.Controls.Add(this.buttonP);
            this.Controls.Add(this.textP);
            this.Controls.Add(this.labelP);
            this.Controls.Add(this.buttonZ);
            this.Controls.Add(this.buttonStDev);
            this.Controls.Add(this.buttonAvg);
            this.Controls.Add(this.buttonX);
            this.Controls.Add(this.textZ);
            this.Controls.Add(this.textStDev);
            this.Controls.Add(this.textAvg);
            this.Controls.Add(this.textX);
            this.Controls.Add(this.labelZ);
            this.Controls.Add(this.labelStDev);
            this.Controls.Add(this.labelAvg);
            this.Controls.Add(this.labelX);
            this.MaximumSize = new System.Drawing.Size(492, 247);
            this.MinimumSize = new System.Drawing.Size(492, 247);
            this.Name = "Normal";
            this.Text = "Normal Distribution";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelAvg;
        private System.Windows.Forms.Label labelStDev;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.TextBox textX;
        private System.Windows.Forms.TextBox textAvg;
        private System.Windows.Forms.TextBox textStDev;
        private System.Windows.Forms.TextBox textZ;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.Button buttonAvg;
        private System.Windows.Forms.Button buttonStDev;
        private System.Windows.Forms.Button buttonZ;
        private System.Windows.Forms.ComboBox dropdownProportionType;
        private System.Windows.Forms.Button buttonP;
        private System.Windows.Forms.TextBox textP;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.Button buttonXFromP;
        private System.Windows.Forms.Button buttonAvgFromP;
        private System.Windows.Forms.Button buttonStDevFromP;
        private System.Windows.Forms.Button buttonZFromP;
        private System.Windows.Forms.Button buttonPFromX;
        private System.Windows.Forms.Label labelProportionDesc1;
        private System.Windows.Forms.Label label1;
    }
}

