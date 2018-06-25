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
        private char rol;

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

        public User(int id, string nickname, string email, string password, int edad, char rol, char activo)
        {
            this.Id = id;
            this.Nickname = nickname;
            this.Email = email;
            this.Password = password;
            this.Edad = edad;
            this.Rol = rol;
            this.Activo = activo;
        }
        public User(string nickname, string email, string password, int edad)
        {
            this.Id = 0;
            this.Nickname = nickname;
            this.Email = email;
            this.Password = password;
            this.Edad = edad;
            this.Rol = 'C';
            this.Activo = 'A';
        }
        public User()
        {

            this.Id = 0;
                this.Nickname  = "";
            this.Email  = "";
            this.Password  = "";
            this.Edad  = 0;
            this.Rol = 'B';
            this.Activo  = 'I';
        }

    
        override 
        public String ToString()
        {
            return this.Nickname + " - " + this.Email + " - "+this.Password;
        }
    }
}
