using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    partial class Hunter : Fighter
    {
        public override void WriteToFile()
        {
            File.WriteAllText("hunter.txt", "========Fighter type: " + WhatType());
            File.AppendAllText("hunter.txt", "\r\n~~~Level: " + Level.ToString());
            File.AppendAllText("hunter.txt", "\r\n~~~Dexterity: " + Dexterity.ToString());
            File.AppendAllText("hunter.txt", "\r\n~~~HP: " + HP.ToString());
            File.AppendAllText("hunter.txt", "\r\n~~~Damage: " + Damage.ToString());
        }
    }
}
