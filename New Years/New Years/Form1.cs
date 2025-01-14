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
        bool bit1 = false;
        bool bit2 = false;
        bool bit3 = false;
        bool bit4 = false;
        bool bit5 = false;
        bool bit6 = false;
        bool bit7 = false;
        bool bit8 = false;

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
    }
}
