using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GOFPatterns.Creational.Singleton;

namespace GOFPatternsTest
{
    namespace Creational
    {
        [TestClass]
        public class SimpleSingletonTest
        {
            [TestMethod]
            public void TestInstanceOfSimpleSingleton()
            {
                SimpleSingleton source = SimpleSingleton.Instance;

                SimpleSingleton target = SimpleSingleton.Instance;

                Assert.AreSame(source, target);
            }
        }
    }
}
