using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    public delegate int Comparator(Airplane x, Airplane y);

    public class Airport : IEnumerable 
    {

        public List<Airplane> listAirplane;

        public Airport()
        {
            listAirplane = new List<Airplane>();
        }


        public void Add(Airplane plane)
        {
            listAirplane.Add(plane);
        }

        public void RemoveAt(int i)
        {
            listAirplane.RemoveAt(i);
        }

        public int Count()
        {
            return listAirplane.Count();
        }

        public void Clear()
        {
            listAirplane.Clear();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return listAirplane.GetEnumerator();
        }

       public Airplane this[int index]
        {
            get
            {
                return listAirplane[index];
            }
            set
            {
                listAirplane[index] = value;
            }
        }

        public static implicit operator Airport(List<Airplane> v)
        {
            Airport airport = new Airport();

            return airport;
        }

        public void AddToAirport(List<Airplane> list)
        {
            for(int i = 0; i < list.Count(); i++)
            {
                listAirplane.Add(list[i]);
            }
        }

        public void Sort(Comparator func)
        {
            Airplane tmp;
            for (int i = 0; i < listAirplane.Count; i++)
                for (int j = 0; j < listAirplane.Count - 1 - i; j++)
                    if (func(listAirplane[j], listAirplane[j + 1]) > 0)
                    {
                        tmp = listAirplane[j];
                        listAirplane[j] = listAirplane[j + 1];
                        listAirplane[j + 1] = tmp;
                    }
        }

    }
}
