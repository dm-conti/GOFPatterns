using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GOFPatterns.Creational.Singleton;

namespace GOFPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleSingleton singleton = new SimpleSingleton();

            string message = $"**** First instance is [{singleton.GetHashCode()}] ****";
            System.Diagnostics.Debug.WriteLine(message);

            singleton = new SimpleSingleton();

            message = $"**** Last instance is [{singleton.GetHashCode()}] ****";
            System.Diagnostics.Debug.WriteLine(message);
        }
    }
}
