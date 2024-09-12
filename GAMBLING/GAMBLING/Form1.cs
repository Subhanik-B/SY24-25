using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAMBLING
{
    public partial class Form1 : Form
    {
        Random random = new Random{ }; 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                int a = random.Next(1, 4);
                if(a == 2)
                {
                    textBox2.Text = "You win!";
                } else if(a == 3)
                {
                    textBox2.Text = "You lose!";
                }
                else
                {
                    textBox2.Text = "You tied!";
                }
                radioButton1.Checked = false;
            }
            if (radioButton2.Checked == true)
            {
                int a = random.Next(1, 4);
                if (a == 1)
                {
                    textBox2.Text = "You lose!";
                }
                else if (a == 3)
                {
                    textBox2.Text = "You win!";
                }
                else
                {
                    textBox2.Text = "You tied!";
                }
                radioButton2.Checked = false;
            }
            if (radioButton3.Checked == true)
            {
                int a = random.Next(1, 4);
                if (a == 2)
                {
                    textBox2.Text = "You lose!";
                }
                else if (a == 1)
                {
                    textBox2.Text = "You win!";
                }
                else
                {
                    textBox2.Text = "You tied!";
                }
                radioButton1.Checked = false;
            }
        }
    }// Anthony was here, i love gay men(shoob)
}
