using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplicationn
{
    internal class PartTimeEmployee : IEmployee
    {
        private string firstName;
        private string lastName;
        private string department;
        private string jobtitle;
        private double basicsalary;
        public int hoursWorked;
        public double ratePerHour;

        public  PartTimeEmployee(string firstname, string lastname, string department, string jobtitle)
        {
            this.firstName = firstname;
            this.lastName = lastname;  
            this.department = department;
            this.jobtitle = jobtitle;
        }
        public string FirstName 
        {
            get 
            {
                return firstName; 
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }
        public string JobTitle
        {
            get
            {
                return jobtitle;
            } 
            set
            {
                jobtitle = value;
            }
        }
        public double BasicSalary
        {
            get
            {
                return basicsalary;
            }
            set
            {
                basicsalary = value;
            }
        }

        public double getSalary()
        {
            return this.basicsalary;
        }
        public void computeSalary(int hoursWorked, double ratePerHour)
        {
            basicsalary = hoursWorked * ratePerHour;
        }
    }
}
