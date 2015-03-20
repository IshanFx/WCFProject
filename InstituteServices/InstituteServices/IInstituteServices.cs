﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace InstituteServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IInstituteServices" in both code and config file together.
    [ServiceContract]
    public interface IInstituteServices
    {
        [OperationContract]
        void DoWork();
    }

    [ServiceContract]
    public interface IEmployeeServices {
        [OperationContract]
        int SaveEmployee(Employee employee);

        [OperationContract]
        Employee SearchEmployeeData(int employeeid);

        [OperationContract]
        int UpdateEmployee(Employee employee);

        [OperationContract]
        int SaveEmployeePayments(Employee employee);

        [OperationContract]
        DataSet GetEmployeeData();

        [OperationContract]
        DataSet GetEmployeePaymentFull();

        [OperationContract]
        DataSet GetEmployeePayment();

        [OperationContract]
        int GetEmployeeLastId();
        }

    [ServiceContract]
    public interface ITeacherServices {
        [OperationContract]
        int SaveTeacher(Teacher teacher);

        [OperationContract]
        Teacher SearchTeacherData(int teacherId);

        [OperationContract]
        int UpdateTeacher(Teacher teacher);

        [OperationContract]
        int SaveTeacherPayment(Teacher teacher);

        [OperationContract]
        DataSet GetTeacherData();

        [OperationContract]
        DataSet GetTeachersIncome();

        [OperationContract]
        DataSet GetTeachersPaymentFull();

        [OperationContract]
        int GetTeacherLastId(); 
            
        
        
    }


    [ServiceContract]
    public interface ICourseServices {

        [OperationContract]
        int SaveCourse(Course course);

        [OperationContract]
        int UpdateCourse(Course course);

        [OperationContract]
        DataSet GetCourseData();

        [OperationContract]
        int GetCourseLastId();

        [OperationContract]
        DataSet GetAllCourseData();

        [OperationContract]
        Course SearchCourse(int courseid);
    }

    [ServiceContract]
    public interface IStudentServices {

        [OperationContract]
        int SaveStudent(Student student);

        [OperationContract]
        int UpdateStudent(Student student);
    }
    [ServiceContract]
    public interface IAccount {
        int CheckLogIn(Account account);
    
    }
}
