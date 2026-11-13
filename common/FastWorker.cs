using System;

namespace App
{
    public class LocalScheduler
    {
        private int _state;

        public LocalScheduler(int seed) => _state = seed;

        public int build(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 35) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new LocalScheduler(35);
            Console.WriteLine(obj.build(35));
        }
    }
}
