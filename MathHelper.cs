using Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    public class MathHelper
    {
        public static int PrintValue(int a, int b) 
        {
            return a + b;
        }

        public static int PrintValue (bool a) 
        {
          if (a == true)
                return 1;
          else
           return 0;
        }
        public static void PrintValue (string a, string b)
        {
            Console.WriteLine( a + b);
        }

        public static int  PrintValue (int a, int b, int c) 
        {
            return a * b * c;
        }
    }


}
internal class Program
{
    static void Main(string[] args)
    {
        int sum = MathHelper.PrintValue(3, 5);
        Console.WriteLine(sum);
        int boolresult = MathHelper.PrintValue(true);
        Console.WriteLine(boolresult);
        MathHelper.PrintValue("Hi,", "Bayim!");
        int product = MathHelper.PrintValue(6, 10, 5);
        Console.WriteLine(product);
    }
}
