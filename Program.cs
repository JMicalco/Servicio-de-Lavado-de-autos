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
            String Tam_car, res_do_lavado;
            Double Saldo = 0.00, descuento_lavado = 0, paquete_completo = 0;
            Int32 menu_op = 0, res_lavado = 0, lavado_completo = 0, lavado_tolvas = 0, abrillantado = 0, detallado_general = 0;

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


            Console.WriteLine("Elige una opción del menu (Ingresa el numero de la opción)");
            //Switch de cada opcion del menu principal
            switch (menu_op)
            {
                //Lavado 
                case 1:
                    Console.WriteLine("Cual es el tamaño del vehiculo? (Compacto - Sedan - SUV");
                    Tam_car = Console.ReadLine();
                    //Menu de lavado
                    Console.WriteLine("Elige una opcion: ");
                    Console.WriteLine("1.Lavado Completo ");
                    Console.WriteLine("2.Lavado de Tolvas ");
                    Console.WriteLine("3.Abrillantado de vidrio ");
                    Console.WriteLine("4.Detallado general ");
                    Console.WriteLine("5.Paquete completo  ");
                    res_lavado = Convert.ToInt32(Console.ReadLine());

                    //Tamaño compatco
                    if (Tam_car == "Compacto" || Tam_car == "compacto")
                    {
                        do
                        {
                            //Condicional para verificar que el saldo es mayor a 0
                            if (Saldo > 0)
                            {
                                //Condicional para verificar que el saldo es mayor a la cantidad minia de cualquier servicio de lavado
                                if (Saldo < 45)
                                {
                                    //Switch del menu de lavado tamaño compacto
                                    switch (res_lavado)
                                    {
                                        case 1:
                                            lavado_completo = 100;
                                            Saldo = Saldo - lavado_completo;
                                            break;
                                        case 2:
                                            lavado_tolvas = 65;
                                            Saldo = Saldo - lavado_tolvas;
                                            break;
                                        case 3:
                                            abrillantado = 50;
                                            Saldo = Saldo - abrillantado;
                                            break;
                                        case 4:
                                            detallado_general = 70;
                                            Saldo = Saldo - detallado_general;
                                            break;
                                        case 5:
                                            descuento_lavado = ((100 + 65 + 50 + 70) * 10) / 100;
                                            paquete_completo = (100 + 65 + 50 + 70) - descuento_lavado;
                                            Saldo = Saldo - paquete_completo;
                                            break;
                                        default:
                                            Console.WriteLine("Error, respuesta no encontrada");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Lo lamento tu saldo es insuficiente para realizar cualquier tipo de servico de lavado");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Lo lamento tu saldo es 0 por favor haz una recarga");
                            }
                            Console.WriteLine("¿Quieres otro servicio de lavado");
                            res_do_lavado = Console.ReadLine();
                        } while (res_do_lavado == "Si" || res_do_lavado == "si" || res_do_lavado == "SI");
                    }

                    //Tamaño Sedan
                    if (Tam_car == "sedan" || Tam_car == "Sedan")
                    {
                        do
                        {
                            //Condicional para verificar que el saldo es mayor a 0
                            if (Saldo > 0)
                            {
                                //Condicional para verificar que el saldo es mayor a la cantidad minia de cualquier servicio de lavado
                                if (Saldo < 45)
                                {
                                    //Switch del menu de lavado tamaño sedan
                                    switch (res_lavado)
                                    {
                                        case 1:
                                            lavado_completo = 125;
                                            Saldo = Saldo - lavado_completo;
                                            break;
                                        case 2:
                                            lavado_tolvas = 70;
                                            Saldo = Saldo - lavado_tolvas;
                                            break;
                                        case 3:
                                            abrillantado = 65;
                                            Saldo = Saldo - abrillantado;
                                            break;
                                        case 4:
                                            detallado_general = 80;
                                            Saldo = Saldo - detallado_general;
                                            break;
                                        case 5:
                                            descuento_lavado = ((125 + 70 + 65 + 80) * 10) / 100;
                                            paquete_completo = (125 + 70 + 65 + 80) - descuento_lavado;
                                            Saldo = Saldo - paquete_completo;
                                            break;
                                        default:
                                            Console.WriteLine("Error, respuesta no encontrada");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Lo lamento tu saldo es insuficiente para realizar cualquier tipo de servico de lavado");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Lo lamento tu saldo es 0 por favor haz una recarga");
                            }
                            Console.WriteLine("¿Quieres otro servicio de lavado");
                            res_do_lavado = Console.ReadLine();
                        } while (res_do_lavado == "Si" || res_do_lavado == "si" || res_do_lavado == "SI");
                    }

                    //Tamaño SUV
                    if (Tam_car == "SUV" || Tam_car == "suv")
                    {
                        do
                        {
                            //Condicional para verificar que el saldo es mayor a 0
                            if (Saldo > 0)
                            {
                                //Condicional para verificar que el saldo es mayor a la cantidad minia de cualquier servicio de lavado
                                if (Saldo < 45)
                                {
                                    //Switch del menu de lavado tamaño SUV
                                    switch (res_lavado)
                                    {
                                        case 1:
                                            lavado_completo = 150;
                                            Saldo = Saldo - lavado_completo;
                                            break;
                                        case 2:
                                            lavado_tolvas = 80;
                                            Saldo = Saldo - lavado_tolvas;
                                            break;
                                        case 3:
                                            abrillantado = 60;
                                            Saldo = Saldo - abrillantado;
                                            break;
                                        case 4:
                                            detallado_general = 90;
                                            Saldo = Saldo - detallado_general;
                                            break;
                                        case 5:
                                            descuento_lavado = ((150 + 80 + 60 + 90) * 10) / 100;
                                            paquete_completo = (150 + 80 + 60 + 90) - descuento_lavado;
                                            Saldo = Saldo - paquete_completo;
                                            break;
                                        default:
                                            Console.WriteLine("Error, respuesta no encontrada");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Lo lamento tu saldo es insuficiente para realizar cualquier tipo de servico de lavado");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Lo lamento tu saldo es 0 por favor haz una recarga");
                            }
                            Console.WriteLine("¿Quieres otro servicio de lavado");
                            res_do_lavado = Console.ReadLine();
                        } while (res_do_lavado == "Si" || res_do_lavado == "si" || res_do_lavado == "SI");
                    }

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
                default:
                    break;



            }
        }
    }
}
