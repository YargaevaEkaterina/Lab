using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        int n, i = 0;
        int karta=0;  //для регулирования карты
        int sum = 500;  //для оплаты
        int q; // gas ne gas
        

        public Form1()
        {
            InitializeComponent();
            pictureBox4.Image = Image.FromFile("k.gif");
            wmp.URL = "1.mp3";
        }

        
        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            button5.Enabled = false;
            button9.Enabled = false;

            if (karta == 1 & sum>0)
            {
                timer1.Interval = 1900;
                timer2.Interval = 1800;
                timer1.Start();
                timer2.Start();
                timer4.Interval = 1800;
                
                switch (n)
                {
                    case 1:
                        if (sum >= 15 && q==0)
                        {
                            pictureBox1.Image = Image.FromFile("cran13.gif");
                            sum -= 15;
                            richTextBox1.Clear();
                            richTextBox1.AppendText("Баланс карты: " + sum);

                        }
                        else
                        {
                            richTextBox1.Clear();
                            richTextBox1.AppendText("Недостаточно средств на карте  Ваш баланс: " + sum);
                        }
                        if (sum >= 5 && q==1)
                        {
                            pictureBox1.Image = Image.FromFile("cran13.gif");
                            sum -= 5;
                            richTextBox1.Clear();
                            richTextBox1.AppendText("Баланс карты: " + sum);
                        }
                        else
                        {
                            richTextBox1.Clear();
                            richTextBox1.AppendText("Недостаточно средств на карте  Ваш баланс: " + sum);
                        }
                        break;
                    case 2:
                        if (sum >= 20 && q==0)
                        {
                            pictureBox1.Image = Image.FromFile("cran11.gif");
                            sum -= 20;
                            richTextBox1.Clear();
                            richTextBox1.AppendText("Баланс карты: " + sum);
                        }
                        else
                        {
                            richTextBox1.Clear();
                            richTextBox1.AppendText("Недостаточно средств на карте  Ваш баланс: " + sum);
                        }
                        if (sum >= 10 && q == 1)
                        {
                            pictureBox1.Image = Image.FromFile("cran13.gif");
                            sum -= 10;
                            richTextBox1.Clear();
                            richTextBox1.AppendText("Баланс карты: " + sum);
                        }
                        else
                        {
                            richTextBox1.Clear();
                            richTextBox1.AppendText("Недостаточно средств на карте  Ваш баланс: " + sum);
                        }
                        break;
                    case 3:
                        if (sum >= 60 && q==0)
                        {
                            pictureBox1.Image = Image.FromFile("cran12.gif");
                            sum -= 60;
                            richTextBox1.Clear();
                            richTextBox1.AppendText("Баланс карты: " + sum);
                        }
                        else
                        {
                            richTextBox1.Clear();
                            richTextBox1.AppendText("Недостаточно средств на карте  Ваш баланс: " + sum);
                        }
                        if (sum >= 50 && q == 1)
                        {
                            pictureBox1.Image = Image.FromFile("cran13.gif");
                            sum -= 50;
                            richTextBox1.Clear();
                            richTextBox1.AppendText("Баланс карты: " + sum);
                        }
                        else
                        {
                            richTextBox1.Clear();
                            richTextBox1.AppendText("Недостаточно средств на карте  Ваш баланс: " + sum);
                        }
                        break;
                    case 4:
                        if (sum >= 110 && q==0)
                        {
                            pictureBox1.Image = Image.FromFile("cran14.gif");
                            sum -= 110;
                            richTextBox1.Clear();
                            richTextBox1.AppendText("Баланс карты: " + sum);
                        }
                        else
                        {
                            richTextBox1.Clear();
                            richTextBox1.AppendText("Недостаточно средств на карте  Ваш баланс: " + sum);
                        }
                        if (sum >= 100 && q == 1)
                        {
                            pictureBox1.Image = Image.FromFile("cran13.gif");
                            sum -= 100;
                            richTextBox1.Clear();
                            richTextBox1.AppendText("Баланс карты: " + sum);
                        }
                        else
                        {
                            richTextBox1.Clear();
                            richTextBox1.AppendText("Недостаточно средств на карте  Ваш баланс: " + sum);
                        }
                        break;

                }
            }
            
        }

  

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            
            switch (n)
            {
                case 1:
                    pictureBox1.Image = Image.FromFile("cran131.gif");
                    pictureBox1.Image = Image.FromFile("cran.png");
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile("cran111.gif");
                    pictureBox1.Image = Image.FromFile("cran.png");
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile("cran121.gif");
                    pictureBox1.Image = Image.FromFile("cran.png");
                    break;
                case 4:
                    pictureBox1.Image = Image.FromFile("cran141.gif");
                    pictureBox1.Image = Image.FromFile("cran.png");
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            button9.Enabled = true;
            if (karta == 1)
            {
                n = 1;
                pictureBox4.Image = Image.FromFile("o5.gif"); timer4.Start();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            button9.Enabled = true;
            if (karta == 1)
            {
                n = 2;
                pictureBox4.Image = Image.FromFile("o1.gif"); timer4.Start();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            button9.Enabled = true;

            if (karta == 1)
            {
                n = 3;
                pictureBox4.Image = Image.FromFile("o55.gif"); timer4.Start();
                timer4.Start();
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            button9.Enabled = true;


            if (karta == 1)
            {
                n = 4;
                pictureBox4.Image = Image.FromFile("o10.gif"); timer4.Start();
               
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (karta == 0)
            {
                timer2.Interval = 1800;
                i = 5;
                timer2.Start();
                pictureBox4.Image = Image.FromFile("o.gif");
                pictureBox3.Image = Image.FromFile("dis2.gif");
                karta = 1;
                richTextBox1.Clear();
                richTextBox1.AppendText("Баланс карты: " + sum);
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            if (i==5)
                pictureBox3.Image = null;
            else
                pictureBox3.Image = Image.FromFile("dis2.png");


            //pictureBox3.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (karta == 1)
            {
                timer2.Interval = 1800;
                i = 5;
                timer2.Start();
                pictureBox3.Image = Image.FromFile("dis3.gif");
                karta = 0;
                richTextBox1.Clear();
            }
          
        }

      

    
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            timer5.Stop();
            pictureBox5.Visible = false;
            pictureBox5.Enabled = false;
            button8.Visible = false;
            button8.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer5.Interval = 900;
            timer5.Start();
            pictureBox5.Image = Image.FromFile("disw2.gif");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button6.Enabled = true;
            q = 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button6.Enabled = true;
            q = 1;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
          
          timer4.Stop();
          pictureBox4.Image = Image.FromFile("ok.gif");

        }
    }
}
