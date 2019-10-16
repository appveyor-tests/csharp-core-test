using Newtonsoft.Json;
using System;

namespace MyCSharpCoreTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var json = JsonConvert.SerializeObject(new { a = 1 });
            Console.WriteLine(json);
        }
    }
}
