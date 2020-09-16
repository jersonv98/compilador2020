using System;
using System.Collections.Generic;
using System.Text;

namespace Compilador2020.Scanner
{
    public class Tokens
    {
        private int numeroToken;
        private String sinonimoToken;
        private String nombreToken;
        private String lexemaToken;

        public Tokens(int numeroToken, string sinonimoToken, string nombreToken, string lexemaToken)
        {
            this.numeroToken = numeroToken;
            this.sinonimoToken = sinonimoToken;
            this.nombreToken = nombreToken;
            this.lexemaToken = lexemaToken;
        }

        public Tokens()
        {
        }

        public int NumeroToken { get => numeroToken; set => numeroToken = value; }
        public string SinonimoToken { get => sinonimoToken; set => sinonimoToken = value; }
        public string NombreToken { get => nombreToken; set => nombreToken = value; }
        public string LexemaToken { get => lexemaToken; set => lexemaToken = value; }
    }
}
