namespace SquareConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive number: ");
            var strInput = Console.ReadLine();
            var number = String.IsNullOrEmpty(strInput) ? 0 : Convert.ToInt32(strInput);
            Console.WriteLine($"The square root of {number} is {SquareCalc.SquareCalculator.SquareRoot(number)}");
            Console.ReadKey();
        }
    }
}