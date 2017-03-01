using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1 {
    static class MathPrism {
        public static double GetFigureCapasity(Prism obj) {
            double radians = (180 / obj.NumberOfEdges) * (Math.PI / 180);
            return ((obj.NumberOfEdges * Math.Pow(obj.BaseSide, 2)) / (4 * Math.Tan(radians))) * obj.Height;
        }

        public static int GetFigureSideSquare(Prism obj) {
            return obj.BaseSide * obj.NumberOfEdges * obj.Height;
        }

        public static void StretchFigure(ref Prism obj) {
            obj.Height *= 2;
        }
    }
}
