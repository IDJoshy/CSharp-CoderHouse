using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joshua_Auristondo
{
    public class Producto
    {
        #region Properties
        //Id, Descripcion, Costo, PrecioVenta, Stock, IdUsuario


        private int _id;
        private int _idUsuario;

        private string _descripcion;
        private double _costo;

        private double _precioVenta;
        private int _stock;


        #endregion

        //Constructor (Default)

        public Producto()
        {
            this._id = 0;
            this._idUsuario = 0;
            this._descripcion = string.Empty;
            this._costo = 0;
            this._precioVenta = 0;
            this._stock = 0;
        }

        //Constructor Parametrizado

        public Producto(int id, int idUsuario, string descripcion, double costo, double precioVenta, int stock)
        {
            this._id = id;
            this._idUsuario = idUsuario;
            this._descripcion = descripcion;
            this._costo = costo;
            this._precioVenta = precioVenta;
            this._stock = stock;
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
        public string Descripcion
        {
            get { return this._descripcion; }
            set { this._descripcion = value; }
        }
        public double Costo
        {
            get { return this._costo; }
            set { this._costo = value; }
        }
        public double PrecioVenta
        {
            get { return this._precioVenta; }
            set { this._precioVenta = value; }
        }
        public int Stock
        {
            get { return this._stock; }
            set { this._stock = value; }
        }
        #endregion
    }
}
