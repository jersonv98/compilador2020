using Compilador2020.Scanner;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace Compilador2020.Parser
{
    class Sintactico
    {
        Lexico lexico = new Lexico();
        public List<Reglas> listReglas;
        public List<Reglas> listReglasReconocidas;
        public List<FirstNext> listFirstNext;
        public List<SLR> listSLR;
        public List<Errores> listErroresSintactico = new List<Errores>();
        public List<Tokens> listTokensReconocidos = new List<Tokens>();
        public List<TDS> listTDS = new List<TDS>();
        public List<Tokens> listAlfabeto = new List<Tokens>();
        public List<AFD> listMovimientos = new List<AFD>();
        public Stack<object> pilaSintactica = new Stack<object>();
        //public List<List<object>> movimientoPila = new List<List<object>>();
        public List<Pila> movimientoPila = new List<Pila>();
        public int contadorGlobalTokens = 0;

        private void guardarMovimientoPila()
        {
            Pila miPila;
            string pila = "[ ";
            foreach (var item in pilaSintactica.Reverse())
            {
                pila += item + " , ";
            }
            pila += "]";
            miPila = new Pila()
            {
                PilaSintactica = pila
            };
            movimientoPila.Add(miPila);
        }

        public Sintactico(List<Tokens> listTKSReconocidos, List<TDS> list_TDS, List<Tokens> list_Alfabeto)
        {
            //cargar reglas de produccion

            //cargar el automata SLR
            //listSLR = Cargar_Automata_SLR();

            listTokensReconocidos = listTKSReconocidos;

            listTDS = list_TDS;

            listAlfabeto = list_Alfabeto;

            //añadir al final del los tokens reconocidos el $ como
            //fin de terminacion del analizador
            Tokens tk = new Tokens()
            {
                NumeroToken = 1000,
                SinonimoToken = "ñ",
                NombreToken = "fin",
                LexemaToken = "EOF"
            };
            listTokensReconocidos.Add(tk);  
        }

        DataView Cargar_XML(string archivo)
        {
            string ruta = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Parser\FilesSintactico\");
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(ruta + archivo);
            return dataSet.Tables[0].DefaultView;
        }

        public List<Reglas> Cargar_Gramatica(DataGrid Tabla, string xml)
        {
            Tabla.ItemsSource = Cargar_XML(xml);
            int filas = Tabla.Items.Count;
            Reglas reglas;
            listReglas = new List<Reglas>();
            for (int i = 0; i < filas; i++)
            {
                reglas = new Reglas()
                {
                    NumeroRegla = int.Parse((Tabla.Items[i] as DataRowView).Row.ItemArray[0] + ""),
                    ParteIzq = (string)(Tabla.Items[i] as DataRowView).Row.ItemArray[1],
                    ParteDer = (string)(Tabla.Items[i] as DataRowView).Row.ItemArray[2]
                };
                listReglas.Add(reglas);
            }
            return listReglas;
        }

        public List<FirstNext> Cargar_FirstNext(DataGrid Tabla)
        {
            Tabla.ItemsSource = Cargar_XML("FirstNext2.xml");
            int filas = Tabla.Items.Count;
            FirstNext firstNext;
            listFirstNext = new List<FirstNext>();
            for (int i = 0; i < filas; i++)
            {
                firstNext = new FirstNext()
                {
                    NoTerminal = (string)(Tabla.Items[i] as DataRowView).Row.ItemArray[0],
                    First = (string)(Tabla.Items[i] as DataRowView).Row.ItemArray[1],
                    Next = (string)(Tabla.Items[i] as DataRowView).Row.ItemArray[2]
                };
                listFirstNext.Add(firstNext);
            }
            return listFirstNext;
        }

        public List<SLR> Cargar_Automata_SLR(DataGrid Tabla)
        {
            Tabla.ItemsSource = Cargar_XML("MatrizSLR2.xml");
            int filas = Tabla.Items.Count;
            SLR slr;
            listSLR = new List<SLR>();
            for (int i = 0; i < filas; i++)
            {
                slr = new SLR()
                {
                    Estado= int.Parse((Tabla.Items[i] as DataRowView).Row.ItemArray[0] + ""),
                    SimbolosLeyendo = (string)(Tabla.Items[i] as DataRowView).Row.ItemArray[1],
                    Newestado = int.Parse((Tabla.Items[i] as DataRowView).Row.ItemArray[2] + "")
                };
                listSLR.Add(slr);
            }
            return listSLR;
        }

        public void AnalizadorSLR()
        {
            Tokens tk = new Tokens();
            listReglasReconocidas = new List<Reglas>();
            bool band = true;
            string simbolo;
            int estado = 0;
            int newestado = 0;
            int cont = 0;

            //tomar el token 
            tk = listTokensReconocidos[cont];
            simbolo = tk.SinonimoToken;

            //Guarda el movimiento quese hizo en pila
            pilaSintactica.Push(estado);
            guardarMovimientoPila();

            //bucle del reconosedor hasta cuando reconosca Apectar o Error
            while (band)
            {
                // Movernos en la matriz sintactica con el simbolo
                // para buscar el nuevo estado         
                newestado = devolverNuevoEstado(estado, simbolo);
                // Verificar si encontro el nuevo estado
                if (newestado != 997)
                {
                    // Si encontro nuevo estado
                    if (newestado < 0)
                    {
                        //se reconocio regla
                        newestado = -newestado;
                        Reglas rule = devolverRegla(newestado);

                        if (rule == null)
                        {
                            //Error no encontró regla
                            continue;
                        }
                        //Guardar la regla en lista de reglas reconocidas
                        listReglasReconocidas.Add(rule);

                        int cuenta = rule.ParteDer.Length;
                        cuenta = cuenta * 2;
                        // Agregamos a la pila sintactica
                        guardarMovimientoPila();
                        //bajar de la pila
                        for (int i = 0; i < cuenta; i++)
                        {
                            pilaSintactica.Pop();
                        }
                        //encontro la regla y tenemos que sacar la parte izquierda
                        estado = (int)pilaSintactica.Peek();
                        // Guardamos en la pila el no terminal que esta la parte izquierda de la regla
                        pilaSintactica.Push(rule.ParteIzq);
                        //movernos en la SLR para ver a que estado va
                        string s = rule.ParteIzq;
                        newestado = devolverNuevoEstado(estado, s);

                        if (newestado != 997)
                        {
                            pilaSintactica.Push(newestado);
                            estado = newestado;
                        }
                        else
                        {
                            // Presentar mensaje de error
                            Errores miError = new Errores()
                            {
                                NumError = 1,
                                Mensaje = "Error sintáctico: " + s + " no se encuentra en la matriz transciones"
                            };
                            listErroresSintactico.Add(miError);
                            band = false;
                        }
                        // Guardar movimiento de la pila
                        guardarMovimientoPila();
                    }
                    else if (newestado == 1000)
                    {
                        //Aceptar 
                        //bajar de la pila
                        for (int i = 0; i < 3; i++)
                        {
                            pilaSintactica.Pop();
                        }
                        // Guardar movimiento de la pila
                        guardarMovimientoPila();
                        break;
                    }
                    else
                    {
                        // Guardar movimientos en la lista de movimientos
                        // para presentar en la tabla mov sintactica
                        AFD miMove = new AFD()
                        {
                            Estado = estado,
                            Lee = simbolo,
                            NEstado = newestado
                        };
                        listMovimientos.Add(miMove);
                        //moverse dentrodel automata
                        pilaSintactica.Push(simbolo);
                        pilaSintactica.Push(newestado);
                        estado = newestado;
                        //tomar el token 
                        cont++;
                        tk = listTokensReconocidos[cont];
                        simbolo = tk.SinonimoToken;
                    }
                }
                else
                {
                    // Guardar movimientos en la lista de movimientos
                    // para presentar en la tabla mov sintactica
                    AFD miMove = new AFD()
                    {
                        Estado = estado,
                        Lee = simbolo,
                        NEstado = newestado
                    };
                    listMovimientos.Add(miMove);
                    // Presentar mensaje de error
                    Errores miError = new Errores()
                    {
                        NumError = 1,
                        Mensaje = "Error sintáctico: " + simbolo + " no se encuentra en la matriz transciones"
                    };
                    listErroresSintactico.Add(miError);
                    //band = false;
                    //tomar el token para recuperarse del error
                    cont++;
                    tk = listTokensReconocidos[cont];
                    simbolo = tk.SinonimoToken;

                }
            }
        }

        public int devolverNuevoEstado(int estado, string simbolo)
        {
            foreach (SLR e in listSLR)
            {

                if (e.Estado == estado && simbolo == e.SimbolosLeyendo)
                {
                    return (e.Newestado);
                }
            }
            return 997;
        }

        public Reglas devolverRegla(int regla)
        {
            foreach (Reglas rule in listReglas)
            {
                if (rule.NumeroRegla == regla)
                {
                    //verificar la regla 5 6 7 8 9
                    switch (regla)
                    {
                        case 5: // C-->e
                            buscarEnTokensIdentificador(1, 2, "e");
                            break;
                        case 6: // C-->r
                            buscarEnTokensIdentificador(2, 4, "r");
                            break;
                        case 7: // C-->c
                            buscarEnTokensIdentificador(3, 1, "c");
                            break;
                        case 8: // C-->t
                            buscarEnTokensIdentificador(4, 256, "t");
                            break;
                        case 9: // C-->b
                            buscarEnTokensIdentificador(5, 1, "b");
                            break;
                        default:
                            break;
                    }
                    return rule;
                }
            }
            return null;
        }

        public void buscarEnTokensIdentificador(int tipo, int size, string sinonimo)
        {
            Tokens item;
            bool flag  = false;
            string variable;
            while (contadorGlobalTokens <listTokensReconocidos.Count)
            {
                item = listTokensReconocidos[contadorGlobalTokens++];
                if (item.SinonimoToken.Equals(sinonimo))
                {
                    flag = true;
                }
                else
                {
                    if (item.SinonimoToken.Equals("i") && flag)
                    {
                        variable = item.LexemaToken;
                        buscarEnTDSIdentificador(variable, tipo, size);

                    }
                    if (item.SinonimoToken.Equals(";"))
                    {
                        return;
                    }
                }
            }
        }

        public void buscarEnTDSIdentificador(string variable, int tipo, int size)
        {
            foreach (var item in listTDS)
            {
                if (item.Nombre.Equals(variable))
                {
                    if (item.Tipo == 0)
                    {
                        item.Tipo = tipo;
                        item.Size = size;
                    } else
                    {
                        Errores miError = new Errores()
                        {
                            NumError = 3,
                            Mensaje = "Error sintáctico: variable " + variable + " ya definida"
                        };
                        listErroresSintactico.Add(miError);
                    }
                }
            }
        }

    }
}
