using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rojas_Josafat_Trabajo1
{
    public class Producto
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int Valor { get; set; }
        public int Stock { get; set; }

        public Producto(int codigo, string nombre, string tipo, int valor, int stock)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Tipo   = tipo;
            this.Valor  = valor;
            this.Stock  = stock;
        }
    }
}
