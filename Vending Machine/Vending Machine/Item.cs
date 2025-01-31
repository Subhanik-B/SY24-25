using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Vending_Machine
{
    public partial class Item : UserControl
    {
        public Image image { get; set; }
        public double price { get; set; }
        public String name { get; set; }
        public Item()
        {
            InitializeComponent();
        }

        private void Item_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = image;
        }
    }
}
