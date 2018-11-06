using System;
using System.Globalization;

namespace SixthPerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            double Glic;

            Glic = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (Glic <= 100.00){
                Console.WriteLine("Normal");

            }
            else if (Glic <= 140.0){
                Console.WriteLine("Nivel de Glicose Elevado.");
            }

            else {
                Console.WriteLine("Mano, Tu tá com Diabetes, Fera.");
            }

            Console.ReadLine();
        }
    }
}
