using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximum
{
    public class GenericExtend<T> where T : IComparable
    {
        T value1, value2, value3, value4;

        public GenericExtend(T value1, T value2, T value3, T Value4)
        {
            this.value1 = value1;
            this.value2 = value2;
            this.value3 = value3;
            this.value4 = value4;
        }
        public static T Maximumavalue(T value1, T value2, T value3, T Value4)
        {
            if (value1.CompareTo(value2) > 0 && value1.CompareTo(value3) > 0)
            {

                return value1;

            }
            if (value2.CompareTo(value1) > 0 && value2.CompareTo(value3) > 0)
            {
                return value2;
            }
            if (value3.CompareTo(value3) > 0 && value3.CompareTo(value2) > 0)
            {
                return value3;
            }
            if (Value4.CompareTo(Value4) > 0 && Value4.CompareTo(value1) > 0)
            {
                return Value4;
            }
            throw new Exception("firstNumber , secondNumber , thirdNumber are same");

        }
    }
}
