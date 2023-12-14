using System;

namespace Prodapt.CSharp.Day5
{
    public class Example6
    {
        public string name;
        public static string city;
        //Instance Method
        public void GetData()
        {
            Console.Write("Enter Name :");
            name = Console.ReadLine();
            Console.Write("Enter City :");
            city = Console.ReadLine();
        }
        //Static Method
        public static void PrintData()
        {
            Console.WriteLine($"City :{city}");
        }
        static void Main(string[] args)
        {
            Example6 obj = new Example6();
            obj.GetData();//Chennai
            Example6 obj2=new Example6();
            obj2.GetData();//Bengaluru
            Example6.PrintData();
        }
    }
}
