using System;
using System.Collections.Generic;
using System.Text;

namespace Compilador2020.Scanner
{
    public class TDS
    {
        private int numero;
        private String nombre;
        private int tipo;
        private int size;
        private object valor;

        public TDS(int numero, string nombre, int tipo, int size, object valor)
        {
            this.numero = numero;
            this.nombre = nombre;
            this.tipo = tipo;
            this.size = size;
            this.valor = valor;
        }

        public TDS()
        {
        }

        public int Numero { get => numero; set => numero = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public int Size { get => size; set => size = value; }
        public object Valor { get => valor; set => valor = value; }
    }
}
