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
        public Form1()
        {
            InitializeComponent();
        }
        Random fishy = new Random();
        int fish;
        private void button1_Click(object sender, EventArgs e)
        {
            fish = fishy.Next();
            textBox1.Text = fish.ToString();
        }
    }
}
