using Microsoft.VisualStudio.TestTools.UnitTesting;
using code_challenges;

namespace code_challenges_tests
{
    [TestClass]
    public class equilibriumTests
    {
        int[] list = new int[] {3,1,2,4,3};

        [TestMethod]
        public void firstTest() {
            var response = new equilibrium().find1(list);
            Assert.AreEqual(1, response);
        }
    }
}
