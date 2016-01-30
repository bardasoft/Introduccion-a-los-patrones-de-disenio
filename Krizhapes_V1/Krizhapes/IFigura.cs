using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Krizhapes
{
    public interface IFigura
    {
        double CoordX { get; set; }
        double CoordY { get; set; }
        double Largo { get; set; }
        void Dibujar(MainWindow ventana);
    }
}
