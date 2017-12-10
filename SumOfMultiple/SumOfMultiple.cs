namespace ASML
{
    public class SumOfMultiple
    {
        /// <summary>
        /// Find the sum of all natural numbers that are a 
        /// multiple of 3 or 5 below a limit provided as input.
        /// </summary>
        public int FindSumOfNatNrs(int limit)
        {
            int sumOfNatNrs = 0;

            if (limit < 3)
                return 0;

            for (int i = limit; i >= 3; i--)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sumOfNatNrs += i;
            }

            return sumOfNatNrs;
        }
    }
}
