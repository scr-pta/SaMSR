using System;
using Sentry;

namespace SaMSR
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SentrySdk.Init("https://a8be7a6e66364a4d827aba202dd3e0ec@sentry.io/1539264"))
            {
                Entry();
            }
        }

        static void Entry()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
