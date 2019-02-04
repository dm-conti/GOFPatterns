using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFPatterns.Creational.AbstractFactory
{
    public class AfricaFactory : ContinentFactory
    {
        public Carnivore CreateCarnivore()
        {
            return new Lion();
        }

        public Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }
    }
}
