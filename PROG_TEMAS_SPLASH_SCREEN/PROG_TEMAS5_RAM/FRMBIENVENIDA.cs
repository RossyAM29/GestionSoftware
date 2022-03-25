using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG_TEMAS5_RAM
{
    public partial class FRMBIENVENIDA : Form
    {
        public FRMBIENVENIDA()
        {
            InitializeComponent();
        }

        int c;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            ++c;
            progressBar1.Value = c;
            if (c==100)
            {
                timer1.Stop();
                timer2.Start();
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity==0)
            {
                timer2.Stop();
                this.Hide();
                Form1 myForm = new Form1();
                myForm.Show();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FRMBIENVENIDA_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
