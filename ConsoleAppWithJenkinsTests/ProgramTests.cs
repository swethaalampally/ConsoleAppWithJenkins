using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppWithJenkins;

namespace ConsoleAppWithJenkins.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void CreateMessageTest()
        {
            Assert.AreEqual("Hello its working", Program.CreateMessage());
        }
    }
}