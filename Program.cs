namespace Assignment1_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            string myName = Console.ReadLine();
            Console.WriteLine("Please enter your age: ");
            double myAge = Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("Please enter your address: ");
            string myAddress = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("My name is "+myName);
            Console.WriteLine("My age is "+myAge);
            Console.WriteLine("My address is "+myAddress);

            //Assignment 1.1.2
            int intValue1 = 10;
            int intValue2 = 20;

            float fltValue1 = 5.5F;
            float fltValue2 = 6.5F;

            double doubleValue1 = 30.25;
            double doubleValue2 = 60.25;

            decimal decValue1 = 100.55M;
            decimal decValue2 = 200.45M;

            int maxInt = Math.Max(intValue1, intValue2);
            int minInt = Math.Min(intValue1, intValue2);
            Console.WriteLine("Max integer is :" + maxInt);
            Console.WriteLine("Min integer is :" +  minInt);

            float maxFloat = Math.Max(fltValue1, fltValue2);
            float minFloat = Math.Min(fltValue1, fltValue2);

            //Assignment 1.1.3 and 4
            //Another comment

        }
    }
}
