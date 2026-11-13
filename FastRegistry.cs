using System;

namespace App
{
    public class StreamCache
    {
        private int _state;

        public StreamCache(int seed) => _state = seed;

        public int flush(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 11) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new StreamCache(11);
            Console.WriteLine(obj.flush(11));
        }
    }
}
