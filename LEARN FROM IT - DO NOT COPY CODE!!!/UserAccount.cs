namespace UserAccountNamespace
{
    public class UserAccount
    {
        private string full_name;
        protected string username;
        protected string password;

        public UserAccount(string name, string uname, string password)
        {
            this.full_name = name;
            this.username = uname;
            this.password = password;
        }

        public bool ValidateLogin(string uname, string password)
        {
            return this.username == uname && this.password == password;
        }

        public string GetFullName()
        {
            return this.full_name;
        }
    }

    public class Cashier : UserAccount
    {
        private string department;

        public Cashier(string name, string department, string uname, string password)
            : base(name, uname, password)
        {
            this.department = department;
        }

        public new bool ValidateLogin(string uname, string password)
        {
            return base.ValidateLogin(uname, password);
        }

        public string Department
        {
            get { return this.department; }
        }
    }
}
