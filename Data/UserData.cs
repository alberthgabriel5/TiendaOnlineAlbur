using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{

    public class UserData
    {
        private String connString;

        public UserData(string connString)
        {
            this.connString = connString;
        }
        public User insertarUser(User usuario)
        {
            SqlConnection connection = new SqlConnection(this.connString);
            String sqlStoreProcedure = "sp_Agregar_Usuario";
            SqlCommand cmdInsertar = new SqlCommand(sqlStoreProcedure, connection);
            cmdInsertar.CommandType = System.Data.CommandType.StoredProcedure;
            //(  @contraseniaUsuario VARCHAR(40), @edad SMALLINT
            cmdInsertar.Parameters.Add(new SqlParameter("@nombreUsuario", usuario.Nickname));
            cmdInsertar.Parameters.Add(new SqlParameter("@emailUsuario", usuario.Email));
            cmdInsertar.Parameters.Add(new SqlParameter("@contraseniaUsuario", usuario.Password));
            cmdInsertar.Parameters.Add(new SqlParameter("@edad", usuario.Edad));

            cmdInsertar.Connection.Open();
            cmdInsertar.ExecuteNonQuery();
            cmdInsertar.Connection.Close();
            return usuario;
        }//insertar usuario

        public LinkedList<User> obtenerUsuarios()
        {
            SqlConnection connection = new SqlConnection(this.connString);
            String sqlSelect = "sp_Obtener_Todos_Usuarios";
            SqlDataAdapter sqlDataAdapterClient = new SqlDataAdapter();
            sqlDataAdapterClient.SelectCommand = new SqlCommand();
            sqlDataAdapterClient.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterClient.SelectCommand.Connection = connection;

            DataSet dataSetUsario = new DataSet();
            sqlDataAdapterClient.Fill(dataSetUsario, "Usuario");
            sqlDataAdapterClient.SelectCommand.Connection.Close();

            DataRowCollection dataRowCollection = dataSetUsario.Tables["Usuario"].Rows;
            LinkedList<User> personas = new LinkedList<User>();

            foreach (DataRow currentRow in dataRowCollection)
            {
                User usuarioActual = new User();
                usuarioActual.Id = int.Parse(currentRow["id_Usuario"].ToString());
                usuarioActual.Nickname = currentRow["nombreUsuario"].ToString();
                usuarioActual.Email = currentRow["emailUsuario"].ToString();
                usuarioActual.Password = currentRow["contraseniaUsuario"].ToString();
                usuarioActual.Edad = int.Parse(currentRow["edad"].ToString());
                usuarioActual.Activo = 'A';

                personas.AddLast(usuarioActual);
            }//foreach
            return personas;
        }//obtener usuarios

        public User obtenerUsuario()
        {
            SqlConnection connection = new SqlConnection(this.connString);
            String sqlSelect = "sp_Obtener_Usuario";//Verificar procedimiento SQL 
            SqlDataAdapter sqlDataAdapterClient = new SqlDataAdapter();
            sqlDataAdapterClient.SelectCommand = new SqlCommand();
            sqlDataAdapterClient.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterClient.SelectCommand.Connection = connection;

            DataSet dataSetUsario = new DataSet();
            sqlDataAdapterClient.Fill(dataSetUsario, "Usuario");
            sqlDataAdapterClient.SelectCommand.Connection.Close();

            DataRowCollection dataRowCollection = dataSetUsario.Tables["Usuario"].Rows;
            
            User usuarioActual = new User();
            foreach (DataRow currentRow in dataRowCollection)
            {                
                usuarioActual.Id = int.Parse(currentRow["id_Usuario"].ToString());
                usuarioActual.Nickname = currentRow["nombreUsuario"].ToString();
                usuarioActual.Email = currentRow["emailUsuario"].ToString();
                usuarioActual.Password = currentRow["contraseniaUsuario"].ToString();
                usuarioActual.Edad = int.Parse(currentRow["edad"].ToString());
                usuarioActual.Activo = 'A';                
            }//foreach
            return usuarioActual;
        }//obtener usuario

        public String actualizarUsuario(User usuario)
        {
            return "";
        }
    }
}
