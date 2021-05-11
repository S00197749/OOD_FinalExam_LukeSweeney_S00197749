using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LukeSweeney_S00197749;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Game g1 = new Game("It Takes Two", "PC, Xbox, PS, Switch", 88, 69.99m,"/ images / ittakes2.jpg", " From Hazelight comes It Takes Two an innovative co-op adventure where uniquely varied gameplay and emotional storytelling intertwine in a fantastical journey. Founded to push the creative boundaries of what's possible in games, Hazelight is the award-winning studio behind the critically acclaimed A Way Out and Brothers: A Tale of Two Sons.");
            decimal expectedPrice = 59.99m;

            g1.DecreasePrice(10);

            Assert.AreEqual(expectedPrice, g1.Price);
        }
    }
}
