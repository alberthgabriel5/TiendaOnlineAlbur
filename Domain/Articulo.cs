using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Articulo
    {
        private int id;
        private String nombre;
        private String categoria;
        private int precio;
        private String descripcion;
        private String imagen;
        private char estado;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Categoria
        {
            get
            {
                return categoria;
            }

            set
            {
                categoria = value;
            }
        }

        public int Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public string Imagen
        {
            get
            {
                return imagen;
            }

            set
            {
                imagen = value;
            }
        }

        public char Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public Articulo()
        {
            this.Id = 0;
            this.Nombre = "";
            this.Categoria = "";
            this.Precio = 0;
            this.Descripcion = "";
            this.Imagen = "";
            this.Estado = ' ';
        }

        public Articulo(int id, string nombre, string categoria, int precio, string descripcion, string imagen, char estado)
        {
            this.id = id;
            this.nombre = nombre;
            this.categoria = categoria;
            this.precio = precio;
            this.descripcion = descripcion;
            this.imagen = imagen;
            this.estado = estado;
        }
    }
}
