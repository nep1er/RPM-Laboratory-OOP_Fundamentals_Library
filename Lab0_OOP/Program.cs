using OOP_Fundamentals_Library;

namespace Lab0_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer("John", 30);
            var employee = new Employee("Alice", 25, 50000, "Developer");
            var manager = new Manager("Bob", 40, 80000, "IT");

            manager.AddTeamMember(employee);
            employee.Salary = 55000;

            customer.PrintInfo();
            employee.PrintInfo();
            manager.PrintInfo();

            var payroll = new PayrollSystem();
            payroll.ProcessSalary(employee);
            payroll.ProcessSalary(manager);

            var reportService = new ReportService();
            reportService.GenerateEmployeeReport(employee);
            reportService.GenerateManagerReport(manager);
        }
    }
}