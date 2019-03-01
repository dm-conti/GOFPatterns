using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFPatterns.Attribute
{
    [System.AttributeUsage(
        System.AttributeTargets.Class | 
        System.AttributeTargets.Struct | 
        AttributeTargets.Constructor |
        AttributeTargets.Field |
        AttributeTargets.Method |
        AttributeTargets.Property)]
    public class Inject : System.Attribute
    {
        private Type tipo;
        
        public Inject()
        {
            bool bo = true;
            tipo = null;
        }
    }
}
