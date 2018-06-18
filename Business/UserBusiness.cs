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
        public User insertUser(User user)
        {
            return this.userData.insertarUser(user);
        }//insertar
        public LinkedList<User> obtenerUsuarios()
        {
            return this.userData.obtenerUsuarios();
        }//obtenerPersona
    }
}
