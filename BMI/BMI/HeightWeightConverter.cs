using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class HeightWeightConverter
    {
        public double HeightConverter(string type,double value)
        {
            if (type.Equals("cm"))
            {
                return Math.Round((value*(0.01)),2);
            }
            else if (type.Equals("yd"))
            {
                return Math.Round((value * 0.91), 2);
            }
            else if (type.Equals("ft"))
            {
                return Math.Round((value * 0.31), 2);
            }
            else
            {
                return Math.Round((0.025), 2);
            }
        }
        public double WeightConverter(double value)
        {
            return Math.Round((value * 0.5), 2);
        }
    }
}
