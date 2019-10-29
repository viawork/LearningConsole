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
            int height = 1;
            while (height > 0)
            {
               Console.WriteLine("Введите высоту");
               height = int.Parse(Console.ReadLine());
               triangle(height,true);
                figure fg = new figure();
                Figname(1);
               //triangle(height, false);
            }
        }
        /// <summary>
        ////выводит наименования фигур из списка
        /// </summary>
        /// <param name="number"></param>
        private static void Figname(byte number)
            {
                var figlist = new List < string >() {"точка","отрезок", "треугольник", "четырехугольник"};
                //figlist.
                foreach (var lelem in figlist)
                {
                    Console.WriteLine(lelem);
                }
            }
       private static void triangle( int height, bool direction)
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
