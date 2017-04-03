using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4 {
    class Prism : IComparable, IEnumerable
    {
        private const string figureType = "Prism";
        private int baseSide;
        private int height;
        private int numberOfEdges;
        public static int totalCount;
        public readonly int ID;

        int IComparable.CompareTo(object obj)
        {
            if (this.Height < (obj as Prism).Height)
                return 1;
            else if (this.Height > (obj as Prism).Height)
                return -1;
            else return 0;
        }

        public Prism(int BaseSide, int Height, int NumberOfEdges) {
            this.BaseSide = BaseSide;
            this.Height = Height;
            this.NumberOfEdges = NumberOfEdges;
            ID = BaseSide.GetHashCode() + Height.GetHashCode() + NumberOfEdges.GetHashCode();
            totalCount++;
        }

        public Prism() {
            baseSide = 0;
            height = 0;
            numberOfEdges = 0;
            ID = BaseSide.GetHashCode() + Height.GetHashCode() + NumberOfEdges.GetHashCode();
            totalCount++;
        }

        static Prism() {
            totalCount = 0;
            Console.WriteLine("----------------Конструктор типа------------------");
        }

        public string FigureType {
            get { return figureType; }
        }
        public int BaseSide {
            get { return baseSide; }
            set {
                if (value > 0)
                    baseSide = value; 
                else {
                    Console.WriteLine("!!!Неверный ввод BaseSide!!!");
                    BaseSide = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public int Height {
            get { return height; }
            set {
                if(value > 0)
                    height = value;
                else {
                    Console.WriteLine("!!!Неверный ввод Height!!!");
                    Height = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public int NumberOfEdges {
            get { return numberOfEdges; }
            set {
                if(value > 2) {
                    numberOfEdges = value;
                }
                else {
                    Console.WriteLine("!!!Неверный ввод NumberOfEdges!!!");
                    NumberOfEdges = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public static void ClassInfo() {
            Console.WriteLine("-------------------Класс призмы-------------------");
        }

        public void Print() {
            Console.WriteLine(new String('=', 14));
            Console.WriteLine("\tBase side:{0}\n\tВысота:{1}\n\tЧисло граней:{2}\n\tID: {3}",
                    BaseSide,
                    Height,
                    NumberOfEdges,
                    ID
            );
        }

        public override bool Equals(object obj) {
            return Equals(obj as Prism);
        }

        public bool Equals(Prism obj) {
            if (obj== null) return false;
            return this.BaseSide==obj.BaseSide && this.Height==obj.Height && this.NumberOfEdges==obj.NumberOfEdges;
        }

        public override int GetHashCode() {
            return BaseSide.GetHashCode() + Height.GetHashCode() + NumberOfEdges.GetHashCode();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        ~Prism() {
            totalCount--;
        }
    }

    static class PrismExtender {
        public static bool PrismInBox(this Prism obj,int length,int height,int width) {
                if (height >= obj.Height && length > obj.BaseSide && width > obj.BaseSide) return true;
                else if (height >= obj.BaseSide && length > obj.Height && width > obj.BaseSide) return true;
                else return false;
        }
    }
}
