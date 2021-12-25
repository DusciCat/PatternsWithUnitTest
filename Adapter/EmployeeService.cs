using System.Linq;

namespace Adapter
{
    /// <summary>
    ///     Представляет класс Adapter.
    ///     Этот класс создает экземпляр класса RecordServer и обслуживает клиента возвращая сотрудника на основе id.
    /// </summary>
    public class EmployeeService : IEmployeeService
    {
        private readonly RecordServer recordServer;

        public EmployeeService()
        {
            recordServer = new RecordServer();
        }

        /// Этот метод извлекает список сотрудников с сервера записи
        /// и возвращает сотрудника на основе employeeId
        public Employee GetEmployee(int employeeId)
        {
            var allEmployees = recordServer.GetEmployees();
            return allEmployees.FirstOrDefault(e => e.Id == employeeId);
        }
    }
}