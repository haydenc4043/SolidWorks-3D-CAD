using System;

namespace App
{
    public class LocalMonitor
    {
        private int _state;

        public LocalMonitor(int seed) => _state = seed;

        public int decode(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 16) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new LocalMonitor(16);
            Console.WriteLine(obj.decode(16));
        }
    }
}
