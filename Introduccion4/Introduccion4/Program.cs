using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion4
{
    internal class Program
    {
        //Dado la edad de una persona decir si es mayor e edad
        static void Main(string[] args)
        {
            int edad, mayoria;

            edad = 17;
            mayoria = 18;

            if (edad >= mayoria)
            {
                Console.WriteLine("Eres mayor de edad");
            }
            else
            {
                Console.WriteLine("Eres menor de edad");

            }
            Console.WriteLine("Presione Enter para continuar");
            Console.ReadLine();
        }
    }
}
