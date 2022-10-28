using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace TestMaximum
{
    public class GenericMaxNumber<T> where T : IComparable
    {
        public T[] value;

        public GenericMaxNumber(T[] value)
        {
            this.value = value;
        }
        public T[] sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        public T MaxValue(params T[] values)
        {
            var sorted_values = sort(values);
            return sorted_values[^1];
        }
        public T MaxMethod()
        {
            var max = MaxValue(this.value);
            return max;
        }
        public void PrintMaxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("maximum value is " + max);
        }
    }
}
