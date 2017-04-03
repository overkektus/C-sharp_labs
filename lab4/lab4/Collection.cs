using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Collection<T>: IEnumerable
         where T: new()
    {
        IEnumerator IEnumerable.GetEnumerator()
        {
            return collect.GetEnumerator();
        }

        private List<T> collect;

        public Collection()
        {
            collect = new List<T>();
        }

        public void Add(T el)
        {
            collect.Add(el);
        }

        public void Add(Collection<T> collect2)
        {
            foreach (T el in collect2) collect2.Add(el);
        }

        public void InsertAt(T el, int i)
        {
            collect.Insert(i, el);
        }

        public T this[int i]
        {   
            get
            {
                return collect.ElementAt<T>(i);
            }
            set
            {
                collect.Insert(i, value);
            }
        }

        public void Remove(T el)
        {
            collect.Remove(el);
        }

        public void RemoveAt(int i)
        {
            collect.RemoveAt(i);
        }

        public void RemoveAll(Predicate<T> predicate)
        {
            collect.RemoveAll(predicate);
        }

        public void ReverseList()
        {
            collect.Reverse();
        }

        public void Sort()
        {
            collect.Sort();
        }

        public void PrintList()
        {
            int i = 0;
            Console.WriteLine("----PrintList----");
            foreach(T el in collect)
            {
                i++;
                Console.WriteLine("~elem " + i + " " + el);
            }
        }

        public int Count()
        {
            return collect.Count();
        }

        public static int GetMaxCollectionCount(Collection<T>[] mass)
        {
            try
            {
                int max = 0;
                foreach (Collection<T> el in mass)
                {
                    if (el.Count() > max)
                        max = el.Count();
                }
                return max;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static int GetMinCollectionCount(Collection<T>[] arr)
        {
            try
            {
                int minCount = arr[0].Count();
                foreach (Collection<T> item in arr)
                {
                    if (item.Count() < minCount)
                    {
                        minCount = item.Count();
                    }
                }
                return minCount;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public void WriteToFile()
        {
            Stream stream;
            using (stream = File.Open(@"\collection.txt", FileMode.Create, FileAccess.Write))
            {
                foreach (T item in collect)
                {
                    File.AppendAllText("collection.txt", item.ToString() + "\r\n");
                }
            }
        }

        public bool Exists(Predicate<T> predicate)
        {
            return !(collect.Exists(predicate));
        }
       
    }
}
