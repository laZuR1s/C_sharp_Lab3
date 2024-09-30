using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Lab3
{
    internal class Program
    {

        static void Main(string[] args)
        {

            int countOfCircles;
            do
            {
                Console.WriteLine("Введите количество окружностей: ");

            } while (!int.TryParse(Console.ReadLine(), out countOfCircles) || countOfCircles < 0);

            int countOfCrossing = 0;

            double[] xCord = new double[countOfCircles];
            double[] yCord = new double[countOfCircles];
            double[] radius = new double[countOfCircles];
            bool[] isCrossing = new bool[countOfCircles];

            for (int i = 0; i < countOfCircles; i++)
            {
                Console.WriteLine("\n-----------------------------------------");
                Console.WriteLine("\nВведите данные окружности " + (i + 1) + ":\n");
                do
                {
                    Console.WriteLine("\nВведите координату x: ");

                } while (!double.TryParse(Console.ReadLine(), out xCord[i]));

                do
                {
                    Console.WriteLine("\nВведите координату y: ");

                } while (!double.TryParse(Console.ReadLine(), out yCord[i]));

                do
                {
                    Console.WriteLine("\nВведите радиус окружности: ");

                } while (!double.TryParse(Console.ReadLine(), out radius[i]) || radius[i] < 0);
                isCrossing[i] = false;
            }

            for (int i = 0; i < countOfCircles; i++)
            {
                for (int j = i + 1; j < countOfCircles; j++)
                {
                    double range = Math.Sqrt((xCord[i] - xCord[j]) * (xCord[i] - xCord[j]) + (yCord[i] - yCord[j]) * (yCord[i] - yCord[j]));
                    if (Math.Abs(radius[i] - radius[j]) <= range && range <= (radius[i] + radius[j]))
                    {
                        if (!isCrossing[i] && !isCrossing[j])
                        {
                            countOfCrossing += 2;
                            isCrossing[i] = true;
                            isCrossing[j] = true;
                        }
                        else
                        {
                            if (!isCrossing[i] && isCrossing[j]|| isCrossing[i] && !isCrossing[j])
                            {
                                countOfCrossing++;
                                isCrossing[i] = true;
                                isCrossing[j] = true;
                            }
                        }
                    }
                }
            }
            Console.WriteLine("\n-----------------------------------------");

            Console.WriteLine("\nВсего пересекающихся окружностей: " + countOfCrossing);

        }
    }
}
