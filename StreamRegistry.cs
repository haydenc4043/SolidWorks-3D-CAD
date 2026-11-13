using System;

namespace App
{
    public class BatchLoader
    {
        private int _state;

        public BatchLoader(int seed) => _state = seed;

        public int build(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 93) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new BatchLoader(93);
            Console.WriteLine(obj.build(93));
        }
    }
}
