using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using EmployeeBO;
using EmployeeException;

namespace EmployeeDAL
{
    public class EmpDAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ToString());
        public int AddEmployeeDetails(Employee ObjBO)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("sp_AddEmpdetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", ObjBO.Id);
                cmd.Parameters.AddWithValue("@name", ObjBO.Name);
                cmd.Parameters.AddWithValue("@address", ObjBO.Address);
                cmd.Parameters.AddWithValue("@email", ObjBO.Email);
                cmd.Parameters.AddWithValue("@phone", ObjBO.Phone);
                cmd.Parameters.AddWithValue("@deptid", ObjBO.DeptId);

                con.Open();
                int Result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                return Result;
            }
            catch
            {
                throw;
            }
        }


        public int DeleteEmployeeDal(Employee objUserBL)
        {
            try
            {


                con.Open();
                SqlCommand cmd = new SqlCommand("sp_deleteEmpInfo", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", objUserBL.Id);

                int result = cmd.ExecuteNonQuery();
                con.Close();
                return result;

            }
            catch
            {
                throw;
            }



            
        }


        public DataSet GetEmpInfo()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Employee", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public int UpdateEmployeeDetails(Employee ObjBO1)  //For Update
        {
            try
            {

                SqlCommand cmd = new SqlCommand("sp_updatedetailsemp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", ObjBO1.Id);
                cmd.Parameters.AddWithValue("@name", ObjBO1.Name);
                cmd.Parameters.AddWithValue("@address", ObjBO1.Address);

                con.Open();
                int Result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                return Result;
            }
            catch
            {
                throw;
            }
        }


        public int AdminUpdateEmpDetails(Employee ObjBO1)  //For Update
        {
            try
            {

                SqlCommand cmd = new SqlCommand("sp_AdminupdateEmpdeails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", ObjBO1.Id);
                cmd.Parameters.AddWithValue("@name", ObjBO1.Name);
                cmd.Parameters.AddWithValue("@address", ObjBO1.Address);
                cmd.Parameters.AddWithValue("@email", ObjBO1.Email);
                cmd.Parameters.AddWithValue("@phone", ObjBO1.Phone);
                cmd.Parameters.AddWithValue("@deptid", ObjBO1.DeptId);

                con.Open();
                int Result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                return Result;
            }
            catch
            {
                throw;
            }
        }

        

        public DataSet GetEmployeeDetails(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_GetEmpDetail", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    throw new DataNotFoundException("Give valid Employee Id");
                }
                Console.ReadLine();
                return ds;
            }
            catch
            {
                throw; 
            }

        }
    }

}
