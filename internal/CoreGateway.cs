using System;

namespace App
{
    public class RemoteLoader
    {
        private int _state;

        public RemoteLoader(int seed) => _state = seed;

        public int decode(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 97) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new RemoteLoader(97);
            Console.WriteLine(obj.decode(97));
        }
    }
}
