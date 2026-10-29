namespace Ciclos1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables globales
            byte op = 0;
            do
            {
                //Despliegue del menú de opciones
                Console.WriteLine("\n*** COMPENDIO DE CICLO 1  ***");
                Console.WriteLine("\n   MENU DE OPCIONES");
                Console.WriteLine("1. Caras de un dado");
                Console.WriteLine("2. Múltiplos de 7");
                Console.WriteLine("3. Suma mayor a 100");
                Console.WriteLine("4. Suma de pares/Multiplicación impares");
                Console.WriteLine("5. Serie de Fibonacci");
                Console.WriteLine("6. Salir");
                Console.Write("Opción: ");
                op = Convert.ToByte(Console.ReadLine());
                
                //VALIDAR LA ENTRADA PARA QUE SOLO ACEPTE NUMEROS ENTRE 1 Y 6
                switch (op)  //PROGRAMAR CADA UNO DE LOS CASOS
                {
                    case 1:
                        Console.WriteLine("Leer un número entero obtenido al lanzar un dado de seis caras");
                        Console.WriteLine("e imprimir el número en letras de la cara opuesta ");
                        Console.WriteLine("En las caras opuestas de un dado están los números 1-6 /2-5/3-4");
                        Console.WriteLine("Si el número capturado en menor a 1 o mayor que 6 mostrará el mensaje de error");
                        int caraDado = 0;
                        Console.WriteLine("Ingrese el número de la cara del dado");
                        caraDado = Convert.ToInt16(Console.ReadLine());
                        if (caraDado >= 1 && caraDado <= 6)
                        {
                          int  caraOp = 7 - caraDado;
                          Console.WriteLine("la cara opuesta es:" +caraOp);
                        }
                         else
                         {
                             Console.WriteLine("Error: el dado solo tiene números del 1 al 6");
                         }
                        break;

                        
                    case 2:
                        Console.WriteLine("Mostrar los múltiples de 7 entre el 0 y 150");
                        
                        break;
                    case 3:
                        Console.WriteLine("Sumar un conjunto de números hasta que la suma sea mayor que 100");
                        break;
                    case 4:
                        Console.WriteLine("Sumar los números pares y multiplicar los impares, hasta que la suma sea mayor que 50");
                        Console.WriteLine("o el producto mayor que 150");
                        break;
                    case 5:
                        Console.WriteLine("Calcular la serie de fibonacci de un número ingresado por el usuario");
                        byte n;
                        uint fib=0,fib2=1,r;
                        Console.WriteLine("Ingrese un numero del 1 - 255");
                        n = Convert.ToByte(Console.ReadLine());
                        for (int i = 0; i <= n; i++)
                        {
                            Console.Write($"{fib} ");
                            r = fib;
                            fib += fib2;
                            fib2 = r;
                        }
                        break;
                    case 6:
                        Console.WriteLine("Derechos reservados!\nGracias por usar el programa");
                        op = 6;
                        break;
                    default:
                        Console.WriteLine("Opción no valida");
                        break;
                }
                Console.WriteLine("Presione una tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
            } while (op <= 5 || op>6);
            Console.WriteLine("Hecho por: Rodrigo Palomares Sanchez");
        }
    }
}
