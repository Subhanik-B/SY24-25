using Quartet3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quartet3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CarCard display = new CarCard("","",0,0,0,0,0,0);
        List<CarCard> beans = new List<CarCard>();
        CarCard A1 = new CarCard("A1", "BMW Z8", 250, 4.7, 400, 4941, 8, 6600);
        CarCard A2 = new CarCard("A2", "MG Xpower SV Club Sport", 230, 4.2, 465, 4997, 8, 6450);
        CarCard A3 = new CarCard("A3", "Ferrari F430 F1", 315, 4.0, 490, 4308, 8, 8500);
        CarCard A4 = new CarCard("A4", "Viper GTS", 285, 4.6, 411, 7990, 10, 5100);
        CarCard B1 = new CarCard("B1", "Ford GT", 325, 3.3, 550, 5403, 8, 5250);
        CarCard B2 = new CarCard("B2", "TVR Sagaris", 300, 3.9, 3966, 400, 8, 7000);
        CarCard B3 = new CarCard("B3", "Range Rover Sport", 225, 7.6, 390, 4197, 8, 5750);
        CarCard B4 = new CarCard("B4", "Rindspeed Chopster", 290, 4.4, 600, 4511, 8, 6700);
        CarCard C1 = new CarCard("C1", "Maserati Spyder", 283, 5.0, 390, 4244, 8, 7000);
        CarCard C2 = new CarCard("C2", "Toyota Celia", 205, 8.7, 143, 1794, 4, 6400);
        CarCard C3 = new CarCard("C3", "Porsche 911 Targa", 285, 5.2, 320, 3596, 6, 6800);
        CarCard C4 = new CarCard("C4", "Corvette Coupe", 281, 5.2, 344, 5665, 8, 5400);
        CarCard D1 = new CarCard("D1", "Audi RS4", 250, 4.8, 420, 4163, 8, 7800);
        CarCard D2 = new CarCard("D2", "Audi RS 6 Plus", 280, 4.6, 480, 4172, 8, 6400);
        CarCard D3 = new CarCard("D3", "Nissan 350 Z", 250, 5.9, 280, 3498, 6, 6200);
        CarCard D4 = new CarCard("D4", "Mercedes CLK DTM AMG", 320, 4.0, 582, 5439, 8, 6100);
        CarCard E1 = new CarCard("E1", "Aston Martin V8 Vantage", 280, 5.0, 4282, 385, 8, 7000);
        CarCard E2 = new CarCard("E2", "Ferrari F50", 325, 3.9, 521, 4700, 12, 8500);
        CarCard E3 = new CarCard("E3", "BMW 645 Ci", 250, 5.6, 333, 4398, 7, 6100);
        CarCard E4 = new CarCard("E4", "Bentley Azure", 241, 6.7, 6750, 388, 8, 4000);
        CarCard F1 = new CarCard("F1", "Opel Astra Coupe 2.0", 245, 7.5, 192, 1998, 4, 5400);
        CarCard F2 = new CarCard("F2", "VW Golf R32", 248, 6.2, 250, 3189, 6, 6300);
        CarCard F3 = new CarCard("F3", "Chrysler Crossfire", 250, 6.9, 218, 3199, 6, 5700);
        CarCard F4 = new CarCard("F4", "Fisker Tramonto", 325, 3.6, 610, 5439, 8, 6100);
        CarCard G1 = new CarCard("G1", "Marcos Mantara", 225, 5.4, 190, 3998, 8, 4750);
        CarCard G2 = new CarCard("G2", "Mercedes-Benz SL 500", 250, 6.3, 4966, 306, 8, 5600);
        CarCard G3 = new CarCard("G3", "Alfa Romeo Brera", 248, 6.3, 260, 3195, 6, 6200);
        CarCard G4 = new CarCard("G4", "Porsche Cayman S", 275, 5.4, 295, 3387, 6, 6250);
        CarCard H1 = new CarCard("H1", "BMW Z4", 250, 5.9, 2979, 231, 6, 5900);
        CarCard H2 = new CarCard("H2", "Alfa Romeo GT", 243, 6.7, 240, 3179, 6, 6400);
        CarCard H3 = new CarCard("H3", "Pontiac GTO", 280, 5.7, 5970, 400, 8, 5200);
        CarCard H4 = new CarCard("H4", "BMW M5", 250, 4.7, 4999, 507, 10, 7750);
        Deck deck = new Deck(null);
        Hand p1 = new Hand();
        Hand p2 = new Hand();
        Hand p3 = new Hand();
        Hand p4 = new Hand();

        private void button1_Click(object sender, EventArgs e)
        {
            showCard(p1.getTop());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int i = random.Next(0, 32);
            showCard1(beans[i]);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int i = random.Next(0, 32);
            showCard2(beans[i], i);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int i = random.Next(0, 32);
            showCard3(beans[i], i);
        }
        private void showCard(CarCard card)
        {
            display = card;
            pictureBox1.Load(card.id + ".jpg");
            TopSpeedTB.Text = card.maxspeed.ToString();
            ToSixty.Text = card.zerotosixty.ToString();
            Horsepower.Text = card.hp.ToString();
            cc.Text = card.cc.ToString();
            Cylinders.Text = card.cylinders.ToString();
            RPM.Text = card.rpm.ToString();
            Name.Text = card.name.ToString();
            ID.Text = card.id.ToString();
        }

        private void showCard1(CarCard card)
        {
            pictureBox2.Load(card.id + ".jpg");
            textBox2.Text = card.id.ToString();
            textBox3.Text = card.name.ToString();
            textBox4.Text = card.rpm.ToString();
            textBox5.Text = card.hp.ToString();
            textBox6.Text = card.cylinders.ToString();
            textBox7.Text = card.zerotosixty.ToString();
            textBox8.Text = card.cc.ToString();
            textBox9.Text = card.maxspeed.ToString();
        }
        private void showCard2(CarCard card, int i)
        {
            pictureBox3.Load(beans[i].id + ".jpg");
            textBox10.Text = beans[i].id.ToString();
            textBox11.Text = beans[i].name.ToString();
            textBox12.Text = beans[i].rpm.ToString();
            textBox13.Text = beans[i].hp.ToString();
            textBox14.Text = beans[i].cylinders.ToString();
            textBox15.Text = beans[i].zerotosixty.ToString();
            textBox16.Text = beans[i].cc.ToString();
            textBox17.Text = beans[i].maxspeed.ToString();
        }
        private void showCard3(CarCard card, int i)
        {
            pictureBox4.Load(beans[i].id + ".jpg");
            textBox18.Text = beans[i].id.ToString();
            textBox19.Text = beans[i].name.ToString();
            textBox20.Text = beans[i].rpm.ToString();
            textBox21.Text = beans[i].hp.ToString();
            textBox22.Text = beans[i].cylinders.ToString();
            textBox23.Text = beans[i].zerotosixty.ToString();
            textBox24.Text = beans[i].cc.ToString();
            textBox25.Text = beans[i].maxspeed.ToString();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            beans.Add(A1);
            beans.Add(A2);
            beans.Add(A3);
            beans.Add(A4);
            beans.Add(B1);
            beans.Add(B2);
            beans.Add(B3);
            beans.Add(B4);
            beans.Add(C1);
            beans.Add(C2);
            beans.Add(C3);
            beans.Add(C4);
            beans.Add(D1);
            beans.Add(D2);
            beans.Add(D3);
            beans.Add(D4);
            beans.Add(E1);
            beans.Add(E2);
            beans.Add(E3);
            beans.Add(E4);
            beans.Add(F1);
            beans.Add(F2);
            beans.Add(F3);
            beans.Add(F4);
            beans.Add(G1);
            beans.Add(G2);
            beans.Add(G3);
            beans.Add(G4);
            beans.Add(H1);
            beans.Add(H2);
            beans.Add(H3);
            beans.Add(H4);

            deck.updateDeck(beans);
            deck.shuffle();
            deck.updateDeck(beans);
        }

        private void splitCard_Click(object sender, EventArgs e)
        {
            //shuffle
            deck.shuffle();
            //deal cards
            
            while (deck.isEmpty() %4 == 0)
            {
                p1.addCard(deck.GetCard(0));
                p2.addCard(deck.GetCard(0));
                p3.addCard(deck.GetCard(0));
                p4.addCard(deck.GetCard(0));
            }
        }
    }
}
