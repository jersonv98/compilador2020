using Microsoft.Msagl.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Compilador2020.Scanner
{
    /// <summary>
    /// Lógica de interacción para AFDWindow.xaml
    /// </summary>
    public partial class AFDWindow : Window
    {
        public AFDWindow()
        {
            InitializeComponent();
            InitAutomata();
        }

        private void InitAutomata()
        {
            Graph graph = new Graph("graph");
            graph.AddEdge("0", "#", "0");
            graph.AddEdge("0", "mayuscula", "12");
            graph.AddEdge("0", "+", "16");
            graph.AddEdge("0", "-", "17");
            graph.AddEdge("0", "*", "18");
            graph.AddEdge("0", "/", "19");
            graph.AddEdge("0", "&", "20");
            graph.AddEdge("0", "|", "21");
            graph.AddEdge("0", "<", "30");
            graph.AddEdge("0", ">", "31");
            graph.AddEdge("0", "=", "32");
            graph.AddEdge("0", "!", "29");
            graph.AddEdge("0", "f", "4");
            graph.AddEdge("0", "b", "1");
            graph.AddEdge("0", "c", "2");
            graph.AddEdge("0", "t", "9");
            graph.AddEdge("0", "m", "8");
            graph.AddEdge("0", "{", "27");
            graph.AddEdge("0", "}", "28");
            graph.AddEdge("0", "i", "6");
            graph.AddEdge("0", "w", "11");
            graph.AddEdge("0", "l", "7");
            graph.AddEdge("0", "g", "5");
            graph.AddEdge("0", ",", "24");
            graph.AddEdge("0", ")", "22");
            graph.AddEdge("0", "(", "23");
            graph.AddEdge("0", ";", "25");
            graph.AddEdge("0", "d", "3");
            graph.AddEdge("0", ":", "33");
            graph.AddEdge("0", "v", "10");
            graph.AddEdge("0", "\"", "15");
            graph.AddEdge("0", "digito", "13");
            graph.AddEdge("0", "'", "34");
            graph.AddEdge("0", ".", "26");
            graph.AddEdge("0", "\\", "35");
            graph.AddEdge("1", "o", "36");
            graph.AddEdge("1", "r", "37");
            graph.AddEdge("2", "h", "38");
            graph.AddEdge("2", "o", "39");
            graph.AddEdge("3", "o", "40");
            graph.AddEdge("4", "a", "41");
            graph.AddEdge("4", "l", "42");
            graph.AddEdge("4", "o", "43");
            graph.AddEdge("5", "e", "44");
            graph.AddEdge("6", "n", "46");
            graph.AddEdge("6", "f", "45");
            graph.AddEdge("7", "o", "47");
            graph.AddEdge("8", "a", "48");
            graph.AddEdge("9", "r", "50");
            graph.AddEdge("9", "e", "49");
            graph.AddEdge("10", "a", "51");
            graph.AddEdge("11", "h", "52");
            graph.AddEdge("12", "letra", "12");
            graph.AddEdge("12", "digito", "12");
            graph.AddEdge("12", "#", "-1");
            graph.AddEdge("13", "digito", "13");
            graph.AddEdge("13", "#", "-43");
            graph.AddEdge("15", "letra", "55");
            graph.AddEdge("15", "mayuscula", "55");
            graph.AddEdge("15", "digito", "55");
            graph.AddEdge("15", "simbolo", "55");
            //graph.AddEdge("15", "+", "55");
            //graph.AddEdge("15", "-", "55");
            //graph.AddEdge("15", "*", "55");
            //graph.AddEdge("15", "/", "55");
            //graph.AddEdge("15", "&", "55");
            //graph.AddEdge("15", "(", "55");
            //graph.AddEdge("15", ")", "55");
            //graph.AddEdge("15", ",", "55");
            //graph.AddEdge("15", ".", "55");
            //graph.AddEdge("15", "{", "55");
            //graph.AddEdge("15", "}", "55");
            //graph.AddEdge("15", "!", "55");
            //graph.AddEdge("15", "#", "55");
            //graph.AddEdge("15", "$", "55");
            //graph.AddEdge("15", "%", "55");
            //graph.AddEdge("15", "<", "55");
            //graph.AddEdge("15", ">", "55");
            //graph.AddEdge("15", "_", "55");
            //graph.AddEdge("15", "=", "55");
            //graph.AddEdge("15", ":", "55");
            //graph.AddEdge("15", "?", "55");
            //graph.AddEdge("15", "'", "55");
            graph.AddEdge("15", "#", "-2");
            graph.AddEdge("16", "+", "57");
            graph.AddEdge("17", "#", "-3");
            graph.AddEdge("17", "digito", "59");
            graph.AddEdge("18", "#", "-4");
            graph.AddEdge("18", "*", "62");
            graph.AddEdge("19", "#", "-5");
            graph.AddEdge("20", "&", "65");
            graph.AddEdge("21", "|", "66");
            graph.AddEdge("22", "#", "-35");
            graph.AddEdge("23", "#", "-36");
            graph.AddEdge("24", "#", "-34");
            graph.AddEdge("25", "#", "-37");
            graph.AddEdge("26", "digito", "71");
            graph.AddEdge("27", "#", "-23");
            graph.AddEdge("28", "#", "-24");
            graph.AddEdge("29", "=", "75");
            graph.AddEdge("30", "#", "-9");
            graph.AddEdge("30", "=", "77");
            graph.AddEdge("31", "#", "-10");
            graph.AddEdge("31", "=", "79");
            graph.AddEdge("32", "=", "81");
            graph.AddEdge("32", "#", "-25");
            graph.AddEdge("33", "#", "-39");
            graph.AddEdge("34", "letra", "83");
            graph.AddEdge("34", "mayuscula", "83");
            graph.AddEdge("34", "digito", "83");
            graph.AddEdge("34", "simbolo", "83");
            //graph.AddEdge("34", "+", "83");
            //graph.AddEdge("34", "-", "83");
            //graph.AddEdge("34", "*", "83");
            //graph.AddEdge("34", "/", "83");
            //graph.AddEdge("34", "&", "83");
            //graph.AddEdge("34", "(", "83");
            //graph.AddEdge("34", ")", "83");
            //graph.AddEdge("34", ",", "83");
            //graph.AddEdge("34", ".", "83");
            //graph.AddEdge("34", "{", "83");
            //graph.AddEdge("34", "}", "83");
            //graph.AddEdge("34", "!", "83");
            //graph.AddEdge("34", "#", "83");
            //graph.AddEdge("34", "$", "83");
            //graph.AddEdge("34", "%", "83");
            //graph.AddEdge("34", "<", "83");
            //graph.AddEdge("34", ">", "83");
            //graph.AddEdge("34", "_", "83");
            //graph.AddEdge("34", "=", "83");
            //graph.AddEdge("34", ":", "83");
            //graph.AddEdge("34", "?", "83");
            //graph.AddEdge("34", "'", "83");
            graph.AddEdge("35", "*", "85");
            graph.AddEdge("36", "o", "86");
            graph.AddEdge("37", "e", "87");
            graph.AddEdge("38", "a", "88");
            graph.AddEdge("39", "n", "89");
            graph.AddEdge("40", "c", "90");
            graph.AddEdge("40", "#", "-38");
            graph.AddEdge("41", "l", "92");
            graph.AddEdge("42", "o", "93");
            graph.AddEdge("43", "r", "94");
            graph.AddEdge("44", "t", "95");
            graph.AddEdge("45", "#", "-26");
            graph.AddEdge("46", "t", "97");
            graph.AddEdge("47", "o", "98");
            graph.AddEdge("48", "i", "99");
            graph.AddEdge("49", "x", "100");
            graph.AddEdge("50", "u", "101");
            graph.AddEdge("51", "r", "102");
            graph.AddEdge("52", "i", "103");
            graph.AddEdge("55", "letra", "55");
            graph.AddEdge("55", "mayuscula", "55");
            graph.AddEdge("55", "digito", "55");
            graph.AddEdge("55", "simbolo", "55");
            //graph.AddEdge("55", "+", "55");
            //graph.AddEdge("55", "-", "55");
            //graph.AddEdge("55", "*", "55");
            //graph.AddEdge("55", "/", "55");
            //graph.AddEdge("55", "&", "55");
            //graph.AddEdge("55", "(", "55");
            //graph.AddEdge("55", ")", "55");
            //graph.AddEdge("55", ",", "55");
            //graph.AddEdge("55", ".", "55");
            //graph.AddEdge("55", "{", "55");
            //graph.AddEdge("55", "}", "55");
            //graph.AddEdge("55", "!", "55");
            //graph.AddEdge("55", "#", "55");
            //graph.AddEdge("55", "$", "55");
            //graph.AddEdge("55", "%", "55");
            //graph.AddEdge("55", "<", "55");
            //graph.AddEdge("55", ">", "55");
            //graph.AddEdge("55", "_", "55");
            //graph.AddEdge("55", "=", "55");
            //graph.AddEdge("55", ":", "55");
            //graph.AddEdge("55", "?", "55");
            //graph.AddEdge("55", "'", "55");
            graph.AddEdge("55", "\"", "104");
            graph.AddEdge("57", "#", "-30");
            graph.AddEdge("59", "digito", "59");
            graph.AddEdge("59", ".", "26");
            graph.AddEdge("62", "#", "-6");
            graph.AddEdge("65", "#", "-7");
            graph.AddEdge("66", "#", "-8");
            graph.AddEdge("71", "digito", "71");
            graph.AddEdge("71", "#", "-44");
            graph.AddEdge("75", "#", "-14");
            graph.AddEdge("77", "#", "-12");
            graph.AddEdge("79", "#", "-13");
            graph.AddEdge("81", "#", "-11");
            graph.AddEdge("83", "letra", "83");
            graph.AddEdge("83", "mayuscula", "83");
            graph.AddEdge("83", "digito", "83");
            graph.AddEdge("83", "simbolo", "83");
            //graph.AddEdge("83", "+", "83");
            //graph.AddEdge("83", "-", "83");
            //graph.AddEdge("83", "*", "83");
            //graph.AddEdge("83", "/", "83");
            //graph.AddEdge("83", "&", "83");
            //graph.AddEdge("83", "(", "83");
            //graph.AddEdge("83", ")", "83");
            //graph.AddEdge("83", ",", "83");
            //graph.AddEdge("83", ".", "83");
            //graph.AddEdge("83", "{", "83");
            //graph.AddEdge("83", "}", "83");
            //graph.AddEdge("83", "!", "83");
            //graph.AddEdge("83", "#", "83");
            //graph.AddEdge("83", "$", "83");
            //graph.AddEdge("83", "%", "83");
            //graph.AddEdge("83", "<", "83");
            //graph.AddEdge("83", ">", "83");
            //graph.AddEdge("83", "_", "83");
            //graph.AddEdge("83", "=", "83");
            //graph.AddEdge("83", ":", "83");
            //graph.AddEdge("83", "?", "83");
            graph.AddEdge("83", "'", "112");
            graph.AddEdge("85", "letra", "113");
            graph.AddEdge("85", "mayuscula", "113");
            graph.AddEdge("85", "digito", "113");
            graph.AddEdge("85", "simbolo", "113");
            //graph.AddEdge("85", "+", "113");
            //graph.AddEdge("85", "-", "113");
            //graph.AddEdge("85", "*", "113");
            //graph.AddEdge("85", "/", "113");
            //graph.AddEdge("85", "&", "113");
            //graph.AddEdge("85", "(", "113");
            //graph.AddEdge("85", ")", "113");
            //graph.AddEdge("85", ",", "113");
            //graph.AddEdge("85", ".", "113");
            //graph.AddEdge("85", "{", "113");
            //graph.AddEdge("85", "}", "113");
            //graph.AddEdge("85", "!", "113");
            //graph.AddEdge("85", "#", "113");
            //graph.AddEdge("85", "$", "113");
            //graph.AddEdge("85", "%", "113");
            //graph.AddEdge("85", "<", "113");
            //graph.AddEdge("85", ">", "113");
            //graph.AddEdge("85", "_", "113");
            //graph.AddEdge("85", "=", "113");
            //graph.AddEdge("85", ":", "113");
            //graph.AddEdge("85", "?", "113");
            //graph.AddEdge("85", "'", "113");
            graph.AddEdge("86", "l", "115");
            graph.AddEdge("87", "a", "116");
            graph.AddEdge("88", "r", "117");
            graph.AddEdge("89", "t", "118");
            graph.AddEdge("90", "u", "119");
            graph.AddEdge("92", "s", "120");
            graph.AddEdge("93", "a", "121");
            graph.AddEdge("94", "#", "-29");
            graph.AddEdge("95", "E", "123");
            graph.AddEdge("97", "#", "-17");
            graph.AddEdge("98", "p", "125");
            graph.AddEdge("99", "n", "126");
            graph.AddEdge("100", "t", "127");
            graph.AddEdge("101", "e", "128");
            graph.AddEdge("102", "#", "-40");
            graph.AddEdge("103", "l", "130");
            graph.AddEdge("104", "#", "-42");
            graph.AddEdge("112", "#", "-45");
            graph.AddEdge("113", "letra", "113");
            graph.AddEdge("113", "mayuscula", "113");
            graph.AddEdge("113", "digito", "113");
            graph.AddEdge("113", "simbolo", "113");
            //graph.AddEdge("113", "+", "113");
            //graph.AddEdge("113", "-", "113");
            //graph.AddEdge("113", "/", "113");
            //graph.AddEdge("113", "&", "113");
            //graph.AddEdge("113", "(", "113");
            //graph.AddEdge("113", ")", "113");
            //graph.AddEdge("113", ",", "113");
            //graph.AddEdge("113", ".", "113");
            //graph.AddEdge("113", "{", "113");
            //graph.AddEdge("113", "}", "113");
            //graph.AddEdge("113", "!", "113");
            //graph.AddEdge("113", "#", "113");
            //graph.AddEdge("113", "$", "113");
            //graph.AddEdge("113", "%", "113");
            //graph.AddEdge("113", "<", "113");
            //graph.AddEdge("113", ">", "113");
            //graph.AddEdge("113", "_", "113");
            //graph.AddEdge("113", "=", "113");
            //graph.AddEdge("113", ":", "113");
            //graph.AddEdge("113", "?", "113");
            //graph.AddEdge("113", "'", "113");
            graph.AddEdge("113", "*", "133");
            graph.AddEdge("114", "#", "-100");
            graph.AddEdge("115", "#", "-19");
            graph.AddEdge("116", "k", "135");
            graph.AddEdge("117", "#", "-20");
            graph.AddEdge("118", "i", "137");
            graph.AddEdge("119", "m", "138");
            graph.AddEdge("120", "e", "139");
            graph.AddEdge("121", "t", "140");
            graph.AddEdge("123", "l", "141");
            graph.AddEdge("125", "#", "-28");
            graph.AddEdge("126", "#", "-22");
            graph.AddEdge("127", "#", "-21");
            graph.AddEdge("128", "#", "-15");
            graph.AddEdge("130", "e", "146");
            graph.AddEdge("133", "\\", "114");
            graph.AddEdge("135", "#", "-41");
            graph.AddEdge("137", "n", "149");
            graph.AddEdge("138", "e", "150");
            graph.AddEdge("139", "#", "-16");
            graph.AddEdge("140", "#", "-18");
            graph.AddEdge("141", "e", "153");
            graph.AddEdge("146", "#", "-27");
            graph.AddEdge("149", "u", "156");
            graph.AddEdge("150", "n", "157");
            graph.AddEdge("153", "m", "158");
            graph.AddEdge("156", "e", "159");
            graph.AddEdge("157", "t", "160");
            graph.AddEdge("158", "e", "161");
            graph.AddEdge("159", "#", "-33");
            graph.AddEdge("160", "#", "-32");
            graph.AddEdge("161", "n", "164");
            graph.AddEdge("164", "t", "165");
            graph.AddEdge("165", "#", "-31");
            StyleNodes(graph.Nodes);
            StyleEdges(graph.Edges);
            //this.gViewer.Graph = graph;                 // Cargando datos a la vista
            //this.gViewer.ToolBarIsVisible = false;      // Quitando barra de herramientas
        }

        private void StyleNodes(IEnumerable<Node> nodes)
        {
            foreach (Node node in nodes)
            {
                node.Attr.FillColor = new Microsoft.Msagl.Drawing.Color(36, 129, 207); // magenta
                node.Attr.Color = new Microsoft.Msagl.Drawing.Color(119, 121, 206); // color del borde
                node.Label.FontName = "Consolas"; // tipo de fuente de texto
                //node.Label.FontColor = new Microsoft.Msagl.Drawing.Color(32, 32, 32); // color del texto negro
                node.Label.FontColor = new Microsoft.Msagl.Drawing.Color(255, 255, 255); // color del texto blanco
                node.Attr.LabelMargin = 5; // margen entre el texto y el borde
                node.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Circle; // tipo de forma
                node.Attr.LineWidth = 0; // grosor del borde: si es cero va el minimo
                node.UserData = "UserData present";
            }
            var firstNode = nodes.First(c => c.LabelText == "0"); // Busca el primer nodo
            firstNode.Attr.FillColor = new Microsoft.Msagl.Drawing.Color(245, 177, 22); // cyan
            firstNode.Attr.Color = new Microsoft.Msagl.Drawing.Color(103, 210, 198); // color del borde
        }

        private void StyleEdges(IEnumerable<Edge> edges)
        {
            foreach (Edge edge in edges)
            {
                edge.Attr.Color = new Microsoft.Msagl.Drawing.Color(180, 180, 180);
                edge.Label.FontSize = 12;
            }
        }

        private void windowsFormsHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
