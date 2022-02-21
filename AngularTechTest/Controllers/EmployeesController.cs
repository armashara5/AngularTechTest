using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCTestappWithDotNstFramework.Data;
using MVCTestappWithDotNstFramework.Models;

namespace MVCTestappWithDotNstFramework.Controllers
{
    public class EmployeesController : Controller
    {
        private AngularTechTestContext db = new AngularTechTestContext();


        // GET: Employees

        public async Task<ActionResult> Index()
        {
            List<Employee> model = await db.Employees.ToListAsync();
            return View(model);
        }
        public async Task<JsonResult> IndexJson()
        {

            return Json(await db.Employees.ToListAsync(), JsonRequestBehavior.AllowGet);
        }

        public async Task<JsonResult> EmployeeTasksJson(int employeeId)
        {
            return Json(await db.EmployeeETasks.Where(e => e.EmployeeId == employeeId).Include(task => task.ETask).Select(t => t.ETask).ToListAsync(), JsonRequestBehavior.AllowGet);
        }

        public async Task<JsonResult> UpdateEmployeeSalaryJson(int employeeId,int salary)
        {
            
            var employee = await db.Employees.FirstOrDefaultAsync(e => e.EmployeeId == employeeId);
            if(employee == null) 
                return Json( new EmptyResult(), JsonRequestBehavior.AllowGet);
            employee.Salary = salary;
            await db.SaveChangesAsync();
            return Json(employee, JsonRequestBehavior.AllowGet);
        }

    }     
}
