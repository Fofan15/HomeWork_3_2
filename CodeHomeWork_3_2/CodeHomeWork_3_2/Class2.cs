using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeHomeWork_3_2
{
    public class Class2
    {
        public delegate bool PowDelegate(double value);

        private  double _result;

        public PowDelegate Calc(Func<double, double, double> powdelegate, double x, double y)
        {
            _result = powdelegate(x, y);
            return Result;
        }

        public  bool Result(double value) 
        {
            double remainder = _result % value;

            if (remainder == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
