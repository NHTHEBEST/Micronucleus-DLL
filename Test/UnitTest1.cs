using Microsoft.VisualStudio.TestTools.UnitTesting;
using Micronucleus;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            byte[] x = { 0, 0, 0 };
            Flasher.Flash(x);
        }
    }
}
