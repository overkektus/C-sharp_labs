using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    partial class Hunter : Fighter, IAction
    {
        const double h = 1.2, d = 1, dex = 1.15;

        public Hunter() : base("hunter", h, d, dex) { }

        public override string ToString() => 
            $"Hunter {WhatType()} Level:{Level} Dexterity:{Dexterity} HP:{HP} Damage:{Damage}";

        public override int GetHashCode()
        {
            return Level.GetHashCode() + Dexterity.GetHashCode() + HP.GetHashCode() + Damage.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if ((obj as Hunter) != null)
                return Equals(obj as Hunter);
            else throw new InvalidParam("Can not compare 'Hunter' with unknown object");
         }

        public bool Equals(ref Hunter obj)
        {
            if (this.Damage == obj.Damage && this.Dexterity == obj.Dexterity &&
                this.HP == obj.HP && this.Level == obj.Level)
                return true;
            else return false;
        }

        public override string WhatType()
        {
            return base.WhatType();
        }

        protected override void LevelUP(int level)
        {
            Dexterity = Convert.ToInt32(Dexterity * dex);
            HP        = Convert.ToInt32(HP * h);
            Damage    = Convert.ToInt32(Damage * d);
        }

        protected override void LevelDOWN(int level)
        {
            Dexterity = Convert.ToInt32(Dexterity / dex);
            HP        = Convert.ToInt32(HP / h);
            Damage    = Convert.ToInt32(Damage / d);   
        }

        public static Hunter operator +(Hunter obj, int level)
        {
            obj.Level += level;
            return obj;
        }

        public static Hunter operator -(Hunter obj, int level)
        {
            if(obj.Level > 1)
            {
                obj.Level += level;
            }
            return obj;
        }
    }
}
