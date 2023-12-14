using System;

namespace Prodapt.CSharp.Day5
{
    //Rename = Ctrl + R, Ctrl + R
    public class Example4
    {
        //Instance Constructor
        public Example4()
        {
            Console.WriteLine("Instance Constructor Called");
        }

        //Static Constructor
        static Example4()
        {
            Console.WriteLine("Static Constructor Called");
        }

        static void Main(string[] args)
        {
            Example4 obj = new Example4();
            Example4 obj2 = new Example4();
        }
    }
}
