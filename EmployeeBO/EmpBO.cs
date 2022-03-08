using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeBO
{
    public class Employee

    {
        private int _id;



        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        
        
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
        
        private string _address;



        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        private string _email;



        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private int _phone;



        public int Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        private int _deptid;



        public int DeptId
        {
            get { return _deptid; }
            set { _deptid = value; }
        }


    }

    public class Organization
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _id;



        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

    }

    public class Departments
    {
        private int _id;



        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        private int _organiztionid;

        public int OrganizationId
        {
            get { return _organiztionid; }
            set { _organiztionid = value; }
        }

    }
}
