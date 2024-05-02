using ER_Core.DAL;
using ER_Core.Models;
using ER_Core.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ER_Core.Services.Concretes
{
    internal class EmployeesServices: IEmployeesServices
    {
        AppDbContext _appDbContext;
        public EmployeesServices()
        {
            _appDbContext = new AppDbContext();
        }

        public void Add(Employee employee)
        {
           
                _appDbContext.Employees.Add(employee);
                _appDbContext.SaveChanges();
            
        }

        public void Delete(int id)
        {
            Employee employee = _appDbContext.Employees.FirstOrDefault(x => x.Id == id);
            if (employee == null) throw new NullReferenceException();
            _appDbContext.Employees.Remove(employee);
            _appDbContext.SaveChanges();
        }
        public void Update(int id, Employee employee)
        {
            Employee finfEmployee = _appDbContext.Employees.Find(id);
            if (finfEmployee == null) throw new NullReferenceException();
            finfEmployee.Name = employee.Name;
            finfEmployee.Age = employee.Age;
            _appDbContext.SaveChanges();

        }
        public Employee Get(int id)
        {
            return _appDbContext.Employees.FirstOrDefault(x => x.Id == id);
        }

        public List<Employee> GetAll(Func<Employee, bool> predicate = null)
        {
            if (predicate != null)
            {
                return _appDbContext.Employees.Where(predicate).ToList();
            }
            else
            {
                return _appDbContext.Employees.ToList();
            }
        }
    }
}
