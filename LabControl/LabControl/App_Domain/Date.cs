using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace login.App_Domain
{
    public class Date
    {

        private int id;
        private Date date;
        private String hour;


        public Date()
        { 
        }
        public Date(int id, Date date, String hour) 
        {
            this.id = id;
            this.date = date;
            this.hour = hour;
            
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        

        public Date Date1
        {
            get { return date; }
            set { date = value; }
        }
        

        public String Hour
        {
            get { return hour; }
            set { hour = value; }
        }

     

        
    }
}