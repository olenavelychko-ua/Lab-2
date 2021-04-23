using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace TestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_ShallowCopy()
        {
            var sheep = new Lamb(5, 3, "black");
            var result = sheep.ShallowCopy();
            var result1 = sheep.ShallowCopy();
            result1.color = "green";
            var expected = new Lamb(5, 3, "black");
            Assert.AreEqual(result.weight, expected.weight);
            Assert.AreEqual(result.height, expected.height);
            Assert.AreEqual(result.color, expected.color);
            
        }
        [TestMethod]
        public void Test_DeepCopy()
        {
            var sheep = new Lamb(5, 3, "black");
            var result = sheep.DeepCopy();
            var result2 = sheep.DeepCopy();
            result2.weight = 34;
            var expected = new Lamb(5, 3, "black");
            Assert.AreEqual(result.weight, expected.weight);
            Assert.AreEqual(result.height, expected.height);
            Assert.AreEqual(result.color, expected.color);

        }
    }
}
