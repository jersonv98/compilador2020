using System;
using System.Collections.Generic;
using System.Text;

namespace Compilador2020.Parser
{
    class Errores
    {
        private int numError;
        private string mensaje;

        public int NumError { get => numError; set => numError = value; }
        public string Mensaje { get => mensaje; set => mensaje = value; }
    }
}
