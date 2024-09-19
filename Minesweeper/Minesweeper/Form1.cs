﻿using System;
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
            int c = 0;
            int.TryParse(textBox1.Text, out c);
            for (int b = 0; b < c; b++)
            {
                int a = random.Next(0, 100);
                if (tileGrid[a].isMine() == false)
                {
                    btn[a].BackColor = Color.Red;
                    tileGrid[a].setMine(true);
                    label1.Text += a.ToString() + ", ";
                }
                else
                {
                    a = random.Next(0, 100);
                    btn[a].BackColor = Color.Red;
                    tileGrid[a].setMine(true);
                    label1.Text += a.ToString() + ", ";
                }
                //btn[a].BackgroundImage = pictureBox2.Image;
                //btn[a].ForeColor = Color.Gray;
                
            }
        }
        bool flag = false;
        bool mine = false;
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            Tile t = tileGrid[getIndex(b)];
            if (e.Button == MouseButtons.Right)
            {
                t.setFlag(!flag);
            }
            if(e.Button == MouseButtons.Left)
            {
                /*if (!mine)
                {
                    (sender as Button).BackgroundImage = pictureBox2.Image;
                    mine = true;
                }
                else
                {
                    (sender as Button).BackgroundImage = null;
                    mine = false;
                }
                */
                (sender as Button).BackColor = Color.Red;
                
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            getIndex(sender as Button);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                btn[i].BackColor = Color.Green;
                tileGrid[i] = new Tile(btn[i]);
                label1.Text = "";
                tileGrid[i].setFlagImage(pictureBox1.Image);
            }
        }
    }
}
