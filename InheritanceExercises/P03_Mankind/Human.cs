namespace P03_Mankind
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            Lastname = lastName;
        }

        public string Lastname
        {
            get { return lastName; }
            set
            {
                if (Regex.IsMatch(value, @"^[^A-Z]"))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: lastName");
                }
                if (value.Length < 3)
                {
                    throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
                }
                lastName = value;
            }
        }
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (Regex.IsMatch(value, @"^[^A-Z]"))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");
                }
                if (value.Length < 4)
                {
                    throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
                }
                firstName = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"First Name: {this.FirstName}").AppendLine($"Last Name: {this.Lastname}");
            return sb.ToString();
        }
    }
}
