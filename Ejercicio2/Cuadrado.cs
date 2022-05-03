namespace EjerciciosOCP.Ejercicio2
{
    public class Cuadrado : Figuras_Geometricas
    {
        private readonly double Lado;

        public Cuadrado(double lado)
        {
            Lado = lado;
        }

        public double ObtenerLado() => Lado;
        public double ObtenerArea() => Lado*Lado;
    }
}