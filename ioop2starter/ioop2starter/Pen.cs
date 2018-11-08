using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioop2starter
{
    class Pen
    {
        //Static Properties
        private static uint NumberOfPens = 0;

        //Properties
        public string Name;
        public string Color;
        public float Price;
        private uint PercentInkRemaining;
        private bool IsEmpty; 


        //Constructors
        public Pen()
        {
            PercentInkRemaining = 100;
            IsEmpty = false;
            NumberOfPens++;
        }

        public Pen(string name, string color, float price)
        {
            Name = name;
            Color = color;
            Price = price;
            PercentInkRemaining = 100;
            IsEmpty = false;
            NumberOfPens++;

        }


        //Methods
        public void HowManyPens()
        {
            Console.WriteLine("Number of Pens = " + NumberOfPens);
        }

        public void SetInkLevel(uint level)
        {
            if (level > 100 || level < 0)
            {
                Console.Write("Hey bozo.. that's not a good amount");
                return;
            }
            PercentInkRemaining = level;
        }


        public void WriteName()
        {
            Console.WriteLine("My name is " + this.Name);
        }

        public void WriteColor()
        {
            Console.WriteLine("My color is " + this.Color);
        }

        public void WriteInkLevel()
        {
            Console.WriteLine("I have " + this.PercentInkRemaining + "% ink remaining.");
        }

        public void UseInk(uint percentToUse)
        {
            this.PercentInkRemaining -= percentToUse;
        }

        public void Refill()
        {
            this.PercentInkRemaining = 100;
        }

        public float GetCurrentMonetaryValue()
        {
            return (this.PercentInkRemaining / 100.0f * this.Price);
        }
    }
}
