using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables inicialización
            int numero1, numero2, resultado, multiplicacion;

            numero1 = 10;
            numero2=20;

            //lógica

            resultado= numero1 + numero2;
            multiplicacion = numero1 * numero2;
            
            if ( numero1 < numero2) 
            {
                Console.WriteLine("numero1 menor mumero2");          
            }
            if ( numero1 > numero2) 
            { 
            Console.WriteLine("numero1 mayor numero2");
            }
            if(numero1 == numero2)
            {
                Console.WriteLine("numero1 igual numero2");
            }
            //visualización

            Console.WriteLine(numero1 +" + " + numero2 + " = " + resultado);
            Console.WriteLine(numero1 + " * " + numero2 + " = " + multiplicacion);

            Console.WriteLine("Hola Mundo");

            Console.WriteLine("Presione Enter para salir");
            Console.ReadLine();
        }
    }
}
