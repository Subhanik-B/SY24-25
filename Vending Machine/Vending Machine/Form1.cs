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
        Item i = new Item();
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        public void showPrice(object sender, MouseEventArgs e)
        {
            i = sender as Item;
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

        private void Buy_Click(object sender, EventArgs e)
        {
            if (i.stock > 0 && coinSlot.returnMoney() > i.price)
            {
                i.buy();
                coinSlot.insertCoin(-i.price);
                label6.Text = coinSlot.returnMoney().ToString();
                MessageSystem.Text = "You have bought: " + i.name;
            }
            if (i.stock == 0)
            {
                MessageSystem.Text = "Sorry, but we're out of: " + i.name;
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadForm();
        }

        private async Task LoadForm()
        {
            Item[] items = new Item[] { item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12 };
            for (int i = 0; i < items.Length; i++)
            {
                items[i].stock = random.Next(0, 100);
                items[i].price = random.Next(1, 15) + 0.99;
                items[i].updateLabel();
                await Task.Delay(1);
            }
        }
    }
}
