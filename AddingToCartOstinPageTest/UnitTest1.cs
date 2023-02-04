using NUnit.Framework;

namespace AddingToCartOstinPageTest
{
    [TestFixture]

    public class Tests : BaseClass
    { 
        [Test]
        public void Test1()
        {
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);
        }
    }
}