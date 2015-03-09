using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InstituteServices
{
    public class Employee
    {
        private int empId;
        private string empFName;
        private string empLName;
        private string empNIC;
        private string empAddress;
        private string empContact;
        private string empPayMonth;
        private int empPayYear;
        private DateTime empPayDate;
        private double empPayAmount;

        public int EmpId
        {
            get { return empId; }
            set { empId = value; }
        }
        
        public string EmpFName
        {
            get { return empFName; }
            set { empFName = value; }
        }
       
        public string EmpLName
        {
            get { return empLName; }
            set { empLName = value; }
        }
        

        public string EmpNIC
        {
            get { return empNIC; }
            set { empNIC = value; }
        }
       
        public string EmpAddress
        {
            get { return empAddress; }
            set { empAddress = value; }
        }

        public string EmpContact
        {
            get { return empContact; }
            set { empContact = value; }
        }
        
        public string EmpPayMonth
        {
            get { return empPayMonth; }
            set { empPayMonth = value; }
        }
        
        public int EmpPayYear
        {
            get { return empPayYear; }
            set { empPayYear = value; }
        }
       
        public DateTime EmpPayDate
        {
            get { return empPayDate; }
            set { empPayDate = value; }
        }
        
        public double EmpPayAmount
        {
            get { return empPayAmount; }
            set { empPayAmount = value; }
        }


    }
}
