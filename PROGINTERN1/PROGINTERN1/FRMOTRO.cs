using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGINTERN1
{
    public partial class FRMOTRO : Form
    {
        public FRMOTRO()
        {
            InitializeComponent();
            // CARGA LOS ELEMENTOS DE TEXTO DE 
            // CADA CONTROL EN EL IDIOMA DE
            // CONFIGURACION
            Idioma.controles(this);
            this.Text = Idioma.info["titulo2"];
        }

        private void BTNCERRAR_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
