using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GOFPatterns.Creational.AbstractFactory;
using Castle.Windsor;
using Castle.MicroKernel.Registration;
using GOFPatterns.Attribute;
using Castle.Windsor.Configuration.Interpreters;

namespace GOFPatternsTest.Creational
{
    [TestClass]
    public class AbstractFactory_ManuallyRegistrationTest
    {
        private AfricaFactory africaFactory;

        private AmericaFactory americaFactory;

        [TestInitialize]
        public void testInit_manuallyRegistratin()
        {
            // create instance of the container
            WindsorContainer container = new WindsorContainer();

            // Register Components
            container.Register(Component.For<AfricaFactory>().ImplementedBy<AfricaFactory>());
            container.Register(Component.For<AmericaFactory>().ImplementedBy<AmericaFactory>());

            // Resolve with Resolve methods
            africaFactory = container.Resolve<AfricaFactory>();
            americaFactory = container.Resolve<AmericaFactory>();
        }

        [TestMethod]
        public void TestRunFoodChain()
        {
            // Create and run the African animal world
            AnimalWorld world = new AnimalWorld(africaFactory);
            Assert.AreEqual("Lion eats Wildebeest", world.RunFoodChain());

            // Create and run the American animal world
            world = new AnimalWorld(americaFactory);
            Assert.AreEqual("Wolf eats Bison", world.RunFoodChain());
        }

        [TestCleanup]
        public void testClean()
        {
            africaFactory = null;
            americaFactory = null;
        }
    }
}
