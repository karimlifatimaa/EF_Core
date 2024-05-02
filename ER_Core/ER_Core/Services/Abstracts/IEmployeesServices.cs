using ER_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ER_Core.Services.Abstracts
{
    internal interface IEmployeesServices
    {
        void Add(Employee employee);
        void Delete(int id);
        void Update(int id, Employee employee);
        Employee Get(int id);
        List<Employee> GetAll(Func<Employee, bool> predicate = null);
    }
}
