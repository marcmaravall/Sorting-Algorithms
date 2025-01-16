using SortingAlgorithms.Algorithms.Interfaces;

namespace SortingAlgorithms.Algorithms
{
    public class BogoSort : IAlgorithm
    {
        public string Name => "Bogo Sort";
        private int attemps = 0;

        public List<int> Sort(List<int> input)
        {
            while (!IsSorted(input))
            {
                input = Shuffle(input);
            }

            return input;
        }

        private List<int> Shuffle(List<int> input)
        {
            for (int i = input.Count - 1; i > 0; i--)
            {
                int j = RandomNumber(i + 1);
                (input[i], input[j]) = (input[j], input[i]);
            }
            attemps++;
            Console.WriteLine($"Attemps: {attemps}");
            return input;
        }

        private int RandomNumber(int max)
        {
            byte[] buffer = new byte[4];
            using (var rng = System.Security.Cryptography.RandomNumberGenerator.Create())
            {
                rng.GetBytes(buffer);
            }
            return Math.Abs(BitConverter.ToInt32(buffer, 0)) % max;
        }

        private bool IsSorted(List<int> input)
        {
            for (int i = 1; i < input.Count; i++)
            {
                if (input[i] < input[i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
