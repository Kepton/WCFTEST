using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client();
            string msg = client.GetData(12);
            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}
