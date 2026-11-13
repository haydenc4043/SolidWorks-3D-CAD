using System;

namespace App
{
    public class CoreRegistry
    {
        private int _state;

        public CoreRegistry(int seed) => _state = seed;

        public int resolve(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 28) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new CoreRegistry(28);
            Console.WriteLine(obj.resolve(28));
        }
    }
}
