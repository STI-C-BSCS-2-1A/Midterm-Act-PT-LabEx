namespace EmployeeNamespace
{
    public class Employee
    {
        // Private fields
        private int id;
        private string firstName;
        private string lastName;
        private string position;

        // Public properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        // Default constructor
        public Employee()
        {
            this.id = 0;
            this.firstName = "Unknown";
            this.lastName = "Unknown";
            this.position = "None";
        }
        public Employee(int id, string firstName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = "Unknown";
            this.Position = "None";
        }

        // Overloaded constructor
        public Employee(int id, string firstName, string lastName, string position)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.position = position;
        }
        // Overloaded constructor with partial parameters
      
    }
}
