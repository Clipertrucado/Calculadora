using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Servicios
{
    internal interface OperacionInterface
    {
        /// <summary>
        /// Se realiza la suma 
        /// 101023 - sav
        /// </summary>
        /// <returns></returns>
        public int Suma(int n1, int n2);

        /// <summary>
        /// Se realiza la resta
        /// 101023 - sav
        /// </summary>
        /// <returns></returns>
        public int Resta(int n1, int n2);

        /// <summary>
        /// Se realiza la multiplicacion
        /// 101023 - sav
        /// </summary>
        /// <returns></returns>
        public int Multi(int n1, int n2);

        /// <summary>
        /// Se realiza la division
        /// 101023 - sav
        /// </summary>
        /// <returns></returns>
        public int Divi(int n1, int n2);

        /// <summary>
        /// Se realiza la pedida de los datos
        /// 101023 - sav
        /// </summary>
        /// <returns></returns>
        public int Datos();
    }
}
