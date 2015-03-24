using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IO;
using System.Drawing;

namespace InstituteServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "InstituteServices" in both code and config file together.
    public class InstituteServices : IInstituteServices,IEmployeeServices,ITeacherServices,IStudentServices,ICourseServices
    {
       
        DB db;
        DataTable table;
        DataSet set;
        MySqlDataReader read;
        MySqlCommand cmd;
        public void DoWork()
        {
        }

        public int SaveEmployee(Employee employee)
        {
            MySqlCommand cmd = new MySqlCommand();
            string sql = "INSERT INTO Employee VALUES('" + employee.EmpId + "','" + employee.EmpFName + "','" + employee.EmpLName + "','" + employee.EmpNIC + "','" + employee.EmpAddress + "','" + employee .EmpContact+ "')";     
      
            return new DB().DMLQuery(sql);
        }

        public Employee SearchEmployeeData(int employeeid)
        {
                Employee employee = new Employee();
                db = new DB();
                
                string sql = "SELECT * FROM Employee WHERE empid = '"+employeeid+"'";
                DataTable table = db.SelectQuery(sql);             
                     employee.EmpFName = table.Rows[0][1].ToString();
                     employee.EmpLName = table.Rows[0][2].ToString();
                     employee.EmpNIC = table.Rows[0][3].ToString();
                     employee.EmpAddress = table.Rows[0][4].ToString();
                     employee.EmpContact = table.Rows[0][5].ToString();

            return employee;
        }

        public int UpdateEmployee(Employee employee)
        {
          string sql = "UPDATE Employee SET fname='" + employee.EmpFName + "',lname='" + employee.EmpLName + "',nic='" + employee.EmpNIC + "',address='" + employee.EmpAddress + "',contact='" + employee.EmpContact + "' WHERE empid='" + employee .EmpId+ "' ";

            return new DB().DMLQuery(sql);
        }



        public int SaveEmployeePayments(Employee employee)
        {
           string sql = "INSERT INTO emppayments(month,year,paydate,amount,empid) VALUES('" + employee.EmpPayMonth + "','" + employee.EmpPayYear + "','" + employee.EmpPayDate + "','" + employee.EmpPayAmount + "','" + employee .EmpId+ "') ";  
            return new DB().DMLQuery(sql);
        }

        public int SaveTeacher(Teacher teacher)
        {
            string sql = "INSERT INTO teachers VALUES('" + teacher.TeacherId + "','" + teacher.TeacherFName + "','" + teacher.TeacherLName + "','" + teacher.TeacherNIC + "','" + teacher.TeacherContact + "','" + teacher.TeacherAddress + "','" + teacher.TeacherMail + "','" + teacher.TeacherSubject + "')";

            return new DB().DMLQuery(sql);
        }

        public Teacher SearchTeacherData(int teacherId)
        {
            Teacher teacher = new Teacher ();
                string sql = "SELECT * FROM teachers WHERE teaid='" + teacherId+ "'";
                db = new DB ();
                DataTable table = db.SelectQuery(sql);  
                teacher.TeacherFName = table.Rows[0][1].ToString();
                teacher.TeacherLName = table.Rows[0][2].ToString();
                teacher.TeacherNIC = table.Rows[0][3].ToString();
                teacher.TeacherContact = table.Rows[0][4].ToString();
                teacher.TeacherAddress = table.Rows[0][5].ToString();
                teacher.TeacherMail = table.Rows[0][6].ToString();
                teacher.TeacherSubject = table.Rows[0][7].ToString();
           
            return teacher;
        }

        public int UpdateTeacher(Teacher teacher)
        {
            string sql = "UPDATE teachers SET fname='" + teacher.TeacherFName + "',lname='" + teacher.TeacherLName + "',nic='" + teacher.TeacherNIC + "',contact='" + teacher.TeacherContact + "',address='" + teacher.TeacherAddress + "',mail='" + teacher.TeacherMail + "',subname='" + teacher.TeacherSubject + "' WHERE teaid='" + teacher.TeacherId + "'";
            return new DB().DMLQuery(sql);
        }


        public int SaveTeacherPayment(Teacher teacher)
        {
           string sql = "INSERT INTO teacherspayments(month,year,date,amount,teacid) VALUES('" + teacher.TeacherPayMonth + "','" + teacher.TeacherPayYear + "','" + teacher.TeacherPayDate + "','" + teacher.TeacherPayAmount + "','" + teacher .TeacherId+ "')";
               
            return new DB().DMLQuery(sql);
        }

        public int SaveStudent(Student student)
        {
            string sql = "INSERT INTO student VALUES('" + student.stuid + "','" + student.stuFName + "','" + student.stuLName + "','" + student.stuAddr + "','" + student.stuGender + "','" + student.stuContact + "',?pic)";

            new DB().ImageSave(student.stuPhoto,sql);

            return StudentClassSave(student);
        }

        public int StudentClassSave(Student student)
        {           
            string sql = "INSERT INTO studentclass VALUES('"+student.stuid+"','" +student.stuCourseID+ "')";
             return new DB().DMLQuery(sql);
        }

        public DataSet GetStuCourseData()
        {
            string sql = "SELECT cls.courseid,cls.day,cls.starttime,cls.endtime,cls.batch,CONCAT(tea.fname,' ',tea.lname) As Teacher FROM Teachers tea JOIN course cls WHERE tea.teaid = cls.teachid";
            db = new DB();
            DataTable table = db.SelectQuery(sql);
            DataSet set = new DataSet();
            set.Tables.Add(table);
            return set;
        }

        public DataSet GetStuAttenReport()
        {
            string sql = "SELECT CONCAT(s.fname,' ',s.lname)AS Name,a.year AS Year,a.month AS Month,a.courseid AS COURSE_ID FROM student s,attendance a WHERE s.studentid=a.studentid AND a.attenID";
            db = new DB();
            DataTable table = db.SelectQuery(sql);
            DataSet set = new DataSet();
            set.Tables.Add(table);
            return set;
        }

        public DataSet GetAllStudentData()
        {
            string sql = "SELECT studentid As Id,CONCAT(fname,' ',lname)AS Name,CONCAT(address)AS Address,gender AS Gender,contact AS Contact FROM student";
            db = new DB();
            DataTable table = db.SelectQuery(sql);
            DataSet set = new DataSet();
            set.Tables.Add(table);
            return set;
        }


        public int UpdateStudent(Student student)
        {
            string sql = "UPDATE student SET fname='" + student.stuFName + "', lname='" + student.stuLName + "', address='" + student.stuAddr + "', gender='" + student.stuGender + "', contact='" + student.stuContact + "' WHERE studentid='" + student.stuid + "'";
            return new DB().DMLQuery(sql);
        }

        public Student SearchStudentDate(int studentid)
        {
            Student student = student = new Student();
            db = new DB();

            string sql = "SELECT * FROM student WHERE studentid = '" + studentid + "'";
            DataTable table = db.SelectQuery(sql);

            student.stuFName = table.Rows[0][1].ToString();
            student.stuLName = table.Rows[0][2].ToString();
            student.stuAddr = table.Rows[0][3].ToString();
            student.stuGender = table.Rows[0][4].ToString();
            student.stuContact = Convert.ToInt32(table.Rows[0][5].ToString());

            return student;
        }
        

        public int studentlastid()
        {

            int id = new DB().GetLastIdQuery("SELECT MAX(studentid) FROM student");
            return id;
        }

        public int StudentAttenSave(Student student, int month, int day, int year)
        {
            int maxid = new DB().GetLastIdQuery("SELECT MAX(attenID) FROM attendance");
            string sql = "INSERT INTO attendance VALUES('" + maxid + "','" + month + "','" + year + "','" + day + "','" + student.stuid + "','" + student.stuCourseID + "')";
            return new DB().DMLQuery(sql);

            
        }

        
        public string stupaymentcheck(int stuid, int courseid)
        {
            string sql = "SELECT month FROM studentpayments WHERE studentID='" + stuid + "' AND courseid='" + courseid + "' AND month='" + DateTime.Now.Date.ToString("MMMM") + "' ";
            return new DB().GetData(sql); 
        }

        public int StudentPaySave(Student student,string month,int year,int amount)
        {
            int maxid=new DB().GetLastIdQuery("SELECT MAX(stuPayID) FROM studentpayments");
            string sql = "INSERT INTO studentpayments VALUES('" + maxid + "','" + month + "','" + year + "','" + amount + "','" + student.stuid + "','" + student.stuCourseID + "')";
            return new DB().DMLQuery(sql);
        }

        public int SaveCourse(Course course)
        {
            string sql = "INSERT INTO course VALUES('" + course.CourseId + "','" + course.CourseDay + "','" + course.CourseStartTime + "','" + course.CourseEndTime + "','" + course.CourseBatch + "','" + course.CourseTeacherId + "')";
            return new DB().DMLQuery(sql);
        }

        public DataSet GetAllCourseData()
        {
            string sql = "SELECT cls.courseid,cls.day,cls.starttime,cls.endtime,cls.batch,CONCAT(tea.fname,' ',tea.lname) As Teacher FROM Teachers tea JOIN course cls WHERE tea.teaid = cls.teachid";
            db = new DB();
            DataTable table = db.SelectQuery(sql);
            DataSet set = new DataSet();
            set.Tables.Add(table);
            return set;
        }

        public Course SearchCourse(int courseid)
        {
            Course course = new Course();
            string sql = "SELECT * FROM course WHERE courseid='" + courseid + "'";
            db = new DB();
            DataTable table = db.SelectQuery(sql);
            
            course.CourseDay = table.Rows[0][1].ToString();
            course.CourseStartTime = table.Rows[0][2].ToString();
            course.CourseEndTime = table.Rows[0][3].ToString();
            course.CourseBatch =Convert.ToInt32(table.Rows[0][4].ToString());
            course.CourseTeacherId = Convert.ToInt32(table.Rows[0][5].ToString());
            

            return course;
        }

        public int UpdateCourse(Course course)
        {
            string sql = "UPDATE course set day='" + course.CourseDay + "',startTime='"+course.CourseStartTime+"',endTime='"+course.CourseEndTime+"',batch='"+course.CourseBatch+"',teachID='"+course.CourseTeacherId+"' WHERE courseid='"+course.CourseId+"'";
            return new DB().DMLQuery(sql);
        }

        public DataSet GetCourseData()
        {
            string sql = "SELECT teaid As TeacherID,CONCAT(fname,' ',lname) As Name FROM Teachers ";
            db = new DB();
            DataTable table = db.SelectQuery(sql);
            DataSet set = new DataSet();
            set.Tables.Add(table);
            return set;
        }

        public int GetCourseLastId()
        {
            string sql = "SELECT MAX(courseid) FROM course";
            return new DB().GetLastIdQuery(sql);
        }

        public DataSet GetEmployeeData()
        {
                string sql = "SELECT* FROM Employee ";
                db = new DB();
                DataTable table = db.SelectQuery(sql);
                DataSet set = new DataSet();
                set.Tables.Add(table);
                return set;
        }


        public DataSet GetTeachersIncome()
        {
            string sql = "SELECT SUM(amount),month FROM teacherspayments GROUP BY month order by teacPayID";
            db = new DB();
            table = db.SelectQuery(sql);
            set = new DataSet();
            set.Tables.Add(table);
            return set;
        }


        public DataSet GetTeachersPaymentFull()
        {
            string sql = "SELECT t.teaid AS ID,CONCAT(t.fname,' ',t.lname) AS Name,t.nic AS NIC,tp.month AS Month,tp.year AS Year,tp.amount AS Amount,tp.date AS Date FROM teachers t,teacherspayments tp WHERE t.teaid=tp.teacid ";
            db = new DB();
            table = db.SelectQuery(sql);
            set = new DataSet();
            set.Tables.Add(table);
            return set;
        }


        public DataSet GetEmployeePaymentFull()
        {
            string sql = "SELECT CONCAT(e.fname,' ',e.lname)AS Name,e.nic AS NIC,ep.month AS Month,ep.year AS Year,ep.paydate AS PayDate,ep.amount AS Amount FROM employee e,emppayments ep WHERE e.empid=ep.empid";
            db = new DB();
            table = db.SelectQuery(sql);
            set = new DataSet();
            set.Tables.Add(table);
            return set;
        }


        public DataSet GetTeacherData()
        {
            string sql = "SELECT * FROM teachers";
            table = new DB().SelectQuery(sql);
            set = new DataSet();
            set.Tables.Add(table);
            return set;
        }


        public DataSet GetEmployeePayment()
        {
            string sql = "SELECT SUM(amount),month FROM emppayments GROUP BY month order by payid";
            db = new DB();
            table = db.SelectQuery(sql);
            set = new DataSet();
            set.Tables.Add(table);
            return set;
        }


        public int GetEmployeeLastId()
        {
            string sql = "SELECT MAX(empid) FROM employee";
            return new DB().GetLastIdQuery(sql);
        }


        public int GetTeacherLastId()
        {
            string sql = "SELECT MAX(teaid) FROM teachers";
            return new DB().GetLastIdQuery(sql);
        }


        public DataSet GetEmployeeAllPaymentReport()
        {
            string sql= "SELECT E.EMPID,E.FNAME,E.LNAME,EP.YEAR,EP.MONTH,EP.PAYDATE,EP.AMOUNT FROM EMPLOYEE E JOIN EMPPAYMENTS EP ON E.EMPID=EP.EMPID";
            table = new DB().SelectQuery(sql);
            set = new DataSet();
            set.Tables.Add(table);
            return set;
        }


        public DataSet GetEmployeeMonthYearpaymentReport(Employee employee)
        {
            string sql = "SELECT E.EMPID,E.FNAME,E.LNAME,EP.YEAR,EP.MONTH,EP.PAYDATE,EP.AMOUNT FROM EMPLOYEE E JOIN EMPPAYMENTS EP ON E.EMPID=EP.EMPID WHERE EP.MONTH='"+employee.EmpPayMonth+"' AND EP.YEAR='"+employee.EmpPayYear+"'";
            table = new DB().SelectQuery(sql);
            set = new DataSet();
            set.Tables.Add(table);
            return set;
        }


        public DataSet GetTeacherAllPaymentReport()
        {
            string sql = "SELECT T.TEAID,T.FNAME,T.LNAME,TP.YEAR,TP.MONTH,TP.DATE,TP.AMOUNT FROM TEACHERS T JOIN TEACHERSPAYMENTS TP ON TP.TEACID=T.TEAID";
            table = new DB().SelectQuery(sql);
            set = new DataSet();
            set.Tables.Add(table);
            return set;
        }

        public DataSet GetTeacherMonthYearpaymentReport(Teacher teacher)
        {
            string sql = "SELECT T.TEAID,T.FNAME,T.LNAME,TP.YEAR,TP.MONTH,TP.DATE,TP.AMOUNT FROM TEACHERS T JOIN TEACHERSPAYMENTS TP ON TP.TEACID=T.TEAID WHERE TP.MONTH='"+teacher.TeacherPayMonth+"' AND TP.YEAR='"+teacher.TeacherPayYear+"'";
            table = new DB().SelectQuery(sql);
            set = new DataSet();
            set.Tables.Add(table);
            return set;
        }

        
    }
}
