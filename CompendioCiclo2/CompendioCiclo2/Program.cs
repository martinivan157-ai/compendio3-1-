namespace CompendioCiclo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables globales
            byte op = 0;
            do
            {
                Console.Write("Ingrese la opcion que desea utilizar" +
                    "\n1.- Promedio de Calificaciones" +
                    "\n2.- Sumatoria de Numeros" +
                    "\n3.- Fracciones" +
                    "\n4.- Cantidad de ceros" +
                    "\n5.- Sucesion de Ulam" +
                    "\n6.- Cantidad de Positivos y Negativos" +
                    "\n7.- Velocidad pelota" +
                    "\n8.- Numero perfecto" +
                    "\n9.- Factorial" +
                    "\n10.- Coordenadas");

                Console.Write("\nOpción: ");
                op = Convert.ToByte(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        //Calificaiones
                        //Declaracion de variables
                        float prom = 0;
                        short suma = 0;

                        //Entrada de datos
                        for (int i = 0; i < 7; i++)
                        {
                            Console.WriteLine("Ingrese la calificacion");
                            suma += Convert.ToByte(Console.ReadLine());
                        }
                        //Procesamiento
                        prom = suma / 7;
                        //Salida de datos
                        if (prom > 70)
                        {
                            Console.WriteLine($"Su promedio final es de {prom}");
                            Console.WriteLine("Aprobado");
                        }
                        else
                        {
                            Console.WriteLine($"Su promedio final es de {prom}");
                            Console.WriteLine("Reprobado");
                        }
                        break;
                    case 2:
                        //Declaracion de variables
                        //Entrada de datos
                        //Procesamiento
                        //Salida de datos
                        break;
                    case 3:
                        //Declaracion de variables
                        //Entrada de datos
                        //Procesamiento
                        //Salida de datos
                        break;
                    case 4:
                        //Declaracion de variables
                        //Entrada de datos
                        //Procesamiento
                        //Salida de datos
                        break;
                    case 5:
                        //Declaracion de variables
                        //Entrada de datos
                        //Procesamiento
                        //Salida de datos
                        break;
                    case 6:
                        //Declaracion de variables
                        //Entrada de datos
                        //Procesamiento
                        //Salida de datos
                        break;
                    case 7:
                        //Declaracion de variables
                        //Entrada de datos
                        //Procesamiento
                        //Salida de datos
                        break;
                    case 8:
                        //Declaracion de variables
                        //Entrada de datos
                        //Procesamiento
                        //Salida de datos
                        break;
                    case 9:
                    //Declaracion de variables
                    //Entrada de datos
                    //Procesamiento
                    //Salida de datos
                    case 10:
                        //Declaracion de variables
                        //Entrada de datos
                        //Procesamiento
                        //Salida de datos
                        break;
                    default:
                        Console.WriteLine("Opción no valida");
                        break;

                }
                Console.WriteLine("Presione una tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
            } while (op <= 5 || op > 6);
            Console.WriteLine("Hecho por: Rodrigo Palomares Sanchez");
        }
    }
}
