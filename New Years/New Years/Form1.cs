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

        
        int total = 0;
        bool bit1 = false;
        bool bit2 = false;
        bool bit3 = false;
        bool bit4 = false;
        bool bit5 = false;

        private void Bit_5_TextChanged(object sender, EventArgs e)
        {
            if (Bit_1.Text.Equals("1") && !bit1)
            {
                total += 1;
                bit1 = true;
            }
            if (Bit_2.Text.Equals("1") && !bit2)
            {
                total += 2;
                bit2 = true;
            }
            if (Bit_3.Text.Equals("1") && !bit3)
            {
                total += 4;
                bit3 = true;
            }
            if (Bit_4.Text.Equals("1") && !bit4)
            {
                total += 8;
                bit4 = true;
            }
            if (Bit_5.Text.Equals("1") && !bit5)
            {
                total += 16;
                bit5 = true;
            }


            if (Bit_1.Text.Equals("0"))
            {
                if (total >= 1)
                {
                    total -= 1;
                    bit1 = false;
                }
            }
            if (Bit_2.Text.Equals("0"))
            {
                if (total >= 2)
                {
                    total -= 2;
                    bit2 = false;
                }
            }
            if (Bit_3.Text.Equals("0"))
            {
                if (total >= 4)
                {
                    total -= 4;
                    bit3 = false;
                }
            }
            if (Bit_4.Text.Equals("0"))
            {
                if (total >= 8)
                {
                    total -= 8;
                    bit4 = false;
                }
            }
            if (Bit_5.Text.Equals("0"))
            {
                if (total >= 16)
                {
                    total -= 16;
                    bit5 = false;
                }
            }
            textBox1.Text = total.ToString();
        }
    }
}
