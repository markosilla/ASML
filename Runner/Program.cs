using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner
{
    class Program
    {
        public static int Main(string[] args)
        {
            Console.WriteLine("Please choose below:");
            Console.WriteLine("[1] SumOfMultiple");
            Console.WriteLine("[2] SequenceAnalysis");
            Console.WriteLine("Preas any other key for exit.");
            while (true)
            {
                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        break;
                    case '2':
                        break;
                    default:
                        return 0;
                }
            }
        }
    }
}
