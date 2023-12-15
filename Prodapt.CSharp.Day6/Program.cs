namespace Prodapt.CSharp.Day6
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            int[] arr = new int[10];
            arr[0] = 10;
            arr[2] = 34;
            arr[1] = 23;
            arr[3] = 6;
            arr[5] = 55;
            arr[6] = -8;

            string[] cities = new string[3] { "Chennai", "Bengaluru", "Madurai" };

            string[] names = new string[] { "Prabhu", "Kumar" };

            //Accept value from User using For Loop

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"Enter a number :");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Using For Loop");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"Index :{i} is {arr[i]}");
            //}

            //Sorting
            // Array.Sort(arr);

            //Reverse
            //Array.Reverse(arr);

            //Copy array from another
            // int[] arr2 = arr;
            int[] arr2 = new int[4];
            arr2 = arr;

            //Array.Copy(arr, arr2, 3);
            //Array.Copy(arr, 2, arr2, 3, 1);

            //Resize
            //Array.Resize(ref arr, 20);

            Console.WriteLine("Using Foreach Loop");
            foreach (int x in arr2)
            {
                Console.WriteLine(x);
            }
        }
    }
}
