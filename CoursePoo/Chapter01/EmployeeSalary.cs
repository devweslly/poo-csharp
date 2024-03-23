using System.Globalization;

namespace Chapter01
{
    public class EmployeeSalary
    {
        public string Name;
        public double GrossSalary;
        public double Tax;

        public double NetSalary()
        {
            Console.WriteLine($"Making a tax deduction of R$ {Tax} from the salary.");

            double netSalary    = GrossSalary - Tax;

            return netSalary;
        }

        public void IncreaseSalary(double percentage)
        {
            Console.WriteLine($"{percentage}% increase in salary.");

            GrossSalary        *= 1 + (percentage / 100);
        }

        public override string ToString()
        {
            string displaysData = $"Employee: {Name} | Net Salary: {NetSalary().ToString("F2", CultureInfo.InvariantCulture)}";

            return displaysData;
        }
    }
}
