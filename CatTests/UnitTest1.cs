namespace CatTests;
using Cats;

[TestClass]
public class UnitTest1
{
    [TestMethod]
public void InheritsBaseInFirstConstructor()
{
   HouseCat keyboardCat = new HouseCat("Keyboard Cat", 7);
   Assert.AreEqual(7, keyboardCat.Weight, .001);
}
}