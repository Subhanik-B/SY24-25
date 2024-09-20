using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    internal class Tile
    {
        private Button m_b;
        private bool flag;
        int nearbymine;
        bool mine;
        private bool dug;
        Image flagImage;

        public Tile(Button b)
        {
            m_b = b;
            m_b.BackColor = System.Drawing.Color.Green;
        }
        public void setMine(Boolean b)
        {
            mine = b;
        }
        public bool isMine() { return mine; }
        public bool isFlag() { return flag; }
        public void setDug(Boolean b)
        {
            dug = b;
            if(dug == true)
            {
                m_b.BackColor = System.Drawing.Color.White;
            }
        }
        public void setFlag(Boolean b)
        {
            m_b.BackgroundImage = flagImage;
            flag = b;
        }
        public void button_MouseDown(object sender)
        {

        }
        public void setFlagImage(Image image) { flagImage = image; }
    }
}
