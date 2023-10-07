using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("\nMenú de opciones:");
                Console.WriteLine("1. Sumar dos números enteros.");
                Console.WriteLine("2. Calcular salario.");
                Console.WriteLine("3. Calcular salario neto.");
                Console.WriteLine("Salir");
                Console.WriteLine("\nIngrese su opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.Write("\nIngrese el primer número: ");
                            int num1 = Convert.ToInt32(Console.ReadLine());

                            Console.Write("\nIngrese el segundo número: ");
                            int num2 = Convert.ToInt32(Console.ReadLine());

                            SumarDosNumeros(num1, num2);
                            break;
                        case 2:
                            Console.Write("\nIngrese el número de horas trabajadas: ");
                            int horasTrabajadas = Convert.ToInt32(Console.ReadLine());

                            Console.Write("\nIngrese el precio por hora: ");
                            double precioPorHora = Convert.ToInt32(Console.ReadLine());

                            CalcularSalario(horasTrabajadas, precioPorHora);
                            break;
                        case 3:
                            Console.Write("\nIngrese el número de horas trabajadas: ");
                            int hTrabajadas = Convert.ToInt32(Console.ReadLine());

                            Console.Write("\nIngrese el precio por hora: ");
                            double precioPHora = Convert.ToInt32(Console.ReadLine());

                            CalcularSalarioNeto(hTrabajadas, precioPHora);
                            break;
                        case 4:
                            Console.Write("\nSaliendo del programa...");
                            break;
                        default:
                            Console.Write("\nOpción no válida. Intente de nuevo.");
                            break;
                    }
                }
                else
                {
                    Console.Write("\nOpción no válida. Intente de nuevo.");
                }
            }while (opcion != 4);
        }


        static void SumarDosNumeros(int num1, int num2)
        {
            int suma = num1 + num2;
            Console.Write("\nLa suma es: " + suma);
        }

        static void CalcularSalario(int horasTrabajadas, double precioPorHora)
        {
            double salario = horasTrabajadas * precioPorHora;

            Console.Write("\nEl salario es: $" + salario);
        }

        static void CalcularSalarioNeto(int hTrabajadas, double precioPHora)
        {
            double SalarioNeto = hTrabajadas * precioPHora;
            double limiteISSS = 30;

            if (SalarioNeto > 1000)
            {
                SalarioNeto -= limiteISSS;
            }
            Console.Write("\nEl salario es: $" + SalarioNeto);
        }
    }
}