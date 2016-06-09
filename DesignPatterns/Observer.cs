using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Observer : IObserver<string>
    {
        private IDisposable unsubscriber;
        private bool first = true;
        private string lastString;

        public void Subscribe(IObservable<string> provider)
        {
            unsubscriber = provider.Subscribe(this);
        }


        public void OnCompleted()
        {
            Console.WriteLine("Zakonczono.");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("BLAD");
        }

        public void OnNext(string value)
        {
            if (first)
            {
                first = false;
                lastString = value;
                Console.WriteLine("Otrzymana wiadomosc: " + value);
            }
            else
            {
                if (value.Equals(lastString))
                {
                    Console.WriteLine("Otrzymana wiadomosc jest taka sama jak poprzednia.");
                }
                else
                {
                    lastString = value;
                    Console.WriteLine("Otrzymana wiadomosc: " + value);
                }
            }
        }
    }
}
