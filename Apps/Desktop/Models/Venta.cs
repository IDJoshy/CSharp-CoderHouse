using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Models
{
    public class Venta
    {
        private int _id;
        private string _comentarios;
        private int _idUsuario;

        public Venta() 
        {
            _id = 0;
            _comentarios = string.Empty;
            _idUsuario = 0;
        }
        public Venta(int id, string comentario, int idUsuario)
        {
            _id = id;
            _comentarios = comentario;
            _idUsuario = idUsuario;
        }

        public int Id { get; set; }
        public string Comentarios 
        {
            get { return _comentarios; } set { _comentarios = value; } 
        }
        public int IdUsuario { get; set; }
    }
}
