using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    sealed partial class Shaman
    {
        public override void WriteToFile()
        {
            File.WriteAllText("shaman.txt", "========Fighter type: " + WhatType());
            File.AppendAllText("shaman.txt", "\r\n~~~Level: " + Level.ToString());
            File.AppendAllText("shaman.txt", "\r\n~~~Dexterity: " + Dexterity.ToString());
            File.AppendAllText("shaman.txt", "\r\n~~~HP: " + HP.ToString());
            File.AppendAllText("shaman.txt", "\r\n~~~Damage: " + Damage.ToString());
            File.AppendAllText("shaman.txt", "\r\n~~~Mana: " + Mana.ToString());
        }
    }
}
