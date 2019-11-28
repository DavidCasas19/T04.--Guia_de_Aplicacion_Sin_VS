using System;

namespace Practica2_POO
{
   public class Operacion
    {
        //Declaramos res globalmente para que las operacion tenga una variable para el resultado
        double res;
        //Hacemos sus respectivos metodos de cada operacion 
        public double Suma(Valores V)

        {

            res = V.ValorA + V.ValorB;
            return res;

        }
        public double Resta(Valores V)

        {
            res = V.ValorA - V.ValorB;
            return res;

        }
        public double Multiplicar(Valores V)

        {
            res = V.ValorA * V.ValorB;
            return res;

        }
        public double Division(Valores V)

        {
            res = V.ValorA / V.ValorB;
            return res;

        }
    }
}
