using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introducción_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Repartir una cuenta//

            int numeroPersonasEntero;
            float resultado;
            float valorCuentaFloat;
            string valorCuenta;
            string numeroPersonas;
            float igic;

            Console.Write("Escribe el número de personas: ");
            numeroPersonas = Console.ReadLine();

            Console.Write("Introduce valor de la cuenta: ");
            valorCuenta = Console.ReadLine();

            valorCuentaFloat = Convert.ToSingle(valorCuenta) * 1.0f;
            numeroPersonasEntero = Convert.ToInt32(numeroPersonas);

            resultado = valorCuentaFloat / numeroPersonasEntero;
            Console.WriteLine("A pagar: " + resultado);


            //Calcular el IGIC
            //regla de 3
            igic = 7 * valorCuenta / 100;
            Console.WriteLine("Presiona Enter para salir");
            Console.ReadLine();




            
            
            
            
            
            
            
            
            
            
            /*
            string valor1, valor2;
            int resultado;
            int valor1Entero, valor2Entero;

            Console.Write("Entra el primer número; ");
            valor1= Console.ReadLine();

            Console.Write("Entra el segundo número; ");
            valor2 = Console.ReadLine();

            valor1Entero = Convert.ToInt32(valor1);
            valor2Entero = Convert.ToInt32(valor2);
            resultado = valor1Entero + valor2Entero;
            Console.WriteLine(valor1 + " + " + valor2 + " = " + resultado);
            resultado = valor1Entero - valor2Entero;
            Console.WriteLine(valor1 + " - " + valor2 + " = " + resultado);
            resultado = valor1Entero * valor2Entero;
            Console.WriteLine(valor1 + " * " + valor2 + " = " + resultado);
            resultado = valor1Entero / valor2Entero;
            Console.WriteLine(valor1 + " / " + valor2 + " = " + resultado);


            Console.WriteLine("presiona Enter para salir");
            Console.ReadLine();
            */


        }
    }
}
