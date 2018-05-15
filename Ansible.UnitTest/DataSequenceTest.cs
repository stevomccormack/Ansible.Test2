using System.Collections.Generic;
using System.Linq;
using Ansible.Data;
using Xunit;

namespace Ansible.UnitTest
{
    public class DataSequenceTest
    {
        IEnumerable<int> _sequence = AnsibleSequence.CreateRangeList();

        [Fact]
        public void TestAnsible()
        {
            var actual = 0;
            var sequence = AnsibleSequence.CreateRangeList().ToList();
            foreach (var n in sequence)
            {
                if (AnsibleSequence.IsAnsible(n) && !AnsibleSequence.IsAustralia(n))
                    actual++;
            }

            //var result = 27;
            var result = sequence.Count( x => x % 3 == 0 && !( x % 3 == 0 && x % 5 == 0 ) );

            Assert.True(actual == result, $"There shoud be { result } 'Ansible' items in range ({sequence.Min(x => x)}, {sequence.Max(x => x)})");
        }

        [Fact]
        public void TestAustralia()
        {
            var actual = 0;
            var sequence = AnsibleSequence.CreateRangeList().ToList();
            foreach (var n in sequence)
            {
                if (AnsibleSequence.IsAustralia(n) && !AnsibleSequence.IsAnsible(n))
                    actual++;
            }

            //var result = 14;
            var result = sequence.Count(x => x % 5 == 0 && !(x % 3 == 0 && x % 5 == 0));

            Assert.True(actual == result, $"There shoud be { result } 'Australia' items in range ({sequence.Min(x => x)}, {sequence.Max(x => x)})");
        }

        [Fact]
        public void TestAnsibleAustralia()
        {
            var actual = 0;
            var sequence = AnsibleSequence.CreateRangeList().ToList();
            foreach (var n in sequence)
            {
                if (AnsibleSequence.IsAnsibleAustralia(n))
                    actual++;
            }

            //var result = 6;
            var result = sequence.Count(x => x % 3 == 0 && x % 5 == 0);

            Assert.True(actual == result, $"There shoud be { result } 'Ansible Australia' items in range ({sequence.Min(x => x)}, {sequence.Max(x => x)})");
        }
    }
}
