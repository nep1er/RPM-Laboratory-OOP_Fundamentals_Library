namespace OOP_Fundamentals_Library
{
    public class Manager : Employee
    {
        private string _department;
        private List<Employee> _team;

        public string Department
        {
            get => _department;
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Department cannot be empty");
                _department = value;
            }
        }

        public IReadOnlyList<Employee> Team => _team.AsReadOnly();

        public Manager(string name, int age, decimal salary, string department)
            : base(name, age, salary, "Manager")
        {
            Department = department;
            _team = new List<Employee>();
        }

        public void AddTeamMember(Employee employee)
        {
            if (employee == null)
                throw new ArgumentNullException(nameof(employee));

            if (_team.Contains(employee))
                throw new InvalidOperationException("Сотрудник уже в команде");

            _team.Add(employee);
        }

        public void RemoveTeamMember(Employee employee)
        {
            if (employee == null)
                throw new ArgumentNullException(nameof(employee));

            if (!_team.Contains(employee))
                throw new InvalidOperationException("Сотрудник не найден в команде");

            _team.Remove(employee);
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Manager: {Name}, {Age} years old, Department: {Department}");
        }

        public void AssignTaskToEmployee(Employee emp, string task)
        {
            Console.WriteLine($"Assigning task '{task}' to {emp.Name}");
        }

        public override decimal GetSalaryIncrease()
        {
            return 2000;
        }
    }
}