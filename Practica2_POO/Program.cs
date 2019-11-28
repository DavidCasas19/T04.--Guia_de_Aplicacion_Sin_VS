using System;

namespace Practica2_POO
{
    class Program
    {
        static void Main(string[] args)
        {
         //Mandamos a llamar a los metodos
            Principal op = new Principal();
            op.Bienvenida();
            Console.WriteLine("   ");
            op.Valor();
            Console.WriteLine("   ");
            op.Menu();
        }
    }
}
