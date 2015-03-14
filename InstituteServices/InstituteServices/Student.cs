using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InstituteServices
{
    public class Student
    {
        private int Stuid;

        public int stuid
        {
            get { return Stuid; }
            set { Stuid = value; }
        }
        private string StuFName;

        public string stuFName
        {
            get { return StuFName; }
            set { StuFName = value; }
        }
        private string StuLName;

        public string stuLName
        {
            get { return StuLName; }
            set { StuLName = value; }
        }
        private string StuAddr;

        public string stuAddr
        {
            get { return StuAddr; }
            set { StuAddr = value; }
        }
        private string StuGender;

        public string stuGender
        {
            get { return StuGender; }
            set { StuGender = value; }
        }
        private int StuContact;

        public int stuContact
        {
            get { return StuContact; }
            set { StuContact = value; }
        }
        private string StuPhoto;

        public string stuPhoto
        {
            get { return StuPhoto; }
            set { StuPhoto = value; }
        }

        private int StuCourseID;

        public int stuCourseID
        {
            get { return StuCourseID; }
            set { StuCourseID = value; }
        }
        
        
    }
}
