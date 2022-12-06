using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Sum s = new Sum();
            Console.WriteLine("enter 1st number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            s.Add(num1,num2);
            Console.ReadLine();
        }
    }
}
