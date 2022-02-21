namespace MVCTestappWithDotNstFramework.Migrations
{
    using MVCTestappWithDotNstFramework.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCTestappWithDotNstFramework.Data.AngularTechTestContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVCTestappWithDotNstFramework.Data.AngularTechTestContext context)
        {
            //  This method will be called after migrating to the latest version.
            Employee[] Employees =
                {
                new Employee(){EmployeeId=1 ,Name = "John" , Department = "IT", Salary = 100000 },
                new Employee(){EmployeeId=2 ,Name = "Rimi" , Department = "HR", Salary = 200000 },
                new Employee(){EmployeeId=3 ,Name = "Jim" , Department = "Operation", Salary = 50000 },
                new Employee(){EmployeeId=4 ,Name = "Dev" , Department = "IT", Salary = 150000 },
                new Employee(){EmployeeId=5 ,Name = "Sarah" , Department = "HR", Salary = 60000 },
                new Employee(){EmployeeId=6 ,Name = "Seteve" , Department = "IT", Salary = 170000 },
                new Employee(){EmployeeId=7 ,Name = "Henry" , Department = "Operation", Salary = 60000 },
                new Employee(){EmployeeId=8 ,Name = "Tony" , Department = "IT", Salary = 80000 },
                new Employee(){EmployeeId=9 ,Name = "Ema" , Department = "IT", Salary = 85000 },
                new Employee(){EmployeeId=10 ,Name = "Dani" , Department = "Operation", Salary = 90000 },

            };

            ETask[] ETasks =
            {
                new ETask(){ETaskId = 1,TaskName=" Install system"  },
                new ETask(){ETaskId = 2,TaskName=" Deploy on IIS" },
                new ETask(){ETaskId = 3,TaskName=" Training Customers" },
                new ETask(){ETaskId = 4,TaskName=" Analysis" },
                new ETask(){ETaskId = 5,TaskName=" SRS" }
            };

            context.Employees.AddOrUpdate(Employees);
            context.ETasks.AddOrUpdate(ETasks);
            //=============Employees[1]
            context.EmployeeETasks.AddOrUpdate(t => t.Id,
    new EmployeeETask { Employee = Employees[1], ETask = ETasks[0] });

            context.EmployeeETasks.AddOrUpdate(t => t.Id,
                new EmployeeETask { Employee = Employees[1], ETask = ETasks[1] });

            context.EmployeeETasks.AddOrUpdate(t => t.Id,
                new EmployeeETask { Employee = Employees[1], ETask = ETasks[2] });

            //=============Employees[2]
            context.EmployeeETasks.AddOrUpdate(t => t.Id,
    new EmployeeETask { Employee = Employees[2], ETask = ETasks[0] });

            context.EmployeeETasks.AddOrUpdate(t => t.Id,
                new EmployeeETask { Employee = Employees[2], ETask = ETasks[1] });

            context.EmployeeETasks.AddOrUpdate(t => t.Id,
                new EmployeeETask { Employee = Employees[2], ETask = ETasks[2] });

            //=============Employees[3]
            context.EmployeeETasks.AddOrUpdate(t => t.Id,
    new EmployeeETask { Employee = Employees[3], ETask = ETasks[0] });

            context.EmployeeETasks.AddOrUpdate(t => t.Id,
                new EmployeeETask { Employee = Employees[3], ETask = ETasks[2] });

            context.EmployeeETasks.AddOrUpdate(t => t.Id,
                new EmployeeETask { Employee = Employees[3], ETask = ETasks[3] });

            //=============Employees[4]
            context.EmployeeETasks.AddOrUpdate(t => t.Id,
    new EmployeeETask { Employee = Employees[4], ETask = ETasks[1] });

            context.EmployeeETasks.AddOrUpdate(t => t.Id,
                new EmployeeETask { Employee = Employees[4], ETask = ETasks[4] });

            context.EmployeeETasks.AddOrUpdate(t => t.Id,
                new EmployeeETask { Employee = Employees[4], ETask = ETasks[2] });

            //=============Employees[5]
            context.EmployeeETasks.AddOrUpdate(t => t.Id,
    new EmployeeETask { Employee = Employees[5], ETask = ETasks[2] });

            context.EmployeeETasks.AddOrUpdate(t => t.Id,
                new EmployeeETask { Employee = Employees[5], ETask = ETasks[3] });

            context.EmployeeETasks.AddOrUpdate(t => t.Id,
                new EmployeeETask { Employee = Employees[5], ETask = ETasks[1] });





        }
    }
}
