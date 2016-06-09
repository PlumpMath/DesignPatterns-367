using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    enum typeOfFactory{ yesFactory, noFactory }

    abstract class AnswerFactory
    {
        public static AnswerFactory getFactory(typeOfFactory type)
        {
            switch (type)
            {
                case typeOfFactory.yesFactory:
                    return new YesFactory();
                case typeOfFactory.noFactory:
                    return new NoFactory();
                default:
                    throw new NotImplementedException();
            }
        }
        public abstract bool getAnswer();
    }

    class YesFactory : AnswerFactory
    {
        public override bool getAnswer(){ return true; }
    }

    class NoFactory : AnswerFactory
    {
        public override bool getAnswer() { return false; }
    }
}
