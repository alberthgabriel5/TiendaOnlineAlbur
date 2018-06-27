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
    public class ArticuloData
    {
        private String connString;

        public ArticuloData(String connString)
        {
            this.connString = connString;
        } // constructor

        public String insertarArticulo(Articulo articulo)
        {
            try
            {
                
            SqlConnection connection = new SqlConnection(this.connString);
            String sqlStoredProcedure = "sp_Agregar_Articulo";//cambiar
            SqlCommand cmdInsertar = new SqlCommand(sqlStoredProcedure, connection);
            cmdInsertar.CommandType = System.Data.CommandType.StoredProcedure;

            cmdInsertar.Parameters.Add(new SqlParameter("@nombre", articulo.Nombre));
            cmdInsertar.Parameters.Add(new SqlParameter("@categoria", articulo.Categoria));
            cmdInsertar.Parameters.Add(new SqlParameter("@precio", articulo.Precio));
            cmdInsertar.Parameters.Add(new SqlParameter("@descripcion", articulo.Descripcion));
            cmdInsertar.Parameters.Add(new SqlParameter("@imagen", articulo.Imagen));
            //cmdInsertar.Parameters.Add(new SqlParameter("@activo", articulo.Estado));

            cmdInsertar.Connection.Open();
            cmdInsertar.ExecuteNonQuery();
            cmdInsertar.Connection.Close();
                return "Success";
            }
            catch
            {
                return "Error";
            }


            
        } // insertarArticulo

        public LinkedList<Articulo> obtenerArticulo()
        {
            SqlConnection connection = new SqlConnection(this.connString);
            String sqlSelect = "sp_Obtener_Todos_Articulos";

            SqlDataAdapter sqlDataAdapterClient = new SqlDataAdapter();
            sqlDataAdapterClient.SelectCommand = new SqlCommand();
            sqlDataAdapterClient.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterClient.SelectCommand.Connection = connection;

            System.Data.DataSet dataSetPersonas = new DataSet();
            sqlDataAdapterClient.Fill(dataSetPersonas, "Articulo"); // tbArticulo
            sqlDataAdapterClient.SelectCommand.Connection.Close();

            DataRowCollection dataRowCollection = dataSetPersonas.Tables["Articulo"].Rows;
            LinkedList<Articulo> articulos = new LinkedList<Articulo>();

            foreach (DataRow currentRow in dataRowCollection)
            {
                Articulo articuloActual = new Articulo();
                articuloActual.Nombre = currentRow["nombre"].ToString();
                articuloActual.Categoria = currentRow["categoria"].ToString();
                articuloActual.Precio = int.Parse(currentRow["precio"].ToString());
                articuloActual.Descripcion = currentRow["descripcion"].ToString();
                articuloActual.Imagen = currentRow["imagen"].ToString();
                articuloActual.Estado = char.Parse(currentRow["activo"].ToString());
                articulos.AddLast(articuloActual);
            } // foreeach


            return articulos;
        } // obtenerArticulo

        public void borrarArticulo(int id)
        {
            SqlConnection connection = new SqlConnection(this.connString);
            String sqlStoredProcedure = "sp_Eliminar_Articulo";//cambiar
            SqlCommand cmdBorrar = new SqlCommand(sqlStoredProcedure, connection);
            cmdBorrar.CommandType = System.Data.CommandType.StoredProcedure;
            cmdBorrar.Parameters.Add(new SqlParameter("@id_Articulo", id));
            cmdBorrar.Connection.Open();
            cmdBorrar.ExecuteNonQuery();
            cmdBorrar.Connection.Close();
        }

        //int id, String nombre, String categoria, float precio, String descripcion, String imagen, int estado)
        public String actualizarArticulo(Articulo articulo)
        {
            try { 
            SqlConnection connection = new SqlConnection(this.connString);
            String sqlStoredProcedure = "sp_Actualizar_Articulo";//cambiar
            SqlCommand cmdBorrar = new SqlCommand(sqlStoredProcedure, connection);
            cmdBorrar.CommandType = System.Data.CommandType.StoredProcedure;
            cmdBorrar.Parameters.Add(new SqlParameter("@id_Articulo", articulo.Id));
            cmdBorrar.Parameters.Add(new SqlParameter("@nombre", articulo.Nombre));
            cmdBorrar.Parameters.Add(new SqlParameter("@categoria", articulo.Categoria));
            cmdBorrar.Parameters.Add(new SqlParameter("@precio", articulo.Precio));
            cmdBorrar.Parameters.Add(new SqlParameter("@descripcion", articulo.Descripcion));
            cmdBorrar.Parameters.Add(new SqlParameter("@imagen", articulo.Imagen));
            cmdBorrar.Parameters.Add(new SqlParameter("@activo", articulo.Estado));
            cmdBorrar.Connection.Open();
            cmdBorrar.ExecuteNonQuery();
            cmdBorrar.Connection.Close();

            return "Success";
        } catch
            {
                return "Error";
            }
            
        }
}
}
