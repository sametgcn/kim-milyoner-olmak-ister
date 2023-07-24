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
    public partial class soru1joker : Form
    {
        public soru1joker()
        {
            InitializeComponent();
        }
        
       

        private void soru1joker_Load(object sender, EventArgs e)
        {
            Oyun form1 = new Oyun();
            
            if(form1.label8.Text == "1")
            {
                label1.Text = "Arkadaşın Sorunun Cevabının A Olduğunu Söylüyor.";
            }
            if (form1.label8.Text == "2")
            {
                label1.Text = "Arkadaşın Sorunun Cevabının D Olduğunu Söylüyor.";
            }
            if (form1.label8.Text == "3")
            {
                label1.Text = "Arkadaşın Sorunun Cevabının B Olduğunu Söylüyor.";
            }
            if (form1.label8.Text == "4")
            {
                label1.Text = "Arkadaşın Sorunun Cevabının D Olduğunu Söylüyor.";
            }
            if (form1.label8.Text == "5")
            {
                label1.Text = "Arkadaşın Sorunun Cevabının B Olduğunu Söylüyor.";
            }
           if (form1.label8.Text == "6")
            {
                label1.Text = "Arkadaşın Sorunun Cevabının A Olduğunu Söylüyor.";
            }
            if (form1.label8.Text == "7")
            {
                label1.Text = "Arkadaşın Sorunun Cevabının B Olduğunu Söylüyor.";
            }
           if (form1.label8.Text == "8")
            {
                label1.Text = "Arkadaşın Sorunun Cevabının C Olduğunu Söylüyor.";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

