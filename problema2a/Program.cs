using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema2a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalDemanda = 0;
            int menorDemanda = int.MaxValue;
            int mayorDemanda = int.MinValue;
            int totalDiasProduccion = 0;
            int totalDemandaDia = 0;

            // Empezamos con el mes 1

            int mes = 1; 

            while (mes <= 6)
            {
                Console.WriteLine($"Ingrese la demanda esperada para el mes {mes}:");
                int demanda = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Ingrese los días de producción para el mes {mes}:");
                int dias = Convert.ToInt32(Console.ReadLine());

                int demandaDia = demanda / dias;

                totalDemanda += demanda;
                totalDiasProduccion += dias;
                totalDemandaDia += demandaDia;

                if (demanda < menorDemanda)
                    menorDemanda = demanda;
                if (demanda > mayorDemanda)
                    mayorDemanda = demanda;

                double porcentajeDemanda = (double)demanda / totalDemanda * 100;

                Console.WriteLine($"Mes: {mes}");
                Console.WriteLine($"Demanda: {demanda}");
                Console.WriteLine($"Días de Producción: {dias}");
                Console.WriteLine($"Demanda/Día: {demandaDia}");
                Console.WriteLine($"Porcentaje de Demanda: {porcentajeDemanda}%");
                Console.WriteLine();

                mes++;
            }

            double promedioDemanda = (double)totalDemanda / 6;

            Console.WriteLine("Estadísticas Globales:");
            Console.WriteLine($"Total de Demanda: {totalDemanda}");
            Console.WriteLine($"Promedio de Demanda: {promedioDemanda}");
            Console.WriteLine($"Menor Demanda: {menorDemanda}");
            Console.WriteLine($"Mayor Demanda: {mayorDemanda}");
            Console.WriteLine($"Total de Días de Producción: {totalDiasProduccion}");
            Console.WriteLine($"Total de Demanda del Día: {totalDemandaDia}");

            Console.ReadKey();
        }
    }
}
