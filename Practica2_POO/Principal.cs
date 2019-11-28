using System;

namespace Practica2_POO
{
   public class Principal
    {
         //Instanciamos el valor V para que el usuario pueda elegir los numeros que quiera
        Valores V = new Valores();
        //Un metodo para darle la bienvenida al usuario y ser humildes
        public void Bienvenida()
        {
            Console.WriteLine("Bienvenido a la mejor calculadora del mundo");
            Console.ReadKey();
        }
        public void Menu()
        {
            //Diseñamos las opciones de operaciones que tiene el usuario
            Console.WriteLine("Que operacion quiere realizar:");
            Console.WriteLine("1.-Sumar");
            Console.WriteLine("2.-Restar");
            Console.WriteLine("3.Multiplicar");
            Console.WriteLine("4.-Dividir");
            Console.WriteLine("5.-Salir");


            double res;
            Operacion op = new Operacion();
            int n = Convert.ToInt32(Console.ReadLine());
            //Hacemos un switch para hacer el menu y el usuario eliga la operacion que quiera realizar
            switch (n)
            {
                case 1:
                   res =op.Suma(V);
                    Console.WriteLine("La respues es"+" " +res);
                    Console.ReadKey();
                    Console.WriteLine("  ");
                    Menu();
                    break;

                case 2:
                    res = op.Resta(V);
                    Console.WriteLine("La respues es" + " " + res);
                    Console.ReadKey();
                    Console.WriteLine("  ");
                    Menu();
                    break;

                case 3:
                    res = op.Multiplicar(V);
                    Console.WriteLine("La respues es" + " " + res);
                    Console.ReadKey();
                    Console.WriteLine("  ");
                    Menu();
                    break;


                case 4:
                    res = op.Division(V);
                    Console.WriteLine("La respues es" + " " + res);
                    Console.ReadKey();
                    Console.WriteLine("  ");
                    Menu();
                    break;

                case 5:
                    Console.WriteLine("Gracias por usar la mejor calculadora del mundo ");
                    Console.ReadKey();
                    Environment.Exit(0);
                    Console.ReadKey();
                    break;

                //Ponemos un default por si el usuario ingresa otro valor
                default:
                    Console.WriteLine("Introduzca uno de los 5 numeros");
                    Menu();
                    break;
            }
        }
        //Hacemos una clase para pedirle los valores al usuario
        public void Valor()
        {
            //le pedimos al usuario que ingrese los valores 
            Console.WriteLine("Ingrese el primer valor:");

            V.ValorA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("  ");

            Console.WriteLine("Ingrese el segundo valor");

            V.ValorB = Convert.ToDouble(Console.ReadLine());

        }
    }
}
    
