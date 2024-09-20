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
            // set up arrays
            for (int i = 0; i < 100; i++)
            {
                btn[i] = (Button)Controls["b" + (i+1)];
                tileGrid[i] = new Tile(btn[i]);
                tileGrid[i].setFlagImage(pictureBox1.Image); 
            }
            // mine generator
            for (int b = 0; b <= 15; b++)
            {
                int a = random.Next(0, 100);
                while (tileGrid[a].isMine() == true)
                {
                    a = random.Next(0, 100);
                }
                tileGrid[a].setMine(true);
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
            Tile t = tileGrid[getIndex(b)];
            if (e.Button == MouseButtons.Right)
            {
                if(t.isFlag() == false)
                {
                    t.setFlag(true);
                }
            }
            if(e.Button == MouseButtons.Left)
            {
                if(t.isFlag() == true)
                {
                    t.setFlagImage(null);
                    t.setFlag(false);
                    t.setFlagImage(pictureBox1.Image);
                }
                if (t.isMine() == true)
                {
                    b.BackColor = Color.Red;
                    t.setMineImage(pictureBox2.Image);
                    t.setFlag(false);
                    t.setMine(true);
                    label1.Text = "GAME OVER!";

                }
                if (t.isMine() == false)
                {
                    t.setDug(true);
                    checkMine(b);
                }
            }
        }

        private void checkMine(Button b)
        {
            int a = 0;
            int tracker = 0;
            int.TryParse(b.Name.Substring(1), out a);
            for (int x = -1; x < 2; x++)
            {
                for (int y = -1; y < 2; y++)
                {
                    if (a + ((x * 10) + y) <= 100 && a + ((x * 10) + y) >= 0)
                    {
                        //shouldnt have stuff out of the array but it does :'(
                        if (tileGrid[a + ((x* 10) + y)].isMine())
                        {
                            tracker++;
                            if (x == 0)
                            {
                                if (y == 0)
                                {
                                    tracker--;
                                }
                            }
                        }
                    }
                }
            }
            b.Text = tracker.ToString();
            /**
            try
            {
                if (tileGrid[a + 1].isMine())
                {
                    tracker++;
                }
            }
            catch (Exception ArrayIndexOutOfBounds) { }
            try
            {
                if (tileGrid[a - 1].isMine())
                {
                    tracker++;
                }
            } catch(Exception ArrayIndexOutOfBounds) { }
            try
            {
                if (tileGrid[a + 10].isMine())
                {
                    tracker++;
                }
            } catch (Exception ArrayIndexOutOfBounds) { }
            try
            {
                if (tileGrid[a - 10].isMine())
                {
                    tracker++;
                }
            } catch( Exception ArrayIndexOutOfBounds) { }
            try
            {
                if (tileGrid[a + 11].isMine())
                {
                    tracker++;
                }
            } catch( Exception ArrayIndexOutOfBounds) { }
            try
            {
                if (tileGrid[a - 11].isMine())
                {
                    tracker++;
                }
            }
            catch( Exception ArrayIndexOutOfBounds) { }
            try
            {
                if (tileGrid[a + 9].isMine())
                {
                    tracker++;
                }
            } catch( Exception ArrayIndexOutOfBounds) { }
            try
            {
                if (tileGrid[a - 9].isMine())
                {
                    tracker++;
                }
                b.Text = tracker.ToString();
            } catch(Exception ArrayIndexOutOfBounds) { } 
            **/
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                btn[i].BackColor = Color.Green;
                tileGrid[i] = new Tile(btn[i]);
                btn[i].Text = "";
                label1.Text = "";
            }
        }
    }
}
