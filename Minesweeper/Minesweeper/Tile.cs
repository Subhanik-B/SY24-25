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
        public bool flag { get; private set; }
        int nearbymine;
        bool mine;
        public bool dug { get; private set; }
        Image flagImage;
        Image mineImage;

        public Tile(Button b)
        {
            m_b = b;
            m_b.BackColor = System.Drawing.Color.Green;
        }
        public void setMine(Boolean b)
        {
            m_b.BackgroundImage = mineImage;
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
        public void setFlag()
        {
            if (m_b.BackgroundImage == flagImage)
            {
                m_b.BackgroundImage = null;
            } 
            else
            {
                m_b.BackgroundImage = flagImage;
            }
            flag = !flag;
        }
        public void setFlag(Boolean b)
        {
            if (!b)
            {
                m_b.BackgroundImage = null;
            }
            else
            {
                m_b.BackgroundImage = flagImage;
            }
            flag = b;
        }
        public void button_MouseDown(object sender)
        {

        }
        public void setFlagImage(Image image) { flagImage = image; }
        public void setMineImage(Image image) { mineImage = image; }
    }
}