using System;

namespace App
{
    public class LocalEngine
    {
        private int _state;

        public LocalEngine(int seed) => _state = seed;

        public int run(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 33) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new LocalEngine(33);
            Console.WriteLine(obj.run(33));
        }
    }
}
