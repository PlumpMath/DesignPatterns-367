using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            //================FACTORY====================================================
            AnswerFactory yesFactory = AnswerFactory.getFactory(typeOfFactory.yesFactory);
            bool yesAnswer = yesFactory.getAnswer();
            Console.WriteLine("YES ANSWER: " + yesAnswer);
            AnswerFactory noFactory = AnswerFactory.getFactory(typeOfFactory.noFactory);
            bool noAnswer = noFactory.getAnswer();
            Console.WriteLine("NO ANSWER: " + noAnswer);
            //===========================================================================
            Console.WriteLine();
            Console.WriteLine();
            //================SINGLETON==================================================
            Singleton s1 = Singleton.getInstance();
            Console.WriteLine("Singleton state: "+s1.state);
            Singleton s2 = Singleton.getInstance();
            s2.state = true;
            Console.WriteLine("Singleton state: " + s1.state);
            //===========================================================================
            Console.WriteLine();
            Console.WriteLine();
            //================DECORATOR==================================================
            ConcreteComponent component = new ConcreteComponent();
            component.Operation();
            ConcreteDecorator decorator = new ConcreteDecorator();
            decorator.SetComponent(component);
            decorator.Operation();
            //===========================================================================
            Console.WriteLine();
            Console.WriteLine();
            //================STRATEGY===================================================
            Context context;
            context = new Context(new StrategyA());
            context.ContextInterface();
            context = new Context(new StrategyB());
            context.ContextInterface();
            //===========================================================================
            Console.WriteLine();
            Console.WriteLine();
            //================OBSERVER===================================================
            Observable provider = new Observable();
            Observer reciever = new Observer();
            reciever.Subscribe(provider);
            provider.sendString();
            //===========================================================================

            Console.ReadLine();
        }
    }
}
