using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vending_Machine
{
    public partial class Form1 : Form
    {
        CoinSlot coinSlot = new CoinSlot();

        public Form1()
        {
            InitializeComponent();
        }

        public void showPrice(object sender, MouseEventArgs e)
        {
            Item i = sender as Item;
            showProduct(i.name, i.price);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            coinSlot.insertCoin(0.05);
            showDeposit();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            coinSlot.insertCoin(0.1);
            showDeposit();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            coinSlot.insertCoin(0.25);
            showDeposit();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            coinSlot.insertCoin(1);
            showDeposit();
        }

        private void showDeposit()
        {
            label6.Text = coinSlot.returnMoney().ToString();
        }

        private void showProduct(String Name, Double Price)
        {
            label3.Text = Name;
            label4.Text = Price.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            coinSlot.coinReturn();
            label6.Text = coinSlot.returnMoney().ToString();
        }
    }
}
