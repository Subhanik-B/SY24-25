namespace Quartet3
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TopSpeedTB = new System.Windows.Forms.TextBox();
            this.cc = new System.Windows.Forms.TextBox();
            this.Cylinders = new System.Windows.Forms.TextBox();
            this.ToSixty = new System.Windows.Forms.TextBox();
            this.RPM = new System.Windows.Forms.TextBox();
            this.Horsepower = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(39, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TopSpeedTB
            // 
            this.TopSpeedTB.Location = new System.Drawing.Point(39, 121);
            this.TopSpeedTB.Name = "TopSpeedTB";
            this.TopSpeedTB.Size = new System.Drawing.Size(100, 22);
            this.TopSpeedTB.TabIndex = 1;
            // 
            // cc
            // 
            this.cc.Location = new System.Drawing.Point(145, 121);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(100, 22);
            this.cc.TabIndex = 2;
            // 
            // Cylinders
            // 
            this.Cylinders.Location = new System.Drawing.Point(145, 149);
            this.Cylinders.Name = "Cylinders";
            this.Cylinders.Size = new System.Drawing.Size(100, 22);
            this.Cylinders.TabIndex = 4;
            // 
            // ToSixty
            // 
            this.ToSixty.Location = new System.Drawing.Point(39, 149);
            this.ToSixty.Name = "ToSixty";
            this.ToSixty.Size = new System.Drawing.Size(100, 22);
            this.ToSixty.TabIndex = 3;
            // 
            // RPM
            // 
            this.RPM.Location = new System.Drawing.Point(145, 177);
            this.RPM.Name = "RPM";
            this.RPM.Size = new System.Drawing.Size(100, 22);
            this.RPM.TabIndex = 6;
            // 
            // Horsepower
            // 
            this.Horsepower.Location = new System.Drawing.Point(39, 177);
            this.Horsepower.Name = "Horsepower";
            this.Horsepower.Size = new System.Drawing.Size(100, 22);
            this.Horsepower.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(403, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(92, 205);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(100, 22);
            this.Name.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RPM);
            this.Controls.Add(this.Horsepower);
            this.Controls.Add(this.Cylinders);
            this.Controls.Add(this.ToSixty);
            this.Controls.Add(this.cc);
            this.Controls.Add(this.TopSpeedTB);
            this.Controls.Add(this.pictureBox1);
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TopSpeedTB;
        private System.Windows.Forms.TextBox cc;
        private System.Windows.Forms.TextBox Cylinders;
        private System.Windows.Forms.TextBox ToSixty;
        private System.Windows.Forms.TextBox RPM;
        private System.Windows.Forms.TextBox Horsepower;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Name;
    }
}

