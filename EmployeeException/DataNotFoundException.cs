using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeException
{
    public class DataNotFoundException:Exception
    {
        public DataNotFoundException(string message):base(message)
        {

        }
    }


}
