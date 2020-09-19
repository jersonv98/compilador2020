using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Compilador2020.Scanner
{
    class Lexico
    {
        //Declarar tipos de datos globales
        public static List<AFD> listAFD;
        public List<AFD> listMovimientos;
        public List<Tokens> listAlfabeto;
        public List<TDS> listTDS;
        public List<Tokens> list_tokens_reconocidos;
        public static List<Errores> listErrores = new List<Errores>();
        public string text_file_name;
        int aux = 0;

        public Lexico()
        {
            // Aperturar el archivo fuente de entrada
            Cargar_Archivo_Fuente();
        }

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
            int filas = Tabla.Items.Count;
            Tokens token;
            listAlfabeto = new List<Tokens>();
            for (int i = 0; i < filas; i++)
            {
                token = new Tokens()
                {
                    NumeroToken = int.Parse((Tabla.Items[i] as DataRowView).Row.ItemArray[0] + ""),
                    SinonimoToken = (string)(Tabla.Items[i] as DataRowView).Row.ItemArray[1],
                    NombreToken = (string)(Tabla.Items[i] as DataRowView).Row.ItemArray[2],
                    LexemaToken = (string)(Tabla.Items[i] as DataRowView).Row.ItemArray[3]
                };
                listAlfabeto.Add(token);
            }
            return listAlfabeto;
        }

        //Cargar el DataSet con mi AFD en un listafd de tipo AFD
        public List<AFD> Cargar_AFD(DataGrid Tabla)
        {
            Tabla.ItemsSource = CargarXML("AFD.xml");
            int filas = Tabla.Items.Count;
            AFD afd;
            listAFD = new List<AFD>();
            for (int i = 0; i < filas; i++)
            {
                afd = new AFD()
                {
                    Estado = int.Parse((Tabla.Items[i] as DataRowView).Row.ItemArray[0] + ""),
                    Leyendo = (string)(Tabla.Items[i] as DataRowView).Row.ItemArray[1],
                    NEstado = int.Parse((Tabla.Items[i] as DataRowView).Row.ItemArray[2] + "")
                };
                listAFD.Add(afd);
            }
            return listAFD;
        }

        //Cargar lista de errores en un TextBox
        public void Cargar_Errores(DataGrid Datos)
        {
            Datos.ItemsSource = listErrores;
        }



        // Funcion que carga el archivo fuente a compilar
        public string Cargar_Archivo_Fuente()
        {
            string ruta_file = Path.GetFullPath("../../../Scanner/FilesLexico");
            text_file_name = File.ReadAllText(ruta_file + "\\ArchivoPruebaSinErrores.txt");
            return text_file_name;
        }

        //Funciones de movimientos
        public void Reconocedor_Lexico()
        {
            listMovimientos = new List<AFD>();
            list_tokens_reconocidos = new List<Tokens>();
            listErrores = new List<Errores>();
            listTDS = new List<TDS>();
            int estado = 0, newestado = 0, nidentificador = 0;
            char simbolo;
            string lexema = null;

            //Formateando el texto de entrada, tomar en cuenta que al quitar el blando dentro de lo que este en comillas se pondra como #
            //Hacer un replace siempre y cuando no este entre comillas
            text_file_name = text_file_name.Replace('\n', '#').Replace('\t', '#').Replace('\r', '#').Replace(' ', '#')+ '#';
            char[] palabras = text_file_name.ToCharArray();

            int j = 0;
            AFD afd;
            while (j < palabras.Length)
            {
                simbolo = Convert.ToChar(palabras[j]);
                newestado = Movimiento_AFD(estado, simbolo);
                if (!(simbolo.Equals('#') && (estado == 0)))
                {
                    afd = new AFD()
                    {
                        Estado = estado,
                        Leyendo = simbolo.ToString(),
                        NEstado = newestado
                    };
                    if (newestado < 0)
                    {
                        afd.Lee = "Token reconocido " + (-newestado);
                        aux = 0;
                    }
                    listMovimientos.Add(afd);
                }
                if (newestado == 997)
                {
                    Errores miError = new Errores()
                    {
                        NumError = 3,
                        MensajeError = "Error léxico: simbolo " +  simbolo + " no reconocido en el lexema " + lexema
                    };
                    listErrores.Add(miError);
                    estado = 0;
                    lexema = "";
                    j++;
                    aux = 0;
                    while (true)
                    {
                        if (palabras[j] != '#')
                        {
                            j++;
                            continue;
                        }
                        break;
                    }
                    continue;
                }
                if (newestado == 998)
                {
                    estado = 0;
                    lexema = "";
                    j++;
                    continue;
                }
                if (newestado == 999)
                {
                    // presentar mensaje de error
                    Errores miError = new Errores()
                    {
                        NumError = 1,
                        MensajeError = "Error léxico: simbolo " + simbolo + " no reconocido en el lexema " + lexema
                    };
                    listErrores.Add(miError);

                    //vovlemos al estado 0 y lexema para que vuleva a reconocer otro token
                    while (true)
                    {
                        if (palabras[j] != '#')
                        {
                            j++;
                            continue;
                        }
                        break;
                    }
                    estado = 0;
                    lexema = "";
                    j++;
                    continue;
                }
                else if (newestado < 0)
                {
                    // reconocio un token
                    newestado = -newestado;
                    Buscar_Token(newestado, lexema);
                    if (newestado == 1)
                    {
                        //Quedarnos solo con 8 caracteres significativos
                        lexema = lexema.Substring(0, 8);
                        //Se reconoció un identificador, guardar en la tabla de simbolos
                        //almacenarlo en la TDS
                        TDS identificador = new TDS()
                        {
                            Numero = nidentificador++,
                            Nombre = lexema
                        };
                        listTDS.Add(identificador);
                    }
                    estado = 0;
                    lexema = "";
                }
                else
                {
                    if (!simbolo.Equals('#'))
                    {
                        lexema += simbolo;
                    }
                    estado = newestado;
                }
                j++;
            }
        }

        private int Movimiento_AFD(int estado, char simbolo)
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
                // caso digito
                if (aux == 0)
                {
                    caso = 3;
                    if (simbolo == '0' && aux == 0)
                    {
                        aux = 2;
                    }
                    else
                    {
                        aux = 1;
                    }
                }
                else if (simbolo == '0' && aux == 2 || !(simbolo == '0') && aux == 2)
                {
                    return 997;
                }
                else if (aux == 1)
                {
                    caso = 3;
                }
            }
            else
            {
                //validar que el simbolo exista en nuestro alfabeto
                //caso ha sido otro caracter
                string simbolos = "!#$%&|'_<>=:,\"?+-/*().{};\\";
                string simboloString = simbolo.ToString();
                if (!(simbolos.Contains(simboloString) || simbolo.Equals('\"') || simbolo.Equals('\'')))
                {
                    Errores miError = new Errores()
                    {
                        NumError = 2,
                        MensajeError = "Error léxico: simbolo " + simbolo + " no es parte de nuestro lenguaje"
                    };
                    listErrores.Add(miError);
                    return 998;
                }
                caso = 4;
            }
            foreach (AFD transicion in listAFD)
            {
                if (transicion.Estado == estado)
                {
                    if ((transicion.Leyendo.Equals("letra") && caso == 2) ||
                        (transicion.Leyendo.Equals("mayuscula") && caso == 1) ||
                        (transicion.Leyendo.Equals("digito") && caso == 3) ||
                        (transicion.Leyendo.Equals("simbolo") && caso == 4))
                    {
                        return transicion.NEstado;
                    }
                    string letra = simbolo.ToString();
                    if (transicion.Leyendo.Equals(letra))
                    {
                        return transicion.NEstado;
                    }
                }
            }
            return 999;
        }

        public void Buscar_Token(int numToken, string lexema)
        {
            Tokens token; ;
            foreach (Tokens item in listAlfabeto)
            {
                if (item.NumeroToken == numToken)
                {
                    token = new Tokens()
                    {
                        NumeroToken = item.NumeroToken,
                        NombreToken = item.NombreToken,
                        SinonimoToken = item.SinonimoToken,
                        LexemaToken = lexema
                    };
                    //guardar el la lista_tokens_reconocidos
                    list_tokens_reconocidos.Add(token);
                }
            }
        }

    }
}
