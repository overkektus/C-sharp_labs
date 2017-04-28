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
    public class Airplane
    {
        public List<Member> listMember = new List<Member>();
        public UInt16 Id { get; set; }
        public String Type { get; set; }
        public String Model { get; set; }
        public UInt16 Year_of_issue { get; set; }
        public UInt16 Seats { get; set; }
        public UInt16 Carrying { get; set; }
        public String Maintenance { get; set; }

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

        public Airplane(UInt16 id, String type, String model, UInt16 year_of_issue, UInt16 seats, UInt16 carrying, String maintenance)
        {
            Id = id;
            Type = type;
            Model = model;
            Year_of_issue = year_of_issue;
            Seats = seats;
            Carrying = carrying;
            Maintenance = maintenance;
        }
     
    }
}
