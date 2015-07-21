using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Attempt1.App_Domain
{
    public class Lab
    {
        private int id;
        private string name;
        private Schedule schedule;
        private List<WorkStation> workStations;


        public Lab()
        {

        }

        public Lab(int id, string name)
        {
            this.id = id;
            this.name = name;
            workStations = new List<WorkStation>();
            schedule = new Schedule();
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    

        public Schedule Schedule
        {
            get { return schedule; }
            set { schedule = value; }
        }

        public List<WorkStation> WorkStations 
        {
            get { return workStations; }
            set { workStations = value; }
        }
    }
}