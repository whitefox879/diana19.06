using System.ComponentModel.Design;
using System.Diagnostics;

namespace _19._06._2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string line = Console.ReadLine();
           string[] parts = line.Split(" ");
           Dictionary<string, int> intCount = new Dictionary<string, int>();
            while (line != "Stop")
            {
                line = Console.ReadLine();
                foreach (string part in parts)
                {
                    if (intCount.ContainsKey(part))
                    {
                        int count = intCount[part];
                    }
                    else
                    {
                        int count = 5;
                    }
                }
         
        }
            Console.WriteLine("Stop");
        }
    }
}
