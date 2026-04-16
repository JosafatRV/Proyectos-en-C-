using System;
using System.Collections.Generic;
using System.Text;

namespace TrabajoUnidad2VictorJosafat
{
    internal class ContratoPoliza
    {
        private Cliente cliente;
        private Poliza poliza;
        private double ufDelDia;
        private double valorEnPesos;
        private double coberturaEnPesos;
        private DateTime fechaAdquisicion;

        public ContratoPoliza(Cliente cliente, Poliza poliza, double ufDelDia)
        {
            this.cliente = cliente;
            this.poliza = poliza;
            this.ufDelDia = ufDelDia;

            // Cálculos automáticos
            valorEnPesos = poliza.ValorUF * ufDelDia;
            coberturaEnPesos = poliza.CoberturaUF * ufDelDia;

            fechaAdquisicion = DateTime.Now;
        }

        public Cliente Cliente => cliente;
        public Poliza Poliza => poliza;
        public double UfDelDia => ufDelDia;
        public double ValorEnPesos => valorEnPesos;
        public double CoberturaEnPesos => coberturaEnPesos;
        public DateTime FechaAdquisicion => fechaAdquisicion;

        public override string ToString()
        {
            return $"{cliente.Nombre} {cliente.Apellido} adquirió {poliza.Tipo} el {fechaAdquisicion.ToShortDateString()}";
        }
    }
}
