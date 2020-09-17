using System;
using System.Collections.Generic;
using System.Text;

namespace Compilador2020.Scanner
{
    public class AFD
    {
        private int estado;
        private string leyendo;
        private int nEstado;
        private string lee;

        public AFD()
        {
        }

        public int Estado { get => estado; set => estado = value; }
        public string Leyendo { get => leyendo; set => leyendo = value; }
        public int NEstado { get => nEstado; set => nEstado = value; }
        public string Lee { get => lee; set => lee = value; }
    }
}
