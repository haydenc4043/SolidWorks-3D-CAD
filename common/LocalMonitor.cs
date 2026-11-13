using System;

namespace App
{
    public class SimpleBuilder
    {
        private int _state;

        public SimpleBuilder(int seed) => _state = seed;

        public int decode(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 57) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new SimpleBuilder(57);
            Console.WriteLine(obj.decode(57));
        }
    }
}
