using EjerciciosOCP.Ejercicio3;
using System;
using System.Collections.Generic;

namespace EjerciciosOCP.Ejercicio3
{
    public class Calculadora
    {
        public double Calcular(OperacionCalculadora operacionCalculadora)
        {
            return operacionCalculadora.Obtenerdato();
                 }
    }
}

