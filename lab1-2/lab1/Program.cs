using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1 {
    class Program {
        static void Main(string[] args) {
            Prism pr1 = new Prism(3,5,3);
            Console.WriteLine("Объем призмы: {0}", MathPrism.GetFigureCapasity(pr1));
            Prism.ClassInfo();

            Console.WriteLine(new String('-', 50));

            pr1.Print();
            MathPrism.StretchFigure(ref pr1);
            Console.WriteLine(new String('-', 50));
            pr1.Print();

            Console.WriteLine(new String('-', 50));

            if (pr1.PrismInBox(3, 10, 4))
                Console.WriteLine("Может быть помещена в коробку!");
            else
                Console.WriteLine("НЕ может быть помещена в коробку!");

            Console.WriteLine(new String('-',50));

            var anonim = new { FigureType = pr1.FigureType, FigureSquare=MathPrism.GetFigureSideSquare(pr1),
                FigureCapasity =MathPrism.GetFigureCapasity(pr1) };
            Console.WriteLine("Тип: {0}\nПлощадь: {1}\nОбъем: {2}",
                anonim.FigureType,anonim.FigureSquare,anonim.FigureCapasity);
        }
    }
}
