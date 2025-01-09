namespace New_Years
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
            this.Bit_1 = new System.Windows.Forms.TextBox();
            this.Bit_2 = new System.Windows.Forms.TextBox();
            this.Bit_3 = new System.Windows.Forms.TextBox();
            this.Bit_4 = new System.Windows.Forms.TextBox();
            this.Bit_5 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Bit_1
            // 
            this.Bit_1.Location = new System.Drawing.Point(448, 183);
            this.Bit_1.MaxLength = 1;
            this.Bit_1.Name = "Bit_1";
            this.Bit_1.Size = new System.Drawing.Size(26, 22);
            this.Bit_1.TabIndex = 0;
            this.Bit_1.TextChanged += new System.EventHandler(this.Bit_5_TextChanged);
            // 
            // Bit_2
            // 
            this.Bit_2.Location = new System.Drawing.Point(416, 183);
            this.Bit_2.MaxLength = 1;
            this.Bit_2.Name = "Bit_2";
            this.Bit_2.Size = new System.Drawing.Size(26, 22);
            this.Bit_2.TabIndex = 1;
            this.Bit_2.TextChanged += new System.EventHandler(this.Bit_5_TextChanged);
            // 
            // Bit_3
            // 
            this.Bit_3.Location = new System.Drawing.Point(384, 183);
            this.Bit_3.MaxLength = 1;
            this.Bit_3.Name = "Bit_3";
            this.Bit_3.Size = new System.Drawing.Size(26, 22);
            this.Bit_3.TabIndex = 2;
            this.Bit_3.TextChanged += new System.EventHandler(this.Bit_5_TextChanged);
            // 
            // Bit_4
            // 
            this.Bit_4.Location = new System.Drawing.Point(352, 183);
            this.Bit_4.MaxLength = 1;
            this.Bit_4.Name = "Bit_4";
            this.Bit_4.Size = new System.Drawing.Size(26, 22);
            this.Bit_4.TabIndex = 3;
            this.Bit_4.TextChanged += new System.EventHandler(this.Bit_5_TextChanged);
            // 
            // Bit_5
            // 
            this.Bit_5.Location = new System.Drawing.Point(320, 183);
            this.Bit_5.MaxLength = 1;
            this.Bit_5.Name = "Bit_5";
            this.Bit_5.Size = new System.Drawing.Size(26, 22);
            this.Bit_5.TabIndex = 4;
            this.Bit_5.TextChanged += new System.EventHandler(this.Bit_5_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(320, 237);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(154, 22);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Bit_5);
            this.Controls.Add(this.Bit_4);
            this.Controls.Add(this.Bit_3);
            this.Controls.Add(this.Bit_2);
            this.Controls.Add(this.Bit_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Bit_1;
        private System.Windows.Forms.TextBox Bit_2;
        private System.Windows.Forms.TextBox Bit_3;
        private System.Windows.Forms.TextBox Bit_4;
        private System.Windows.Forms.TextBox Bit_5;
        private System.Windows.Forms.TextBox textBox1;
    }
}

