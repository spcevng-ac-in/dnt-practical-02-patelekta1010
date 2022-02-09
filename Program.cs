using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Distance : ");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Weight : ");
            double weight = Convert.ToDouble(Console.ReadLine());

            int rate = 0;
            if (distance < 100)
                rate = 50;
            else if (distance < 200)
                rate = 65;
            else if (distance < 300)
                rate = 90;
            else
                rate = 120;
            double totalCost = weight * rate;

            Console.WriteLine("The total cost is : " +totalCost);
            Console.Read();
        }
         
    }
}
