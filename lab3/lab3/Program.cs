using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Hunter hunter1 = new Hunter();
            Console.WriteLine(hunter1.ToString());
            hunter1.WriteToFile();
            hunter1 += 3;
            hunter1.Go(hunter1);
            Console.WriteLine(hunter1.ToString());
            Console.WriteLine("hunter1.GetHashCode() - " + hunter1.GetHashCode() + "\n");

            Hunter hunter2 = new Hunter();
            Console.WriteLine(hunter2.ToString() + "\n");

            Console.WriteLine("hunter1 > hunter2?");
            Console.WriteLine(hunter1 > hunter2);
            Console.WriteLine();

            Console.WriteLine("hunter1 < hunter2?");
            Console.WriteLine(hunter1 < hunter2);
            Console.WriteLine();

            Console.WriteLine("hunter1 == hunter2?");
            Console.WriteLine(hunter1 == hunter2);
            Console.WriteLine();

            Console.WriteLine("hunter1 != hunter2?");
            Console.WriteLine(hunter1 != hunter2);
            Console.WriteLine();

            Shaman shaman = new Shaman();
            Console.WriteLine(shaman.ToString());
            shaman += 2;
            Console.WriteLine(shaman.ToString() + "\n");
            
            try
            {
                Hunter hunter3 = new Hunter();
                hunter3.HP = -30;
            }
            catch(InvalidParam exp)
            {
                Console.WriteLine(new String('!', 53));
                Console.WriteLine(exp.What());
            }
            finally
            {
                Console.WriteLine("\n----------Блок finally");

                GameHistory game = new GameHistory();

                Console.WriteLine(shaman.ToString() + "\n");

                game.History.Push(shaman.SaveState());
                shaman.RestoreState(game.History.Pop());
                Console.WriteLine("");
            }
        }
    }
}
