using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Attempt1.App_Domain
{
    public class WorkStation
    {
        private int id;
        private string name;
        private bool reserved;

        public WorkStation()
        {

        }

        public WorkStation(int id, string name, bool reserved)
        {
            this.id = id;
            this.name = name;
            this.reserved = reserved;
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
    }
}