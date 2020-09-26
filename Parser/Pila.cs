using System;
using System.Collections.Generic;
using System.Text;

namespace Compilador2020.Parser
{
    class Pila
    {
        private string pilaSintactica;

        public string PilaSintactica { get => pilaSintactica; set => pilaSintactica = value; }

        public Pila(string pila)
        {
            this.PilaSintactica = pila;
        }

        public Pila()
        {
        }
    }
}
