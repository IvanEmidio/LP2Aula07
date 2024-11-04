using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula7LP2
{
    public class ConsolePrinter : IObserver<AbstractStringSubject>
    {
        public void Update(AbstractStringSubject subject)
        {
            Console.WriteLine(subject.Item);
        }
    }
}