using Domain;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ArticuloBusiness
    {
       
            private ArticuloData articuloData;

            public ArticuloBusiness(String connString)
            {
                this.articuloData = new ArticuloData(connString);
            } // constructor

            public Articulo insertarArticulo(Articulo articulo)
            {
                return this.articuloData.insertarArticulo(articulo);
            } // insertarArticulo

            public LinkedList<Articulo> obtenerArticulo()
            {
                return this.articuloData.obtenerArticulo();
            } // obtenerArticulo

            public void borrarArticulo(int id)
            {
                this.articuloData.borrarArticulo(id);
            }//borrarArticulo

            public String actualizarArticulo(Articulo articulo)
            {
                return this.articuloData.actualizarArticulo(articulo);
            }//ActualizarArticulo
        }
    
}
