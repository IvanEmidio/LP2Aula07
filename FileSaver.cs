using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula7LP2
{
    public class FileSaver : IObserver<AbstractStringSubject>
    {
        private readonly string _filename;

        public FileSaver(string _filename)
        {
            this._filename = _filename;
        }
        public void Update(AbstractStringSubject subject)
        {
            FileSaver.AppendText(_filename, subject.Item + "\n");
        }
    }
}