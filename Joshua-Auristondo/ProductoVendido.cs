using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joshua_Auristondo
{
    public class ProductoVendido
    {
        #region Properties
        //Id, IdProducto, Stock, IdVenta 

        private int _id;
        private int _idProducto;
        private int _idVenta;
        private int _stock;

        #endregion

        //Constructor (Default)

        public ProductoVendido()
        {
            this._id = 0;
            this._idProducto = 0;
            this._idVenta = 0;
            this._stock = 0;
        }

        //Constructor Parametrizado

        public ProductoVendido(int id, int idProducto, int idVenta, int stock)
        {
            this._id = id;
            this._idProducto = idProducto;
            this._idVenta = idVenta;
            this._stock = stock;
        }

        #region Setters - Getters
        public int ID
        {
            get { return this._id; }
            set { this._id = value; }
        }
        public int IDProducto
        {
            get { return this._idProducto; }
            set { this._idProducto = value; }
        }
        public int IDVenta
        {
            get { return this._idVenta; }
            set { this._idVenta = value; }
        }
        public int Stock
        {
            get { return this._stock; }
            set { this._stock = value; }
        }
        #endregion
    }
}
