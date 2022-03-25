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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            actualizar();
        }

        private void menuSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuEspañol_Click(object sender, EventArgs e)
        {
            
            Idioma.cambiarIdioma("mx.txt");
            actualizar();
        }

        private void menuIngles_Click(object sender, EventArgs e)
        {
            Idioma.cambiarIdioma("en.txt");
            actualizar();
        }
        void actualizar()
        {
            //SOLO SI HAY CONTROLES EN EL FORMULARIO
            Idioma.controles(this);

            //LOS SUBMENUS NO SE CONSIDERAN COMO CONTROLES
            //POR LO QUE SE ASIGNARÁ UNO A UNO
            this.Text = Idioma.info["titulo"];
            menuArchivo.Text = Idioma.info["menuArchivo"];
            menuAcercaDe.Text = Idioma.info["menuAcercaDe"];
            menuAyuda.Text = Idioma.info["menuAyuda"];
            menuEspañol.Text = Idioma.info["menuEspañol"];
            menuIdiomas.Text = Idioma.info["menuIdiomas"];
            menuIngles.Text = Idioma.info["menuIngles"];
            menuOpciones.Text = Idioma.info["menuOpciones"];
            menuSalir.Text = Idioma.info["menuSalir"];
        }

        private void menuAlumnos_Click(object sender, EventArgs e)
        {
            FRMOTRO MYfORM = new FRMOTRO();
            MYfORM.Show();
        }
    }
}
