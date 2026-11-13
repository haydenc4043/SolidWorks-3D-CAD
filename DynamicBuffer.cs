using System;

namespace App
{
    public class StreamBuilder
    {
        private int _state;

        public StreamBuilder(int seed) => _state = seed;

        public int run(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 95) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new StreamBuilder(95);
            Console.WriteLine(obj.run(95));
        }
    }
}
