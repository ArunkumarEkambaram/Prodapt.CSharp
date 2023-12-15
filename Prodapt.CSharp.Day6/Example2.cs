using System;

namespace Prodapt.CSharp.Day6
{
    public class Example2
    {
        //array in parameter
        public void GetElements(int[] elements, string[] names)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                Console.WriteLine(elements[i]);
            }
            Console.WriteLine(names[2]);
        }
        public int[] GetValues(int[] values)
        {
            return new int[] { 2, 3, 4, 5 };
        }
        static void Main(string[] args)
        {
            Example2 obj = new Example2();
            int[] t1 = { 1, 3, 5, 6, 7 };
            string[] names = { "a", "b", "c" };
            obj.GetElements(t1, names);
            var output = obj.GetValues(t1);           
            Console.WriteLine(string.Join("-", output));
            // obj.GetElements(new int[] { 1, 2, 3, 4, 5 });
            //obj.GetElements(new[] { 3, 33, 333, 3333 }, new[] { "Sanjai", "Karthick", "Lokesh" });
        }
    }
}
