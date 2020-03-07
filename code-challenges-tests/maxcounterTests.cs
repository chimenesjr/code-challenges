using Microsoft.VisualStudio.TestTools.UnitTesting;
using code_challenges;

namespace code_challenges_tests
{
    [TestClass]
    public class maxcounterTests
    {
        private maxcounter maxcounter;

        [TestInitialize]
        public void setup(){
            maxcounter = new maxcounter();
        }

        [TestMethod]
        [DataRow(5, new int[] {3,4,4,6,1,4,4}, new int[] {3,2,2,4,2})]
        public void Test1(int A, int[] list, int[] result)
        {
            var response = maxcounter.find1(A, list);
            CollectionAssert.AreEqual(response, result);

            response = maxcounter.find2(A, list);
            CollectionAssert.AreEqual(response, result);
        }

        [TestMethod]
        [DataRow(1, new int[] {1}, new int[] {1})]
        public void Test2(int A, int[] list, int[] result)
        {
            var response = maxcounter.find1(A, list);
            CollectionAssert.AreEqual(response, result);

            response = maxcounter.find2(A, list);
            CollectionAssert.AreEqual(response, result);
        }

        [TestMethod]
        [DataRow(6, new int[] {1,6,8,1,6,8,4,6,5}, new int[] {2,2,2,3,3,3})]
        public void Test3(int A, int[] list, int[] result)
        {
            var response = maxcounter.find1(A, list);
            CollectionAssert.AreEqual(response, result);

            response = maxcounter.find2(A, list);
            CollectionAssert.AreEqual(response, result);
        }

        [TestMethod]
        [DataRow(6, new int[] {1,6,8,1,6,8,4,6,5}, new int[] {2,2,2,3,3,3})]
        public void Test4(int A, int[] list, int[] result)
        {
            var response = maxcounter.find1(A, list);
            CollectionAssert.AreEqual(response, result);

            response = maxcounter.find2(A, list);
            CollectionAssert.AreEqual(response, result);
        }

        [TestMethod]
        [DataRow(1, new int[] {2,1,1,2,1}, new int[] {3})]
        public void Test5(int A, int[] list, int[] result)
        {
            var response = maxcounter.find1(A, list);
            CollectionAssert.AreEqual(response, result);

            response = maxcounter.find2(A, list);
            CollectionAssert.AreEqual(response, result);
        }
    }
}