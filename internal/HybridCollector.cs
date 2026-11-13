using System;

namespace App
{
    public class LocalResolver
    {
        private int _state;

        public LocalResolver(int seed) => _state = seed;

        public int fetch(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 12) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new LocalResolver(12);
            Console.WriteLine(obj.fetch(12));
        }
    }
}
