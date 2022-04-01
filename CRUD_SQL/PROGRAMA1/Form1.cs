using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PROGRAMA1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DGClientes.DataSource = Llenar();
            conexion.Conectar();
        }


        public DataTable Llenar()
        {
            //conexion.Conectar();
            DataTable miTabla = new DataTable();
            string filtro = "SELECT * FROM CLIENTES";
            SqlCommand cmd = new SqlCommand(filtro, conexion.Conectar());
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            adaptador.Fill(miTabla);
            return miTabla;  
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                //conexion.Conectar();
                string insertar = "INSERT INTO CLIENTES(ID_CTE, NOM_CTE, DIR_CTE, TEL_CTE, CIU_CTE) VALUES(@ID, @NOMBRE, @DIRECCION, @TELEFONO, @CIUDAD)";
                SqlCommand cmd1 = new SqlCommand(insertar, conexion.Conectar());
                cmd1.Parameters.AddWithValue("@ID", txtID.Text);
                cmd1.Parameters.AddWithValue("@NOMBRE", txtNombre.Text);
                cmd1.Parameters.AddWithValue("@DIRECCION", txtDireccion.Text);
                cmd1.Parameters.AddWithValue("@TELEFONO", txtTelefono.Text);
                cmd1.Parameters.AddWithValue("@CIUDAD", txtCiudad.Text);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("¡Los datos se agregaron con éxito!",this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGClientes.DataSource = Llenar();
            }
            catch (Exception err)
            {
                MessageBox.Show("¡Los datos no tienen el formato correcto o el cliente ya existe!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Focus();
            }
       }

        private void DGClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = 0;
            foreach (Control ctrl in panel1.Controls)
            {
                Type t = ctrl.GetType();
                if (t.Equals(typeof(TextBox)))
                {
                    ctrl.Text = DGClientes.CurrentRow.Cells[i].Value.ToString();
                    ++i;
                }
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //conexion.Conectar();
            string actualizar = "UPDATE CLIENTES SET ID_CTE=@ID, NOM_CTE=@NOMBRE, DIR_CTE=@DIRECCION, TEL_CTE=@TELEFONO, CIU_CTE=@CIUDAD WHERE ID_CTE=@ID";
            SqlCommand cmd2 = new SqlCommand(actualizar, conexion.Conectar());
            cmd2.Parameters.AddWithValue("@ID", txtID.Text);
            cmd2.Parameters.AddWithValue("@NOMBRE", txtNombre.Text);
            cmd2.Parameters.AddWithValue("@DIRECCION", txtDireccion.Text);
            cmd2.Parameters.AddWithValue("@TELEFONO", txtTelefono.Text);
            cmd2.Parameters.AddWithValue("@CIUDAD", txtCiudad.Text);
            cmd2.ExecuteNonQuery();
            MessageBox.Show("¡Los datos han sido actualizados!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            DGClientes.DataSource = Llenar();

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (txtID.Text =="")
            {
                MessageBox.Show("¡No has seleccionado al cliente!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 

                try
                {
                   //conexion.Conectar();
                   string eliminar = "DELETE FROM CLIENTES WHERE ID_CTE=@ID";
                   SqlCommand cmd3 = new SqlCommand(eliminar, conexion.Conectar());
                   cmd3.Parameters.AddWithValue("@ID", txtID.Text);
                   DialogResult resp = MessageBox.Show("¿Estás seguro de eliminar al cliente",
                       "Clientes", MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question);
                  if (resp == DialogResult.Yes)
                  {
                      cmd3.ExecuteNonQuery();
                      MessageBox.Show("¡Los datos fueron eliminados con éxito!", 
                          "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                          DGClientes.DataSource = Llenar();
                  }
                }
            
                catch(Exception err)
                {
                    MessageBox.Show("¡Los datos no tienen el formato correcto!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtID.Focus();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in panel1.Controls)
            {
                Type t = ctrl.GetType();
                if (t.Equals(typeof(TextBox)))
                {
                    ctrl.Text = "";
                }
            }
            txtID.Focus();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resp = MessageBox.Show("¿Está seguro que desea salir de la aplicación?", 
                this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            conexion.Desconectar();
        }
    } //CIERRA EL CLASS
} //CIERRA EL NAMESPACE
