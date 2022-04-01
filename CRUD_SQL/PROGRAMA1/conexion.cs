using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PROGRAMA1
{
    public class conexion
    {
        public static SqlConnection Conectar()
        {
                SqlConnection cn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\DATOS\\BDTIENDA.mdf;Integrated Security = True; Connect Timeout = 30;");
                cn.Open();
                return cn;
        }
        public static SqlConnection Desconectar()
        {
            SqlConnection cn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\DATOS\\BDTIENDA.mdf;Integrated Security = True; Connect Timeout = 30");
            cn.Close();
            return cn;
        }
    }
}
