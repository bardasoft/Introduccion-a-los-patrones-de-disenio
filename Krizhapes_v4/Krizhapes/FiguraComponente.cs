using System;

namespace Krizhapes
{
    public abstract  class FiguraComponente
    {
        double CoordX { get; set; }
        double CoordY { get; set; }
        double Largo { get; set; }

        public virtual void Dibujar(MainWindow ventana)
        {
            throw new NotImplementedException();
        }

        public virtual void Agregar(FiguraComponente figura)
        {
            throw new NotImplementedException();
        }

        public virtual void Remover(FiguraComponente figura)
        {
            throw new NotImplementedException();
        }

        public virtual FiguraComponente ObtenerHijo(int indice)
        {
            throw new NotImplementedException();
        }
    }
}