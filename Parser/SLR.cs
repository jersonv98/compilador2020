using System;
using System.Collections.Generic;
using System.Text;

namespace Compilador2020.Parser
{
    class SLR
    {
        private int estado;
        private string simbolosLeyendo;
        private int newestado;

        //public SLR()
        //{
        //}

        //public SLR(int estado, string simbolosLeyendo, int newestado)
        //{
        //    this.Estado = estado;
        //    this.SimbolosLeyendo = simbolosLeyendo;
        //    this.Newestado = newestado;
        //}

        public int Estado { get => estado; set => estado = value; }
        public string SimbolosLeyendo { get => simbolosLeyendo; set => simbolosLeyendo = value; }
        public int Newestado { get => newestado; set => newestado = value; }
    }
}
