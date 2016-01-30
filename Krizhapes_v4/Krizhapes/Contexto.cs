namespace Krizhapes
{
    public class Contexto
    {
        public FiguraComponente Figura;
        MainWindow Ventana { get; set; }

        public Contexto(FiguraComponente figura, MainWindow ventana)
        {
            Figura = figura;
            Ventana = ventana;
        }
        public void DibjarFigura()
        {
            Figura.Dibujar(Ventana);
        }
    }
}