using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCTestappWithDotNstFramework.Models
{
    public class ETask
    {
        public int ETaskId { get; set; }
        public string TaskName { get; set; }

        //public virtual ICollection<Employee> Employees { get; set; }
    }
}