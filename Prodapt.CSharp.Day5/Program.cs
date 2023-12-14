namespace Prodapt.CSharp.Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var today = DateTime.Now;
            Console.WriteLine($"Today :{today}");
            Console.WriteLine($"Date Only :{today.ToShortDateString()}");
            Console.WriteLine($"Date Only :{DateTime.Now.ToShortDateString()}");
            Console.WriteLine($"Time Only :{today.ToShortTimeString()}");
            Console.WriteLine($"Time Only :{DateTime.Now.ToShortTimeString()}");
            Console.WriteLine($"Long Date :{today.ToLongDateString()}");
            Console.WriteLine($"Long Time only :{today.ToLongTimeString()}");
        }
    }
}
