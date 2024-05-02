using ER_Core.Models;
using ER_Core.Services.Abstracts;
using ER_Core.Services.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ER_Core.Controller
{
    internal class EmployeesController
    {
        
        IEmployeesServices _services = new EmployeesServices();

        public void AddEmployees()
        {
            Console.WriteLine("Iscinin adini daxil edin:");
            string name=Console.ReadLine();
            string ageStr;
            int age;
            do
            {
                Console.WriteLine("Yasi daxil edin:");
                ageStr = Console.ReadLine();

            } while (!int.TryParse(ageStr,out age));
            Employee employee = new Employee()
            {
                Name = name,
                Age = age
            };
            _services.Add(employee);
        }
        public void RemoveEmployees()
        {
          
            string idStr;
            int id;
            do
            {
                Console.WriteLine("Sileceyiniz iscinin Id-ni daxil edin:");
                idStr = Console.ReadLine();

            } while (!int.TryParse(idStr, out id));
            _services.Delete(id);
        }
        public void Update()
        {
            
            string idStr;
            int id;
            do
            {
                Console.WriteLine("deyisiklik edeceyinin iscinin Id-ni daxil edin:");
                idStr = Console.ReadLine();

            } while (!int.TryParse(idStr, out id));

            Console.WriteLine("Iscinin adini daxil edin:");
            string name = Console.ReadLine();
            string ageStr;
            int age;
            do
            {
                Console.WriteLine("Yasi daxil edin:");
                ageStr = Console.ReadLine();

            } while (!int.TryParse(ageStr, out age));
            Employee employee = new Employee()
            {
                Name = name,
                Age = age
            };
            _services.Update(id, employee);
        }
        public void Get()
        {
            string idStr;
            int id;
            do
            {
                Console.WriteLine("Gormek istediyiniz iscinin Id-ni daxil edin:");
                idStr = Console.ReadLine();

            } while (!int.TryParse(idStr, out id));
            Console.WriteLine(_services.Get(id));
        }
        public void GetAll()
        {
            Console.WriteLine("Butun isciler:");
            foreach (Employee emp in _services.GetAll())
            {
                Console.WriteLine(emp.Name);
            }
        }
    }
}
