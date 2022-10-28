namespace TestMaximum
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("find Max number among Values");

            //int output = FindMaximum.MaximumIntegerNumber(23, 54, 84);
            //Console.WriteLine(output);

            //double doubleoutput = FloatNumber.MaximumFloatNumber(234.43, 342.32, 44.54);
            //Console.WriteLine(doubleoutput);

            //string stringoutput = StringMaximum.MaximumStringNumber("43", "67", "34");
            //Console.WriteLine(stringoutput);

            //int[] intArray = { 112, 123, 234, 345 };
            //GenericMaxNumber<int> generic = new GenericMaxNumber<int>(intArray);
            //generic.PrintMaxValue();

            //double[] doubleArray = { 112.33, 123.53, 234.43, 345.63 };
            //GenericMaxNumber<double> genericDouble = new GenericMaxNumber<double>(doubleArray);
            //genericDouble.PrintMaxValue();

            //string[] stringArray = { "234","673","359", "872"};
            //GenericMaxNumber<string> genericString = new GenericMaxNumber<string>(stringArray);
            //genericString.PrintMaxValue();

            Console.WriteLine("The max Number Among 4 String numbers is:-\n " + ("Orange", "Dragonfruit", "Banana", "mango"));
            Console.WriteLine("The max Number Among 4 Integer numbers is:-\n " + (14, 22, 27, 55));
            Console.WriteLine("The max Number Among 4 Float numbers is:-\n " + (39.5f, 96.98f, 98.99f, 77.6f));
        }

    }
}