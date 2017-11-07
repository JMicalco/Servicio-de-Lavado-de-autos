using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio_de_lavado_de_autos___PF
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            String Tam_car;
            Double Saldo = 0.00;
            Int32 menu_op = 0;

            //Titulo del programa
            Console.WriteLine("::: Servicio de lavado de autos :::");
            //Menu
            Console.WriteLine("Menu:");
            Console.WriteLine("1.Lavado");
            Console.WriteLine("2.Detallado ");
            Console.WriteLine("3.Aplicación de fibra de carbono");
            Console.WriteLine("4.Conmpra de tarjeta/Recarga de saldo");
            Console.WriteLine("5.Consulta de saldo");
            Console.WriteLine("6.Cierre de dia ");
            do
            {

                //Elegir opciones del menu
                Console.WriteLine("Elige una opción del menu (Ingresa el numero de la opción)");
                //Switch de cada opcion 
                switch (menu_op)
                {
                    case 1:
                        Console.WriteLine("Cual es el tamaño del vehiculo?");
                        Tam_car = Console.ReadLine();
                        Console.WriteLine("Lavado Completo");
                        Console.WriteLine("Lavado de Tolvas");
                        Console.WriteLine("Abrillantado de vidrio");
                        Console.WriteLine("Detallado general");
                        Console.WriteLine("Paquete completo");

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;

                
gggabbsj
  
        }
    }
}
