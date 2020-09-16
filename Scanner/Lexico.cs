using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Controls;

namespace Compilador2020.Scanner
{
    class Lexico
    {
        //Declarar tipos de datos globales
        public static List<AFD> listAFD = new List<AFD>();
        public static List<Tokens> listAlfabeto = new List<Tokens>();
        public static List<TDS> listTDS = new List<TDS>();
        public static List<Tokens> lista_tokens_reconocidos = new List<Tokens>();

        //Carga los archivos .xml y los guarda en un DataSet
        DataView CargarXML(string archivo)
        {
            string ruta = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Scanner\FilesLexico\");
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(ruta + archivo);
            //retorna tipo DataView
            return dataSet.Tables[0].DefaultView;
        }

        // Cargar el DataSet con mi alfabeto en un listToken de tipo Tokens
        public List<Tokens> Cargar_Alfabeto(DataGrid Tabla)
        {
            Tabla.ItemsSource = CargarXML("alfabeto.xml");
            int filas = Tabla.Items.Count - 1;
            Tokens token = new Tokens();
            for (int i = 0; i < filas; i++)
            {
                token.NumeroToken = int.Parse((Tabla.Items[i] as DataRowView).Row.ItemArray[0] + "");
                token.SinonimoToken = (string)(Tabla.Items[i] as DataRowView).Row.ItemArray[1];
                token.NombreToken = (string)(Tabla.Items[i] as DataRowView).Row.ItemArray[2];
                token.LexemaToken = (string)(Tabla.Items[i] as DataRowView).Row.ItemArray[3];
                listAlfabeto.Add(token);
            }
            return listAlfabeto;
        }

        // Cargar el DataSet con mi AFD en un listafd de tipo AFD
        public List<AFD> Cargar_AFD(DataGrid Tabla)
        {
            Tabla.ItemsSource = CargarXML("AFD.xml");
            int filas = Tabla.Items.Count - 1;
            AFD afd = new AFD();
            for (int i = 0; i < filas; i++)
            {
                afd.EstadoInicial = int.Parse((Tabla.Items[i] as DataRowView).Row.ItemArray[0] + "");
                afd.Leyendo = (string)(Tabla.Items[i] as DataRowView).Row.ItemArray[1];
                afd.EstadoFinal = int.Parse((Tabla.Items[i] as DataRowView).Row.ItemArray[2] + "");
                listAFD.Add(afd);
            }
            return listAFD;
        }

        // Aperturar el archivo fuente de entrada
        public string text_file_name = Cargar_Archivo_Fuente();

        // Proceso de ir reconociendo los tokens
        //int err = Reconocedor_Lexico();

        // Funcion que carga el archivo fuente a compilar
        public static string Cargar_Archivo_Fuente()
        {
            string ruta_file = Path.GetFullPath("../../../Scanner/FilesLexico");
            // Perdir el nombre de archivo a compliar
            string texto_archivo_fuente = CodigoFuente(ruta_file);
            // Subir a una estructura para ir leyendo caracter por caracter

            return texto_archivo_fuente;
        }

        static string CodigoFuente(string ruta)
        {
            string texto_archivo = File.ReadAllText(ruta + "\\ejemplo.txt");
            return texto_archivo;
        }

        // Funciones de movimientos
        public int Reconocedor_Lexico()
        {
            int estado = 0;
            int newestado = 0;
            int nidentificador = 0;
            char simbolo;
            string lexema = null;
            Tokens tk = new Tokens();
            string[] palabras = null;
            int j;

            //Formateando el texto
            string[] listaFilas = text_file_name.Trim().Split("\n");
            foreach (string linea in listaFilas)
            {
                palabras = linea.Trim().Split(' ','#');
            }

            int error = 0;
            //Recorremos las palabras para ir reconociendo token por toke
            for (int cont = 0; cont < palabras.Length; cont++)
            {
                string palabra = palabras[cont];
                j = 0;
                while (j < palabra.Length)
                {
                    simbolo = palabra[j];
                    newestado = Movimiento_AFD(estado, simbolo);
                    if (newestado == 999)
                    {
                        // presentar mensaje de error
                        error = 999;
                        j++;
                        continue;
                    }
                    if (newestado < 0)
                    {
                        // reconocio un token
                        newestado = -newestado;
                        tk.NumeroToken = newestado;
                        tk = Buscar_Token(newestado);
                        tk.LexemaToken = lexema;
                        lista_tokens_reconocidos.Add(tk);
                        if (tk.NumeroToken == 0)
                        {
                            // es un identificador
                            TDS identificador = new TDS();
                            //Verificar que tipo de dato es

                            // almacenarlo en la TDS
                            identificador.Nombre = lexema;
                            identificador.Numero = nidentificador++;
                            listTDS.Add(identificador);
                        }
                    }
                    lexema += simbolo;
                    estado = newestado;
                    j++;
                }
            }
            return error;
        }



        private static int Movimiento_AFD(int estado, char simbolo)
        {
            int caso = 0;
            if (char.IsLetter(simbolo))
            {
                //es una letra
                caso = 2;
                //caso mayuscula
                if (char.IsUpper(simbolo))
                {
                    caso = 1;
                }
            }
            else if (char.IsDigit(simbolo))
            {
                //caso digito
                caso = 3;
            }
            else
            {
                //validar que el simbolo exista en nuestro alfabeto
                //caso ha sido otro caracter
                caso = 4;
            }
            foreach (AFD transicion in listAFD)
            {
                if (transicion.EstadoInicial == estado)
                {
                    if ((transicion.Leyendo.Equals("letra") && caso == 2) ||
                        (transicion.Leyendo.Equals("mayuscula") && caso == 1) ||
                        (transicion.Leyendo.Equals("digito") && caso == 3) ||
                        (transicion.Leyendo.Equals("simbolo") && caso == 4))
                    {
                        return transicion.EstadoFinal;
                    }
                    if (transicion.Leyendo.Equals(simbolo))
                    {
                        return transicion.EstadoFinal;
                    }
                }
            }
            return 999;
        }

        public static Tokens Buscar_Token(int numToken)
        {
            Tokens token = new Tokens();
            foreach (Tokens item in listAlfabeto)
            {
                if (item.NumeroToken == numToken)
                {
                    token = item;
                }
            }
            return token;
        }
    }
}
