using Tyuiu.ZhukovaYA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.ZhukovaYA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "яна";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("ѕривет, яна", res);
        }
    }
}