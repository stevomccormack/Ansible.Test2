using System;
using System.Collections.Generic;
using System.Linq;
using Ansible.Data;

namespace Ansible
{
    static class Program
    {
        private static void Main(string[] args)
        {
            int ansibleCount = 0, ausCount = 0, ansibleAusCount = 0;

            var sequence = AnsibleSequence.CreateRangeList();
            foreach (var n in sequence)
            {
                if( AnsibleSequence.IsAnsibleAustralia( n ) )
                {
                    ansibleAusCount++;
                    Console.WriteLine( $"{n} Ansible Australia" );
                }
                else if( AnsibleSequence.IsAnsible( n ) )
                {
                    ansibleCount++;
                    Console.WriteLine( $"{n} Ansible" );
                }
                else if( AnsibleSequence.IsAustralia( n ) )
                {
                    ausCount++;
                    Console.WriteLine( $"{n} Australia" );
                }
            }
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Total 'Ansible' Count: {ansibleCount}");
            Console.WriteLine($"Total 'Australia' Count: {ausCount}");
            Console.WriteLine($"Total 'Ansible Australia' Count: {ansibleAusCount}");
            Console.WriteLine("--------------------------------------------------");


            Console.ReadLine();
        }
    }
}
