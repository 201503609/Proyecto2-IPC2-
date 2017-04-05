using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace _IPC2_Proyecto2
{
    class Conexion
    {
        private SqlConnection cn;
        public string stringConexion = @"Data Source=DIEGO\sqlexpress;Initial Catalog=BugTracker;Integrated Security=True";

        public SqlConnection getSqlConnection()
        {
            return this.cn;
        }

        private Conexion()
        {
            try
            {
                cn = new SqlConnection(stringConexion);
                cn.Open();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Se ha detectado un error al intentar hacer la conexión " + e.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no controlado " + ex.Message);
            }
        }

        public static Conexion conectar()
        {
            Conexion cnn = new Conexion();
            return cnn;
        }

        public void finalizar()
        {
            if (this.cn != null)
            {
                this.cn.Close();
            }
        }

    }
}