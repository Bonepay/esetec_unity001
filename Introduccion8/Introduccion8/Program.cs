using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //tabla de multiplicar de un numero

             int tabla = 1;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(tabla + " * " + i + " = " + (tabla * i));
            }
            tabla = 2;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(tabla + " * " + i + " = " + (tabla * i));
            }

            tabla = 3;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(tabla + " * " + i + " = " + (tabla * i));
            }
            tabla = 4;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(tabla + " * " + i + " = " + (tabla * i));
            }

            //todas las tablas
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine(i + " * " + j + " = " + (j * i));
                }
            }
           
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                     Console.WriteLine("Par: " + i);
                else 
                    Console.WriteLine("Impar: " + i);
            }

            Console.ReadLine();
        }   
    }
}
