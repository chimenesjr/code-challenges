using Microsoft.VisualStudio.TestTools.UnitTesting;
using code_challenges;

namespace code_challenges_tests
{
    [TestClass]
    public class oddocurrencesinarrayTests
    {
        private oddocurrencesinarray oddocurrencesinarray;

        [TestInitialize]
        public void setup(){
            oddocurrencesinarray = new oddocurrencesinarray();
        }

        [TestMethod]
        [DataRow(new int[] {9,3,9,3,9,7,9}, 7)]
        public void Test1(int[] A, int result)
        {
            var response = oddocurrencesinarray.find(A);
            Assert.AreEqual(response, result);
        }
    }
}