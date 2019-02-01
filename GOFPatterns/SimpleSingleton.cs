using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFPatterns.Singleton
{
    public class SimpleSingleton
    {
        private static SimpleSingleton instance = null;
        public static SimpleSingleton Instance {
            get
            {
                if (instance == null) {
                    instance = new SimpleSingleton();
                }
                return instance;
            }
        }
    }
}
