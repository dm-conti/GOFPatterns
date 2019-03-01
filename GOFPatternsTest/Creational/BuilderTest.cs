using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GOFPatterns.Creational.Singleton;
using GOFPatterns.Creational.Builder;

namespace GOFPatternsTest
{
    namespace Creational
    {
        [TestClass]
        public class BuilderTest
        {
            [TestMethod]
            public void TestBuilder()
            {
                VehicleBuilder builder;

                // Create shop with vehicle builders

                Shop shop = new Shop();

                // Construct and display vehicles

                builder = new ScooterBuilder();
                shop.Construct(builder);
                builder.Vehicle.Show();

                builder = new CarBuilder();
                shop.Construct(builder);
                builder.Vehicle.Show();

                builder = new MotorCycleBuilder();
                shop.Construct(builder);
                builder.Vehicle.Show();
            }
        }
    }
}
