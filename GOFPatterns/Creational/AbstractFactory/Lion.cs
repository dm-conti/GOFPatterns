﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFPatterns.Creational.AbstractFactory
{
    class Lion : Carnivore
    {
        public String Eat(Herbivore h)
        {
            // Eat Wildebeest
            return this.GetType().Name + " eats " + h.GetType().Name;
        }
    }
}
