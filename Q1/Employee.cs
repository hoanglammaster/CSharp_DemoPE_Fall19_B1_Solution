﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Q1
{
    class Employee
    {
        private int employeeid;
        private string employeename;
        private string address;
        public Employee()
        {

        }

        public Employee(int employeeid, string employeename, string address)
        {
            this.employeeid = employeeid;
            this.employeename = employeename;
            this.address = address;
        }

        public int EmployeeID
        {
            get { return employeeid; }
            set { employeeid = value; }
        }
        public string EmployeeName
        {
            get { return employeename; }
            set { employeename = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public override string ToString()
        {
            return employeeid + " - " + employeename + " - " + address;
        }

        public void ReadFromString(string line)
        {
            string[] data = line.Split('|');
            this.employeeid = Convert.ToInt32(data[0]);
            this.employeename = data[1];
            this.address = data[2];
        }
    }
}
