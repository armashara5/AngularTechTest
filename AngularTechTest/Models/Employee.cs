using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTestappWithDotNstFramework.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }

        //public virtual ICollection<ETask> ETasks { get; set; }

    }
}