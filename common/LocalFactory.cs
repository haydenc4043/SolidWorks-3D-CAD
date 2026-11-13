using System;

namespace App
{
    public class LiteClient
    {
        private int _state;

        public LiteClient(int seed) => _state = seed;

        public int parse(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 75) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new LiteClient(75);
            Console.WriteLine(obj.parse(75));
        }
    }
}
