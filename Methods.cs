using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CompMath1
{
    public class Function
    {
        
        private static float x;
        private static float y = 2 * Methods.Power(x, 4) - 24 * Methods.Power(x, 2) - x + 8;
        private static float dy = 8 * Methods.Power(x, 3) - 48 * x - 1;
        private static float accuracy = 0.001f;
        private static float intervals;

    }

    public static class Methods
    {
        public static float Power(float x, short y)
        {
            for (int i = 1; i < y; i++)
            {
                x *= x;
            }
            return x;
        }

        public static float SimpleIterations(float x)
        {
            float xf = 2 * Methods.Power(x, 4) - 24 * Methods.Power(x, 2) + 8;

        }
    }
   
  
}
