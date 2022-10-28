using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximum
{
    public class StringMaximum
    {
        public static string MaximumStringNumber(string firststring,string secondstring,string thirdstring)
        {
            if(firststring.CompareTo(secondstring) > 0 && firststring.CompareTo(thirdstring) > 0)
            {
                return firststring;
            }
            if(secondstring.CompareTo(firststring) > 0 && secondstring.CompareTo(thirdstring) > 0)
            {
                return secondstring;
            }
            if(thirdstring.CompareTo(thirdstring) > 0 && thirdstring.CompareTo(secondstring) > 0)
            {
                return thirdstring;
            }
            throw new Exception("firstNumber , secondNumber , thirdNumber are same");
        }
    }
}
