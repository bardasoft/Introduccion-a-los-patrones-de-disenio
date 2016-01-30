using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Krizhapes
{
    public class Contexto
    {
        public IFigura Figura;
        MainWindow Ventana { get; set; }

        public Contexto(IFigura figura, MainWindow ventana)
        {
            Figura = figura;
            Ventana = ventana;
        }

        public void DibujarFigura()
        {
            Figura.Dibujar(Ventana);
        }
    }
}
