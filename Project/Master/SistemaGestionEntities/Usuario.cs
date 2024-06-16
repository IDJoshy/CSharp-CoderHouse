using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities
{
    public class Usuario
    {
        private int _id;
        private string _nombre;
        private string _apellido;
        private string _nombreUsuario;
        private string _contrasenia;
        private string _mail;

        //Constructor

        public Usuario()
        {
            _id = 0;
            _nombre = string.Empty;
            _apellido = string.Empty;
            _nombreUsuario = string.Empty;
            _contrasenia = string.Empty;
            _mail = string.Empty;
        }
        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contrasenia, string Mail)
        {
            this._id = id;
            this._nombre = nombre;
            this._apellido = apellido;
            this._nombreUsuario = nombreUsuario;
            this._contrasenia = contrasenia;
            this._mail = Mail;
        }

        public int Id { get { return this._id; } set { this._id = value; } }
        public string Nombre { get { return this._nombre; } set { this._nombre = value; } }
        public string Apellido { get { return this._apellido; } set { this._apellido = value; } }
        public string NombreUsuario { get { return this._nombreUsuario; } set { this._nombreUsuario = value; } }
        public string Contrasenia { get { return this._contrasenia; } set { this._contrasenia = value; } }
        public string Mail { get { return this._mail; } set { this._mail = value; } }

    }
}