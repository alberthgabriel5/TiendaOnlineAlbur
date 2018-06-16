using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    

    class User
    {
        private String nickname;
        private String email;
        private String password;
        private int edad;
        private char rol;
        private char activo;

        public User(string nickname, string email, string password, int edad, char rol, char activo)
        {
            this.nickname = nickname;
            this.email = email;
            this.password = password;
            this.edad = edad;
            this.rol = rol;
            this.activo = activo;
        }
        public User()
        {
            this.nickname = "";
            this.email = "";
            this.password = "";
            this.edad = 0;
            this.rol = 'B';
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

        public char Rol
        {
            get
            {
                return rol;
            }

            set
            {
                rol = value;
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
    }
}
