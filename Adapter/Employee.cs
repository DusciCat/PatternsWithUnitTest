namespace Adapter
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }

        public override string ToString()
        {
            return $"Id #{Id}  Имя: {FirstName}  Фамилия: {LastName}  Отдел: {Department}";
        }
    }
}