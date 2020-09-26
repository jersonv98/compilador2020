using System;
using System.Collections.Generic;
using System.Text;

namespace Compilador2020.Parser
{
    class Reglas
    {
        private int numeroRegla;
        private string parteIzq;
        private string parteDer;

        public int NumeroRegla { get => numeroRegla; set => numeroRegla = value; }
        public string ParteIzq { get => parteIzq; set => parteIzq = value; }
        public string ParteDer { get => parteDer; set => parteDer = value; }
    }
}
