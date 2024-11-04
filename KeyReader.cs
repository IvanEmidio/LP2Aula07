using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula7LP2
{
    public class KeyReader : AbstractStringSubject
    {
        public void ReadKeys()
        {
            ConsoleKeyInfo key;
            while(true)
            {
                key = Console.ReadKey(true).key;
                if(key == ConsoleKey.Escape) break; 
                Item = key.ToString();
            }
        }
    }
}