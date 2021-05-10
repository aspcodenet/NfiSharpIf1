using System;

namespace NfiSharpIf1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in ett tal:");
            int talet = Convert.ToInt32(Console.ReadLine());
            if (talet > 10)
            {
                Console.WriteLine("Talet är större än 10.");
            }
            else if(talet < 10)
            {
                Console.WriteLine("Talet är mindre än 10.");
            }

        }
    }
}
