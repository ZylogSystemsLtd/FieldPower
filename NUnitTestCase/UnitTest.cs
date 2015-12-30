using NUnit.Framework;

namespace GitSample
{
    [TestFixture]
    public class UnitTest
    {
        MathsHelper helper = new MathsHelper();
        [TestCase]
        public void AddTest()
        {
            int result = helper.Add(20, 10);
            Assert.AreEqual(40, result);
        }
        [TestCase]
        public void SubtractTest()
        {
            int result = helper.Subtract(20, 10);
            Assert.AreEqual(10, result);
        }
       
    }
}
