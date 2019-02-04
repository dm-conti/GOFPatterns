using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Creational.GOFPatterns.Singleton;

namespace Creational
{
    namespace GOFPatternsTest
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
