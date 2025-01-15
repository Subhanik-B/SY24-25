using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Years
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int[] total = new int[8];
        int[] totalB = new int[8];
        int[] totalC = new int[8];

        bool bit1 = false;
        bool bit2 = false;
        bool bit3 = false;
        bool bit4 = false;
        bool bit5 = false;
        bool bit6 = false;
        bool bit7 = false;
        bool bit8 = false;
        bool bit1B = false;
        bool bit2B = false;
        bool bit3B = false;
        bool bit4B = false;
        bool bit5B = false;
        bool bit6B = false;
        bool bit7B = false;
        bool bit8B = false;
        bool bit1C = false;
        bool bit2C = false;
        bool bit3C = false;
        bool bit4C = false;
        bool bit5C = false;
        bool bit6C = false;
        bool bit7C = false;
        bool bit8C = false;

        private void Bit_8_TextChanged(object sender, EventArgs e)
        {
            if (Bit_1.Text.Equals("1") && !bit1)
            {
                total[0] = 1;
                bit1 = true;
            }
            if (Bit_2.Text.Equals("1") && !bit2)
            {
                total[1] = 2;
                bit2 = true;
            }
            if (Bit_3.Text.Equals("1") && !bit3)
            {
                total[2] = 4;
                bit3 = true;
            }
            if (Bit_4.Text.Equals("1") && !bit4)
            {
                total[3] = 8;
                bit4 = true;
            }
            if (Bit_5.Text.Equals("1") && !bit5)
            {
                total[4] = 16;
                bit5 = true;
            }
            if (Bit_6.Text.Equals("1") && !bit6)
            {
                total[5] = 32;
                bit6 = true;
            }
            if (Bit_7.Text.Equals("1") && !bit7)
            {
                total[6] = 64;
                bit7 = true;
            }
            if (Bit_8.Text.Equals("1") && !bit8)
            {
                total[7] = 128;
                bit8 = true;
            }


            if (Bit_1.Text.Equals("0") && bit1)
            {
                total[0] = 0;
                bit1 = false;
            }
            if (Bit_2.Text.Equals("0") && bit2)
            {
                total[1] = 0;
                bit2 = false;
            }
            if (Bit_3.Text.Equals("0") && bit3)
            {
                total[2] = 0;
                bit3 = false;
            }
            if (Bit_4.Text.Equals("0") && bit4)
            {
                total[3] = 0;
                bit4 = false;
            }
            if (Bit_5.Text.Equals("0") && bit5)
            {
                total[4] = 0;
                bit5 = false;
            }
            if (Bit_6.Text.Equals("0") && bit6)
            {
                total[5] = 0;
                bit6 = false;
            }
            if (Bit_7.Text.Equals("0") && bit7)
            {
                total[6] = 0;
                bit7 = false;
            }
            if (Bit_8.Text.Equals("0") && bit8)
            {
                total[7] = 0;
                bit8 = false;
            }
            int b = 0;
            for (int i = 0; i < total.Length; i++)
            {
               b += total[i];
            }
            textBox1.Text = b.ToString();
        }

        private void Bit_8B_TextChanged(object sender, EventArgs e)
        {
            if (Bit_1B.Text.Equals("1") && !bit1B)
            {
                totalB[0] = 1;
                bit1B = true;
            }
            if (Bit_2B.Text.Equals("1") && !bit2B)
            {
                totalB[1] = 2;
                bit2B = true;
            }
            if (Bit_3B.Text.Equals("1") && !bit3B)
            {
                totalB[2] = 4;
                bit3B = true;
            }
            if (Bit_4B.Text.Equals("1") && !bit4B)
            {
                totalB[3] = 8;
                bit4B = true;
            }
            if (Bit_5B.Text.Equals("1") && !bit5B)
            {
                totalB[4] = 16;
                bit5B = true;
            }
            if (Bit_6B.Text.Equals("1") && !bit6B)
            {
                totalB[5] = 32;
                bit6B = true;
            }
            if (Bit_7B.Text.Equals("1") && !bit7B)
            {
                totalB[6] = 64;
                bit7B = true;
            }
            if (Bit_8B.Text.Equals("1") && !bit8B)
            {
                totalB[7] = 128;
                bit8B = true;
            }


            if (Bit_1B.Text.Equals("0") && bit1B)
            {
                totalB[0] = 0;
                bit1B = false;
            }
            if (Bit_2B.Text.Equals("0") && bit2B)
            {
                totalB[1] = 0;
                bit2B = false;
            }
            if (Bit_3B.Text.Equals("0") && bit3B)
            {
                totalB[2] = 0;
                bit3B = false;
            }
            if (Bit_4B.Text.Equals("0") && bit4B)
            {
                totalB[3] = 0;
                bit4B = false;
            }
            if (Bit_5B.Text.Equals("0") && bit5B)
            {
                totalB[4] = 0;
                bit5B = false;
            }
            if (Bit_6B.Text.Equals("0") && bit6B)
            {
                totalB[5] = 0;
                bit6B = false;
            }
            if (Bit_7B.Text.Equals("0") && bit7B)
            {
                totalB[6] = 0;
                bit7B = false;
            }
            if (Bit_8B.Text.Equals("0") && bit8B)
            {
                totalB[7] = 0;
                bit8B = false;
            }
            int b = 0;
            for (int i = 0; i < totalB.Length; i++)
            {
                b += totalB[i];
            }
            textBox2.Text = b.ToString();
        }

        private void Bit_8C_MouseDown(object sender, MouseEventArgs e)
        {
            if (((TextBox)sender).Text == "1")
            {
                ((TextBox)sender).Text = "0";
            }
            else
            {
                ((TextBox)sender).Text = "1";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < total.Length; i++)
            {
                total[i] = 0;
                Update();
            }
        }

        private void Update()
        {
            Bit_1.Text = "0";
            Bit_2.Text = "0";
            Bit_3.Text = "0";
            Bit_4.Text = "0";
            Bit_5.Text = "0";
            Bit_6.Text = "0";
            Bit_7.Text = "0";
            Bit_8.Text = "0";
            Bit_1B.Text = "0";
            Bit_2B.Text = "0";
            Bit_3B.Text = "0";
            Bit_4B.Text = "0";
            Bit_5B.Text = "0";
            Bit_6B.Text = "0";
            Bit_7B.Text = "0";
            Bit_8B.Text = "0";
        }
    }
}
