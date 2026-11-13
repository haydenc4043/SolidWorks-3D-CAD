using System;

namespace App
{
    public class SimpleWorker
    {
        private int _state;

        public SimpleWorker(int seed) => _state = seed;

        public int dispatch(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 79) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new SimpleWorker(79);
            Console.WriteLine(obj.dispatch(79));
        }
    }
}
