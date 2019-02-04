using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFPatterns.Creational.AbstractFactory
{
    public interface ContinentFactory
    {
        Herbivore CreateHerbivore();
        Carnivore CreateCarnivore();
    }
}
