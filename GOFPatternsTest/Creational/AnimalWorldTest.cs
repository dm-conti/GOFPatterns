using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GOFPatterns.Creational.AbstractFactory;

namespace GOFPatternsTest.Creational
{
    [TestClass]
    public class AnimalWorldTest
    {
        [TestMethod]
        public void TestRunFoodChain()
        {
            // Create and run the African animal world
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            Assert.AreEqual("Lion eats Wildebeest", world.RunFoodChain());

            // Create and run the American animal world
            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            Assert.AreEqual("Wolf eats Bison", world.RunFoodChain());
        }
    }
}
