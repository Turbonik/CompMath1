using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CompMath1
{
    public class Interval
    {
        public float left; public float right;
        public Interval(float left, float right)
        {
            this.left = left; this.right = right;
        }
        public float Get_mid()
        {
            return (this.left + this.right) / 2;
        }

        public float Count_Lyambda(Func<float, float> funcd)
        {
            
            bool Dfunc_sign = Methods.Is_Positive(funcd(this.left));
       
            float left = Math.Abs(funcd(this.left));
            float right = Math.Abs(funcd(this.right));

            float high = Math.Max(left, right);

            if (Dfunc_sign)
            {
                high = -high;
            }
                
            return 1/high;
        }
    }
}