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

        private void Bit_8C_TextChanged(object sender, EventArgs e)
        {
            if (Bit_1C.Text.Equals("1") && !bit1C)
            {
                totalC[0] = 1;
                bit1C = true;
            }
            if (Bit_2C.Text.Equals("1") && !bit2C)
            {
                totalC[1] = 2;
                bit2C = true;
            }
            if (Bit_3C.Text.Equals("1") && !bit3C)
            {
                totalC[2] = 4;
                bit3C = true;
            }
            if (Bit_4C.Text.Equals("1") && !bit4C)
            {
                totalC[3] = 8;
                bit4C = true;
            }
            if (Bit_5C.Text.Equals("1") && !bit5C)
            {
                totalC[4] = 16;
                bit5C = true;
            }
            if (Bit_6C.Text.Equals("1") && !bit6C)
            {
                totalC[5] = 32;
                bit6C = true;
            }
            if (Bit_7C.Text.Equals("1") && !bit7C)
            {
                totalC[6] = 64;
                bit7C = true;
            }
            if (Bit_8C.Text.Equals("1") && !bit8C)
            {
                totalC[7] = 128;
                bit8C = true;
            }


            if (Bit_1C.Text.Equals("0") && bit1C)
            {
                totalC[0] = 0;
                bit1C = false;
            }
            if (Bit_2C.Text.Equals("0") && bit2C)
            {
                totalC[1] = 0;
                bit2C = false;
            }
            if (Bit_3C.Text.Equals("0") && bit3C)
            {
                totalC[2] = 0;
                bit3C = false;
            }
            if (Bit_4C.Text.Equals("0") && bit4C)
            {
                totalC[3] = 0;
                bit4C = false;
            }
            if (Bit_5C.Text.Equals("0") && bit5C)
            {
                totalC[4] = 0;
                bit5C = false;
            }
            if (Bit_6C.Text.Equals("0") && bit6C)
            {
                totalC[5] = 0;
                bit6C = false;
            }
            if (Bit_7C.Text.Equals("0") && bit7C)
            {
                totalC[6] = 0;
                bit7C = false;
            }
            if (Bit_8C.Text.Equals("0") && bit8C)
            {
                totalC[7] = 0;
                bit8C = false;
            }
            int b = 0;
            for (int i = 0; i < totalC.Length; i++)
            {
                b += totalC[i];
            }
            textBox3.Text = b.ToString();
        }
    }
}
