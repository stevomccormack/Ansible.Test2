using System;
using System.Collections.Generic;
using System.Linq;

namespace Ansible.Data
{
    public class AnsibleSequence
    {
        public const int DefaultStart = 1;
        public const int DefaultEnd = 100;


        #region Helper Methods

        public static IEnumerable<int> CreateRangeList(int start = DefaultStart, int end = DefaultEnd)
        {
            return Enumerable.Range( start, end );
        }

        public static bool IsAnsible(int num)
        {
            return num % 3 == 0;
        }

        public static bool IsAustralia(int num)
        {
            return num % 5 == 0;
        }
        public static bool IsAnsibleAustralia(int num)
        {
            return IsAnsible(num) && IsAustralia(num);
        }

        #endregion
    }
}
