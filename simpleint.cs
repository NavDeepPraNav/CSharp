using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace xxx
{
    class Program
    {
       static void Main(string[] args)
        {
         int n;
       int r;
        double p;
        double si;
        
        Console.WriteLine("enter the principle amount");
        p = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("enter the rate of interest");
        r = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("enter the no of years");
        n = Convert.ToInt16(Console.ReadLine());
             si=(p*n*r)/100;
        Console.WriteLine("simple interest is{0}", si);
        Console.ReadLine();
        }
    }

}
