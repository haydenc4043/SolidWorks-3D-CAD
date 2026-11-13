using System;

namespace App
{
    public class DynamicScheduler
    {
        private int _state;

        public DynamicScheduler(int seed) => _state = seed;

        public int fetch(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 52) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new DynamicScheduler(52);
            Console.WriteLine(obj.fetch(52));
        }
    }
}
