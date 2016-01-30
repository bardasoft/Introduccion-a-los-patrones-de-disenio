using System.Collections.Generic;

namespace Krizhapes
{
    public class Estrella : FiguraComponente
    {

        public double CoordX { get; set; }
        public double CoordY { get; set; }
        public double Largo { get; set; }
        private Triangulo TrianguloArriba { get; set; }
        private Triangulo TrianguloAbajo { get; set; }
        public List<FiguraComponente> ListaFiguras { get; set; }

        public Estrella(double coordX, double coordY, double largo)
        {
            CoordX = coordX;
            CoordY = coordY;
            Largo = largo;
            ListaFiguras = new List<FiguraComponente>();
        }

        public override void Dibujar(MainWindow ventana)
        {
            TrianguloArriba = new Triangulo(CoordX, CoordY, Largo);
            Agregar(TrianguloArriba);
            TrianguloAbajo = new Triangulo(CoordX, CoordY, Largo) { TrianguloArriba = false };
            Agregar(TrianguloAbajo);
            
            foreach (FiguraComponente componente in ListaFiguras)
            {
                componente.Dibujar(ventana);
            }
        }

        public override void Agregar(FiguraComponente figura)
        {
            ListaFiguras.Add(figura);
        }

        public override void Remover(FiguraComponente figura)
        {
            ListaFiguras.Remove(figura);
        }

        public override FiguraComponente ObtenerHijo(int indice)
        {
            return ListaFiguras[indice];
        }
    }
}