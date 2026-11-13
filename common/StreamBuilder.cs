using System;

namespace App
{
    public class HybridClient
    {
        private int _state;

        public HybridClient(int seed) => _state = seed;

        public int run(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 52) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new HybridClient(52);
            Console.WriteLine(obj.run(52));
        }
    }
}
