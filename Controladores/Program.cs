
using Calculadora.Servicios;

namespace Calculadora 
{
    /// <summary>
    /// Clase principal del programa
    /// 101023 - sav
    /// </summary>

    class Program 
    {
        /// <summary>
        /// Metodo de entrada a la aplicación
        /// 101023 - sav
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            //creamos un objeto de la clase MenuImplementación
            MenuInterface menuInterfaz = new MenuImplementacion();
            OperacionInterface operacionInter = new OperacionImplementacion();

            //creamos un tipo bool para poder cerrar el while
            bool cerrarMenu = false;

            // este int sera el encargado de guardar el valor seleccionado en el menu
            int opcionSeleccionada;
            
            //crearemos un while para que nos mantengamos en el menu siempre que no se diga lo contrario
            while (!cerrarMenu)
            {
                //llamamos al metodo menu 
                opcionSeleccionada = menuInterfaz.Menu();


                Console.WriteLine(opcionSeleccionada);

                // este int contendra el resultado de la llamada
                int num1;
                int num2;
                int resul;

                
                num1 = operacionInter.Datos();
                num2 = operacionInter.Datos();

                //compara la opcion seleccionada y entra en el casos correcto
                switch (opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("[INFO] - se ejecuta caso uno 0");
                        cerrarMenu = true;
                        break;

                    case 1:
                        
                        resul = operacionInter.Suma(num1,num2);
                        Console.WriteLine("El resultado de la suma es: "+ resul);
                        break;

                    case 2:
                        
                        resul = operacionInter.Resta(num1, num2);
                        Console.WriteLine("El resultado de la resta es: " + resul);
                        break;

                    case 3:
                       
                        resul = operacionInter.Multi(num1, num2);
                        Console.WriteLine("El resultado de la multiplicación es: " + resul);
                        break;

                    case 4:
                    
                        resul = operacionInter.Divi(num1, num2);
                        Console.WriteLine("El resultado de la división es: " + resul);
                        break;

                }

            }

        }

    }

}
