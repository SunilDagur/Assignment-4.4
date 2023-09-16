using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4._4
{
    using System;

    public class Temperature
    {
        private double celsius;

        public double Celsius
        {
            get { return celsius; }
            set { celsius = value; }
        }

        public double Fahrenheit
        {
            get
            {
                
                return (celsius * 9 / 5) + 32;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Temperature temperature = new Temperature();
            temperature.Celsius = 25; 

            Console.WriteLine($"Celsius: {temperature.Celsius}");
            Console.WriteLine($"Fahrenheit: {temperature.Fahrenheit}");
        }
    }

}
