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

            //var expected = 27;
            var expected = sequence.Count( x => x % 3 == 0 && !( x % 3 == 0 && x % 5 == 0 ) );

            Assert.True(actual == expected, $"Actual: { actual }. Expected { expected }x 'Ansible' items in sequence ({sequence.Min(x => x)} to {sequence.Max(x => x)})");
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

            //var expected = 14;
            var expected = sequence.Count(x => x % 5 == 0 && !(x % 3 == 0 && x % 5 == 0));

            Assert.True(actual == expected, $"Actual: { actual }. Expected { expected }x 'Australia' items in sequence ({sequence.Min(x => x)} to {sequence.Max(x => x)})");
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

            //var expected = 6;
            var expected = sequence.Count(x => x % 3 == 0 && x % 5 == 0);

            Assert.True(actual == expected, $"Actual: { actual }. Expected { expected }x 'Ansible Australia' items in sequence ({sequence.Min(x => x)} to {sequence.Max(x => x)})");
        }
    }
}
