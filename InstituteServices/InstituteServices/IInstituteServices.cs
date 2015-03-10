using System;
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
    
    }


    [ServiceContract]
    public interface ICourseServices {

        [OperationContract]
        int SaveCourse(Course course);

        [OperationContract]
        int UpdateCourse(Course course);
    }

    [ServiceContract]
    public interface IStudentServices {

        [OperationContract]
        int SaveStudent(Student student);

        [OperationContract]
        int UpdateStudent(Student student);
    }
}
