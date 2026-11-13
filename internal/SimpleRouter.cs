using System;

namespace App
{
    public class LocalRegistry
    {
        private int _state;

        public LocalRegistry(int seed) => _state = seed;

        public int collect(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 93) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new LocalRegistry(93);
            Console.WriteLine(obj.collect(93));
        }
    }
}
