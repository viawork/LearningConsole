using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyApp
{
    public abstract class Devise
    {
        string type { get; set; }
        int memory { get; set; }
        

        //int storage;
        //string processor;
        // выводим вид девайса
        public void ShowType()
        {
            Console.WriteLine(this.type);
            //MessageBox();
        }


    }
}
