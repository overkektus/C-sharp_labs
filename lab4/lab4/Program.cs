using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Collection<Prism> collect1 = new Collection<Prism>();
            collect1.Add(new Prism(20, 20, 3));
            collect1.Add(new Prism(30, 30, 3));
            collect1.Add(new Prism(40, 40, 3));

            collect1.Sort();
            collect1.PrintList();

            foreach (Prism el in collect1)
            {
                el.Print();
            }
        }
    }
}
