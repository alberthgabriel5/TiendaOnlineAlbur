using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    

    public class User
    {
        private int id;
        private String nickname;
        private String email;
        private String password;
        private int edad;        
        private char activo;

        public User(int id,string nickname, string email, string password, int edad, char activo)
        {
            this.id = id;
            this.nickname = nickname;
            this.email = email;
            this.password = password;
            this.edad = edad;
            this.activo = activo;
        }
        public User()
        {
            this.nickname = "";
            this.email = "";
            this.password = "";
            this.edad = 0;
            this.activo ='I';
        }

        public string Nickname
        {
            get
            {
                return nickname;
            }

            set
            {
                nickname = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public int Edad
        {
            get
            {
                return edad;
            }

            set
            {
                edad = value;
            }
        }       

        public char Activo
        {
            get
            {
                return activo;
            }

            set
            {
                activo = value;
            }
        }

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
    }
}
