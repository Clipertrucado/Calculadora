using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Servicios
{
    internal class MenuImplementacion : MenuInterface
    {
        

        public int Menu() 
        {
            
            int opcionIntroducida;

            Console.WriteLine("#################################");
            Console.WriteLine("      0. Cerrar aplicación");
            Console.WriteLine("      1. Suma");
            Console.WriteLine("      2. Resta");
            Console.WriteLine("      3. Multiplicación");
            Console.WriteLine("      4. División");
            Console.WriteLine("#################################");

            opcionIntroducida = Console.ReadKey(true).KeyChar - ('0');

            return opcionIntroducida;

        }
        
    }
}
