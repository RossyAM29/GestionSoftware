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
    public partial class FRMCONF : Form
    {
        public FRMCONF(int ntema)
        {
            InitializeComponent();
            comboBox1.SelectedIndex= ntema;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tema = comboBox1.SelectedItem.ToString();
            //ACTUALIZA EL TEMA EN LA CONFIGURACION
            Form1.mus.Tema = comboBox1.SelectedIndex;
            Form1.AplicarTema(tema);
            
            
        }
    }
}
