using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace tarea_3_programacion___justin__
{
    class cls_conexion
    {
        private const string ConnectionString = "Data Source=DESKTOP-O767CTB\\SQLEXPRESS;Initial Catalog=TESTER;Integrated Security=True";
        SqlConnection MyCon;
        SqlCommand comand;
        SqlDataReader reader;
        public cls_conexion()
        {
            // User Id="";Password="";
            MyCon = new SqlConnection(ConnectionString);
        }
        public SqlConnection Conectar()
        {
            try
            {
                MyCon.Open();   // abrir conexion 
            }
            catch (Exception x)  // si se produce un error los despliega
            {
                MessageBox.Show("Error :: " + x.ToString());
            }
            return MyCon;       //  return variable de conexion 
        }
        public bool Validar(string user, string password)  // valida usuraio
        {
            bool valido = false;   // estatus del usuario
            string query = @"SELECT id_usuario,pass from dbo.usuario where 
                              id_usuario='" + user + "' and pass ='" + password + "'"; // query valida usuario

            comand = new SqlCommand(query, Conectar());  // ejecuta el query
            reader = comand.ExecuteReader();  // asigna el resultado del select del command al reader

            if (reader.HasRows == true)  // si el reader tiene valor de el select anterior  el estatus es valido(true)
            {
                valido = true;
            }

            return valido; // return estatus del usuario  --
        }

    }

}
