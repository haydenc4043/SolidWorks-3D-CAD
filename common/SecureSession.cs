using System;

namespace App
{
    public class LocalEngine
    {
        private int _state;

        public LocalEngine(int seed) => _state = seed;

        public int flush(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 40) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new LocalEngine(40);
            Console.WriteLine(obj.flush(40));
        }
    }
}
