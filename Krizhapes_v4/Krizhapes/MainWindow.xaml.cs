using System.Windows;

namespace Krizhapes
{
    public partial class MainWindow
    {
        int _coordX;
        int _coordY;
        int _largo;
        private Contexto _contexto;

        public MainWindow()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
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
            _contexto.DibjarFigura();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            btnCrearLinea.Click += btnCrearLinea_Click;
            btnCrearCirculo.Click += btnCrearCirculo_Click;
            btnCrearTriangulo.Click += btnCrearTriangulo_Click;
            btnCrearEstrella.Click += btnCrearEstrella_Click;
        }

        void btnCrearEstrella_Click(object sender, RoutedEventArgs e)
        {
            LeerValores();
            _contexto = new Contexto(new Estrella(_coordX, _coordY, _largo), this);
            _contexto.DibjarFigura();
        }

        void btnCrearTriangulo_Click(object sender, RoutedEventArgs e)
        {
            LeerValores();
            _contexto = new Contexto(new Triangulo(_coordX, _coordY, _largo), this);
            _contexto.DibjarFigura();
        }

        void btnCrearCirculo_Click(object sender, RoutedEventArgs e)
        {
            LeerValores();
            _contexto = new Contexto(new Circulo(_coordX, _coordY, _largo), this);
            _contexto.DibjarFigura();
        }
    }
}