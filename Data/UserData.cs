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
        public String insertarUser(User usuario)
        {
            try
            {
                
                SqlConnection connection = new SqlConnection(this.connString);
                string sqlStoreProcedure = "sp_Agregar_Usuario";
                SqlCommand cmdInsertar = new SqlCommand(sqlStoreProcedure, connection);
                cmdInsertar.CommandType = System.Data.CommandType.StoredProcedure;
                cmdInsertar.Parameters.Add(new SqlParameter("@nombreUsuario", usuario.Nickname));
                cmdInsertar.Parameters.Add(new SqlParameter("@emailUsuario", usuario.Email));
                cmdInsertar.Parameters.Add(new SqlParameter("@contraseniaUsuario", usuario.Password));
                cmdInsertar.Parameters.Add(new SqlParameter("@edad", usuario.Edad));

                cmdInsertar.Connection.Open();
                cmdInsertar.ExecuteNonQuery();
                cmdInsertar.Connection.Close();
                return "Success";
            } catch
            {
                return "Error";
            }
            
            
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

        public User obtenerUsuario(int id)
        {
            SqlConnection connection = new SqlConnection(this.connString);
            String sqlSelect = "sp_select_user_id";//Verificar procedimiento SQL 
            SqlDataAdapter sqlDataAdapterClient = new SqlDataAdapter();
            sqlDataAdapterClient.SelectCommand = new SqlCommand(sqlSelect, connection);
            sqlDataAdapterClient.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlDataAdapterClient.SelectCommand.Parameters.Add(new SqlParameter("@id_", id));
            sqlDataAdapterClient.SelectCommand.Connection.Open();
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

        public User obtenerUsuario(string name, string pass)
        {

            
            SqlConnection connection = new SqlConnection(this.connString);
            String sqlSelect = "sp_exist_user";//Verificar procedimiento SQL 
            SqlCommand sqlDataAdapterClient = new SqlCommand(sqlSelect, connection);



            sqlDataAdapterClient.CommandType = CommandType.StoredProcedure;
            sqlDataAdapterClient.Parameters.Add(new SqlParameter("@name", name));
            sqlDataAdapterClient.Parameters.Add(new SqlParameter("@pass", pass));
            sqlDataAdapterClient.Connection.Open();
            SqlDataReader reader = sqlDataAdapterClient.ExecuteReader();
            User usuarioActual =null; 
            if (reader.Read())
            {
                usuarioActual= new User();
                usuarioActual.Id = int.Parse(reader.GetValue(0).ToString());
                usuarioActual.Nickname = reader.GetValue(1).ToString();
                usuarioActual.Email = reader.GetValue(2).ToString();
                usuarioActual.Password = reader.GetValue(3).ToString();
                usuarioActual.Edad = int.Parse(reader.GetValue(4).ToString());
                usuarioActual.Rol = char.Parse(reader.GetValue(5).ToString());
                usuarioActual.Activo = char.Parse(reader.GetValue(6).ToString());

             }//if
            return usuarioActual;
        }//obtener usuario

        public User actualizarUsuario(User usuario)
        {
            SqlConnection connection = new SqlConnection(this.connString);
            String sqlStoreProcedure = "sp_Actualizar_Usuario";
            SqlCommand cmdInsertar = new SqlCommand(sqlStoreProcedure, connection);
            cmdInsertar.CommandType = System.Data.CommandType.StoredProcedure;
            cmdInsertar.Parameters.Add(new SqlParameter("@nombreUsuario", usuario.Nickname));
            cmdInsertar.Parameters.Add(new SqlParameter("@emailUsuario", usuario.Email));
            cmdInsertar.Parameters.Add(new SqlParameter("@contraseniaUsuario", usuario.Password));
            cmdInsertar.Parameters.Add(new SqlParameter("@edad", usuario.Edad));

            cmdInsertar.Connection.Open();
            cmdInsertar.ExecuteNonQuery();
            cmdInsertar.Connection.Close();
            return usuario;
        }//actualizar usuario

        public String eliminarUsuario(int Id)
        {
            try
            {
                SqlConnection connection = new SqlConnection(this.connString);
                String sqlStoreProcedure = "sp_Eliminar_Usuario";
                SqlCommand cmdInsertar = new SqlCommand(sqlStoreProcedure, connection);
                cmdInsertar.CommandType = System.Data.CommandType.StoredProcedure;
                cmdInsertar.Parameters.Add(new SqlParameter("@id_Usuario", Id));            

                cmdInsertar.Connection.Open();
                cmdInsertar.ExecuteNonQuery();
                //cmdInsertar.Connection.Close();
                return "Success";
            }
            catch {
                
                return "Error";
            }  
        }
    }
}
