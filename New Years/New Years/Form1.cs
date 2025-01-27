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

        int Actualtotal = 0;
        int ActualtotalB = 0;
        int ActualtotalC = 0;

        int[] total = new int[8];
        int[] totalB = new int[8];
        int[] totalC = new int[8];

        

        private void Bit_8_TextChanged(object sender, EventArgs e)
        {
            if (Bit_1.Text.Equals("1"))
            {
                total[0] = 1;
            }
            if (Bit_2.Text.Equals("1"))
            {
                total[1] = 1;
            }
            if (Bit_3.Text.Equals("1"))
            {
                total[2] = 1;
            }
            if (Bit_4.Text.Equals("1"))
            {
                total[3] = 1;
            }
            if (Bit_5.Text.Equals("1"))
            {
                total[4] = 1;
            }
            if (Bit_6.Text.Equals("1"))
            {
                total[5] = 1;
            }
            if (Bit_7.Text.Equals("1"))
            {
                total[6] = 1;
            }
            if (Bit_8.Text.Equals("1"))
            {
                total[7] = 1;
            }


            if (Bit_1.Text.Equals("0"))
            {
                total[0] = 0;
            }
            if (Bit_2.Text.Equals("0"))
            {
                total[1] = 0;
            }
            if (Bit_3.Text.Equals("0"))
            {
                total[2] = 0;
            }
            if (Bit_4.Text.Equals("0"))
            {
                total[3] = 0;
            }
            if (Bit_5.Text.Equals("0"))
            {
                total[4] = 0;
            }
            if (Bit_6.Text.Equals("0"))
            {
                total[5] = 0;
            }
            if (Bit_7.Text.Equals("0"))
            {
                total[6] = 0;
            }
            if (Bit_8.Text.Equals("0"))
            {
                total[7] = 0;
            }

            Updatept2(false);
        }

        private void Bit_8B_TextChanged(object sender, EventArgs e)
        {
            if (Bit_1B.Text.Equals("1"))
            {
                totalB[0] = 1;
            }
            if (Bit_2B.Text.Equals("1"))
            {
                totalB[1] = 1;
            }
            if (Bit_3B.Text.Equals("1"))
            {
                totalB[2] = 1;

            }
            if (Bit_4B.Text.Equals("1"))
            {
                totalB[3] = 1;
            }
            if (Bit_5B.Text.Equals("1"))
            {
                totalB[4] = 1;
            }
            if (Bit_6B.Text.Equals("1"))
            {
                totalB[5] = 1;
            }
            if (Bit_7B.Text.Equals("1"))
            {
                totalB[6] = 1;
            }
            if (Bit_8B.Text.Equals("1"))
            {
                totalB[7] = 1;
            }


            if (Bit_1B.Text.Equals("0"))
            {
                totalB[0] = 0;
            }
            if (Bit_2B.Text.Equals("0"))
            {
                totalB[1] = 0;
            }
            if (Bit_3B.Text.Equals("0"))
            {
                totalB[2] = 0;
            }
            if (Bit_4B.Text.Equals("0"))
            {
                totalB[3] = 0;
            }
            if (Bit_5B.Text.Equals("0"))
            {
                totalB[4] = 0;
            }
            if (Bit_6B.Text.Equals("0"))
            {
                totalB[5] = 0;
            }
            if (Bit_7B.Text.Equals("0"))
            {
                totalB[6] = 0;
            }
            if (Bit_8B.Text.Equals("0"))
            {
                totalB[7] = 0;
            }

            Updatept2(false);
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
            FirstUpdate();
        }

        private void FirstUpdate()
        {
            for (int i = 0; i < total.Length; i++)
            {
                total[i] = 0;
                OtherUpdate();
            }

            for (int i = 0; i < totalB.Length; i++)
            {
                totalB[i] = 0;
                OtherUpdate();
            }

            for (int i = 0; i < totalC.Length; i++)
            {
                totalC[i] = 0;
                OtherUpdate();
            }
        }

        private void OtherUpdate()
        {
            Bit_1.Text = total[0].ToString();
            Bit_2.Text = total[1].ToString();
            Bit_3.Text = total[2].ToString();
            Bit_4.Text = total[3].ToString();
            Bit_5.Text = total[4].ToString();
            Bit_6.Text = total[5].ToString();
            Bit_7.Text = total[6].ToString();
            Bit_8.Text = total[7].ToString();

            Bit_1B.Text = totalB[0].ToString();
            Bit_2B.Text = totalB[1].ToString();
            Bit_3B.Text = totalB[2].ToString();
            Bit_4B.Text = totalB[3].ToString();
            Bit_5B.Text = totalB[4].ToString();
            Bit_6B.Text = totalB[5].ToString();
            Bit_7B.Text = totalB[6].ToString();
            Bit_8B.Text = totalB[7].ToString();

            Bit_1C.Text = totalC[0].ToString();
            Bit_2C.Text = totalC[1].ToString();
            Bit_3C.Text = totalC[2].ToString();
            Bit_4C.Text = totalC[3].ToString();
            Bit_5C.Text = totalC[4].ToString();
            Bit_6C.Text = totalC[5].ToString();
            Bit_7C.Text = totalC[6].ToString();
            Bit_8C.Text = totalC[7].ToString();
        }

        private void Left_Shift_Click(object sender, EventArgs e)
        {

            for (int i = total.Length - 1; i >= 0; i--)
            {
                if (i != 0)
                    (total[i], totalB[i]) = (total[i - 1], totalB[i - 1]);
                else
                    (total[i], totalB[i]) = (0, 0);
                OtherUpdate();
            }
            
        }

        private void Updatept2(Boolean Cadd)
        {
            Actualtotal = 0;
            ActualtotalB = 0;
            ActualtotalC = 0;

            if (Cadd)
            {
                ActualtotalC += 256;
            }

            for (int i = 0; i < total.Length; i++)
            {
                if (total[i] != 0)
                {
                    Actualtotal += (int)Math.Pow(2, i);
                }
            }
            textBox1.Text = Actualtotal.ToString();

            for (int i = 0; i < totalB.Length; i++)
            {
                if (totalB[i] != 0)
                {
                    ActualtotalB += (int)Math.Pow(2, i);
                }
            }
            textBox2.Text = ActualtotalB.ToString();

            for (int i = 0; i < totalC.Length; i++)
            {
                if (totalC[i] != 0)
                {
                    ActualtotalC += (int)Math.Pow(2, i);
                }
            }
            textBox3.Text = ActualtotalC.ToString();
        }

        private void Clear3rdLine()
        {
            for (int i = 0; i < totalC.Length; i++)
            {
                totalC[i] = 0;
                OtherUpdate();
            }
        }

        private void Right_Shift_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < total.Length; i++)
            {
                if (i != 7)
                    (total[i], totalB[i]) = (total[i + 1], totalB[i + 1]);
                else
                    (total[i], totalB[i]) = (0, 0);
                OtherUpdate();
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Clear3rdLine();
            
            for(int i = 0; i < total.Length; i++)
            {
                if (total[i] != 0 && totalB[i] != 0)
                {
                    try
                    {
                        totalC[i + 1] = 1;
                    }
                    catch(Exception ArrayIndexOutOfBounds)
                    {
                        Updatept2(true);
                    }
                } else if (total[i] != 0 || totalB[i] != 0)
                {
                    totalC[i] = 1;
                } else if (totalC[i] != 1)
                {
                    totalC[i] = 0;
                }
                OtherUpdate();
            }
        }

        private void Bit_8C_TextChanged(object sender, EventArgs e)
        {
            if (Bit_1C.Text.Equals("1"))
            {
                totalC[0] = 1;
            }
            if (Bit_2C.Text.Equals("1"))
            {
                totalC[1] = 1;
            }
            if (Bit_3C.Text.Equals("1"))
            {
                totalC[2] = 1;

            }
            if (Bit_4C.Text.Equals("1"))
            {
                totalC[3] = 1;
            }
            if (Bit_5C.Text.Equals("1"))
            {
                totalC[4] = 1;
            }
            if (Bit_6C.Text.Equals("1"))
            {
                totalC[5] = 1;
            }
            if (Bit_7C.Text.Equals("1"))
            {
                totalC[6] = 1;
            }
            if (Bit_8C.Text.Equals("1"))
            {
                totalC[7] = 1;
            }


            if (Bit_1C.Text.Equals("0"))
            {
                totalC[0] = 0;
            }
            if (Bit_2C.Text.Equals("0"))
            {
                totalC[1] = 0;
            }
            if (Bit_3C.Text.Equals("0"))
            {
                totalC[2] = 0;
            }
            if (Bit_4C.Text.Equals("0"))
            {
                totalC[3] = 0;
            }
            if (Bit_5C.Text.Equals("0"))
            {
                totalC[4] = 0;
            }
            if (Bit_6C.Text.Equals("0"))
            {
                totalC[5] = 0;
            }
            if (Bit_7C.Text.Equals("0"))
            {
                totalC[6] = 0;
            }
            if (Bit_8C.Text.Equals("0"))
            {
                totalC[7] = 0;
            }

            Updatept2(false);
        }

        private void And_Click(object sender, EventArgs e)
        {
            Clear3rdLine();
            for (int i = 0; i < total.Length; i++)
            {
                if (total[i] != 0 && totalB[i] != 0)
                {
                    totalC[i] = 1;
                }
                else
                {
                    totalC[i] = 0;
                }
                OtherUpdate();
            }
        }

        private void Or_Click(object sender, EventArgs e)
        {
            Clear3rdLine();

            for (int i = 0; i < total.Length; i++)
            {
                if (total[i] != 0 || totalB[i] != 0)
                {
                    totalC[i] = 1;
                }
                else
                {
                    totalC[i] = 0;
                }
                OtherUpdate();
            }
        }

        private void XOr_Click(object sender, EventArgs e)
        {
            Clear3rdLine();

            for (int i = 0; i < total.Length; i++)
            {
                if (total[i] != totalB[i])
                {
                    totalC[i] = 1;
                }
                else
                {
                    totalC[i] = 0;
                }
                OtherUpdate();
            }
        }
    }
}
