using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AthleteManagement
{
    public partial class StopWatch : Form
    {
        int seconds = 0;
        int minutes = 0;
        Form1 form = new Form1();
        public StopWatch()
        {
            InitializeComponent();
        }

        private void StopWatch_Load(object sender, EventArgs e)
        {
            Seconds2.Enabled = true;
            Seconds2.Stop();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Seconds2.Start();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Seconds2.Stop();
        }

        private void Seconds2_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds == 60)
            {
                minutes++;
                label4.Text = minutes.ToString();
                seconds = 0;
            }
            label5.Text = seconds.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            seconds = 0;
            minutes = 0;
            label2.Text = "0";
            label4.Text = "00";
            label5.Text = "00";
        }

        private void Lap_Button_Click(object sender, EventArgs e)
        {
            form.transferAthlete.RaceTime = minutes.ToString() + " : " + seconds.ToString();
            form.updateTimes();
        }
    }
}
