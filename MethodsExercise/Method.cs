using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise
{
    public class Method
    {
        public static int Add (int x, int y)
        {
            int sum = x + y;
            return sum;

        }
        public static int Multiply (int x, int y)
        {
            int product = x * y;
            return product;
        }
        public static int Divide (int x, int y) 
        {
            int quotient = x / y;
            return quotient;
        }
        public static int Subtract (int x, int y)
        {
            int difference = x - y;
            return difference;
        }
        public static int Remainder (int x, int y)
        {
            int remainder = x % y;
            return remainder;
        }

        
    }
}
