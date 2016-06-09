using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Observable : IObservable<string>
    {
        List<IObserver<string>> observers;

        public Observable()
        {
            observers = new List<IObserver<string>>();
        }

        private class Unsubscriber : IDisposable
        {
            List<IObserver<string>> _observers;
            IObserver<string> _observer;

            public Unsubscriber(List<IObserver<string>> observers, IObserver<string> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (!(_observer == null))
                {
                    _observers.Remove(_observer);
                }
            }
        }

        public IDisposable Subscribe(IObserver<string> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }
            return new Unsubscriber(observers, observer);
        }

        public void sendString()
        {
            string[] words = {"aa","bb", "aa", "bb" , "aa", "bb" , "bb", "aa", "aa", "bb" , "aa", "bb", null};
            string previous = null;
            bool start = true;
            foreach (string word in words)
            {
                System.Threading.Thread.Sleep(3000);
                if (word != null)
                {
                    if (start || word != previous)
                    {
                        foreach (var obs in observers)
                        {
                            obs.OnNext(word);
                        }
                        previous = word;
                        if (start)
                        {
                            start = false;
                        }
                    }
                }
                else
                {
                    foreach (var obs in observers)
                    {
                        if (obs != null)
                        {
                            obs.OnCompleted();
                        }
                    }
                    observers.Clear();
                    break;
                }
            }
        }
    }
}
