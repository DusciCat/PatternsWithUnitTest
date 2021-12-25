namespace Adapter
{
    /// <summary>
    ///     Представляет IAdapter
    ///     Интерфейс позволит клиенту выбрать сотрудника с помощью employeeId
    /// </summary>
    public interface IEmployeeService
    {
        Employee GetEmployee(int employeeId);
    }
}