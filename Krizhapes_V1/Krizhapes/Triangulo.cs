using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Krizhapes
{
    public class Triangulo : IFigura
    {
        public double CoordX { get; set; }
        public double CoordY { get; set; }
        public double Largo { get; set; }
        public bool TrianguloArriba { get; set; }
        public Linea Linea1 { get; set; }
        public Linea Linea2 { get; set; }
        public Linea Linea3 { get; set; }

        public Triangulo(double coordX, double coordY, double largo)
        {
            CoordX = coordX;
            CoordY = coordY;
            Largo = largo;
            TrianguloArriba = true;
        }

        public void Dibujar(MainWindow ventana)
        {
            double parteMinima = Largo/6;

            if (TrianguloArriba)
            {
                Linea1 = new Linea
                    {
                        CoordX = CoordX - (parteMinima*3),
                        CoordY = CoordY - (parteMinima*2),
                        CoordX2 = CoordX,
                        CoordY2 = CoordY+(parteMinima*4)
                    };
                Linea1.Dibujar(ventana);

                Linea2 = new Linea
                    {
                        CoordX = CoordX,
                        CoordY = CoordY + (parteMinima * 4),
                        CoordX2 = CoordX + (parteMinima*3),
                        CoordY2 = CoordY - (parteMinima * 2)
                    };
             Linea2.Dibujar(ventana);

             Linea3 = new Linea
             {
                 CoordX = CoordX - (parteMinima*3),
                 CoordY = CoordY - (parteMinima * 2),
                 CoordX2 = CoordX + (parteMinima * 3),
                 CoordY2 = CoordX - (parteMinima * 2)
             };
             Linea3.Dibujar(ventana);
            }

            else
            {
                Linea1 = new Linea
                {
                    CoordX = CoordX + (parteMinima * 3),
                    CoordY = CoordY + (parteMinima * 2),
                    CoordX2 = CoordX,
                    CoordY2 = CoordY - (parteMinima * 4)
                };
                Linea1.Dibujar(ventana);

                Linea2 = new Linea
                {
                    CoordX = CoordX,
                    CoordY = CoordY - (parteMinima * 4),
                    CoordX2 = CoordX - (parteMinima * 3),
                    CoordY2 = CoordY + (parteMinima * 2)
                };
                Linea2.Dibujar(ventana);

                Linea3 = new Linea
                {
                    CoordX = CoordX + (parteMinima * 3),
                    CoordY = CoordY + (parteMinima * 2),
                    CoordX2 = CoordX - (parteMinima * 3),
                    CoordY2 = CoordX + (parteMinima * 2)
                };
                Linea3.Dibujar(ventana);
            }

        }

    }
}
