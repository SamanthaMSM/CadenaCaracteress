using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nombre;

            Console.WriteLine("¿Cuál es su nombre?");
            Nombre = Console.ReadLine();

            Console.WriteLine("\nBienvenido " + Nombre + " ¿Desea ver el menú?");
            Console.ReadKey();
        }
    }
}