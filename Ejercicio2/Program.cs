using System.Collections.Generic;

namespace EjerciciosOCP.Ejercicio2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var figuras = new List<Figuras_Geometricas>
            {
                new Cuadrado(5),
                new Rectangulo(2, 5),
                new Triangulo(8, 3),
               // new Circulo (radio:6)
            };

            var calculadora = new CalculadoraAreas(figuras);

            calculadora.Calcular();
        }
    }

    public class Triangulo : Figuras_Geometricas
    {
        private readonly double alto;
        private readonly double ancho;
        public Triangulo(double alto, double ancho)

        {
            this.alto = alto;
            this.ancho = ancho;
        }

        public double ObtenerArea()
        {
            return (alto * ancho) / 2;
        }
        public class Circulo : Figuras_Geometricas
        {
            private const double pi = 3.1416;
            private readonly double radio;

            public Circulo (double radio)
            {
                this.radio = radio;
            }
            public double ObtenerArea()
            {
                return radio * radio * pi ;
            }
        }
    }
}