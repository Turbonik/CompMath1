using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CompMath1
{
    public class Function
    {
        public static float x; 
        public static float accuracy = (float)Math.Pow(10, -3); // 10^-7.2247 предел точности для Ньютона

    }

    public static class Methods
    {
        static Function function = new Function();
        
        public static bool Accuracy_condition(float xnew, float xlast) {  return Math.Abs(xnew - xlast) > Function.accuracy; }
        public static bool Is_Positive(float x) { return Math.Abs(x) == x; }
        public static float Count1Function(float x)
        {
            return 2 * x * x * x * x - 24 * x * x - x + 8;
        }
        public static float Count1DFunction(float x)
        {
            return 8 * x * x * x - 48 * x - 1;
        }
        public static float Count2Function(float x)
        {
            return 100 * x * x - 10000 * x - 4; // v = 4
        }
        public static float Count2DFunction(float x)
        {
            return 200 * x - 10000;
        }
        public static float SimpleIterations(float x, float lyamda, Func<float, float> func)
        {
            Console.WriteLine();
            float xnew = x; 
            float xlast = x;
            int count = 1; 
            do
            {
                xlast = xnew;
                xnew = xnew + lyamda * func(xnew);
                Console.WriteLine($" После {count} итерации: x{count} = {xnew}");
                count++;
             
            } while (Methods.Accuracy_condition(xnew, xlast));
        
            return 0;
        }
        public static float Neuton(float x, Func<float, float> func, Func<float, float> funcD)
        {
            Console.WriteLine();
            int count = 1; float xnew = x;
            float xlast = x;
            do
            {
                xlast = xnew;
                xnew = xnew - func(xnew) / funcD(xnew);
                Console.WriteLine($" После {count} итерации: x{count} = {xnew}");
                count++;
               
            } while (Methods.Accuracy_condition(xnew, xlast));
       
            return 0;
        }
        public static float Bisection(Interval interval, Func<float, float> func)
        {
            Console.WriteLine();
            float left = interval.left;
            float right = interval.right;
            bool left_sign;
            bool right_sign;
            bool middle_sign;
            int count = 1;
            float xnew = (left + right) / 2; 
            float xlast = xnew;
            do
            {
                left_sign = Is_Positive(func(left));
                right_sign = Is_Positive(func(right));
                middle_sign = Is_Positive(func(xnew));
                if(left_sign != middle_sign)
                {
                    right = xnew;
                }
                else if(middle_sign != right_sign)
                {
                    left = xnew;
                }
                xlast = xnew;
                xnew = (left + right) / 2;
                Console.WriteLine($" После {count} итерации: x{count} = {xnew}");
         
                count++;
            } while (Methods.Accuracy_condition(xnew, xlast));
          
            return 0;
        }
    }

}
