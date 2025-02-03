namespace Dictionary
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
            this.Words = new System.Windows.Forms.ComboBox();
            this.Add = new System.Windows.Forms.Button();
            this.Word = new System.Windows.Forms.TextBox();
            this.Definition = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Words
            // 
            this.Words.FormattingEnabled = true;
            this.Words.Location = new System.Drawing.Point(12, 12);
            this.Words.Name = "Words";
            this.Words.Size = new System.Drawing.Size(121, 24);
            this.Words.TabIndex = 0;
            this.Words.SelectedIndexChanged += new System.EventHandler(this.Words_SelectedIndexChanged);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(183, 12);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Word
            // 
            this.Word.Location = new System.Drawing.Point(12, 67);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(100, 22);
            this.Word.TabIndex = 2;
            // 
            // Definition
            // 
            this.Definition.Location = new System.Drawing.Point(158, 67);
            this.Definition.Multiline = true;
            this.Definition.Name = "Definition";
            this.Definition.Size = new System.Drawing.Size(237, 78);
            this.Definition.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Definition);
            this.Controls.Add(this.Word);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Words);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Words;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox Word;
        private System.Windows.Forms.TextBox Definition;
    }
}

