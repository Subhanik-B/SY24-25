using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class Form1 : Form
    {
        Dict dict = new Dict();
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (Word.Text != String.Empty && Definition.Text != String.Empty)
            {
                dict.addWord(Word.Text, Definition.Text);
                Words.Items.Add(Word.Text);
                Word.Text = "";
                Definition.Text = "";
            }
        }

        private void Words_SelectedIndexChanged(object sender, EventArgs e)
        {
            Definition.Text = dict.getDefinition(Words.SelectedItem.ToString());
            Word.Text = Words.SelectedItem.ToString();
        }
    }
}
