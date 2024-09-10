using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{ 
    public partial class Form1 : Form
    {
        Random random = new Random();
        Button[] btn = new Button[100];
        Tile[] tileGrid = new Tile[100];
        public Form1()
        {
            InitializeComponent();

            for(int i = 0; i < 100; i++)
            {
                btn[i] = (Button)Controls["b" + (i+1)];
                btn[i].BackColor = Color.Green;
                tileGrid[i] = new Tile(btn[i]);
            }
        }
        private Button getButton(int r, int c)
        {
            return (Button)getButton(r, c);
        }
        private int getIndex(Button b)
        {
            String tmp = b.Name.Substring(1);
            int retVal = 0;
            int.TryParse(tmp, out retVal);
            return retVal - 1;
        }
        private void button101_Click(object sender, EventArgs e)
        {
            for (int b = 0; b <= 10; b++)
            {
                int a = random.Next(1, 100);
                btn[a].BackColor = Color.Red;
                //btn[a].BackgroundImage = pictureBox2.Image;
                //btn[a].ForeColor = Color.Gray;
                label1.Text += a.ToString() + ", ";
            }
        }
        bool flag = false;
        bool mine = false;
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (flag == false && mine == false)
                {
                    (sender as Button).BackgroundImage = pictureBox1.Image;
                    flag = true;
                }
                else if (flag == true && mine == false)
                {
                    (sender as Button).BackgroundImage = null;
                    flag = false;
                }
            }
            if(e.Button == MouseButtons.Left)
            {
                //(sender as Button).BackgroundImage = pictureBox2.Image;
                (sender as Button).BackColor = Color.Red;
                mine = true;
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            getIndex(sender as Button);
        }
    }
}
