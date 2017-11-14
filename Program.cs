using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            String Tam_car, res_do_lavado, color_auto, reparado, contraseña, res_tarj;
            Double Saldo = 50.00, descuento_lavado = 0, paquete_completo = 0, tam_pieza, detallado_expres = 0, descuento_color = 0, reparacion = 0, costo_base = 10, descuento_pz = 0, costo_pz = 0, nuevo_saldo = 0, acumulador_total = 0, acumulador_lavado = 0, acumulador_det = 0, acumulador_fb = 0;
            Int32 menu_op = 0, res_lavado = 0, lavado_completo = 0, lavado_tolvas = 0, abrillantado = 0, detallado_general = 0, res_detallado = 0, operaciones = 0;
            do
            {
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
                menu_op = Convert.ToInt32(Console.ReadLine());
                //Switch de cada opcion del menu principal
                switch (menu_op)
                {
                    //Lavado 
                    case 1:
                        //Menu de lavado
                        Console.WriteLine("Elige una opcion: ");
                        Console.WriteLine("1.Lavado Completo (Compacto:100$ - Sedan:125$ -SUV:150$)");
                        Console.WriteLine("2.Lavado de Tolvas(Compacto:65$ - Sedan:70$ -SUV:80$) ");
                        Console.WriteLine("3.Abrillantado de vidrio (Compacto:50$ - Sedan:65$ -SUV:90$)");
                        Console.WriteLine("4.Detallado general (Compacto:70$ - Sedan:80$ -SUV:90$)");
                        Console.WriteLine("5.Paquete completo  (Compacto:256$ - Sedan:306$ -SUV:369$)");
                        res_lavado = Convert.ToInt32(Console.ReadLine());

                        if (Saldo >=50)
                        {
                            Console.WriteLine("Cual es el tamaño del vehiculo? (Compacto - Sedan - SUV)");
                            Tam_car = Console.ReadLine();

                            if (Tam_car == "Compacto" || Tam_car == "compacto")
                            {
                                do
                                {
                                    //Switch del menu de lavado tamaño compacto
                                    switch (res_lavado)
                                    {
                                        case 1:
                                            if (Saldo >= 100)
                                            {
                                                lavado_completo = 100;
                                                Saldo = Saldo - lavado_completo;
                                                operaciones++;
                                                acumulador_lavado = acumulador_lavado + lavado_completo;
                                                acumulador_total = acumulador_total + acumulador_lavado;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Lo lamento tu saldo es insuficiente");
                                            }
                                            break;
                                        case 2:
                                            if (Saldo >= 65)
                                            {
                                                lavado_tolvas = 65;
                                                Saldo = Saldo - lavado_tolvas;
                                                operaciones++;
                                                acumulador_lavado = acumulador_lavado + lavado_tolvas;
                                                acumulador_total = acumulador_total + acumulador_lavado;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Lo lamento tu saldo es insuficiente");
                                            }
                                            break;
                                        case 3:
                                            abrillantado = 50;
                                            Saldo = Saldo - abrillantado;
                                            operaciones++;
                                            acumulador_lavado = acumulador_lavado + abrillantado;
                                            acumulador_total = acumulador_total + acumulador_lavado;
                                            break;
                                        case 4:
                                            if (Saldo >= 70)
                                            {
                                                detallado_general = 70;
                                                Saldo = Saldo - detallado_general;
                                                operaciones++;
                                                acumulador_lavado = acumulador_lavado + detallado_general;
                                                acumulador_total = acumulador_total + acumulador_lavado;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Lo lamento tu saldo es insuficiente");
                                            }

                                            break;
                                        case 5:
                                            if (Saldo >= 285)
                                            {
                                                descuento_lavado = ((100 + 65 + 50 + 70) * 10) / 100;
                                                paquete_completo = (100 + 65 + 50 + 70) - descuento_lavado;
                                                Saldo = Saldo - paquete_completo;
                                                operaciones++;
                                                acumulador_lavado = acumulador_lavado + paquete_completo;
                                                acumulador_total = acumulador_total + acumulador_lavado;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Lo lamento tu saldo es insuficiente");
                                            }

                                            break;
                                        default:
                                            Console.WriteLine("Error, respuesta no encontrada");
                                            break;
                                    }
                                    Console.WriteLine("¿Quieres otro servicio de lavado?");
                                    res_do_lavado = Console.ReadLine();
                                } while (res_do_lavado == "Si" || res_do_lavado == "si" || res_do_lavado == "SI");
                            }
                            else if (Tam_car == "Sedan" || Tam_car == "sedan")
                            {
                                //Switch del menu de lavado tamaño sedan
                                switch (res_lavado)
                                {
                                    case 1:
                                        if (Saldo >= 125)
                                        {
                                            lavado_completo = 125;
                                            Saldo = Saldo - lavado_completo;
                                            operaciones++;
                                            acumulador_lavado = acumulador_lavado + lavado_completo;
                                            acumulador_total = acumulador_total + acumulador_lavado;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Lo lamento tu saldo es insuficiente");
                                        }
                                        break;
                                    case 2:
                                        if (Saldo >= 70)
                                        {
                                            lavado_tolvas = 70;
                                            Saldo = Saldo - lavado_tolvas;
                                            operaciones++;
                                            acumulador_lavado = acumulador_lavado + lavado_tolvas;
                                            acumulador_total = acumulador_total + acumulador_lavado;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Lo lamento tu saldo es insuficiente");
                                        }
                                        break;
                                    case 3:
                                        abrillantado = 65;
                                        Saldo = Saldo - abrillantado;
                                        operaciones++;
                                        acumulador_lavado = acumulador_lavado + abrillantado;
                                        acumulador_total = acumulador_total + acumulador_lavado;
                                        break;
                                    case 4:
                                        if (Saldo >= 80)
                                        {
                                            detallado_general = 80;
                                            Saldo = Saldo - detallado_general;
                                            operaciones++;
                                            acumulador_lavado = acumulador_lavado + detallado_general;
                                            acumulador_total = acumulador_total + acumulador_lavado;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Lo lamento tu saldo es insuficiente");
                                        }
                                        break;
                                    case 5:
                                        if (Saldo >= 285)
                                        {
                                            descuento_lavado = ((125 + 70 + 65 + 80) * 10) / 100;
                                            paquete_completo = (125 + 70 + 65 + 80) - descuento_lavado;
                                            Saldo = Saldo - paquete_completo;
                                            operaciones++;
                                            acumulador_lavado = acumulador_lavado + paquete_completo;
                                            acumulador_total = acumulador_total + acumulador_lavado;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Lo lamento tu saldo es insuficiente");
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("Error, respuesta no encontrada");
                                        break;
                                }
                            }
                            else if (Tam_car == "SUV" || Tam_car == "suv")
                            {
                                //Switch del menu de lavado tamaño SUV
                                switch (res_lavado)
                                {
                                    case 1:
                                        if (Saldo >= 150)
                                        {
                                            lavado_completo = 150;
                                            Saldo = Saldo - lavado_completo;
                                            operaciones++;
                                            acumulador_lavado = acumulador_lavado + lavado_completo;
                                            acumulador_total = acumulador_total + acumulador_lavado;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Lo lamento tu saldo es insuficiente");
                                        }

                                        break;
                                    case 2:
                                        if (Saldo >= 80)
                                        {
                                            lavado_tolvas = 80;
                                            Saldo = Saldo - lavado_tolvas;
                                            operaciones++;
                                            acumulador_lavado = acumulador_lavado + lavado_tolvas;
                                            acumulador_total = acumulador_total + acumulador_lavado;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Lo lamento tu saldo es insuficiente");
                                        }
                                        break;
                                    case 3:
                                        abrillantado = 90;
                                        Saldo = Saldo - abrillantado;
                                        operaciones++;
                                        acumulador_lavado = acumulador_lavado + abrillantado;
                                        acumulador_total = acumulador_total + acumulador_lavado;
                                        break;
                                    case 4:
                                        if (Saldo >= 90)
                                        {
                                            detallado_general = 90;
                                            Saldo = Saldo - detallado_general;
                                            operaciones++;
                                            acumulador_lavado = acumulador_lavado + detallado_general;
                                            acumulador_total = acumulador_total + acumulador_lavado;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Lo lamento tu saldo es insuficiente");
                                        }
                                        break;
                                    case 5:
                                        if (Saldo >= 380)
                                        {
                                            descuento_lavado = ((150 + 80 + 90 + 90) * 10) / 100;
                                            paquete_completo = (150 + 80 + 60 + 90) - descuento_lavado;
                                            Saldo = Saldo - paquete_completo;
                                            operaciones++;
                                            acumulador_lavado = acumulador_lavado + paquete_completo;
                                            acumulador_total = acumulador_total + acumulador_lavado;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Lo lamento tu saldo es insuficiente");
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("Error, respuesta no encontrada");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Tamaño no encontrado");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Lo lamento tu saldo es {0:C} por favor haz una recarga",Saldo);
                        }

                        break;
                    case 2:
                        //Pregnta sobre el color del auto para verificar si se le aplica el 15%
                        Console.WriteLine("¿De qué color es su automovil? ");
                        color_auto = Console.ReadLine();
                        //Menu de detallado
                        Console.WriteLine("Elige una opcion: ");
                        Console.WriteLine("1.Detallado Express ");
                        Console.WriteLine("2.Reparación de defensa ");
                        Console.WriteLine("3.Reparación de rines ");
                        res_detallado = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Cual es el tamaño del vehiculo? (Compacto - Sedan - SUV");
                        Tam_car = Console.ReadLine();
                        switch (res_detallado)
                        {
                            case 1:
                                if (Saldo > 0)
                                {
                                    //Condicional del Tamaño del carro en Compacto
                                    if (Tam_car == "compacto" || Tam_car == "Compacto")
                                    {
                                        if (Saldo >= 50)
                                        {
                                            //Condicional del color del vehiculo
                                            if (color_auto == "rojo" || color_auto == "Rojo" || color_auto == "negro" || color_auto == "Negro")
                                            {
                                                descuento_color = (50 * 15) / 100;
                                                detallado_expres = 50 - descuento_color;
                                                Saldo = Saldo - detallado_expres;
                                                operaciones++;
                                                acumulador_det = acumulador_det + detallado_expres;
                                                acumulador_total = acumulador_total + acumulador_det;
                                            }
                                            else
                                            {
                                                detallado_expres = 50;
                                                Saldo = Saldo - detallado_expres;
                                                operaciones++;
                                                acumulador_det = acumulador_det + detallado_expres;
                                                acumulador_total = acumulador_total + acumulador_det;
                                            }
                                        }
                                        else
                                        {
                                            //Respuesta en que el usuario no tenga un saldo menor al de este servicio
                                            Console.WriteLine("Lo lamento tu saldo es insuficiente para este servicio");
                                        }
                                    }
                                    //Condicional del Tamaño del carro en Sedan
                                    else if (Tam_car == "sedan" || Tam_car == "Sedam")
                                    {
                                        if (Saldo >= 75)
                                        {
                                            //Condicional del color del vehiculo
                                            if (color_auto == "rojo" || color_auto == "Rojo" || color_auto == "negro" || color_auto == "Negro")
                                            {
                                                descuento_color = (75 * 15) / 100;
                                                detallado_expres = 75 - descuento_color;
                                                Saldo = Saldo - detallado_expres;
                                                operaciones++;
                                                acumulador_det = acumulador_det + detallado_expres;
                                                acumulador_total = acumulador_total + acumulador_det;
                                            }
                                            else
                                            {
                                                detallado_expres = 75;
                                                Saldo = Saldo - detallado_expres;
                                                operaciones++;
                                                acumulador_det = acumulador_det + detallado_expres;
                                                acumulador_total = acumulador_total + acumulador_det;
                                            }
                                        }
                                        else
                                        {
                                            //Respuesta en que el usuario no tenga un saldo menor al de este servicio
                                            Console.WriteLine("Lo lamento tu saldo es insuficiente para este servicio");
                                        }
                                    }
                                    //Condicional del Tamaño del carro en SUV
                                    else if (Tam_car == "suv" || Tam_car == "SUV")
                                    {
                                        if (Saldo >= 100)
                                        {
                                            //Condicional del color del vehiculo
                                            if (color_auto == "rojo" || color_auto == "Rojo" || color_auto == "negro" || color_auto == "Negro")
                                            {
                                                descuento_color = (100 * 15) / 100;
                                                detallado_expres = 100 - descuento_color;
                                                Saldo = Saldo - detallado_expres;
                                                operaciones++;
                                                acumulador_det = acumulador_det + detallado_expres;
                                                acumulador_total = acumulador_total + acumulador_det;
                                            }
                                            else
                                            {
                                                detallado_expres = 100;
                                                Saldo = Saldo - detallado_expres;
                                                operaciones++;
                                                acumulador_det = acumulador_det + detallado_expres;
                                                acumulador_total = acumulador_total + acumulador_det;
                                            }
                                        }
                                        else
                                        {
                                            //Respuesta en que el usuario no tenga un saldo menor al de este servicio
                                            Console.WriteLine("Lo lamento tu saldo es insuficiente para este servicio");
                                        }
                                    }
                                    else
                                    {
                                        //Respuesta en caso que el usuario ingrese el tamaño incorrecto
                                        Console.WriteLine("Tamanño del vehiculo incorrecto");
                                    }
                                }
                                else
                                {
                                    //Respuesta en que el usuario no tenga un saldo mayor a 0
                                    Console.WriteLine("Lo lamento tu saldo es insuficiente para este servicio");
                                }
                                break;
                            case 2:
                                //Pregunta para verificar el tipo de reparad
                                Console.WriteLine("¿Delantera o trasera?");
                                reparado = Console.ReadLine();
                                //Condicional del reparado delantero
                                if (reparado == "delantera" || reparado == "Delantera")
                                {
                                    if (color_auto == "rojo" || color_auto == "Rojo" || color_auto == "negro" || color_auto == "Negro")
                                    {
                                        descuento_color = (80 * 15) / 100;
                                        reparacion = 80 - descuento_color;
                                        Saldo = Saldo - reparacion;
                                        operaciones++;
                                        acumulador_det = acumulador_det + reparacion;
                                        acumulador_total = acumulador_total + acumulador_det;
                                    }
                                    else
                                    {
                                        reparacion = 80;
                                        Saldo = Saldo - reparacion;
                                        operaciones++;
                                        acumulador_det = acumulador_det + reparacion;
                                        acumulador_total = acumulador_total + acumulador_det;
                                    }
                                }

                                //Condicional del reparado trasero
                                else if (reparado == "trasera" || reparado == "Trasera")
                                {
                                    if (color_auto == "rojo" || color_auto == "Rojo" || color_auto == "negro" || color_auto == "Negro")
                                    {
                                        descuento_color = (75 * 15) / 100;
                                        reparacion = 75 - descuento_color;
                                        Saldo = Saldo - reparacion;
                                        operaciones++;
                                        acumulador_det = acumulador_det + reparacion;
                                        acumulador_total = acumulador_total + acumulador_det;
                                    }
                                    else
                                    {
                                        reparacion = 75;
                                        Saldo = Saldo - reparacion;
                                        operaciones++;
                                        acumulador_det = acumulador_det + reparacion;
                                        acumulador_total = acumulador_total + acumulador_det;
                                    }
                                }
                                else
                                {
                                    //Respuesta en caso que el usuario ingrese los caracteres incorrectos
                                    Console.WriteLine("Reparacion de defensa invalida");
                                }

                                break;
                            case 3:
                                if (color_auto == "rojo" || color_auto == "Rojo" || color_auto == "negro" || color_auto == "Negro")
                                {
                                    descuento_color = (100 * 15) / 100;
                                    reparacion = 100 - descuento_color;
                                    Saldo = Saldo - reparacion;
                                    operaciones++;
                                    acumulador_det = acumulador_det + reparacion;
                                    acumulador_total = acumulador_total + acumulador_det;
                                }
                                else
                                {
                                    reparacion = 100;
                                    Saldo = Saldo - reparacion;
                                    operaciones++;
                                    acumulador_det = acumulador_det + reparacion;
                                    acumulador_total = acumulador_total + acumulador_det;
                                }
                                break;
                            default:
                                Console.WriteLine("Opcion invalida");
                                break;
                        }

                        break;
                    case 3:
                        Console.WriteLine("Ingresa la dimension de la pieza en centimetros cuadrados");
                        tam_pieza = Convert.ToDouble(Console.ReadLine());
                        //Condicional para descuento de mas de 50 cm cuadrados
                        if (tam_pieza > 50 && tam_pieza < 100)
                        {
                            descuento_pz = (((tam_pieza / costo_base) * 15) * /*descuento -->*/5) / 100;
                            costo_pz = ((tam_pieza / costo_base) * 15) - descuento_pz;
                            Saldo = Saldo - costo_pz;
                            operaciones++;
                            acumulador_fb = acumulador_fb + costo_pz;
                            acumulador_total = acumulador_total + costo_pz;

                        }
                        else if (tam_pieza > 100 && tam_pieza < 150) //Condicional para descuento de mas de 100 cm cuadrados y menos de 150
                        {
                            descuento_pz = (((tam_pieza / costo_base) * 15) * /*descuento -->*/ 10) / 100;
                            costo_pz = ((tam_pieza / costo_base) * 15) - descuento_pz;
                            Saldo = Saldo - costo_pz;
                            operaciones++;
                            acumulador_fb = acumulador_fb + costo_pz;
                            acumulador_total = acumulador_total + costo_pz;
                        }
                        else if (tam_pieza > 150) //Condicional para descuento de mas de 150 cm cuadrados
                        {
                            descuento_pz = (((tam_pieza / costo_base) * 15) * /*descuento -->*/15) / 100;
                            costo_pz = ((tam_pieza / costo_base) * 15) - descuento_pz;
                            Saldo = Saldo - costo_pz;
                            operaciones++;
                            acumulador_fb = acumulador_fb + costo_pz;
                            acumulador_total = acumulador_total + costo_pz;
                        }
                        else if (tam_pieza > 0 && tam_pieza < 50)
                        {
                            costo_pz = ((tam_pieza / costo_base) * 15) - descuento_pz;
                            Saldo = Saldo - costo_pz;
                            operaciones++;
                            acumulador_fb = acumulador_fb + costo_pz;
                            acumulador_total = acumulador_total + costo_pz;
                        }
                        else
                        {
                            Console.WriteLine("El tamaño de la pieza es invalido");
                        }


                        break;
                    case 4:
                        //Pregunta para verificar si el usuario tiene tarjeta
                        Console.WriteLine("Tienes tarjeta");
                        res_tarj = Console.ReadLine();
                        //Condicional en caso de que si tenga
                        if (res_tarj == "si" || res_tarj == "Si")
                        {
                            Console.WriteLine("¿Cuanto saldo quieres recargar");
                            nuevo_saldo = Convert.ToDouble(Console.ReadLine());
                            Saldo = Saldo + nuevo_saldo;

                        }//Condicional en caso de que no tenga
                        else if (res_tarj == "no" || res_tarj == "No")
                        {
                            Console.WriteLine("El costo de una terjeta es de 25.00 $");
                            Console.WriteLine("¿Cuanto saldo quieres recargar");
                            nuevo_saldo = Convert.ToDouble(Console.ReadLine());
                            nuevo_saldo = nuevo_saldo - 25;
                            Saldo = Saldo + nuevo_saldo;
                        }

                        break;
                    case 5:
                        Console.WriteLine("Saldo: {0:C}", Saldo);
                        Console.WriteLine("Numero de operaciones: {0}", operaciones);

                        break;
                    case 6:
                        do
                        {
                            Console.WriteLine("Por favor introduzca la contraseña");
                            contraseña = Console.ReadLine();
                            if (contraseña == "LavaCar2017")
                            {
                                Console.WriteLine("Numero de operaciones: {0}", operaciones);
                                Console.WriteLine("Cantidad de lavado: {0:C}", acumulador_lavado);
                                Console.WriteLine("Cantidad de detallado: {0:C}", acumulador_det);
                                Console.WriteLine("Cantidad de reparacion de fibra de carbono: {0:C}");
                                Console.WriteLine("Cantidad total:{0:C}", acumulador_total);
                            } else
                            {
                                Console.WriteLine("Contraseña incorrecta");
                            }
                        } while (contraseña == "LavaCar2017");
                        break;
                    default:
                        Console.WriteLine("La opcion que escojiste es invalida");
                        break;
                }
            } while (menu_op != 6);
            Console.ReadKey();
        }
    }
}
