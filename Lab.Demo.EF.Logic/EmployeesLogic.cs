using Lab.Demo.EF.Data;
using Lab.Demo.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF.Logic
{
    public class EmployeesLogic
    {
        private readonly NorthwindContext context;

        public EmployeesLogic()
        {
            context = new NorthwindContext();

        }

        public List<Employees> GetAll()
        {
            return context.Employees.ToList();
        }

    }
}
