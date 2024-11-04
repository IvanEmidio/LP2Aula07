using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula7LP2
{
    public abstract class AbstractStringSubject : ISubject<AbstractStringSubject>
    {
        private ISet<IObserver<AbstractStringSubject>> _observers;

        private string _item;

        public string Item
        {
            get => _item;
            set
            {
                _item = value;
                foreach (var observer in _observers)
                {
                    observer.Update(this);
                }
            }
        }

        public AbstractStringSubject()
        {
            _observers = new HashSet<IObserver<AbstractStringSubject>>() 
        }
        public void RegisterObserver(IObserver<AbstractStringSubject> obs)
        {
            _observers.Add(obs);
        }
        public void RemoveObserver(IObserver<AbstractStringSubject> obs)
        {
            _observers.Remove(obs);
        }
        
    }
}