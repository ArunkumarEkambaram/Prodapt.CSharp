namespace Prodapt.CSharp.Day5
{
    internal class Example2
    {
        //Instance Varaible or Non-Static Variable
        int num1 = 10;

        //Static variable
       public static int num2 = 100;


        static void Main(string[] args)
        {
            Example2 obj1 = new Example2();
            Console.WriteLine(obj1.num1);
            obj1.num1 = 100;
            Console.WriteLine(obj1.num1);
            Console.WriteLine();
            Example2 obj2 = new Example2();
            Console.WriteLine(obj2.num1);
            obj2.num1 = 5000;
            Console.WriteLine(obj2.num1);
            Console.WriteLine("Static Example");
            Console.WriteLine($"Static Value :{Example2.num2}");
            Example2.num2 = 2222;
            Console.WriteLine($"Static Value :{Example2.num2}");
            Console.WriteLine() ;
            ExecuteClass obj = new ExecuteClass();
            obj.Manipulate();
        }
    }

    public class ExecuteClass
    {
        public void Manipulate()
        {
            Example2.num2 = 100000;
            Console.WriteLine($"Static Value in Another Class :{Example2.num2}");
        }
    }
}
