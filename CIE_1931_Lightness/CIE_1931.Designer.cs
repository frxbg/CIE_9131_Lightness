namespace CIE_1931_Lightness
{
    partial class CIE_1931
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CIE_1931));
            this.InputSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OutputSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SelectButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.StartFrom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Generate = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // InputSize
            // 
            this.InputSize.Location = new System.Drawing.Point(29, 50);
            this.InputSize.Name = "InputSize";
            this.InputSize.Size = new System.Drawing.Size(100, 20);
            this.InputSize.TabIndex = 1;
            this.InputSize.TextChanged += new System.EventHandler(this.Res_From_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Change directory";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Steps:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // OutputSize
            // 
            this.OutputSize.Location = new System.Drawing.Point(157, 50);
            this.OutputSize.Name = "OutputSize";
            this.OutputSize.Size = new System.Drawing.Size(100, 20);
            this.OutputSize.TabIndex = 5;
            this.OutputSize.TextChanged += new System.EventHandler(this.Res_To_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Generate";
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(314, 48);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(75, 23);
            this.SelectButton.TabIndex = 9;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Resolution:";
            // 
            // StartFrom
            // 
            this.StartFrom.Location = new System.Drawing.Point(157, 109);
            this.StartFrom.Name = "StartFrom";
            this.StartFrom.Size = new System.Drawing.Size(100, 20);
            this.StartFrom.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(154, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Start from:";
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(449, 47);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(75, 23);
            this.Generate.TabIndex = 14;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            // 
            // CIE_1931
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 154);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.StartFrom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OutputSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputSize);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CIE_1931";
            this.Text = "CIE 1931 Generator";
            this.Load += new System.EventHandler(this.CIE_1931_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox InputSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OutputSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox StartFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
    }
}

