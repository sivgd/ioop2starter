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

            Pen colter = new Pen();
            colter.Name = "The Colter Pen";
            colter.HowManyPens();


            Pen jackie = new Pen("Jackelin", "Green", 1.50f);
            jackie.HowManyPens();
            colter.HowManyPens();




            
            Console.ReadKey();
        }
    }
}
