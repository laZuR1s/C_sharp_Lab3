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
            Console.WriteLine("Введите количество окружностей: ");
            int countOfCircles = int.Parse(Console.ReadLine());
            int countOfCrossing = 0;

            double[] xCord = new double[countOfCircles];
            double[] yCord = new double[countOfCircles];
            double[] radius = new double[countOfCircles];

            for (int i = 0; i < countOfCircles; i++)
            {
                Console.WriteLine("\nВведите данные окружности " +i+":\n");
                Console.WriteLine("Введите координату x: ");
                xCord[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите координату y: ");
                yCord[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите радиус окружности: ");
                radius[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < countOfCircles; i++)
            {
                for (int j = i + 1; j < countOfCircles; j++)
                {
                    double range = Math.Sqrt((xCord[i] - xCord[j]) * (xCord[i] - xCord[j]) + (yCord[i] - yCord[j]) * (yCord[i] - yCord[j]));
                    if (Math.Abs(radius[i] - radius[j]) <= range && range <= (radius[i] + radius[j]))
                    {
                        countOfCrossing++;
                    }
                }
            }

            Console.WriteLine("Всего пересекающихся окружностей: "+ countOfCrossing);


        }
    }
}
