namespace OOP_Fundamentals_Library
{
    public class PayrollSystem
    {
        public void ProcessSalary(IPayable payable)
        {
            if (payable is Employee employee)
            {
                Console.WriteLine($"Processing {employee.GetType().Name}: {employee.Name}");

                employee.IncreaseSalary(employee.GetSalaryIncrease());
            }
        }
    }
}
