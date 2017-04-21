using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.Collections;

namespace lab7
{
    class Airplane
    {
        public Int16 Id { get; set; }
        public String Type { get; set; }
        public String Model { get; set; }
        public Int16 Year_of_issue { get; set; }
        public Int16 Seats { get; set; }
        public Int16 Carrying { get; set; }
        public DateTime Maintenance { get; set; }

        public List<Member> listMember = new List<Member>();

        public void Add(Member member)
        {
            listMember.Add(member);
        }

        public void RemoveAt(int i)
        {
            listMember.RemoveAt(i);
        }

        public int Count()
        {
            return listMember.Count();
        }

        public void Clear()
        {
            listMember.Clear();
        }

        /*
        IEnumerator IEnumerable.GetEnumerator()
        {
            return listMember.GetEnumerator();
        }
        */

        public Member this[int index]
        {
            get
            {
                return listMember[index];
            }
            set
            {
                listMember[index] = value;
            }
        }

        public Airplane() { }

        public Airplane(Int16 id, String type, String model, Int16 year_of_issue, Int16 seats, Int16 carrying, DateTime maintenance)
        {
            Id = id;
            Type = type;
            Model = model;
            Year_of_issue = year_of_issue;
            Seats = seats;
            Carrying = carrying;
            Maintenance = maintenance;
        }

        public override string ToString()
        {
            string result;
            result = "ID: " + Id + '\t' +
                     "Type: " + Type + "\t" +
                     "Model: " + Model + "\t" +
                     "Year issue: " + Year_of_issue + "\t" +
                     "Seats: " + Seats + "\t" +
                     "Carrying: " + Carrying + "\t" +
                     "Maintenance: " + Maintenance + "\t";
            return result;
        }

    }
}
