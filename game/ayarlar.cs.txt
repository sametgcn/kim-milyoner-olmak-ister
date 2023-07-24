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
    public partial class ayarlar2 : Form
    {
        public ayarlar2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
           

        private void ayarlar2_Load(object sender, EventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(button1.BackColor==Color.Green)
            {
                button1.BackColor = Color.DarkRed;
            }
           else
            {
                button1.BackColor = Color.Green;
            }


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.Green)
            {
                button2.BackColor = Color.DarkRed;

               
}
            else
            {
                button2.BackColor = Color.Green;
            }
        }
        }
    }
    
    

