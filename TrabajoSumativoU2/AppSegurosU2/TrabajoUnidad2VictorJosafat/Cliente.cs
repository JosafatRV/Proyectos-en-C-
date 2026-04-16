using System;
using System.Collections.Generic;
using System.Text;

namespace TrabajoUnidad2VictorJosafat
{
    internal class Cliente
    {
        // Atributos privados
        private string rut;
        private string nombre;
        private string apellido;
        private string telefono;

        // Constructor
        public Cliente(string rut, string nombre, string apellido, string telefono)
        {
            this.rut = rut;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
        }

        // Getters y Setters
        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Telefono { get => telefono; set => telefono = value; }

        public override string ToString()
        {
            return $"{rut} - {nombre} {apellido} - Tel: {telefono}";
        }
    }
}
