using System;
using System.Linq;
using System.Reflection;

namespace Matilde
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Contains("--version") || args.Contains("-v"))
            {
                var version = Assembly.GetEntryAssembly().GetName().Version;

                Console.WriteLine($"{version.Major}.{version.Minor}.{version.Revision}");
                return;
            }

            Console.WriteLine("Matilde - your very own web api telekinesis superpower");
        }
    }
}
