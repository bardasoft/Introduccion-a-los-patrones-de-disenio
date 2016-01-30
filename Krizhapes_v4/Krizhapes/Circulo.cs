using System.Windows.Media;
using System.Windows.Shapes;


namespace Krizhapes
{
    public class Circulo : FiguraComponente
    {
        public double CoordX { get; set; }
        public double CoordY { get; set; }
        public double Largo { get; set; }

        public Circulo(double coordX, double coordY, double largo)
        {
            CoordX = coordX;
            CoordY = coordY;
            Largo = largo;            
        }

        public override void Dibujar(MainWindow ventana)
        {
            var elipse = new Ellipse
                {
                    Width = Largo,
                    Height = Largo,
                    StrokeThickness = 5,
                    Stroke = Brushes.Black,
                    Margin = new System.Windows.Thickness(0, CoordX - (Largo/2), CoordY - (Largo/2), 0),
                    HorizontalAlignment = System.Windows.HorizontalAlignment.Right,
                    VerticalAlignment = System.Windows.VerticalAlignment.Top
                };
            ventana.Dibujador.Children.Add(elipse);
        }
    }
}

