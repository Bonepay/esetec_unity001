using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // XXXXXXXXX
            // X       X
            // X       X
            // X       X
            // XXXXXXXXX
           Metodo2();

           Console.ReadLine();
        }
        static public void Metodo2()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++) 
                {
                    if (i == 0 || i == 9)
                    {
                        Console.Write("X");                       
                    }
                    else
                    {
                        if (j == 0 || j == 9)
                        {
                            Console.Write("X");
                        }
                        else 
                        { 
                            Console.Write(" "); 
                        }    
                        
                    }
                    
                }
                Console.WriteLine();
            }
            
        }
    }
}
