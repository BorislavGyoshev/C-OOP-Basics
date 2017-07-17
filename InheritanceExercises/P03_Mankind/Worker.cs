namespace P03_Mankind
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Worker : Human
    {
        private decimal weekSalary;
        private decimal workingHours;

        public Worker(string firstName, string secondName, decimal weekSalary, decimal workingHours) : base (firstName, secondName)
        {
            WeekSalary = weekSalary;
            WorkingHours = workingHours;
        }

        public decimal WeekSalary
        {
            get { return weekSalary; }
            set
            {
                if (value <= 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                weekSalary = value;
            }
        }
        public decimal WorkingHours
        {
            get { return WorkingHours1; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                WorkingHours1 = value;
            }
        }

        public decimal WorkingHours1
        {
            get
            {
                return workingHours;
            }

            set
            {
                workingHours = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString()).AppendLine($"Week Salary: {this.WeekSalary:f2}")
                .AppendLine($"Hours per day: {this.WorkingHours:f2}")
                .AppendLine($"Salary per hour: {this.WeekSalary / (this.WorkingHours * 5):f2}");
            return sb.ToString();
        }
    }
}
