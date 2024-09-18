using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    internal class Tile
    {
        private Button m_b;
        private bool m_flag;
        int nearbymine;
        bool mine;
        private bool dug;

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
        public void setDug(Boolean b)
        {
            dug = b;
        }
        public void setFlag(Boolean b)
        {
            m_flag = b;
        }
    }
}
