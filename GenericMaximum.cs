using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximum
{
    public class GenericMaximum<T> where T : IComparable
    {
        public T firstvalue, secondvalue, thirdvalue;

        public GenericMaximum(T firstvalue, T secondvalue, T thirdvalue)
        {
            this.firstvalue = firstvalue;
            this.secondvalue = secondvalue;
            this.thirdvalue = thirdvalue;
        }

        public static T MaxValue(T firstvalue, T secondvalue, T thirdvalue)
        {
            if(firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) > 0)
            {
                return firstvalue;
            }
            if(secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) > 0)
            {
                return secondvalue;
            }
            if(thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) > 0)
            {
                return thirdvalue;
            }
            return default;
        }

        public T MaxMethod()
        {
            T max = GenericMaximum<T>.MaxValue(this.firstvalue, this.secondvalue, this.thirdvalue);
            return max;
        }
    }
}
