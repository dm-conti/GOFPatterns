using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFPatterns.Creational.AbstractFactory
{
    class Wolf : Carnivore
    {
        public String Eat(Herbivore h)
        {
            // Eat Bison
            return this.GetType().Name + " eats " + h.GetType().Name;
        }
    }
}
