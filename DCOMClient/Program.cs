using System;
using DCOMServer;

namespace DCOMClient
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IMyInterface serverObject = new MyServer();
                Console.WriteLine(serverObject.SayHello());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
