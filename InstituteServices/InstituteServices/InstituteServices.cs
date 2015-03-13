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
        string con = ConfigurationManager.ConnectionStrings["Studb"].ConnectionString;
        DB db;
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
                teacher.TeacherLName = table.Rows[0][21].ToString();
                teacher.TeacherNIC = table.Rows[0][1].ToString();
                teacher.TeacherContact = table.Rows[0][1].ToString();
                teacher.TeacherAddress = table.Rows[0][1].ToString();
                teacher.TeacherMail = table.Rows[0][1].ToString();
                teacher.TeacherSubject = table.Rows[0][1].ToString();
           
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
            string sql = "INSERT INTO student VALUES('"+student.stuid+"','"+student.stuFName+"','"+student.stuLName+"','"+student.stuAddr+"','"+student.stuGender+"','"+student.stuContact+"','"+student.stuPhoto+"')";

            return new DB().DMLQuery(sql);
        }

        public int SaveCourse(Course course)
        {
            throw new NotImplementedException();
        }


        public int UpdateCourse(Course course)
        {
            throw new NotImplementedException();
        }


        public int UpdateStudent(Student student)
        {
            throw new NotImplementedException();
        }


        public DataTable GetEmployeeData()
        {
            string sql = "SELECT * FROM employee";
            db = new DB();
            return db.SelectQuery(sql);
        }
    }
}
