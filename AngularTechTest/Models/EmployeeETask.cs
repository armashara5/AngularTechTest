using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCTestappWithDotNstFramework.Models
{
    public class EmployeeETask
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int ETaskId { get; set; }
        public Employee Employee { get; set; }
        public ETask ETask { get; set; }

      
    }
}