using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;

namespace lab7
{
    class airplane
    {
        private Int16 id;
        private String type;
        private String model;
        private Int16 year_of_issue;
        private Int16 seats;
        private Int16 carrying;
        private DateTime maintenance;

        public airplane()
        {

        }

        public airplane(Int16 id, String type, String model, Int16 year_of_issue, Int16 seats, Int16 carrying)
        {
            this.id = id;
            this.type = type;
            this.model = model;
            this.year_of_issue = year_of_issue;
            this.seats = seats;
            this.carrying = carrying;
        }

        public Int16 Id
        {
            get { return id; }
            set { id = Convert.ToInt16(value); }
        }

        public String Type
        {
            get { return type; }
            set { type = Convert.ToString(value); }
        }

        public String Model
        {
            get { return model; }
            set { model = Convert.ToString(value); }
        }

        public Int16 Year_of_issue
        {
            get { return year_of_issue; }
            set { year_of_issue = Convert.ToInt16(value); }
        }

        public Int16 Seats
        {
            get { return seats; }
            set { seats = Convert.ToInt16(value); }
        }

        public Int16 Carrying
        {
            get { return carrying; }
            set { carrying = Convert.ToInt16(value); }
        }

        public DateTime Maintenance
        {
            get { return maintenance; }
            set { maintenance = Convert.ToDateTime(value); }
        }
    }
}
