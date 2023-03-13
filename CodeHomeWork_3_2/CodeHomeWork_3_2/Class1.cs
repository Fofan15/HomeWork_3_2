using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeHomeWork_3_2
{
    public class Class1
    {
        public delegate void ShowDelegate (bool value);

        public  double Pow(double x, double y) 
        {
            double result = x * y;

            return result;
        }
    }
}
