using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProductosRojas
{
    public class Producto
    {
        // Atributos
        private int codigo;
        private string descripcion;
        private string tipo;
        private int precio;
        private int stock;

        // Constructor
        public Producto(int codigo, string descripcion, string tipo, int precio, int stock)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.tipo = tipo;
            this.precio = precio;
            this.stock = stock;
        }

        // Propiedades
        public int Codigo
        {
            get { return codigo; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        // Getters
        public int GetCodigo()
        {
            return codigo;
        }

        public string GetDescripcion()
        {
            return descripcion;
        }

        public string GetTipo()
        {
            return tipo;
        }

        public int GetPrecio()
        {
            return precio;
        }

        public int GetStock()
        {
            return stock;
        }

        // Setters
        public void SetCodigo(int newCodigo)
        {
            codigo = newCodigo;
        }

        public void SetDescripcion(string newDescripcion)
        {
            descripcion = newDescripcion;
        }

        public void SetTipo(string newTipo)
        {
            tipo = newTipo;
        }

        public void SetPrecio(int newPrecio)
        {
            precio = newPrecio;
        }

        // Metodo de Control de Stock
        public void SetStock(int newStock)
        {
            stock = newStock;
        }
        public bool ControlStock(int cantidad)
        {
            if (stock >= cantidad)
            {
                stock = stock - cantidad;
                return true;
            }
            else
            {
                return false;
            }
        }
        // Metodo para estimar el costo de venta
        public int EstimarCostoVenta(int cantidad)
        {
            int total = precio * cantidad;
            return total;
        }
    }

}