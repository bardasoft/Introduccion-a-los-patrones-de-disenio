using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Krizhapes
{
    public class Linea : IFigura
    {
        public double CoordX { get; set; }
        public double CoordY { get; set; }
        public double CoordX2 { get; set; }
        public double CoordY2 { get; set; }
        public double Largo { get; set; }

        public Linea() : this(0, 0, 0)
        {
            
        }

        public Linea(double coordX, double coordY, double largo)
        {
            CoordX = coordX;
            CoordY = coordY;
            Largo = largo;

            CoordX2 = coordX + Largo;
            CoordY2 = coordY;
        }

        public void Dibujar(MainWindow ventana)
        {
            var ln = new Line
                {
                    X1 = CoordX,
                    Y1 = CoordY,
                    X2 = CoordX2,
                    Y2 = CoordY2,
                    Stroke = Brushes.Black,
                    FlowDirection = System.Windows.FlowDirection.RightToLeft,
                    StrokeThickness = 5
                };
            ventana.Dibujador.Children.Add(ln);
        }

    }
}
