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
    public partial class para : Form
    {
        public para()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            anamenu menu20 = new anamenu();
            menu20.Show();
            this.Close();
        }

        private void para_Load(object sender, EventArgs e)
        {
           Oyun form1 = new Oyun();
            for(int i =0; i<=100; i++)
            {
                label1.Text = form1.label9.Text;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
