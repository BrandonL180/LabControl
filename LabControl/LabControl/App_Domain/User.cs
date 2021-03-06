﻿using login.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace login.Account.App_Domain
{
    public class User
    {
        private int id;


        private string name;
        private string email;
        private int studentId;
        private string password;
        private int role;

        public User(){
        
        }

        public User(string name, string clave) {
            this.name = name;
            this.password = clave;
        }

        public User(string name, string email, int studentId, string password, int role) {
            this.name = name;
            this.email = email;
            this.studentId = studentId;
            this.password = password;
            this.role = role;
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

        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }


        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int Role
        {
            get { return role; }
            set { role = value; }
        }
    }
}