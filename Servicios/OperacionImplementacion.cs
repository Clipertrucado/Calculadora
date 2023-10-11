using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Servicios
{
    internal class OperacionImplementacion : OperacionInterface
    {

        public int Divi(int n1, int n2)
        {
            int n3 = n1 / n2;

            return n3;
        }
        public int Multi(int n1, int n2)
        {
            int n3 = n1 * n2;

            return n3;
        }

        public int Resta(int n1, int n2)
        {
            int n3 = n1 - n2;

            return n3;
        }

        public int Suma(int n1 ,int n2)
        {
            int n3 = n1 + n2;

            return n3;

        }

        public int Datos()
        {
            int n1;

            Console.WriteLine("Ingresa un número");
            n1 = Convert.ToInt32(Console.ReadLine());

            return (n1);
        }
    }
}
