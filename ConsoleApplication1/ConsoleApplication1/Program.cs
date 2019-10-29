using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
           // int height = 1;
           // while (height > 0)
            {
              // Console.WriteLine("Введите высоту");
               //height = int.Parse(Console.ReadLine());
                // Triangle(height,true);
                Figure fg = new Figure();
                fg.ShowType();
                Figname(1);
               //triangle(height, false);
               Console.ReadKey();
            }
        }
        /// <summary>
        ////выводит наименования фигур из списка
        /// </summary>
        /// <param name="number"></param>
        private static void Figname(byte number)
            {
            List<string> figlist = new List<string>() { "точка", "отрезок", "треугольник", "четырехугольник" };
            /*
            foreach (string lelem in figlist)
                {
                    Console.WriteLine(lelem);
                }
                */
            string[] teams = { "Бавария", "Боруссия", "Реал Мадрид", "Манчестер Сити", "ПСЖ", "Барселона" };
            var selectedTeams = teams.Where(t => t.ToUpper().StartsWith("Б")).OrderBy(t => t).ToArray();
            var selectedTeamsArray = teams.Where(t => t.ToUpper().EndsWith("а")).OrderBy(t => t).ToArray();
            foreach (string s in selectedTeams) // вычисление 1
            {
                 Console.WriteLine(s);
            }
            foreach (string s in selectedTeamsArray) // вычисление 1
            {
                 Console.WriteLine(s);
            }


        }
        private static void Triangle(int height)
        {
            int maxWidth = height;
            int minWidth = 0; 


            for (int i = minWidth; i < maxWidth; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            //Console.WriteLine();

            for (int i = minWidth; i < maxWidth; i++)
            {
                for (int j = i; j < maxWidth; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
           

        }

    }
}
