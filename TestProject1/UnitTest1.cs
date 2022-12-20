using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hogwarts;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var items = Students.LoadFile("C:\\Users\\фабер\\Desktop\\Students\\Students.csv");
            Assert.AreEqual(1000, items.Count);
        }
    }
}   