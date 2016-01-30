using System.Collections.Generic;

namespace Krizhapes
{
    public class Triangulo : FiguraComponente
    {
        public double CoordX { get; set; }
        public double CoordY { get; set; }
        public double Largo { get; set; }
        public bool TrianguloArriba { get; set; }
        public Linea Linea1 { get; set; }
        public Linea Linea2 { get; set; }
        public Linea Linea3 { get; set; }
        public List<FiguraComponente> ListaFiguras { get; set; }

        public Triangulo(double coordX, double coordY, double largo)
        {
            CoordX = coordX;
            CoordY = coordY;
            Largo = largo;
            TrianguloArriba = true;
            ListaFiguras = new List<FiguraComponente>();
        }

        public override void Dibujar(MainWindow ventana)
        {            
            double parteMinima = Largo / 6;

            if (TrianguloArriba)
            {
                Linea1 = new Linea
                    {
                        CoordX = CoordX - (parteMinima*3),
                        CoordY = CoordY - (parteMinima*2),
                        CoordX2 = CoordX,
                        CoordY2 = CoordY + (parteMinima*4)
                    };
                Agregar(Linea1);

                Linea2 = new Linea
                    {
                        CoordX = CoordX,
                        CoordY = CoordY + (parteMinima*4),
                        CoordX2 = CoordX + (parteMinima*3),
                        CoordY2 = CoordY - (parteMinima*2)
                    };
                Agregar(Linea2);

                Linea3 = new Linea
                    {
                        CoordX = CoordX - (parteMinima*3),
                        CoordY = CoordY - (parteMinima*2),
                        CoordX2 = CoordX + (parteMinima*3),
                        CoordY2 = CoordX - (parteMinima*2)
                    };
                Agregar(Linea3);
            }
            else
            {
                Linea1 = new Linea
                    {
                        CoordX = CoordX + (parteMinima*3),
                        CoordY = CoordY + (parteMinima*2),
                        CoordX2 = CoordX,
                        CoordY2 = CoordY - (parteMinima*4)
                    };
                Agregar(Linea1);

                 Linea2 = new Linea
                    {
                        CoordX = CoordX,
                        CoordY = CoordY - (parteMinima*4),
                        CoordX2 = CoordX - (parteMinima*3),
                        CoordY2 = CoordY + (parteMinima*2)
                    };
                 Agregar(Linea2);

                 Linea3 = new Linea
                    {
                        CoordX = CoordX + (parteMinima*3),
                        CoordY = CoordY + (parteMinima*2),
                        CoordX2 = CoordX - (parteMinima*3),
                        CoordY2 = CoordX + (parteMinima*2)
                    };
                 Agregar(Linea3);
            }

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
