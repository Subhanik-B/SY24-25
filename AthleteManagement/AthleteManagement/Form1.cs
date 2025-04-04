using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;

namespace AthleteManagement
{
    public partial class Form1 : Form
    {
        DatabaseHelper databaseHelper = new DatabaseHelper("C:\\Users\\sbha527\\Documents\\ah\\SY24-25\\AthleteManagement\\AthleteManagement\\bin\\Debug\\Athletes.xml");
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Athlete athlete = new Athlete();
            databaseHelper.AddAthlete(athlete);

        }
    }
}
