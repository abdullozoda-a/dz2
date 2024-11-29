using System;

namespace dz2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choise the weigth: 1 == kilogram, 2 == milligram, 3 == gram, 4 == tonne"); var number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your weight:");double weight = double.Parse(Console.ReadLine());
            double mass = 0;

            switch (number)
            {
                case 1: 
                    mass = weight;
                    break;
                case 2: 
                    mass = weight * 0.000001;
                    break;
                case 3: 
                    mass = weight * 0.001;
                    break;
                case 4: 
                    mass = weight * 1000;
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }

            Console.WriteLine(mass);
        }
    }
}