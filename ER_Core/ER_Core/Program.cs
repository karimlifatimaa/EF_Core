using ER_Core.Controller;
using ER_Core.DAL;
using ER_Core.Models;

namespace ER_Core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeesController employeesController = new EmployeesController();

            bool exit = false;
            do
            {
                Console.WriteLine("1.Isci elave et");
                Console.WriteLine("2.Isci sil");
                Console.WriteLine("3.Isci uzerinde deyisiklik et ");
                Console.WriteLine("4.Id-e gore isci qaytar ");
                Console.WriteLine("5.butun iscilere bax ");
                Console.WriteLine("0.Cixis");
                Console.WriteLine("Secim et:");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                        employeesController.AddEmployees();
                        break;
                    case "2":
                        employeesController.RemoveEmployees();
                        break;
                    case "3":
                        employeesController.Update();
                        break;
                    case "0":
                        exit = true;
                        break;
                    case "4":
                        employeesController.Get();
                        break;
                    case "5":
                        employeesController.GetAll();
                        break;
                    default:
                        Console.WriteLine("Secimin yalnisdir!");
                        break;
                }

            } while (!exit);
        }
    }
}
