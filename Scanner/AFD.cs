using System;
using System.Collections.Generic;
using System.Text;

namespace Compilador2020.Scanner
{
    public class AFD
    {
        private int estadoInicial;
        private String leyendo;
        private int estadoFinal;

        public AFD(int estadoInicial, string leyendo, int estadoFinal)
        {
            this.estadoInicial = estadoInicial;
            this.leyendo = leyendo;
            this.estadoFinal = estadoFinal;
        }

        public AFD()
        {
        }

        public int EstadoInicial { get => estadoInicial; set => estadoInicial = value; }
        public string Leyendo { get => leyendo; set => leyendo = value; }
        public int EstadoFinal { get => estadoFinal; set => estadoFinal = value; }
    }
}
