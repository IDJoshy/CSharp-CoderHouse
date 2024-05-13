using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joshua_Auristondo
{
    public class Venta
    {
        #region Properties
        //Id, IdProducto, Stock, IdVenta 

        private int _id;
        private int _idUsuario;
        private string _comentarios;


        #endregion

        //Constructor (Default)

        public Venta()
        {
            this._id = 0;
            this._idUsuario = 0;
            this._comentarios = string.Empty;
        }

        //Constructor Parametrizado

        public Venta(int id, int idUsuario, string comentarios)
        {
            this._id = id;
            this._idUsuario = idUsuario;
            this._comentarios = comentarios;
        }

        #region Setters - Getters
        public int ID
        {
            get { return this._id; }
            set { this._id = value; }
        }
        public int IDUsuario
        {
            get { return this._idUsuario; }
            set { this._idUsuario = value; }
        }
        public string Comentarios
        { 
            get { return this._comentarios; } 
            set { this._comentarios = value; }
        }
        #endregion
    }
}
