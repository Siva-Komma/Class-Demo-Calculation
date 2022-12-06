using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{
    public class Sum
    {
        public void Add(int num1, int num2)
        {
            int results = num1 + num2;
            Console.WriteLine ("Addion of num1 and num2:"+results);
        }
    }
}
