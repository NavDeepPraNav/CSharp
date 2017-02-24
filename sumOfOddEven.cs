using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace second_program
{
    class Program
    { static void Main(string[] args)
        {
            int evensum=0, oddsum=0;
            int[] arr = new int[10];
            Console.WriteLine("enter the array elements");
            for (int i = 0; i<10; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i<10; i++)
            {
                if (arr[i]%2==0)
                    evensum += arr[i];
                else
                    oddsum += arr[i];
            }
            Console.WriteLine("evensum is {0}", evensum);
            Console.WriteLine("oddsum is {0}", oddsum);
            Console.ReadLine();
}

    }
}
