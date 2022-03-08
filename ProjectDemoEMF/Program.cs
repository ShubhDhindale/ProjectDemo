using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeBO;
using EmployeeBL;
using EmployeeDAL;
using System.Data;


namespace ProjectDemoEMF
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                int x = 0;
                while (x == 0)
                {
                    Console.WriteLine("____________________________________________________");
                    Console.WriteLine("Select your designation");
                    Console.WriteLine("1.Admin");
                    Console.WriteLine("2.Empolyee");

                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("____________________________________________________");


                    if (n == 1)
                    {
                        int y = 0;
                        while (y == 0)
                        {
                            Console.WriteLine("WELCOME ADMIN");
                            Console.WriteLine("1.Add new employee");
                            Console.WriteLine("2.Delete Employee");
                            Console.WriteLine("3.List all employees");
                            Console.WriteLine("4.Get employee details by Employee Id");
                            Console.WriteLine("5.Update");
                            Console.WriteLine("6.View");
                            Console.WriteLine("____________________________________________________");
                            int m = Convert.ToInt32(Console.ReadLine());
                            switch (m)
                            {

                                case 1:
                                    Employee pb1 = new Employee();
                                    Console.WriteLine("Enter the Employee id ,name ,address ,email ,phone ,deptid");
                                    pb1.Id = Convert.ToInt32(Console.ReadLine());
                                    pb1.Name = Console.ReadLine();
                                    pb1.Address = Console.ReadLine();
                                    pb1.Email = Console.ReadLine();
                                    pb1.Phone = Convert.ToInt32(Console.ReadLine());
                                    pb1.DeptId = Convert.ToInt32(Console.ReadLine());

                                    EmpBL bl1 = new EmpBL();
                                    int h = bl1.SaveEmployeeBL(pb1);
                                    if (h != 0)
                                        Console.WriteLine("Successfully Added");
                                    else
                                        Console.WriteLine("Failed to add Product");

                                    Console.ReadLine();
                                    break;

                                case 2:
                                    Employee pb2 = new Employee();
                                    Console.WriteLine("Enter the Employee id:");
                                    pb2.Id = int.Parse(Console.ReadLine());

                                    EmpBL bl2 = new EmpBL();
                                    int h1 = bl2.DeleteEmployeeBL(pb2);
                                    if (h1 != 0)
                                        Console.WriteLine("Deleted Successfully");

                                    Console.ReadLine();
                                    break;

                                case 3:
                                    EmpBL bl3 = new EmpBL();
                                    DataSet ds = bl3.AllEmployees();

                                    Console.WriteLine("Employee Information");
                                    Console.WriteLine("Id  |  Name  |  Address  |  Email  |   Phone   |  DeptId");
                                    foreach (DataRow dr in ds.Tables[0].Rows)
                                    {
                                        for (int i = 0; i <= 5; i++)
                                        {
                                            Console.Write(dr[i] + " |  ");
                                        }
                                        Console.WriteLine(" ");
                                    }
                                    Console.ReadLine();

                                    break;

                                case 4:
                                    EmpBL bl4 = new EmpBL();
                                    Console.WriteLine("Enter Employee Id");
                                    int h5 = int.Parse(Console.ReadLine());

                                    DataSet ds4 = bl4.GetEmployeeDetailsBL(h5);
                                    foreach (DataRow dr in ds4.Tables[0].Rows)
                                    {


                                        Console.WriteLine("Id=" + dr[0] + " Name=" + dr[1] + " Address=" + dr[2] + " Email=" + dr[3] + " Phone=" + dr[4] + " Deptid=" + dr[5]);

                                    }

                                    Console.ReadLine();
                                    break;

                                case 5:
                                    Employee pb5 = new Employee();
                                    Console.WriteLine("Enter the Employee id ,name ,address,email ,phone ,deptid");
                                    pb5.Id = Convert.ToInt32(Console.ReadLine());
                                    pb5.Name = Console.ReadLine();
                                    pb5.Address = Console.ReadLine();
                                    pb5.Email = Console.ReadLine();
                                    pb5.Phone = Convert.ToInt32(Console.ReadLine());
                                    pb5.DeptId = Convert.ToInt32(Console.ReadLine());
                                    break;

                                case 6:
                                    EmpBL bl6 = new EmpBL();
                                    Console.WriteLine("Enter Employee Id");
                                    int h6 = int.Parse(Console.ReadLine());

                                    DataSet ds2 = bl6.GetEmployeeDetailsBL(h6);
                                    Console.WriteLine("Id  |  Name  |  Address  |  Email  |   Phone   |  DeptId");
                                    Console.WriteLine(" ");
                                    foreach (DataRow dr in ds2.Tables[0].Rows)
                                    {


                                        for (int i = 0; i <= 5; i++)
                                        {
                                            Console.Write(dr[i] + " |  ");
                                        }
                                        Console.WriteLine(" ");

                                    }

                                    Console.ReadLine();
                                    break;

                                default:
                                    Console.WriteLine("You are entering wrong number");
                                    Console.ReadLine();
                                    break;
                            }

                            Console.WriteLine("0.Go back to Employee menu");
                            Console.WriteLine("1.Go back to Main menu");
                            y = Convert.ToInt32(Console.ReadLine());
                            Console.ReadLine();

                        }


                    }




                    else if (n == 2)
                    {
                        int y = 0;
                        while (y == 0)
                        {
                            Console.WriteLine("WELCOME EMPLOYEE");
                            Console.WriteLine("1.Update");
                            Console.WriteLine("2.View");

                            int m = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("____________________________________________________");

                            switch (m)
                            {
                                case 1:
                                    Employee pb1 = new Employee();
                                    Console.WriteLine("Enter the Employee id ,name ,address");
                                    pb1.Id = Convert.ToInt32(Console.ReadLine());
                                    pb1.Name = Console.ReadLine();
                                    pb1.Address = Console.ReadLine();
                                    pb1.Email = Console.ReadLine();
                                    pb1.Phone = Convert.ToInt32(Console.ReadLine());
                                    pb1.DeptId = Convert.ToInt32(Console.ReadLine());

                                    EmpBL bl1 = new EmpBL();
                                    int h4 = bl1.AdminUpdateEmpBL(pb1);
                                    if (h4 != 0)
                                        Console.WriteLine("Update Successfully ");
                                    else
                                        Console.WriteLine("Failed to update ");

                                    Console.ReadLine();
                                    break;

                                case 2:
                                    EmpBL bl2 = new EmpBL();
                                    Console.WriteLine("Enter Employee Id");
                                    int h6 = int.Parse(Console.ReadLine());

                                    DataSet ds2 = bl2.GetEmployeeDetailsBL(h6);
                                    foreach (DataRow dr in ds2.Tables[0].Rows)
                                    {


                                        Console.WriteLine("Id=" + dr[0] + " Name=" + dr[1] + " Address=" + dr[2] + " Email=" + dr[3] + " Phone=" + dr[4] + " Deptid=" + dr[5]);

                                    }

                                    Console.ReadLine();
                                    break;

                                default:
                                    Console.WriteLine("You are entering wrong number");
                                    Console.ReadLine();
                                    break;
                            }
                            Console.WriteLine("0.Go back to Admin menu");
                            Console.WriteLine("1.Go back to Main menu");
                            y = Convert.ToInt32(Console.ReadLine());
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("You are entering wrong number");
                        Console.ReadLine();
                    }

                    x = 0;

                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            }


    }
}

