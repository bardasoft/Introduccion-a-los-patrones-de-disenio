using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Krizhapes
{
    public class Estrella : IFigura
    {
        public double CoordX { get; set; }
        public double CoordY { get; set; }
        public double Largo { get; set; }
        private Triangulo TrianguloArriba { get; set; }
        private Triangulo TrianguloAbajo { get; set; }

        public Estrella(double coordX, double coordY, double largo)
        {
            CoordX = coordX;
            CoordY = coordY;
            Largo = largo;
        }

        public void Dibujar(MainWindow ventana)
        {
            TrianguloArriba = new Triangulo(CoordX, CoordY, Largo);
            TrianguloArriba.Dibujar(ventana);

            TrianguloAbajo = new Triangulo(CoordX, CoordY, Largo){TrianguloArriba = false};
            TrianguloAbajo.Dibujar(ventana);
        }

    }
}
