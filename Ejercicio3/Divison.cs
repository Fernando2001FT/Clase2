using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosOCP.Ejercicio3
{
    public class Division : OperacionCalculadora
    {
        private readonly double Valor1;
        private readonly double Valor2;

        public Division(double valor1, double valor2)
        {
            Valor1 = valor1;
            Valor2 = valor2;
        }


        public double Obtenerdato ()
        {
            if (Valor2 !=0)
            {
                return Valor1 / Valor2;

            }
            else
            {
                throw new Exception(" operacion no soportada ");
            }
        }
        
    }
}
