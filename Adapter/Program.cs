using System;
using System.Text;

namespace Adapter
{
    //использует IEmployeeService и выбирает сотрудника на основе идентификатора
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            IEmployeeService service = new EmployeeService();

            var employee = service.GetEmployee(1001);
            PrintEmployeeDetails(employee);

            employee = service.GetEmployee(1004);
            PrintEmployeeDetails(employee);

            employee = service.GetEmployee(1020);
            PrintEmployeeDetails(employee);

            employee = service.GetEmployee(1002);
            PrintEmployeeDetails(employee);

            Console.Read();
        }

        private static void PrintEmployeeDetails(Employee employee)
        {
            if (employee != null)
                Console.WriteLine(employee);
            else
                Console.WriteLine("Сотрудник не найден");
        }
    }
}