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
            collect1.Add(new Prism(50, 50, 3));
            collect1.Add(new Prism(40, 40, 3));

            collect1.Sort();
            //collect1.ReverseList();
            collect1.PrintList();
            collect1.WriteToFile();

            foreach (Prism el in collect1)
            {
                el.Print();
            }
            Console.ReadKey();

            Console.WriteLine("\n");
            Console.WriteLine(new String('-', 50));

            Collection<int> list1 = new Collection<int>();
            list1.Add(1); list1.Add(3); list1.Add(-5); list1.Add(2);

            Collection<int> list2 = new Collection<int>();
            list2.Add(10); list2.Add(313); list2.Add(92); list2.Add(92);

            Collection<int> list3 = new Collection<int>();
            list3.Add(8); list3.Add(5); list3.Add(-53); list3.Add(1); list3.Add(-44);

            Collection<int> list4 = new Collection<int>();
            list4.Add(100); list4.Add(15); list4.Add(280); list4.Add(257);

            Collection<int> list5 = new Collection<int>();
            list5.Add(39); list5.Add(93); list5.Add(69); list5.Add(9); list5.Add(9); list5.Add(9);

            Collection<int>[] list = { list1, list2, list3, list4, list5 };
            int i = 1;
            foreach (Collection<int> item in list)
            {
                Console.WriteLine("\tlist" + i);
                foreach (int itemInList in item)
                {
                    Console.WriteLine("  " + itemInList);
                }
                i++;
            }
            Console.ReadKey();
            Console.WriteLine("\nMax length collection:");

            var newListMax = from Collection<int> item in list
                             where item.Count() == Collection<int>.GetMaxCollectionCount(list)
                             select item;

            foreach (Collection<int> item in newListMax)
            {
                foreach (int itemInList in item)
                {
                    Console.WriteLine(itemInList);
                }
                Console.WriteLine(new String('-', 50));
            }
            Console.ReadKey();
            Console.WriteLine("\nMin length collection:");

            var newListMin = from Collection<int> item in list
                             where item.Count() == Collection<int>.GetMinCollectionCount(list)
                             select item;

            foreach (Collection<int> item in newListMin)
            {
                foreach (int itemInList in item)
                {
                    Console.WriteLine(itemInList);
                }
                Console.WriteLine(new String('-', 50));
            }
            Console.ReadKey();
            Console.WriteLine("\nPositive collections:");

            var newListPositive = from Collection<int> item in list
                                  where item.Exists(x => x < 0)
                                  select item;

            foreach (Collection<int> item in newListPositive)
            {
                foreach (int itemInList in item)
                {
                    Console.WriteLine(itemInList);
                }
                Console.WriteLine(new String('-', 50));
            }

            Console.WriteLine(new String('-', 50));
            Console.ReadKey();
            List<string> StringCollect = new List<string>();
            StringCollect.Add("Apple");
            StringCollect.Add("Potatoes");
            StringCollect.Add("Orange");
            StringCollect.Add("Kiwi");
            StringCollect.Add("Avokado");
            StringCollect.Add("Mango");
            StringCollect.Add("Peach");
            StringCollect.Add("Apricot");
            StringCollect.Add("Lemon");
            StringCollect.Add("Papaya");

            foreach (string item in StringCollect)
            {
                Console.WriteLine("\t" + item);
            }
            //StringCollect.WriteToFile();

            Console.WriteLine("\n~~~~~Strings witch contains 'A': ");

            var listForStringExist = from string item in StringCollect
                                     where item.Contains("A")
                                     select item;

            foreach (string item in listForStringExist)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n~~~~~Strings with length==4 from List: ");
            var listForStringLength = from string item in StringCollect
                                      where item.Length == 4
                                      select item;

            foreach (string item in listForStringLength)
            {
                Console.WriteLine(item);
            }

            StringCollect.SortMore();
            Console.WriteLine("\n");
            Console.WriteLine(new String('=', 50));
            foreach (string item in StringCollect)
            {
                Console.WriteLine("\t" + item);
            }
        }
    }

    static class ListExtender
    {
        public static void SortMore(this List<string> inputList)
        {
            for (int i = 0; i < inputList.Count; i++)
            {
                for (int j = 0; j < inputList.Count - 1 - i; j++)
                {
                    if (inputList[j].Length > inputList[j + 1].Length)
                    {
                        string tmpParam = inputList[j];
                        inputList[j] = inputList[j + 1];
                        inputList[j + 1] = tmpParam;
                    }
                }
            }
        }









        public static void SortLess(this List<string> inputList)
        {
            for (int i = 0; i < inputList.Count; i++)
            {
                for (int j = 0; j < inputList.Count - 1 - i; j++)
                {
                    if (inputList[j].Length < inputList[j + 1].Length)
                    {
                        string tmpParam = inputList[j];
                        inputList[j] = inputList[j + 1];
                        inputList[j + 1] = tmpParam;
                    }
                }
            }
        }
    }
}
