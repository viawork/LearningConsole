using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyApp
{
    public class Figure
    {
        public string type { get; set; }

        // выводим вид девайса
        public void ShowType()
        {
            Console.WriteLine(type);
            //MessageBox();
        }
        public void DrawFigure(int height)
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

