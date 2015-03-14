using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InstituteServices
{
    public class Course
    {
        private int courseId;
        private string courseDay;
        private int courseBatch;
        private int courseTeacherId;
        private DateTime courseStartTime;
        private DateTime courseEndTime;


        public int CourseId
        {
            get { return courseId; }
            set { courseId = value; }
        }
        

        public string CourseDay
        {
            get { return courseDay; }
            set { courseDay = value; }
        }
       

        public int CourseBatch
        {
            get { return courseBatch; }
            set { courseBatch = value; }
        }
        

        public int CourseTeacherId
        {
            get { return courseTeacherId; }
            set { courseTeacherId = value; }
        }
       

        public DateTime CourseStartTime
        {
            get { return courseStartTime; }
            set { courseStartTime = value; }
        }
       

        public DateTime CourseEndTime
        {
            get { return courseEndTime; }
            set { courseEndTime = value; }
        }










    }
}
