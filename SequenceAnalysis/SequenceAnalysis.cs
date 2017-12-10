using System.Linq;

namespace ASML
{
    public class SequenceAnalysis
    {
        /// <summary>
        /// Find the uppercase words in a string, provided as input, 
        /// and order all characters in these words alphabetically.
        /// </summary>
        /// <example>
        /// Input: "This IS a STRING"
        /// Output: "GIINRSST"
        /// </example>
        public string FindUppWordAndOrderChars(string input)
        {
            return new string(
                input
                .Split(' ')
                .Where(x => x.All(y => y >= 'A' && y <= 'Z'))
                .SelectMany(x => x)
                .OrderBy(y => y)
                .ToArray());
        }
    }
}
