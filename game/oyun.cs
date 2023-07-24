using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Oyun : Form
    {
        public Oyun()
        {
            InitializeComponent();
        }

        public void kisaenabled()
        {
            button1.Visible = true;
            button2.Visible = true;
        }
        public void bug1()
        {
            label3.Enabled = false;
            label4.Enabled = false;
            label5.Enabled= false;
            label6.Enabled= false;
        }
        public void bug2()
        {
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
        }
        public void beyaz()
        {
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
        }
        public void kapa()
        {
            button5.Visible = true;

        }
        public void vis()
        {
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            anamenu anamenu3 = new anamenu();
            anamenu3.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ayarlar2 ayar2 = new ayarlar2();
            ayar2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (label8.Text == "1")
            {
                label3.ForeColor = Color.Green;
                label4.ForeColor = Color.Red;
                label5.ForeColor = Color.Red;
                label6.ForeColor = Color.Red;
                label8.Text = "2";
                kisaenabled();
                listBox1.ForeColor = Color.Green;
                listBox1.Items.Add(500);
                label9.Text = "500";
               
                

            }
            else if (label8.Text == "2")
            {
                label3.ForeColor = Color.Red;
                label4.ForeColor = Color.Red;
                label5.ForeColor = Color.Red;
                label6.ForeColor = Color.Green;
                kapa();
                listBox1.ForeColor = Color.DarkRed;
                

            }
            else if(label8.Text =="3")
            {
                label3.ForeColor = Color.Red;
                label4.ForeColor = Color.Red;
                label5.ForeColor = Color.Green;
                label6.ForeColor = Color.Red;
                kapa();
                listBox1.ForeColor = Color.DarkRed;
               

            }
            else if (label8.Text == "4")
            {
                label3.ForeColor = Color.Red;
                label4.ForeColor = Color.Red;
                label5.ForeColor = Color.Red;
                label6.ForeColor = Color.Green;
                kapa();
                listBox1.ForeColor = Color.DarkRed;
                

            }

            else if (label8.Text == "5")
            {
                label3.ForeColor = Color.Red;
                label4.ForeColor = Color.Red;
                label5.ForeColor = Color.Green;
                label6.ForeColor = Color.Red;
                kapa();
                listBox1.ForeColor = Color.DarkRed;
                


            }
            if (label8.Text == "6")
            {
                label3.ForeColor = Color.Green;
                label4.ForeColor = Color.Red;
                label5.ForeColor = Color.Red;
                label6.ForeColor = Color.Red;
                kisaenabled();
                listBox1.ForeColor = Color.Green;
                label9.Text = "400000";
                listBox1.Items.Add(400000);
                label8.Text = "7";
                
                label3.Enabled = true;


            }
            else if (label8.Text == "7")
            {
                label3.ForeColor = Color.Red;
                label4.ForeColor = Color.Red;
                label5.ForeColor = Color.Green;
                label6.ForeColor = Color.Red;
                kapa();
                listBox1.ForeColor = Color.DarkRed;
                
                label5.Enabled= true;

            }
            else if (label8.Text == "8")
            {
                label3.ForeColor = Color.Red;
                label4.ForeColor = Color.Green;
                label5.ForeColor = Color.Red;
                label6.ForeColor = Color.Red;
                kapa();
                listBox1.ForeColor = Color.DarkRed;
                

            }

        }
        
        private void label5_Click(object sender, EventArgs e)
        {
            if (label8.Text == "1")
            {
                label3.ForeColor = Color.Green;
                label4.ForeColor = Color.Red;
                label5.ForeColor = Color.Red;
                label6.ForeColor = Color.Red;
                kapa();
                listBox1.ForeColor = Color.DarkRed;
               

            }

            else  if (label8.Text == "2")
            {
                label3.ForeColor = Color.Red;
                label4.ForeColor = Color.Red;
                label5.ForeColor = Color.Red;
                label6.ForeColor = Color.Green;
                kapa();
                listBox1.ForeColor = Color.DarkRed;
                


            }
            else if(label8.Text =="3")
            {
                label3.ForeColor = Color.Red;
                label4.ForeColor = Color.Red;
                label5.ForeColor = Color.Green;
                label6.ForeColor = Color.Red;
                kisaenabled();
                listBox1.ForeColor = Color.Green;
                listBox1.Items.Add(15000);
                label9.Text = "15000";
                label8.Text = "4";
                
                label5.Enabled = true;






            }
            else if (label8.Text == "4")
            {
                label3.ForeColor = Color.Red;
                label4.ForeColor = Color.Red;
                label5.ForeColor = Color.Red;
                label6.ForeColor = Color.Green;
                kapa();
                listBox1.ForeColor = Color.DarkRed;
                                



            }
            else if (label8.Text == "5")
            {
                label3.ForeColor = Color.Red;
                label4.ForeColor = Color.Red;
                label5.ForeColor = Color.Green;
                label6.ForeColor = Color.Red;
                kisaenabled();
                listBox1.ForeColor = Color.Green;
                label9.Text = "150000";
                listBox1.Items.Add(150000);
                
                label5.Enabled = true;


                label8.Text = "6";
                


            }
            else if (label8.Text == "6")
            {
                label3.ForeColor = Color.Green;
                label4.ForeColor = Color.Red;
                label5.ForeColor = Color.Red;
                label6.ForeColor = Color.Red;
                kapa();
                listBox1.ForeColor = Color.DarkRed;
               



            }
            else if (label8.Text == "7")
            {
                label3.ForeColor = Color.Red;
                label4.ForeColor = Color.Red;
                label5.ForeColor = Color.Green;
                label6.ForeColor = Color.Red;
                kisaenabled();
                listBox1.ForeColor = Color.Green;
                label9.Text = "750000";
                listBox1.Items.Add(750000);
                label8.Text = "8";
                
                




            }
            else if (label8.Text == "8")
            {
                label3.ForeColor = Color.Red;
                label4.ForeColor = Color.Green;
                label5.ForeColor = Color.Red;
                label6.ForeColor = Color.Red;
                kapa();
                listBox1.ForeColor = Color.DarkRed;
                


            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if(label8.Text == "1")
            {
                label3.ForeColor = Color.Green;
                label4.ForeColor = Color.Red;
                label5.ForeColor = Color.Red;
                label6.ForeColor = Color.Red;
                kapa();
                listBox1.ForeColor = Color.DarkRed;
                

            }
            else if(label8.Text =="2")
            {
                label3.ForeColor = Color.Red;
                label4.ForeColor = Color.Red;
                label5.ForeColor = Color.Red;
                label6.ForeColor = Color.Green;
                kapa();
                listBox1.ForeColor = Color.DarkRed;
                


            }
            else if(label8.Text =="3")
            {
                label3.ForeColor = Color.Red;
                label4.ForeColor = Color.Red;
                label5.ForeColor = Color.Green;
                label6.ForeColor = Color.Red;
                kapa();
                listBox1.ForeColor = Color.DarkRed;
                


            }
            else if (label8.Text == "4")
            {
                label3.ForeColor = Color.Red;
                label4.ForeColor = Color.Red;
                label5.ForeColor = Color.Red;
                label6.ForeColor = Color.Green;
                kapa();
                listBox1.ForeColor = Color.DarkRed;
                



            }
            else if (label8.Text == "5")
            {
                label3.ForeColor = Color.Red;
                label4.ForeColor = Color.Green;
                label5.ForeColor = Color.Red;
                label6.ForeColor = Color.Red;
                kapa();
                listBox1.ForeColor = Color.DarkRed;
                



            }
            else  if (label8.Text == "6")
            {
                label3.ForeColor = Color.Green;
                label4.ForeColor = Color.Red;
                label5.ForeColor = Color.Red;
                label6.ForeColor = Color.Red;
                kapa();
                listBox1.ForeColor = Color.DarkRed;
                


            }
            else if (label8.Text == "7")
            {
                label3.ForeColor = Color.Red;
                label4.ForeColor = Color.Red;
                label5.ForeColor = Color.Green;
                label6.ForeColor = Color.Red;
                kapa();
                listBox1.ForeColor = Color.DarkRed;
               


            }
            else if (label8.Text == "8")
            {
                label3.ForeColor = Color.Red;
                label4.ForeColor = Color.Green;
                label5.ForeColor = Color.Red;
                label6.ForeColor = Color.Red;
                kisaenabled();
                listBox1.ForeColor = Color.Green;
                label9.Text = "1000000";
                listBox1.Items.Add(1000000);
                
                label4.Enabled = true;
                label8.Text = "9";



            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if(label8.Text=="1")
            {
                label3.ForeColor = Color.Green;
                label4.ForeColor = Color.Red;
                label5.ForeColor = Color.Red;
                label6.ForeColor = Color.Red;
                kapa();
                listBox1.ForeColor = Color.DarkRed;
                


            }
            else  if(label8.Text=="2")
            {
                label3.ForeColor = Color.Red;
                label4.ForeColor = Color.Red;
                label5.ForeColor = Color.Red;
                label6.ForeColor = Color.Green;
                kisaenabled();
                label8.Text = "3";
                listBox1.ForeColor = Color.Green;
                listBox1.Items.Add(2500);
                label9.Text = "2500";
                
                label6.Enabled = true;



            }
            else if(label8.Text =="3")
            {
                label3.ForeColor = Color.Red;
                label4.ForeColor = Color.Red;
                label5.ForeColor = Color.Green;
                label6.ForeColor = Color.Red;
                kapa();
                listBox1.ForeColor = Color.DarkRed;
                


            }
            else if(label8.Text =="4")
            {
                label3.ForeColor = Color.Red;
                label4.ForeColor = Color.Red;
                label5.ForeColor = Color.Red;
                label6.ForeColor = Color.Green;
                kisaenabled();
                listBox1.ForeColor = Color.Green;
                listBox1.Items.Add(50000);
                label9.Text = "500000";
                label8.Text = "5";
                
                label6.Enabled = true;





            }
            else if (label8.Text == "5")
            {
                label3.ForeColor = Color.Red;
                label4.ForeColor = Color.Green;
                label5.ForeColor = Color.Red;
                label6.ForeColor = Color.Red;
                kapa();
                listBox1.ForeColor = Color.DarkRed;
                


            }
            else if (label8.Text == "6")
            {
                label3.ForeColor = Color.Green;
                label4.ForeColor = Color.Red;
                label5.ForeColor = Color.Red;
                label6.ForeColor = Color.Red;
                kapa();
                listBox1.ForeColor = Color.DarkRed;
                


            }
            else if (label8.Text == "7")
            {
                label3.ForeColor = Color.Red;
                label4.ForeColor = Color.Red;
                label5.ForeColor = Color.Green;
                label6.ForeColor = Color.Red;
                kapa();
                listBox1.ForeColor = Color.DarkRed;
                

            }
            else if (label8.Text == "8")
            {
                label3.ForeColor = Color.Red;
                label4.ForeColor = Color.Green;
                label5.ForeColor = Color.Red;
                label6.ForeColor = Color.Red;
                kapa();
                listBox1.ForeColor = Color.DarkRed;
               

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            soru1joker joker1 = new soru1joker();
            joker1.Show();

        }

        public void label8_Click(object sender, EventArgs e)
        {
            Oyun form1 = new Oyun();
            form1.label8.Text = label1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            if(label8.Text == "2")
            {
                beyaz();
                vis();

                label2.Text = "Amerikanın Kurucusu Kimdir?";
                label3.Text = "II.Peter";
                label4.Text = "Oswald Mosley";
                label5.Text = "Vladimir Lenin";
                label6.Text = "George Washington";
                bug2();
                


            }
            else if(label8.Text =="3")
            {
                beyaz();
                vis();


                label2.Text = "2023 Yılında Real Madride Transfer Olan Türk Oyuncu?";
                label3.Text = "Emrecan Uzunhan";
                label4.Text = "Buluthan Bulut";
                label5.Text = "Arda Güler";
                label6.Text = "Taha Altıkardeş";
                bug2();
                



            }
            else if (label8.Text == "4")
            {
                beyaz();
                vis();


                label2.Text = "Atı İlk Evcilleştiren Medeniyet Hangisidir?";
                label3.Text = "Çin";
                label4.Text = "İngiliz";
                label5.Text = "Mısır";
                label6.Text = "Türk";
                bug2();
                



            }
            else if (label8.Text == "5")
            {
                beyaz();
                vis();


                label2.Text = "Düşünüyorum öyleyse varım düşüncesi kime aittir?";
                label3.Text = "Sokrates";
                label4.Text = "Farabi";
                label5.Text = "Descartes";
                label6.Text = "Aristo";
                bug2();
                



            }
            else if (label8.Text == "6")
            {
                beyaz();
                vis();


                label2.Text = "Güneş Dili Teorisi Kimin Eseridir?";
                label3.Text = "Mustafa Kemal Atatürk";
                label4.Text ="Adolf Hitler";
                label5.Text = "Fidel Castro";
                label6.Text = "Ziya Gökalp";
                bug2();

            }

            else if (label8.Text == "7")
            {
                beyaz();
                vis();


                label2.Text = "Brüksel Hangi Ülkenin Başkentidir?";
                label3.Text = "Lüksemburg";
                label4.Text = "Polonya";
                label5.Text = "Belçika";
                label6.Text = "Kanada";
                bug2();

            }

            else if (label8.Text == "8")
            {
                beyaz();
                vis();


                label2.Text = "Bu Oyunun Yapımcısı Kimdir?";
                label3.Text = "Ren";
                label4.Text = "Sametgcn";
                label5.Text = "John Doe";
                label6.Text = "Srow";
                bug2();
                

            }
            else if(label8.Text =="9")
            {
                para tsk = new para();
                tsk.Show();
                Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            para para = new para();
            para.Show();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        public void label9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;

            if (label8.Text == "1")
            {
                label4.Visible = false;
                label5.Visible = false;

            }
            if (label8.Text == "2")
            {
                label5.Visible = false;
                label3.Visible = false;

            }
            if (label8.Text == "3")
            {
                label4.Visible = false;
                label6.Visible = false;

            }
            if (label8.Text == "4")
            {
                label4.Visible = false;
                label5.Visible = false;

            }
            if (label8.Text == "5")
            {
                label6.Visible = false;
                label5.Visible = false;

            }
            if (label8.Text == "6")
            {
                label4.Visible = false;
                label5.Visible = false;

                

            }
            if (label8.Text == "7")
            {
                label3.Visible = false;
                label5.Visible = false;

            }
            if (label8.Text == "8")
            {
                label3.Visible = false;
                label6.Visible = false;

            }
        }

        private void Oyun_Load(object sender, EventArgs e)
        {

        }
    }
}
