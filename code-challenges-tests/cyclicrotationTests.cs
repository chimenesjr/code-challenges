using Microsoft.VisualStudio.TestTools.UnitTesting;
using code_challenges;

namespace code_challenges_tests
{
    [TestClass]
    public class cyclicrotationTests
    {
        private cyclicrotation cyclicrotation;

        [TestInitialize]
        public void setup(){
            cyclicrotation = new cyclicrotation();
        }

        [TestMethod]
        [DataRow(new int[] {3,8,9,7,6}, new int[] {9, 7, 6, 3, 8},  3)]
        public void Test1(int[] list, int[] result, int k)
        {
            var response = cyclicrotation.find1(list, k);
            CollectionAssert.AreEqual(response, result);
        }

        [TestMethod]
        [DataRow(new int[] {0,0,0},     new int[] {0,0,0},          1)]
        public void Test2(int[] list, int[] result, int k)
        {
            var response = cyclicrotation.find1(list, k);
            CollectionAssert.AreEqual(response, result);
        }

        [TestMethod]
        [DataRow(new int[] {1,2,3,4},   new int[] {1,2,3,4},        4)]
        public void Test3(int[] list, int[] result, int k)
        {
            var response = cyclicrotation.find1(list, k);
            CollectionAssert.AreEqual(response, result);
        }
    }
}