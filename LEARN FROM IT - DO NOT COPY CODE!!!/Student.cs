namespace Student__Registration_Form
{
    internal class Student
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string gender;
        private string day;
        private string month;
        private string year;
        private string? program;

        public Student(string firstName, string lastName, string gender, string? program)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.program = program;
        }

        public Student(string firstName, string middleName, string lastName, string gender, string? program)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.gender = gender;
            this.program = program;
        }

        public Student(string firstName, string middleName, string lastName, string gender, string day, string month, string year, string? program)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.gender = gender;
            this.day = day;
            this.month = month;
            this.year = year;
            this.program = program;
        }

        // Overloaded methods
        internal void ShowRegistrationDetails()
        {
            MessageBox.Show($"Registered Student:\n\n" +
                            $"Name: {firstName} {middleName} {lastName}\n" +
                            $"Gender: {gender}\n" +
                            $"Date of Birth: {month}/{day}/{year}\n" +
                            $"Program: {program}");
        }

        internal void ShowRegistrationDetails(bool includeMiddleName)
        {
            if (includeMiddleName)
            {
                MessageBox.Show($"Registered Student:\n\n" +
                                $"Name: {firstName} {middleName} {lastName}\n" +
                                $"Program: {program}");
            }
            else
            {
                MessageBox.Show($"Registered Student:\n\n" +
                                $"Name: {firstName} {lastName}\n" +
                                $"Program: {program}");
            }
        }

        internal void ShowRegistrationDetails(bool includeMiddleName, bool includeDOB)
        {
            if (includeDOB)
            {
                ShowRegistrationDetails();
            }
            else
            {
                ShowRegistrationDetails(includeMiddleName);
            }
        }
    }
}