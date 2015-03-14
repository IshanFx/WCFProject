using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace InstituteServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "InstituteServices" in both code and config file together.
    public class InstituteServices : IInstituteServices,IEmployeeServices,ITeacherServices,IStudentServices,ICourseServices
    {
       
        DB db;
        DataTable table;
        DataSet set;
        public void DoWork()
        {
        }

        public int SaveEmployee(Employee employee)
        {
            string sql = "INSERT INTO Employee VALUES('" + employee.EmpId + "','" + employee.EmpFName + "','" + employee.EmpLName + "','" + employee.EmpNIC + "','" + employee.EmpAddress + "','" + employee .EmpContact+ "')";           
            return new DB().DMLQuery(sql);
        }

        public Employee SearchEmployeeData(int employeeid)
        {
                Employee employee = employee = new Employee();
                db = new DB();
                
                string sql = "SELECT * FROM Employee WHERE empid = '"+employeeid+"'";
                DataTable table = db.SelectQuery(sql);             
                     employee.EmpFName = table.Rows[0][1].ToString();
                     employee.EmpLName = table.Rows[0][1].ToString();
                     employee.EmpNIC = table.Rows[0][1].ToString();
                     employee.EmpAddress = table.Rows[0][1].ToString();
                     employee.EmpContact = table.Rows[0][1].ToString();

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
            throw new NotImplementedException();
        }

        public int SaveCourse(Course course)
        {
            string sql = "INSERT INTO course VALUES('" + course.CourseId + "','" + course.CourseDay + "','" + course.CourseStartTime + "','" + course.CourseEndTime + "','" + course.CourseBatch + "','" + course.CourseTeacherId + "')";
            return new DB().DMLQuery(sql);
        }


        public int UpdateCourse(Course course)
        {
            throw new NotImplementedException();
        }


        public int UpdateStudent(Student student)
        {
            throw new NotImplementedException();
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
            table = db.SelectQuery(sql);
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
    }
}
