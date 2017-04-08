using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollectionUI
{
    class CollectionList<T> : IEnumerable
    {
        private List<T> list;

        public CollectionList()
        {
            list = new List<T>();
        }

        public T this[int index]
        {
            get
            {
                return list.ElementAt<T>(index);
            }
            set
            {
                list.Insert(index, value);
            }
        }

        public List<T> GetList()
        {
            return list;
        }

        public void Add(T elem)
        {
            list.Add(elem);
        }

        public void Add(CollectionList<T> list2)
        {
            foreach (T item in list2)
            {
                list.Add(item);
            }
        }

        public void InsertAt(T item, int index)
        {
            list.Insert(index, item);
        }

        public void Remove(T item)
        {
            list.Remove(item);
        }

        public void RemoveAt(int index)
        {
            list.RemoveAt(index);
        }


        public void Sort()
        {
            list.Sort();
        }

        public int Count()
        {
            return list.Count();
        }

        public static int GetMaxCollectionCount(CollectionList<T>[] arr)
        {
            try
            {
                int maxCount = 0;
                foreach (CollectionList<T> item in arr)
                {
                    if (item.Count() > maxCount)
                    {
                        maxCount = item.Count();
                    }
                }
                return maxCount;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static int GetMinCollectionCount(CollectionList<T>[] arr)
        {
            try
            {
                int minCount = arr[0].Count();
                foreach (CollectionList<T> item in arr)
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

        internal void Clear()
        {
            list.Clear();
        }

        public bool Exists(Predicate<T> predicate)
        {
            return !(list.Exists(predicate));
        }

        public void ReverseList()
        {
            list.Reverse();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }
}
