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
    public partial class Form1 : Form
    {
        //DECLARACION DE LA VARIABLE DE CONFIGURACION
        public static MyUserSettings mus;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //CREA EL OBJETO DE CONFIGURACION 
            mus = new MyUserSettings();
            ENLAZA_CONF();
        }

        public void ENLAZA_CONF()
        {
            //ENLAZA LAS PROPIEDADES DE LOS CONTROLES A LOS DE LA CONFIGURACION
            PanelPadre.DataBindings.Add(new Binding("BackColor", mus, "PanelPadre"));
            PanelBotones.DataBindings.Add(new Binding("BackColor", mus, "PanelBotones"));
            BarraTitulo.DataBindings.Add(new Binding("BackColor", mus, "BarraTitulo"));
            TextBusqueda.DataBindings.Add(new Binding("BackColor", mus, "TextBusqueda"));
            CBOTEMAS.DataBindings.Add(new Binding("SelectedIndex", mus, "Tema"));
        }

        private void CBOTEMAS_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string tema = CBOTEMAS.SelectedItem.ToString();
            //ACTUALIZA EL TEMA EN LA CONFIGURACION
            mus.Tema = CBOTEMAS.SelectedIndex;
            AplicarTema(tema);
            

        }

        public static void AplicarTema(string tema)
        {
            TemasColores.ElegirTema(tema);
            mus.PanelPadre = TemasColores.PanelPadre;
            mus.PanelBotones = TemasColores.PanelBotones;
            mus.BarraTitulo = TemasColores.BarraTitulo;
            mus.TextBusqueda = TemasColores.TextBusqueda;   
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //GUARDA LA CONFIGURACION
            mus.Save();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FRMCONF myForm1 = new FRMCONF(mus.Tema);
            myForm1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRMCONF myForm1 = new FRMCONF(mus.Tema);
            myForm1.ShowDialog();
        }
    }
}
