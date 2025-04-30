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
        //DatabaseHelper databaseHelper = new DatabaseHelper("C:\\Users\\buntu\\OneDrive\\Documents\\School Code\\SY24-25\\AthleteManagement\\AthleteManagement\\bin\\Debug\\DebugAthletes.xml");
        int globalID = 1;
        List<Athlete> athletes = new List<Athlete> {};
        int editTracker = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Athlete Name", "Athlete Name");
            dataGridView1.Columns.Add("Team", "Team");
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Age", "Age");
            dataGridView1.Columns.Add("Bib Number", "Bib Number");
            
            athletes = databaseHelper.GetAllAthletes();
            try
            {
                if (athletes.Count() == 1)
                {
                    for (int i = 0; i < athletes.Count(); i++)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = athletes[i].FullName;
                        dataGridView1.Rows[i].Cells[2].Value = athletes[i].AthleteID;
                        dataGridView1.Rows[i].Cells[3].Value = athletes[i].Age;
                        dataGridView1.Rows[i].Cells[4].Value = athletes[i].BibNumber;
                        globalID++;
                    }
                }
                else
                {
                    dataGridView1.Rows.Add(athletes.Count() - 1);
                    for (int i = 0; i < athletes.Count(); i++)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = athletes[i].FullName;
                        dataGridView1.Rows[i].Cells[2].Value = athletes[i].AthleteID;
                        dataGridView1.Rows[i].Cells[3].Value = athletes[i].Age;
                        dataGridView1.Rows[i].Cells[4].Value = athletes[i].BibNumber;
                        globalID++;
                    }
                }
            }
            catch (Exception ex)
            {
            } 
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

            textBox4.ReadOnly = true;
            textBox4.Text = globalID.ToString();
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
            int age = 0;
            athlete.AthleteID = globalID;
            athlete.BibNumber = textBox6.Text;
            int.TryParse(textBox5.Text, out age);
            athlete.Age = age;
            athlete.FirstName = textBox2.Text;
            athlete.LastName = textBox3.Text;
            databaseHelper.AddAthlete(athlete);

            athletes = databaseHelper.GetAllAthletes();
            dataGridView1.Rows.Add(1);
            for (int i = 0; i < athletes.Count(); i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = athletes[i].FullName;
                dataGridView1.Rows[i].Cells[2].Value = athletes[i].AthleteID;
                dataGridView1.Rows[i].Cells[3].Value = athletes[i].Age;
                dataGridView1.Rows[i].Cells[4].Value = athletes[i].BibNumber;
            }
            globalID++;

            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (athletes.Count() > 0)
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
                NextBttn.Visible = true;
                PreviousBttn.Visible = true;
                FinishEdit.Visible = true;

                textBox2.Text = athletes[editTracker].FirstName;
                textBox3.Text = athletes[editTracker].LastName;
                textBox4.Text = athletes[editTracker].AthleteID.ToString();
                textBox5.Text = athletes[editTracker].Age.ToString();
                textBox6.Text = athletes[editTracker].BibNumber;
            }
            else
            {
                MessageBox.Show("No Athletes Available To Edit","",MessageBoxButtons.OK);
            }
        }

        private void NextBttn_Click(object sender, EventArgs e)
        {
            try
            {
                Athlete uAthlete = new Athlete();
                uAthlete.FirstName = textBox2.Text;
                uAthlete.LastName = textBox3.Text;
                uAthlete.AthleteID = int.Parse(textBox4.Text);
                uAthlete.Age = int.Parse(textBox5.Text);
                uAthlete.BibNumber = textBox6.Text;

                databaseHelper.UpdateAthlete(uAthlete);

                editTracker++;
                textBox2.Text = athletes[editTracker].FirstName;
                textBox3.Text = athletes[editTracker].LastName;
                textBox4.Text = athletes[editTracker].AthleteID.ToString();
                textBox5.Text = athletes[editTracker].Age.ToString();
                textBox6.Text = athletes[editTracker].BibNumber;
            }
            catch (Exception ex)
            {
                Athlete uAthlete = new Athlete();
                uAthlete.FirstName = textBox2.Text;
                uAthlete.LastName = textBox3.Text;
                uAthlete.AthleteID = int.Parse(textBox4.Text);
                uAthlete.Age = int.Parse(textBox5.Text);
                uAthlete.BibNumber = textBox6.Text;

                databaseHelper.UpdateAthlete(uAthlete);

                editTracker = 0;
                textBox2.Text = athletes[editTracker].FirstName;
                textBox3.Text = athletes[editTracker].LastName;
                textBox4.Text = athletes[editTracker].AthleteID.ToString();
                textBox5.Text = athletes[editTracker].Age.ToString();
                textBox6.Text = athletes[editTracker].BibNumber;
            }
        }

        private void PreviousBttn_Click(object sender, EventArgs e)
        {
            try
            {
                Athlete uAthlete = new Athlete();
                uAthlete.FirstName = textBox2.Text;
                uAthlete.LastName = textBox3.Text;
                uAthlete.AthleteID = int.Parse(textBox4.Text);
                uAthlete.Age = int.Parse(textBox5.Text);
                uAthlete.BibNumber = textBox6.Text;

                databaseHelper.UpdateAthlete(uAthlete);

                editTracker--;
                textBox2.Text = athletes[editTracker].FirstName;
                textBox3.Text = athletes[editTracker].LastName;
                textBox4.Text = athletes[editTracker].AthleteID.ToString();
                textBox5.Text = athletes[editTracker].Age.ToString();
                textBox6.Text = athletes[editTracker].BibNumber;
            }
            catch (Exception ex)
            {
                Athlete uAthlete = new Athlete();
                uAthlete.FirstName = textBox2.Text;
                uAthlete.LastName = textBox3.Text;
                uAthlete.AthleteID = int.Parse(textBox4.Text);
                uAthlete.Age = int.Parse(textBox5.Text);
                uAthlete.BibNumber = textBox6.Text;

                databaseHelper.UpdateAthlete(uAthlete);

                editTracker = 0;
                textBox2.Text = athletes[editTracker].FirstName;
                textBox3.Text = athletes[editTracker].LastName;
                textBox4.Text = athletes[editTracker].AthleteID.ToString();
                textBox5.Text = athletes[editTracker].Age.ToString();
                textBox6.Text = athletes[editTracker].BibNumber;
            }
        }

        private void FinishEdit_Click(object sender, EventArgs e)
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
            NextBttn.Visible = false;
            PreviousBttn.Visible = false;
            FinishEdit.Visible = false;

            Athlete uAthlete = new Athlete();
            uAthlete.FirstName = textBox2.Text;
            uAthlete.LastName = textBox3.Text;
            uAthlete.AthleteID = int.Parse(textBox4.Text);
            uAthlete.Age = int.Parse(textBox5.Text);
            uAthlete.BibNumber = textBox6.Text;

            databaseHelper.UpdateAthlete(uAthlete);

            athletes = databaseHelper.GetAllAthletes();
            for (int i = 0; i < athletes.Count(); i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = athletes[i].FullName;
                dataGridView1.Rows[i].Cells[2].Value = athletes[i].AthleteID;
                dataGridView1.Rows[i].Cells[3].Value = athletes[i].Age;
                dataGridView1.Rows[i].Cells[4].Value = athletes[i].BibNumber;
            }

            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (athletes.Count() > 0)
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
                NextBttn.Visible = true;
                PreviousBttn.Visible = true;
                Delete.Visible = true;

                textBox2.Text = athletes[editTracker].FirstName;
                textBox3.Text = athletes[editTracker].LastName;
                textBox4.Text = athletes[editTracker].AthleteID.ToString();
                textBox5.Text = athletes[editTracker].Age.ToString();
                textBox6.Text = athletes[editTracker].BibNumber;
            }
            else
            {
                MessageBox.Show("No Athletes Available To Delete", "", MessageBoxButtons.OK);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
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
            NextBttn.Visible = false;
            PreviousBttn.Visible = false;
            Delete.Visible = false;

            databaseHelper.DeleteAthlete(athletes[editTracker].AthleteID);
            dataGridView1.Rows.Clear();
            athletes = databaseHelper.GetAllAthletes();
            for (int i = 0; i < athletes.Count(); i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = athletes[i].FullName;
                dataGridView1.Rows[i].Cells[2].Value = athletes[i].AthleteID;
                dataGridView1.Rows[i].Cells[3].Value = athletes[i].Age;
                dataGridView1.Rows[i].Cells[4].Value = athletes[i].BibNumber;
            }

            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void TimerForm_Click(object sender, EventArgs e)
        {
            StopWatch stopWatch = new StopWatch();
            stopWatch.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CSV_Export csv = new CSV_Export();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string lePath = saveFileDialog1.FileName;
                // Get your race results data (replace with your actual data source)
                List<ParticipantResult> results = GetRaceResults(); // You need to implement this method
                csv.ExportToCsv(results, lePath);
            }
        }

        private List<ParticipantResult> GetRaceResults()
        {

            return null;
        }
    }
}
