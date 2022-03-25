using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PROGINTERN1
{
    public static class Idioma
    {
        public static Dictionary<string, string> info = new Dictionary<string, string>();
 
        private  static void cargar(string archivo)
        {
            // CARGA LOS ELEMENTOS DE TEXTO EN CORRESPONDENCIA
            // KEY - TEXT DE CADA ELEMENTO DE LA INTERFAZ
            // DEL IDIOMA EN EL DICCIONARIO GUARDADO EN 
            // LA CONFIGURACION
            info.Clear();
            
            foreach (string linea in File.ReadLines("lang\\" + archivo))
            {
                if (linea.Contains("="))
                {
                    string[] s = linea.Split(new char[] { '=' });
                    info.Add(s[0], s[1]);
                }
            }
        }

        public static void cambiarIdioma(string archivo)
        {
            //CAMBIA, CARGA Y GUARDA EL IDIOMA SELECCIONADO
            Properties.Settings config = new Properties.Settings();
            config.lang = archivo;
            config.Save();
            cargar(archivo);
        }

        public static void controles(Form ff)
        {
            // SE UTILIZA PARA FORMULARIOS QUE CONTIENEN
            // CONTROLES
            foreach(string control in info.Keys)
            {
                try
                {
                    ff.Controls[control].Text = info[control];
                }
                catch (Exception err) 
                { 
                    //NADA QUE HACER
                 }
            }
        }
    } //CIERRA EL CLASS
} //CIERRA EL NAMESPACE
