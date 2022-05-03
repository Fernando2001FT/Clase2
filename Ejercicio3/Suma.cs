using System;

namespace EjerciciosOCP.Ejercicio3
{
    public class Suma : OperacionCalculadora
    {
        private readonly double Valor1;
        private readonly double Valor2;

        public Suma(double valor1, double valor2)
        {
            Valor1 = valor1;
            Valor2 = valor2;
        }



       public double Obtenerdato()
        {
            return Valor1 + Valor2;
        }


    }
}