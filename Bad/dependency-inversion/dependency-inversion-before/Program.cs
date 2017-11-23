using System;

namespace dependency_inversion_before
{
    class Program
    {
        static void Main(string[] args)
        {
            var permits = new Permits();

            permits.Add(new Permit() { Number = "123" });

            Console.WriteLine("Email sent");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
