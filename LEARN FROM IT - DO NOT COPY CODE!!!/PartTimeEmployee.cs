using EmployeeInterface;

namespace EmployeeNamespace
{
    public class PartTimeEmployee : IEmployee
    {
        private string first_name;
        private string last_name;
        private string department;
        private string job_title;
        private double basic_salary;

        public PartTimeEmployee(string Fname, string Lname, string Dept, string job)
        {
            first_name = Fname;
            last_name = Lname;
            department = Dept;
            job_title = job;
        }

        public string FirstName
        {
            get { return first_name; }
            set { first_name = value; }
        }

        public string LastName
        {
            get { return last_name; }
            set { last_name = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public string JobTitle
        {
            get { return job_title; }
            set { job_title = value; }
        }

        public double BasicSalary
        {
            get { return basic_salary; }
            set { basic_salary = value; }
        }

        public void ComputeSalary(double hoursWorked, double ratePerHour)
        {
            basic_salary = hoursWorked * ratePerHour;
            Console.WriteLine("Part Time Employee Salary: " + basic_salary);
        }

        public void ComputeSalary(int hoursWorked, double ratePerHour)
        {
            throw new NotImplementedException();
        }

        public double GetSalary()
        {
            return basic_salary;
        }
    }
}
