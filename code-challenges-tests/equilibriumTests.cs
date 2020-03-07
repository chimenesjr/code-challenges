using Microsoft.VisualStudio.TestTools.UnitTesting;
using code_challenges;

namespace code_challenges_tests
{
    [TestClass]
    public class equilibriumTests
    {
        int[] list = new int[] {3,1,2,4,3};
        int[] list2 = new int[] {-3,1,-2,4,-3};
        int[] list3 = new int[] {-1000,1000};

        private equilibrium equilibrium;

        [TestInitialize]
        public void setup(){
            equilibrium = new equilibrium();
        }

        [TestMethod]
        public void Test1() {
            var response = equilibrium.find1(list);
            Assert.AreEqual(1, response);

            response = equilibrium.find1(list2);
            Assert.AreEqual(1, response);

            response = equilibrium.find1(list3);
            Assert.AreEqual(2000, response);
        }

        [TestMethod]
        public void Test2() {
            var response = equilibrium.find2(list);
            Assert.AreEqual(1, response);
            
            response = equilibrium.find2(list2);
            Assert.AreEqual(1, response);

            response = equilibrium.find2(list3);
            Assert.AreEqual(2000, response);
        }

        // [TestMethod]
        // public void Test3() {
        //     var response = equilibrium.find3(list);
        //     Assert.AreEqual(1, response);

        //     response = equilibrium.find3(list2);
        //     Assert.AreEqual(1, response);

        //     response = equilibrium.find3(list3);
        //     Assert.AreEqual(2000, response);
        // }
    }
}
