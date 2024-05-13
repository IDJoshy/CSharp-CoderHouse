using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Joshua_Auristondo
{
    public class Usuario
    {
        #region Properties

        private int _id;
        private string _nombre;
        private string _apellido;

        private string _nombreUsuario;
        private string _contraseña;
        private string _email;

        #endregion

        //Constructor (Default)

        public Usuario()
        {
            this._id = 0;
            this._nombre = string.Empty;
            this._apellido = string.Empty;

            this._nombreUsuario = string.Empty;
            this._contraseña = string.Empty;
            this._email = string.Empty;
        }

        //Constructor Parametrizado

        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contraseña, string email)
        {
            this._id = id;
            this._nombre = nombre;
            this._apellido = apellido;
            this._nombreUsuario = nombreUsuario;
            this._contraseña = contraseña;
            this._email = email;
        }

        #region Setters - Getters
        public int ID
        {
            get { return this._id; }
            set { this._id = value; }
        }
        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }
        public string Apellido
        {
            get { return this._apellido; }
            set { this._apellido = value; }
        }

        public string NombreUsuario
        {
            get { return this._nombreUsuario; }
            set { this.NombreUsuario = value; }
        }
        public string Contraseña 
        { 
            get { return this._contraseña; }
            set { this._contraseña = value; }
        }
        public string Email 
        {
            get { return this._email; }
            set { this._email = value; }
        }
        #endregion
    }
}
