using Compilador2020.Scanner;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Compilador2020.Parser
{
    /// <summary>
    /// Lógica de interacción para ParserWindow.xaml
    /// </summary>
    public partial class ParserWindow : Window
    {
        public ParserWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Lexico lexico = new Lexico();
            ////reconocer tokens y mostrarlos en pantalla
            //lexico.Cargar_Tokens_Reconocidos(tbl_TokensReconocidos);
            ////Cargar gramaática original
            ////Sintactico sintactico = new Sintactico();
            //sintactico.Cargar_Gramatica(tbl_GramaticaOriginal, "ReglasSnS.xml");
            ////Cargar gramatica en sinonimos
            //sintactico.Cargar_Gramatica(tbl_GramaticaEnSinonimoss, "ReglasCnS.xml");
            ////Cargar los primeros y los siguientes
            //sintactico.Cargar_FirstNext(tbl_FirstNext);
        }
    }
}
