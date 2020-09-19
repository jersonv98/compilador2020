using Compilador2020.Scanner;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Compilador2020
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //cargar alfabeto en mi tabla alfabeto
            lexico.Cargar_Alfabeto(tbl_Alfabeto);
            //cargar AFDA en mi tabla AFD
            lexico.Cargar_AFD(tbl_AFD);
            ////ejecutar el metodo reconocedor lexico
            //lexico.Reconocedor_Lexico();
            ////reconocer tokens y mostrarlos en pantalla
            //tbl_TokensReconocidos.ItemsSource = lexico.list_tokens_reconocidos;
            //BtnSintactico.IsEnabled = true;
            ////mostrar movimientos en pantalla
            //tbl_Movimientos.ItemsSource = lexico.listMovimientos;
            ////mostrar tabla de simbolos en pantalla
            //tbl_TDS.ItemsSource = lexico.listTDS;
            ////mostrar errores
            //lexico.Cargar_Errores(tbl_Errores);
            ////mostrar texto ejemplo en una caja de texto
            //TextBoxEjemplo.Text = lexico.Cargar_Archivo_Fuente();
        }

        Lexico lexico = new Lexico();

        private void Btn_Lexico_Click(object sender, RoutedEventArgs e)
        {
            ////cargar alfabeto en mi tabla alfabeto
            //lexico.Cargar_Alfabeto(tbl_Alfabeto);
            ////cargar AFDA en mi tabla AFD
            //lexico.Cargar_AFD(tbl_AFD);
            //ejecutar el metodo reconocedor lexico
            lexico.Reconocedor_Lexico();
            //reconocer tokens y mostrarlos en pantalla
            tbl_TokensReconocidos.ItemsSource = lexico.list_tokens_reconocidos;
            BtnSintactico.IsEnabled = true;
            MessageBox.Show("El Parser se encuentra habilitado", "Compilador", MessageBoxButton.OK, MessageBoxImage.Information);
            tabItemTokensReconocidos.IsEnabled = true;
            tabItemMovimientos.IsEnabled = true;
            tabItemTDS.IsEnabled = true;
            //mostrar movimientos en pantalla
            tbl_Movimientos.ItemsSource = lexico.listMovimientos;
            //mostrar tabla de simbolos en pantalla
            tbl_TDS.ItemsSource = lexico.listTDS;
            //mostrar errores
            lexico.Cargar_Errores(tbl_Errores);
            //mostrar texto ejemplo en una caja de texto
            TextBoxEjemplo.Text = lexico.Cargar_Archivo_Fuente();
        }
    }
}
