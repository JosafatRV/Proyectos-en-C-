using System;
using System.Collections.Generic;
using System.Text;

namespace TrabajoUnidad2VictorJosafat
{
    internal class Poliza
    {
        private string codigo;
        private string tipo;
        private int vigencia;
        private double valorUF;
        private double coberturaUF;

        public Poliza(string codigo, string tipo, int vigencia, double valorUF, double coberturaUF)
        {
            this.codigo = codigo;
            this.tipo = tipo;
            this.vigencia = vigencia;
            this.valorUF = valorUF;
            this.coberturaUF = coberturaUF;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Vigencia { get => vigencia; set => vigencia = value; }
        public double ValorUF { get => valorUF; set => valorUF = value; }
        public double CoberturaUF { get => coberturaUF; set => coberturaUF = value; }

        public override string ToString()
        {
            return $"{codigo} - {tipo} - Vigencia: {vigencia} - Valor UF: {valorUF} - Cobertura UF: {coberturaUF}";
        }
    }
}
