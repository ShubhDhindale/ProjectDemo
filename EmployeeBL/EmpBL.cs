using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeBO;
using EmployeeDAL;
using System.Data;

namespace EmployeeBL
{
    public class EmpBL
    {
        public int SaveEmployeeBL(Employee objUserBL) 
        {
            try
            {
                EmpDAL objUserda = new EmpDAL(); 
                return objUserda.AddEmployeeDetails(objUserBL); 
            }
            catch
            {
                throw;
            }
        }


        public int DeleteEmployeeBL(Employee objUserBL)
        {
            try
            {
                EmpDAL objUserda = new EmpDAL();
                return objUserda.DeleteEmployeeDal(objUserBL);
            }
            catch
            {
                throw;
            }
        }

        public DataSet AllEmployees()
        {
            EmpDAL dal = new EmpDAL();
            return dal.GetEmpInfo();
        }

        public int UpdateEmployeeBL(Employee objUserBL)
        {
            EmpDAL dal1 = new EmpDAL();
            return dal1.UpdateEmployeeDetails(objUserBL);
        }

        public int AdminUpdateEmpBL(Employee objUserBL1)
        {
            EmpDAL dal2 = new EmpDAL();
            return dal2.AdminUpdateEmpDetails(objUserBL1);
        }

        public DataSet GetEmployeeDetailsBL(int id)
        {
            EmpDAL dal2 = new EmpDAL();
            return dal2.GetEmployeeDetails(id);
        }
    }
}
