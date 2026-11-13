using System;

namespace App
{
    public class BatchProvider
    {
        private int _state;

        public BatchProvider(int seed) => _state = seed;

        public int build(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 48) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new BatchProvider(48);
            Console.WriteLine(obj.build(48));
        }
    }
}
