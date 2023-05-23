using NUnit.Framework;

namespace Lca.Tests
{
    public class LcaTest
    {       
        [Test]
        public void GivenRootWhenCalculatedThenReturnsRoot()
        {
            int n1 = 1;
            int n2 = 1;
            int expected = 1;
            var lca = new Lca();
            var result = lca.Calculate(n1, n2);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GivenN1RootWhenCalcualatedThenReturnsRoot()
        {
            int n1 = 1;
            int n2 = 18;
            int expected = 1;
            var lca = new Lca();
            var result = lca.Calculate(n1, n2);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GivenN2RootWhenCalculatedThenReturnsRoot()
        {
            int n1 = 21;
            int n2 = 1;
            int expected = 1;
            var lca = new Lca();
            var result = lca.Calculate(n1, n2);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(12, 2, 1)]
        [TestCase(25, 8, 1)]
        [TestCase(8, 4, 4)]
        [TestCase(19, 8, 4)]
        [TestCase(16, 22, 2)]
        [TestCase(27, 12, 6)]
        [TestCase(31, 6, 3)]
        public void GivenTwoNodesWhenCalculatedReturnsRoot(int n1, int n2, int expected)
        {
            var lca = new Lca();
            var result = lca.Calculate(n1, n2);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}