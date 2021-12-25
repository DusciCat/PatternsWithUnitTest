using System.Collections.Generic;

namespace Adapter
{
    /// <summary>
    ///     Этот класс представляет класс Adaptee.
    ///     Предполагая, что это устаревший код, который поддерживает список сотрудников и имеет только одну
    ///     функцию - для возврата всех сотрудников сразу.
    /// </summary>
    public class RecordServer
    {
        private List<Employee> _employees;

        public RecordServer()
        {
            InitializeEmployees();
        }

        public List<Employee> GetEmployees()
        {
            return _employees;
        }

        private void InitializeEmployees()
        {
            _employees = new List<Employee>
            {
                new() { Id = 1001, FirstName = "Иван", LastName = "Иванов", Department = "Финансовый" },
                new() { Id = 1002, FirstName = "Петр", LastName = "Петров", Department = "Разработка" },
                new() { Id = 1003, FirstName = "Михаил", LastName = "Михайлов", Department = "Тестирование" },
                new() { Id = 1004, FirstName = "Василий", LastName = "Васильев", Department = "Тестирование" },
                new() { Id = 1005, FirstName = "Максим", LastName = "Максимов", Department = "Разработка" }
            };
        }
    }
}