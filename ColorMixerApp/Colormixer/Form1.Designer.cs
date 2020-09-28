namespace ColorMixerApp
{
    partial class Form1
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
            this.RedBulb = new System.Windows.Forms.PictureBox();
            this.BlueBulb = new System.Windows.Forms.PictureBox();
            this.GreenBulb = new System.Windows.Forms.PictureBox();
            this.SetColorButton = new System.Windows.Forms.Button();
            this.RedValue = new System.Windows.Forms.TextBox();
            this.BlueValue = new System.Windows.Forms.TextBox();
            this.GreenValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.RedBulb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBulb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBulb)).BeginInit();
            this.SuspendLayout();
            // 
            // RedBulb
            // 
            this.RedBulb.Location = new System.Drawing.Point(2, 65);
            this.RedBulb.Name = "RedBulb";
            this.RedBulb.Size = new System.Drawing.Size(150, 150);
            this.RedBulb.TabIndex = 1;
            this.RedBulb.TabStop = false;
            // 
            // BlueBulb
            // 
            this.BlueBulb.Location = new System.Drawing.Point(353, 65);
            this.BlueBulb.Name = "BlueBulb";
            this.BlueBulb.Size = new System.Drawing.Size(150, 150);
            this.BlueBulb.TabIndex = 2;
            this.BlueBulb.TabStop = false;
            // 
            // GreenBulb
            // 
            this.GreenBulb.Location = new System.Drawing.Point(181, 65);
            this.GreenBulb.Name = "GreenBulb";
            this.GreenBulb.Size = new System.Drawing.Size(150, 150);
            this.GreenBulb.TabIndex = 3;
            this.GreenBulb.TabStop = false;
            // 
            // SetColorButton
            // 
            this.SetColorButton.Location = new System.Drawing.Point(112, 233);
            this.SetColorButton.Name = "SetColorButton";
            this.SetColorButton.Size = new System.Drawing.Size(286, 54);
            this.SetColorButton.TabIndex = 4;
            this.SetColorButton.Text = "Set Color";
            this.SetColorButton.UseVisualStyleBackColor = true;
            this.SetColorButton.Click += new System.EventHandler(this.SetColorsButton_Click);
            // 
            // RedValue
            // 
            this.RedValue.Location = new System.Drawing.Point(48, 25);
            this.RedValue.Name = "RedValue";
            this.RedValue.Size = new System.Drawing.Size(54, 20);
            this.RedValue.TabIndex = 5;
            this.RedValue.Text = "255";
            this.RedValue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BlueValue
            // 
            this.BlueValue.Location = new System.Drawing.Point(412, 25);
            this.BlueValue.Name = "BlueValue";
            this.BlueValue.Size = new System.Drawing.Size(45, 20);
            this.BlueValue.TabIndex = 6;
            this.BlueValue.Text = "255";
            // 
            // GreenValue
            // 
            this.GreenValue.Location = new System.Drawing.Point(222, 25);
            this.GreenValue.Name = "GreenValue";
            this.GreenValue.Size = new System.Drawing.Size(54, 20);
            this.GreenValue.TabIndex = 7;
            this.GreenValue.Text = "255";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 299);
            this.Controls.Add(this.GreenValue);
            this.Controls.Add(this.BlueValue);
            this.Controls.Add(this.RedValue);
            this.Controls.Add(this.SetColorButton);
            this.Controls.Add(this.GreenBulb);
            this.Controls.Add(this.BlueBulb);
            this.Controls.Add(this.RedBulb);
            this.Name = "Form1";
            this.Text = "ColorPicker";
            ((System.ComponentModel.ISupportInitialize)(this.RedBulb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBulb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBulb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox RedBulb;
        private System.Windows.Forms.PictureBox BlueBulb;
        private System.Windows.Forms.PictureBox GreenBulb;
        private System.Windows.Forms.Button SetColorButton;
        private System.Windows.Forms.TextBox RedValue;
        private System.Windows.Forms.TextBox BlueValue;
        private System.Windows.Forms.TextBox GreenValue;
    }
}

