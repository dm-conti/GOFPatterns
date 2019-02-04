using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFPatterns.Creational.AbstractFactory
{
    public class AmericaFactory : ContinentFactory
    {
        public Carnivore CreateCarnivore()
        {
            return new Wolf();
        }

        public Herbivore CreateHerbivore()
        {
            return new Bison();
        }
    }
}
