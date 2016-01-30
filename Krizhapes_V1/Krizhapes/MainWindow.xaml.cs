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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Telerik.Windows.Controls;

namespace Krizhapes
{
    public partial class MainWindow : Window
    {        
        double _coordX;
        double _coordY;
        double _largo;
        private Contexto _contexto;

        public MainWindow()
        {
            InitializeComponent();
            this.WindowState = System.Windows.WindowState.Maximized;

        }

        private void LeerValores()
        {
            _coordX = int.Parse(txtX.Text);
            _coordY = int.Parse(txtY.Text);
            _largo = int.Parse(txtLargo.Text);            
        }

        void btnCrearLinea_Click(object sender, RoutedEventArgs e)
        {
            LeerValores();
            _contexto = new Contexto(new Linea(_coordX, _coordY, _largo), this);
            _contexto.DibujarFigura();
        }
   
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            btnCrearLinea.Click += new RoutedEventHandler(btnCrearLinea_Click);
            btnCrearCirculo.Click += btnCrearCirculo_Click;
            btnCrearTriangulo.Click += btnCrearTriangulo_Click;
            btnCrearEstrella.Click += btnCrearEstrella_Click;
        }

        void btnCrearEstrella_Click(object sender, RoutedEventArgs e)
        {
            LeerValores();
            _contexto = new Contexto(new Estrella(_coordX, _coordY, _largo), this);
            _contexto.DibujarFigura();
        }

        void btnCrearTriangulo_Click(object sender, RoutedEventArgs e)
        {
            LeerValores();
            _contexto = new Contexto(new Triangulo(_coordX, _coordY, _largo), this);
            _contexto.DibujarFigura();
        }

        void btnCrearCirculo_Click(object sender, RoutedEventArgs e)
        {
            LeerValores();
            _contexto = new Contexto(new Circulo(_coordX, _coordY, _largo), this);
            _contexto.DibujarFigura();
        }
    }
}