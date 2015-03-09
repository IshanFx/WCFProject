using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InstituteServices
{
    public class Teacher
    {
        private int teacherId;

        public int TeacherId
        {
            get { return teacherId; }
            set { teacherId = value; }
        }
        private string teacherFName;

        public string TeacherFName
        {
            get { return teacherFName; }
            set { teacherFName = value; }
        }
        private string teacherLName;

        public string TeacherLName
        {
            get { return teacherLName; }
            set { teacherLName = value; }
        }
        private string teacherNIC;

        public string TeacherNIC
        {
            get { return teacherNIC; }
            set { teacherNIC = value; }
        }
        private string teacherContact;

        public string TeacherContact
        {
            get { return teacherContact; }
            set { teacherContact = value; }
        }
        private string teacherAddress;

        public string TeacherAddress
        {
            get { return teacherAddress; }
            set { teacherAddress = value; }
        }
        private string teacherMail;

        public string TeacherMail
        {
            get { return teacherMail; }
            set { teacherMail = value; }
        }
        private string teacherSubject;

        public string TeacherSubject
        {
            get { return teacherSubject; }
            set { teacherSubject = value; }
        }

        private string teacherPayMonth;

        public string TeacherPayMonth
        {
            get { return teacherPayMonth; }
            set { teacherPayMonth = value; }
        }
        private int teacherPayYear;

        public int TeacherPayYear
        {
            get { return teacherPayYear; }
            set { teacherPayYear = value; }
        }
        private string teacherPayDate;

        public string TeacherPayDate
        {
            get { return teacherPayDate; }
            set { teacherPayDate = value; }
        }
        private double teacherPayAmount;

        public double TeacherPayAmount
        {
            get { return teacherPayAmount; }
            set { teacherPayAmount = value; }
        }

    }
}
