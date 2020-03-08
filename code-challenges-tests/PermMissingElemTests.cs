using Microsoft.VisualStudio.TestTools.UnitTesting;
using code_challenges;

namespace code_challenges_tests
{
    [TestClass]
    public class PermMissingElemTests
    {
        private PermMissingElem permMissingElem;

        public PermMissingElemTests()
        {
            permMissingElem = new PermMissingElem();
        }

        [TestMethod]
        [DataRow(new int[] {2,3,1,5}, 4)]
        public void Test1(int[] A, int result)
        {
            var response = permMissingElem.find(A);
            Assert.AreEqual(response, result);
        }

        [TestMethod]
        [DataRow(new int[] {}, 1)]
        public void Test2(int[] A, int result)
        {
            var response = permMissingElem.find(A);
            Assert.AreEqual(response, result);
        }

        [TestMethod]
        [DataRow(new int[] {2}, 1)]
        public void Test3(int[] A, int result)
        {
            var response = permMissingElem.find(A);
            Assert.AreEqual(response, result);
        }

        [TestMethod]
        [DataRow(new int[] {4}, 1)]
        public void Test4(int[] A, int result)
        {
            var response = permMissingElem.find(A);
            Assert.AreEqual(response, result);
        }

        [TestMethod]
        [DataRow(new int[] {1}, 2)]
        public void Test5(int[] A, int result)
        {
            var response = permMissingElem.find(A);
            Assert.AreEqual(response, result);
        }

        [TestMethod]
        [DataRow(new int[] {2,3}, 1)]
        public void Test6(int[] A, int result)
        {
            var response = permMissingElem.find(A);
            Assert.AreEqual(response, result);
        }

        [TestMethod]
        [DataRow(new int[] {1,2}, 3)]
        public void Test7(int[] A, int result)
        {
            var response = permMissingElem.find(A);
            Assert.AreEqual(response, result);
        }
    }
}