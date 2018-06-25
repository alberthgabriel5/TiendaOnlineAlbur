using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class UserBusiness
    {
        private UserData userData;

        public UserBusiness(String connString)
        {
            this.userData = new UserData(connString);
        }
        public string insertUser(User user)
        {
            return this.userData.insertarUser(user);
        }//insertar
        public LinkedList<User> obtenerUsuarios()
        {
            return this.userData.obtenerUsuarios();
        }//obtenerPersona
        public String eliminarUsuario(int Id)
        {
            return this.userData.eliminarUsuario(Id);
        }
        public User actualizarUsuario(User usuario)
        {
            return this.userData.actualizarUsuario(usuario);
        }
        public User obtenerUsuario(string name, string pass)
        {
            return this.userData.obtenerUsuario(name,pass);
        }//insertar
        public User obtenerUsuario(int id)
        {
            return this.userData.obtenerUsuario(id);
        }//insertar

    }
}
