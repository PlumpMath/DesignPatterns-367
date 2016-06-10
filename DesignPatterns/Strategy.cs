using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    abstract class Strategy
    {
        public abstract void doAction();
    }

    class StrategyA : Strategy
    {
        public override void doAction()
        {
            Console.WriteLine("Strategia A!");
        }
    }

    class StrategyB : Strategy
    {
        public override void doAction()
        {
            Console.WriteLine("Strategia B!");
        }
    }

    class Context
    {
        private Strategy _strategy;

        public Context(Strategy strategy)
        {
            this._strategy = strategy;
        }

        public void doAction()
        {
            _strategy.doAction();
        }
    }
}
