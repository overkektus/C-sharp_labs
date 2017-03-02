using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    sealed partial class Shaman: Fighter, IAction
    {
        private const double h = 1.13, d = 1.25, dex = 1.10, m = 1.3;
        private int mana = 400;

        private static Shaman instance;

        public static Shaman getInstance()
        {
            if (instance == null)
                instance = new Shaman();
            return instance;
        }

        public override string ToString() =>
           $"Shaman {WhatType()} Level:{Level} Dexterity:{Dexterity} HP:{HP} Mana:{Mana} Damage:{Damage}";

        private Shaman() : base("shaman", h, d, dex) { }

        public int Mana
        {
            get { return mana; }

            set {
                if (value < 400) { throw new InvalidParam("property 'mana' can not be less then 400"); }
                else { mana = value; }
            }
        }

        protected override void LevelUP(int level)
        {
            Dexterity = Convert.ToInt32(Dexterity * dex);
            HP        = Convert.ToInt32(HP * h);
            Damage    = Convert.ToInt32(Damage * d);
            Mana      = Convert.ToInt32(Mana * m);
        }

        protected override void LevelDOWN(int level)
        {
            Dexterity = Convert.ToInt32(Dexterity / dex);
            HP        = Convert.ToInt32(HP / h);
            Damage    = Convert.ToInt32(Damage / d);
            Mana      = Convert.ToInt32(Mana / m);
        }

        public static Shaman operator +(Shaman obj, int level)
        {
            obj.Level += level;
            return obj;
        }

        public static Shaman operator -(Shaman obj, int level)
        {
            if (obj.Level > 1)
            {
                obj.Level += level;
            }
            return obj;
        }
    }
}
