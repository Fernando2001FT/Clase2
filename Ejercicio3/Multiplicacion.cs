﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosOCP.Ejercicio3
{
    public class Multiplicacion : OperacionCalculadora
    {
        private readonly double Valor1;
        private readonly double Valor2;

        public Multiplicacion(double valor1, double valor2)
        {
            Valor1 = valor1;
            Valor2 = valor2;
        }

     
        public double Obtenerdato()
        {
            return Valor1 * Valor2;
        }


    }
}
