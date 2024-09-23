using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        Button[,] btn = new Button[10,10];
        Tile[,] tileGrid = new Tile[10,10];
        public Form1()
        {
            InitializeComponent();
            // set up arrays
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    btn[x, y] = (Button)Controls[$"b{x}{y}"];
                    tileGrid[x, y] = new Tile(btn[x, y]);
                    tileGrid[x, y].setFlagImage(pictureBox1.Image);
                }
            }
            // mine generator
            for (int b = 0; b <= 15; b++)
            {
                int xRand = random.Next(0, 10);
                int yRand = random.Next(0, 10);
                while (tileGrid[xRand, yRand].isMine())
                {
                    xRand = random.Next(0, 10);
                    yRand = random.Next(0, 10);
                }
                tileGrid[xRand, yRand].setMine(true);
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

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            string index = b.Name.Substring(1);
            char[] indexChar = index.ToCharArray();
            int indexX = indexChar[0] - 48;
            int indexY = indexChar[1] - 48;
            Tile t = tileGrid[indexX, indexY];
            if (e.Button == MouseButtons.Right)
            {
                if(t.isFlag() == false)
                {
                    t.setFlag(true);
                }
            }
            if(e.Button == MouseButtons.Left)
            {
                var isFlag = t.isFlag();
                if (isFlag)
                {
                    t.setFlagImage(null);
                    t.setFlag(false);
                    t.setFlagImage(pictureBox1.Image);
                }
                else
                {
                    var isMine = t.isMine();
                    if (isMine)
                    {
                        b.BackColor = Color.Red;
                        t.setMineImage(pictureBox2.Image);
                        t.setFlag(false);
                        t.setMine(true);
                        this.BackColor = Color.Red;
                        label1.Text = "GAME OVER!";
                    }
                    else
                    {
                        t.setDug(true);
                        checkMine(b);
                    }

                }
            }
        }

        private void checkMine(Button b)
        {
            int tracker = 0;
            string index = b.Name.Substring(1);
            char[] indexChar = index.ToCharArray();
            int indexX = indexChar[0] - 48;
            int indexY = indexChar[1] - 48;
            Debug.Print($"{indexX}, {indexY}");
            for (int x = -1; x <= 1; x++)
            {
                for (int y = -1; y <= 1; y++)
                {
                    if ((x + indexX < 10 && x + indexX >= 0) && (y + indexY < 10 && y + indexY >= 0))
                    {
                        //shouldnt have stuff out of the array but it does :'(
                        if (tileGrid[x + indexX, y + indexY].isMine())
                        {
                            if (!tileGrid[x + indexX, y + indexY].dug)
                            {
                                tracker++;
                            }
                        }
                    }
                }
            }
            b.Text = tracker.ToString();
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0;  y < 10; y++)
                {
                    tileGrid[x, y].setFlagImage(null);
                    tileGrid[x, y].setMineImage(null);
                    tileGrid[x, y].setFlag(false);
                    tileGrid[x, y].setMine(false);
                    btn[x, y].BackColor = Color.Green;
                    tileGrid[x, y] = new Tile(btn[x, y]);
                    btn[x, y].Text = "";
                    label1.Text = "";
                    this.BackColor = Color.White;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int checker = 0;
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    if (tileGrid[x, y].dug && !tileGrid[x, y].isMine())
                    {
                        checker++;
                    }
                }
            }
            if(checker == (100 - 15))
            {
                this.BackColor = Color.Green;
                label1.Text = "YOU WIN!!";
            }
        }
    }
}
