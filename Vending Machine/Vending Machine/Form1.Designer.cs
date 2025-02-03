namespace Vending_Machine
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.item12 = new Vending_Machine.Item();
            this.item11 = new Vending_Machine.Item();
            this.item10 = new Vending_Machine.Item();
            this.item9 = new Vending_Machine.Item();
            this.item8 = new Vending_Machine.Item();
            this.item7 = new Vending_Machine.Item();
            this.item6 = new Vending_Machine.Item();
            this.item5 = new Vending_Machine.Item();
            this.item4 = new Vending_Machine.Item();
            this.item3 = new Vending_Machine.Item();
            this.item2 = new Vending_Machine.Item();
            this.item1 = new Vending_Machine.Item();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(461, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(509, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(552, 121);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 16;
            this.button1.Text = "Nickels";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(552, 156);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 17;
            this.button2.Text = "Dimes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(552, 192);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 18;
            this.button3.Text = "Quarters";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(552, 228);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 19;
            this.button4.Text = "Dollars";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(548, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Deposit:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(615, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 21;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Vending_Machine.Properties.Resources.download__14_;
            this.pictureBox4.Location = new System.Drawing.Point(660, 226);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Vending_Machine.Properties.Resources.download__13_;
            this.pictureBox3.Location = new System.Drawing.Point(660, 192);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Vending_Machine.Properties.Resources.download__12_;
            this.pictureBox2.Location = new System.Drawing.Point(660, 156);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vending_Machine.Properties.Resources.download__11_;
            this.pictureBox1.Location = new System.Drawing.Point(661, 118);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // item12
            // 
            this.item12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.item12.image = global::Vending_Machine.Properties.Resources.download__10_;
            this.item12.Location = new System.Drawing.Point(348, 281);
            this.item12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.item12.name = "Chocolate Coffee Beans";
            this.item12.Name = "item12";
            this.item12.price = 6D;
            this.item12.Size = new System.Drawing.Size(105, 127);
            this.item12.TabIndex = 11;
            this.item12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.showPrice);
            // 
            // item11
            // 
            this.item11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.item11.image = global::Vending_Machine.Properties.Resources.download__9_;
            this.item11.Location = new System.Drawing.Point(236, 281);
            this.item11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.item11.name = "Coffee Ice Cream";
            this.item11.Name = "item11";
            this.item11.price = 7.99D;
            this.item11.Size = new System.Drawing.Size(105, 127);
            this.item11.TabIndex = 10;
            this.item11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.showPrice);
            // 
            // item10
            // 
            this.item10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.item10.image = global::Vending_Machine.Properties.Resources.download__8_;
            this.item10.Location = new System.Drawing.Point(124, 281);
            this.item10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.item10.name = "Coffee Chocolate";
            this.item10.Name = "item10";
            this.item10.price = 10.99D;
            this.item10.Size = new System.Drawing.Size(105, 127);
            this.item10.TabIndex = 9;
            this.item10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.showPrice);
            // 
            // item9
            // 
            this.item9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.item9.image = global::Vending_Machine.Properties.Resources.download__7_;
            this.item9.Location = new System.Drawing.Point(12, 281);
            this.item9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.item9.name = "Dark Chocolate";
            this.item9.Name = "item9";
            this.item9.price = 4D;
            this.item9.Size = new System.Drawing.Size(105, 127);
            this.item9.TabIndex = 8;
            this.item9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.showPrice);
            // 
            // item8
            // 
            this.item8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.item8.image = global::Vending_Machine.Properties.Resources.download__6_;
            this.item8.Location = new System.Drawing.Point(348, 146);
            this.item8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.item8.name = "White Chocolate";
            this.item8.Name = "item8";
            this.item8.price = 4.99D;
            this.item8.Size = new System.Drawing.Size(105, 127);
            this.item8.TabIndex = 7;
            this.item8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.showPrice);
            // 
            // item7
            // 
            this.item7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.item7.image = global::Vending_Machine.Properties.Resources.download__5_;
            this.item7.Location = new System.Drawing.Point(236, 146);
            this.item7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.item7.name = "Milk Chocolate";
            this.item7.Name = "item7";
            this.item7.price = 3.99D;
            this.item7.Size = new System.Drawing.Size(105, 127);
            this.item7.TabIndex = 6;
            this.item7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.showPrice);
            // 
            // item6
            // 
            this.item6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.item6.image = global::Vending_Machine.Properties.Resources.download__4_;
            this.item6.Location = new System.Drawing.Point(124, 146);
            this.item6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.item6.name = "Mccoffee";
            this.item6.Name = "item6";
            this.item6.price = 5.5D;
            this.item6.Size = new System.Drawing.Size(105, 127);
            this.item6.TabIndex = 5;
            this.item6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.showPrice);
            // 
            // item5
            // 
            this.item5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.item5.image = global::Vending_Machine.Properties.Resources.download__3_;
            this.item5.Location = new System.Drawing.Point(12, 146);
            this.item5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.item5.name = "smol coffee";
            this.item5.Name = "item5";
            this.item5.price = 2.99D;
            this.item5.Size = new System.Drawing.Size(105, 127);
            this.item5.TabIndex = 4;
            this.item5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.showPrice);
            // 
            // item4
            // 
            this.item4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.item4.image = global::Vending_Machine.Properties.Resources.download__2_;
            this.item4.Location = new System.Drawing.Point(348, 12);
            this.item4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.item4.name = "BIG coffee";
            this.item4.Name = "item4";
            this.item4.price = 12.99D;
            this.item4.Size = new System.Drawing.Size(105, 127);
            this.item4.TabIndex = 3;
            this.item4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.showPrice);
            // 
            // item3
            // 
            this.item3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.item3.image = global::Vending_Machine.Properties.Resources.images;
            this.item3.Location = new System.Drawing.Point(236, 12);
            this.item3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.item3.name = "Happy Coffee";
            this.item3.Name = "item3";
            this.item3.price = 6.99D;
            this.item3.Size = new System.Drawing.Size(105, 127);
            this.item3.TabIndex = 2;
            this.item3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.showPrice);
            // 
            // item2
            // 
            this.item2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.item2.image = global::Vending_Machine.Properties.Resources.download__1_;
            this.item2.Location = new System.Drawing.Point(124, 12);
            this.item2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.item2.name = "Ice Coffee";
            this.item2.Name = "item2";
            this.item2.price = 7.99D;
            this.item2.Size = new System.Drawing.Size(105, 127);
            this.item2.TabIndex = 1;
            this.item2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.showPrice);
            // 
            // item1
            // 
            this.item1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.item1.image = global::Vending_Machine.Properties.Resources.download;
            this.item1.Location = new System.Drawing.Point(12, 12);
            this.item1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.item1.name = "Coffee";
            this.item1.Name = "item1";
            this.item1.price = 5.99D;
            this.item1.Size = new System.Drawing.Size(105, 127);
            this.item1.TabIndex = 0;
            this.item1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.showPrice);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.item12);
            this.Controls.Add(this.item11);
            this.Controls.Add(this.item10);
            this.Controls.Add(this.item9);
            this.Controls.Add(this.item8);
            this.Controls.Add(this.item7);
            this.Controls.Add(this.item6);
            this.Controls.Add(this.item5);
            this.Controls.Add(this.item4);
            this.Controls.Add(this.item3);
            this.Controls.Add(this.item2);
            this.Controls.Add(this.item1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Item item1;
        private Item item2;
        private Item item3;
        private Item item4;
        private Item item5;
        private Item item6;
        private Item item7;
        private Item item8;
        private Item item9;
        private Item item10;
        private Item item11;
        private Item item12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

