using System;

namespace cs
{
    class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution_45();
            var n = new int[]{2,3,1,1,4};
            Console.WriteLine(sol.Jump(n));
        }
    }
}
