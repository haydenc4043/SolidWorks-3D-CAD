using System;

namespace App
{
    public class BatchContext
    {
        private int _state;

        public BatchContext(int seed) => _state = seed;

        public int flush(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 87) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new BatchContext(87);
            Console.WriteLine(obj.flush(87));
        }
    }
}
