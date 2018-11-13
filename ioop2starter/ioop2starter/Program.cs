using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioop2starter
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("I.OOP.0x02:::::");

            //Create some pens...

            Pen expo = new Pen("Expo", "Purple", 1.50f);
            expo.WriteName();
            expo.SetInkLevel(60);
            expo.WriteInkLevel();
            expo.SetInkLevel(9001);
            expo.WriteInkLevel();

            expo.PrintPenCount();

            Pen bic = new Pen();

            bic.PrintPenCount();
            expo.PrintPenCount();


            Console.ReadKey();
        }
    }
}
