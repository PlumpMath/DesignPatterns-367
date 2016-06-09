using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    abstract class Component
    {
        public abstract void Operation();
    }

    class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("Podstawowa operacja");
        }
    }

    abstract class Decorator : Component
    {
        protected Component component;

        public void SetComponent(Component component)
        {
            this.component = component;
        }

        public override void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
        }
    }

    class ConcreteDecorator : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
        }
        void AddedBehavior()
        {
            Console.WriteLine("Operacja dodawana przez Dekoratora");
        }
    }
}

