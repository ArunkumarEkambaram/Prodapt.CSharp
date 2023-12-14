using System.Text;

namespace Prodapt.CSharp.Day5
{
    internal class RLE
    {
        public string Encode(string message)
        {
            string encodedMessage="";
            int count = 1;

            for (int i = 1; i < message.Length; i++)
            {
                if (message[i] == message[i - 1])
                {
                    count++;
                }
                else
                {
                    encodedMessage += message[i - 1].ToString();
                    encodedMessage += count.ToString();
                    count = 1;
                }
            }

            encodedMessage += message[message.Length - 1].ToString();
            encodedMessage += count.ToString();

            return encodedMessage;
        }

        static void Main(string[] args)
        {
            RLE obj = new();
            var result = obj.Encode("AABAB");
            Console.WriteLine(result);
        }
    }
}
