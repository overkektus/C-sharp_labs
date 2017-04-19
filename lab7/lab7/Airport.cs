using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Airport : IEnumerable 
    {
        private List<Airplane> listAirplane = new List<Airplane>();

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
    }
}
