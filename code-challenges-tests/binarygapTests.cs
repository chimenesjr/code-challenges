using Microsoft.VisualStudio.TestTools.UnitTesting;
using code_challenges;

namespace code_challenges_tests
{
    [TestClass]
    public class binarygapTests
    {
        private binarygap binarygap;

        [TestInitialize]
        public void setup(){
            binarygap = new binarygap();
        }

        [TestMethod]
        [DataRow(9, 2)]
        [DataRow(529, 4)]
        [DataRow(20, 1)]
        [DataRow(15, 0)]
        [DataRow(32, 0)]
        [DataRow(1041, 5)]
        public void Test1(int A, int result)
        {
            var response = binarygap.find(A);
            Assert.AreEqual(response, result);
        }
    }
}