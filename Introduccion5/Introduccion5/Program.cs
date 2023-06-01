using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dada una edad, decir si el niño/a es adolescente o adulto
            //13 a 18 adolescencia

            int edad;

            edad = 13;

            if (edad >=18)
            {
                Console.WriteLine("Eres adulto");
            }
            else if (edad >=13 && edad < 18) //forma 2
            {
                Console.WriteLine("Eres Adolescente");
            }
            ////if edad >= 13 && edad < 18)
            //if (edad < 18) 

            //{   if (edad >= 13)
            //    Console.WriteLine("Eres adolescente");
            //}
            if (edad < 13)
            {

                Console.WriteLine("Eres niño");
            }
            Console.WriteLine("Presione Enter para continuar");
            Console.ReadLine();
        
        }
    }
}
