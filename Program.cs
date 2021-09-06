using System;

namespace Pattern1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n = 5;
            for (i = 0; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(" " + j);
                }
                Console.WriteLine();
            }
        }
    }
}

/*OUTPUT:
 1
 1 2
 1 2 3
 1 2 3 4
 1 2 3 4 5
*/