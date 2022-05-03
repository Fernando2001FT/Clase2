using System;
using System.Collections.Generic;
using System.Drawing;

namespace EjerciciosOCP.Ejercicio2
{
    public class CalculadoraAreas
    {
        private readonly List<Figuras_Geometricas> Figuras;
        
        public CalculadoraAreas(List<Figuras_Geometricas> figuras)
        {
            Figuras = figuras;
        }
        
        public double Calcular()
        {
            double area = 0;
            foreach (var figura in Figuras)
            {
                switch (figura)
                {
                    case Cuadrado cuadrado:
                        area += cuadrado.ObtenerArea();
                        break;
                    case Rectangulo rectangulo:
                        area += rectangulo.ObtenerArea();
                        break;
                }

                //area ++ figura.ObtenerArea(); 

                //Agregar circulo
            }
            return area;
        }
    }
}