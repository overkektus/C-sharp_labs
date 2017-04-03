using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    abstract class Fighter
    {
        private string type;
        private int    level, dexterity, hp, damage;

        public static int count = 0;
        public readonly int ID;

        protected Fighter(string type, double h, double d, double dex)
        {
            count++;
            ID = Level.GetHashCode() + Dexterity.GetHashCode() + HP.GetHashCode() + Damage.GetHashCode();
            this.type = type;
            HP = Convert.ToInt32(400 * h);
            Damage = Convert.ToInt32(10 * d);
            Dexterity = Convert.ToInt32(20 * dex);
            Level = 1;
        }

        protected abstract void LevelUP(int level);
        protected abstract void LevelDOWN(int level);
        public abstract void WriteToFile();
        public virtual string WhatType() { return type; }
        
        public string FighterType { get; protected set; }

        public int Level
        {
            get { return level; }
            set
            {
                if (value > 0)
                {
                    level = value;
                    LevelUP(level);
                }
                else if (value < 0)
                {
                    level -= value;
                    LevelDOWN(level);
                }
            }
        }

        public int Dexterity { get; protected set; }

        public int Damage { get; protected set; }

        public int HP
        {
            get { return hp; }
            set
            {
                if (value < 0) throw new InvalidParam("property 'hp' can not be less than zero");
                else { hp = value; }
            }
        }

        ~Fighter() { count--; }

    }
}
