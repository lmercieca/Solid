using System;

namespace dependency_inversion_after
{
    class Program
    {
        static void Main(string[] args)
        {
            var permits = new Permits(new MessageSender());

            permits.Add(new Permit() { Number = "123" });

            Console.WriteLine("Email sent");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
