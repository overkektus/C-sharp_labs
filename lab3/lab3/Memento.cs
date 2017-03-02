using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Memento
    {
        public int Level { get; private set; }
        public Memento(int level)
        {
            Level = level;
        }
    }
    class GameHistory
    {
        public Stack<Memento> History { get; private set; }
        public GameHistory()
        {
            History = new Stack<Memento>();
        }
    }
}
