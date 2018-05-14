using System;
using System.Collections.Generic;
using System.Linq;

namespace Ansible
{
    class Program
    {
        private static readonly IEnumerable<int> _sequence = Enumerable.Range(1, 100);

        static void Main(string[] args)
        {
            foreach (var n in _sequence)
            {
                if( n % 3 == 0 && n % 5 == 0)
                    Console.Write($"{n} Ansible Australia\n" );
                if (n % 3 == 0)
                    Console.Write($"{n} Ansible\n");
                if (n % 5 == 0)
                    Console.Write($"{n} Australia\n");

            }
            Console.ReadLine();
        }

        //TODO: Unit Tests
    }
}
