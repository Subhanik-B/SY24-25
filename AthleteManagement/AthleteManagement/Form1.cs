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
            /*Athlete athlete = new Athlete();
            athlete.AthleteID = 1;
            athlete.BibNumber = "1";
            athlete.Age = 24;
            athlete.FirstName = "Bob";
            athlete.LastName = "Cheese";
            databaseHelper.AddAthlete(athlete);*/
            dataGridView1.Columns.Add("Athlete Name", "Athlete Name");
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Age", "Age");
            dataGridView1.Rows.Add();
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            AddButton.Visible = false;
            EditButton.Visible = false;
            DeleteButton.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            AddAtButton.Visible = true;
        }

        private void AddAtButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            AddButton.Visible = true;
            EditButton.Visible = true;
            DeleteButton.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            AddAtButton.Visible = false;

            Athlete athlete = new Athlete();
            int id = 0;
            int age = 0;
            int.TryParse(textBox4.Text, out id);
            athlete.AthleteID = id;
            athlete.BibNumber = textBox6.Text;
            int.TryParse(textBox5.Text, out age);
            athlete.Age = age;
            athlete.FirstName = textBox2.Text;
            athlete.LastName = textBox3.Text;
            databaseHelper.AddAthlete(athlete);

            dataGridView1.Rows[0].Cells[0].Value = databaseHelper.GetAthleteById(id).FullName;
            dataGridView1.Rows[0].Cells[1].Value = databaseHelper.GetAthleteById(id).AthleteID;
            dataGridView1.Rows[0].Cells[2].Value = databaseHelper.GetAthleteById(id).Age;
        }
    }
}
