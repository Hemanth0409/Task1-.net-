using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1_;
using Task1_.net_; 

namespace task1programTest3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a decimal Number:");
            float f=float.Parse(Console.ReadLine());
            decimal d=Convert.ToDecimal(Console.ReadLine());
            double D=Convert.ToDouble(Console.ReadLine());  

            Console.WriteLine($"The value of float:{f},The value of decimal:{d},'/n'the value of Double {D}");   





            var x = new task1program2();
            x.program2();
            Console.ReadLine();
        }
    }
}
