using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Game
    {
        public delegate void MyEventHendler(object o, GameEventArgs e); //Объявление делегата
        public event MyEventHendler Attacked; //объявление событие атаки
        public event MyEventHendler Treated;  //объявление событие лечить

        public void Battle(Fighter _fighter1, Fighter _fighter2)
        {
            if (Attacked != null)
                Attacked(this, new GameEventArgs(_fighter2, _fighter1));
        }

        public void Treatment(Fighter _fighter1, Fighter _fighter2)
        {
            if (Treated != null)
                Treated(this, new GameEventArgs(_fighter1, _fighter2));
        }
    }

    class GameEventArgs
    {
        public Fighter fighter1, fighter2;
        public GameEventArgs(Fighter _fighter1, Fighter _fighter2)
        {
            fighter1 = _fighter1;
            fighter2 = _fighter2;
        }
    }
}
