using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bananers
{
    public partial class Form1 : Form
    {
        int money;
        int fish;
        public Form1()
        {
            InitializeComponent();
        }
        Random fishy = new Random();
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            fish = fishy.Next(1, 101);
            Fish(fish);
        }

        public void Fish(int fisher)
        {
            int fishvalue = fishy.Next(1, 16);
            if (fisher <= 10)
            {
                textBox1.Text = fisher.ToString();
                money -= 10;
                label1.Text = money.ToString();
            }
            else
            {
                textBox1.Text = fish.ToString();
                money += fishvalue;
                label1.Text = money.ToString();
            }
        }
    }
}
