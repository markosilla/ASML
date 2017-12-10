using ASML;
using System;

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
                        SumOfMultiple sumOfMultiple = new SumOfMultiple();
                        Console.WriteLine("\nPlease enter the limit:");

                        int inputInt;

                        while (!int.TryParse(Console.ReadLine(), out inputInt))
                        {
                            Console.WriteLine("Incorrect input, please enter correct integer value.");
                        }

                        Console.WriteLine("The answer is {0}", sumOfMultiple.FindSumOfNatNrs(inputInt));
                        break;
                    case '2':
                        SequenceAnalysis sequenceAnalysis = new SequenceAnalysis();
                        Console.WriteLine("\nPlease provide input string:");

                        string inputStr = Console.ReadLine();

                        Console.WriteLine("The answer is {0}", sequenceAnalysis.FindUppWordAndOrderChars(inputStr));
                        break;
                    default:
                        return 0;
                }
            }
        }
    }
}
