using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Singleton
    {
        private static volatile Singleton instance;
        private static object syncRoot = new Object();
        public bool state;

        private Singleton()
        {
            this.state = false;
        }

        public static Singleton getInstance()
        {
            if (instance == null)
            {
                lock(syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }
            return instance;
        }
    }
}
