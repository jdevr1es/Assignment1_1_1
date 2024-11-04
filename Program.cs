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
        }
    }
}
