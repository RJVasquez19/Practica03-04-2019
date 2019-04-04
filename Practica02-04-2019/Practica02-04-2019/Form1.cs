using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica02_04_2019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progBar1.Maximum = 100;
            progBar1.Minimum = 0;
            progBar1.Step = 4;
        }

        private void btnButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 24; i++)
                progBar1.PerformStep();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <= 24; i++)
            {
                progBar1.PerformStep();
            }
            //Form2 frm = new Form2();
            //frm.Show();
            //this.Hide();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            btnRojo.UseVisualStyleBackColor = true;
            btnAmarillo.UseVisualStyleBackColor = true;
            btnVerde.BackColor = Color.Green;
            timer3.Enabled = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            btnVerde.UseVisualStyleBackColor = true;
            btnRojo.UseVisualStyleBackColor = true;
            btnAmarillo.BackColor = Color.Yellow;
            timer2.Enabled = false;
            timer4.Enabled = true;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            timer3.Enabled = false;
            btnAmarillo.UseVisualStyleBackColor = true;
            btnVerde.UseVisualStyleBackColor = true;
            btnRojo.BackColor = Color.Red;
            if (timer4.Interval == 5000)
            {
                timer2.Enabled = true;
                timer4.Enabled = false;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }
    }
}
