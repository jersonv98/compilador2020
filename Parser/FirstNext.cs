using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Compilador2020.Parser
{
    class FirstNext
    {
        private string noTerminal;
        private string first;
        private string next;

        public string NoTerminal { get => noTerminal; set => noTerminal = value; }
        public string First { get => first; set => first = value; }
        public string Next { get => next; set => next = value; }
    }
}
