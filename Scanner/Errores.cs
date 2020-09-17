using System;
using System.Collections.Generic;
using System.Text;

namespace Compilador2020.Scanner
{
    public class Errores
    {
        private int numError;
        private string mensajeError;

        public Errores()
        {
        }

        public int NumError { get => numError; set => numError = value; }
        public string MensajeError { get => mensajeError; set => mensajeError = value; }
    }
}
