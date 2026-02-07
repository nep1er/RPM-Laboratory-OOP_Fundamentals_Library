namespace OOP_Fundamentals_Library
{
    public class Employee : Person, IPayable
    {
        private decimal _salary;
        private string _position;

        public decimal Salary
        {
            get => _salary;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Salary cannot be negative");
                _salary = value;
            }
        }

        public string Position
        {
            get => _position;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Position cannot be empty");
                _position = value;
            }
        }

        public Employee(string name, int age, decimal salary, string position): base(name, age)
        {
            Salary = salary;
            Position = position;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Employee: {Name}, {Age} years old");
        }

        public void IncreaseSalary(decimal amount)
        {
            Salary += amount;
        }

        public virtual decimal GetSalaryIncrease()
        {
            return 1000;
        }
    }
}