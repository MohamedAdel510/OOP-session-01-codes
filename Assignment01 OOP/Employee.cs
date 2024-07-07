using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01_OOP
{
    enum Gender
    {
        Male = 1, Female = 2, M = 1, F = 2
    }
    enum Privileges
    {
        Guest, Developer, secretary, DBA
    }
    internal class Employee
    {
        #region Attributes and prperties
        private int Id { get; set; }
        private string Name { get; set; }
        private Privileges SecurityLevel { get; set; }
        private decimal Salary { get; set; }
        private DateTime HireDate { get; set; }
        private Gender gender{get; set; }
        #endregion

        #region Constructors
        public Employee()
        {
            Id = 0;
            Name = "";
            // SecurityLevel = default;
            Salary = 0.0m;
            //HireDate = default;
            //gender = default;
        }
        public Employee(int id, string name, Privileges securityLevel, decimal salary, DateTime hireDate, Gender gender)
        {
            Id = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            this.gender = gender;
        }
        #endregion

        #region Methods
        #region Getters
        public int getId()
        {
            return Id;
        }
        public string getName()
        {
            return Name;
        }
        public Privileges getSecurityLevel()
        {
            return SecurityLevel;
        }
        public decimal getSalary()
        {
            return Salary;
        }
        public DateTime getHireDate()
        {
            return HireDate;
        }
        public Gender getGender()
        {
            return gender;
        }
        #endregion

        #region Setters
        public void setId(int id)
        {
            Id = id;
        }
        public void setName(string name)
        {
            Name = name;
        }
        public void SetSecurityLevel(Privileges securityLevel)
        {
            SecurityLevel = securityLevel;
        }
        public void setSalary(decimal salary)
        {
            Salary = salary;
        }

        public void setHireDate(DateTime hireDate)
        {
            HireDate = hireDate;
        }

        public void setGender(Gender gender)
        {
            this.gender = gender;
        }
        #endregion


        public override string ToString()
        {
            return $"{Salary} $"; // ??
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"SecurityLevel: {SecurityLevel}");
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine($"Hising date {HireDate}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine("----------------");
        }
        #endregion

    }
}
