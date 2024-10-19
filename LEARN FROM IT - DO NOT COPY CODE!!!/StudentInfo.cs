namespace StudentNamespace
{
    public class StudentInfo
    {
        // Private instance variables
        private int studentID;
        private string firstName;
        private string lastName;

        // Default constructor
        public StudentInfo()
        {
            this.studentID = 0; // Initialize to a default value
            this.firstName = string.Empty;
            this.lastName = string.Empty;
        }

        // Overloaded constructor
        public StudentInfo(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.studentID = 0; // Initialize to a default value
        }

        // Overloaded constructor with all parameters
        public StudentInfo(string firstName, int studentID, string lastName)
        {
            this.studentID = studentID;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        // Properties to get and set the values
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

        public int StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }


        public string GetStudentID()
        {
            return $"{StudentID}";
        }
        public string GetFirstName()
        {
            return $"{FirstName}";
        }
        public string GetLastName()
        {
            return $"{LastName}";
        }
    }
}
